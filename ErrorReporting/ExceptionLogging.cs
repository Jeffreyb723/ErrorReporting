using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ErrorReporting
{
    public static class ExceptionLogging
    {
        public static void SendErrorToEmail(Exception exceptionToEmail)
        {
            try
            {

                string application = exceptionToEmail.Source;

                string errorLineNo = Regex.Match(exceptionToEmail.StackTrace, @"line \d*$", RegexOptions.Multiline).Value;
                string errorName = exceptionToEmail.GetType().Name;
                string exceptionType = exceptionToEmail.GetType().ToString();
                string errorMessage = exceptionToEmail.Message;
                string errorStack = exceptionToEmail.StackTrace;

                string customerMessage = 
                    $"A software problem has caused {application} to enter an unstable state.{Environment.NewLine}{Environment.NewLine}" +
                    $"{errorMessage}{Environment.NewLine}{Environment.NewLine}" +
                    $"We apologize for the inconvenience. An error report has been generated. Please click Send Report to help us analyze the cause of the problem.{Environment.NewLine}{Environment.NewLine}" +
                    $"Any data received will be anonymous and confidential.{Environment.NewLine}{Environment.NewLine}" +
                    "Please click Details below to view the details of the report.";
                string errorReport =
                    $"Application: {application}{Environment.NewLine}" +
                    $"Log Written Date: {DateTime.Now}{Environment.NewLine}" +
                    $"Error Line No: {errorLineNo}{Environment.NewLine}" +
                    $"Error Message: {errorName}{Environment.NewLine}" +
                    $"Exception Type: {exceptionType}{Environment.NewLine}" +
                    $"Error Details: {errorMessage}{Environment.NewLine}" +
                    $"Error Stack:{Environment.NewLine}{errorStack}";

                if (DetailsBox.Show(customerMessage, application, errorReport) != DialogResult.Yes)
                {
                    return;
                }

                string hostAddress = ConfigurationManager.AppSettings["host"];
                string from = ConfigurationManager.AppSettings["fromAddress"];
                string password = ConfigurationManager.AppSettings["password"];
                string to = ConfigurationManager.AppSettings["toAddress"];

                string subject = $"Exception occurred in {application}";
                string header =
                    "<b>Dear Team,</b><br/>" +
                    $"An exception occurred in {application}, With the following Details:<br/>";
                const string signature = 
                    "<br/><br/><br/><br/>" +
                    "Thanks and Regards<br/>" +
                    "<b>Application Administrator</b><br/>";

                string body =
                    $"{header}<br/>" +
                    $"<b>Application:</b> {application}<br/>" +
                    $"<b>Log Written Date:</b> {DateTime.Now}<br/>" +
                    $"<b>Error Line No:</b> {errorLineNo}<br/>" +
                    $"<b>Error Message:</b> {errorName}<br/>" +
                    $"<b>Exception Type:</b> {exceptionType}<br/>" +
                    $"<b>Error Details:</b> {errorMessage}<br/>" +
                    $"<b>Error Stack:</b><br/>&emsp;{errorStack.Replace("\n", "<br/>&emsp;")}<br/>" +
                    $"{signature}";

                using MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };

                string[] multipleEmailId = to.Split(',');

                foreach (string userEmails in multipleEmailId)
                {
                    mailMessage.To.Add(new MailAddress(userEmails));
                }

                NetworkCredential networkCredentials = new NetworkCredential
                {
                    UserName = mailMessage.From.Address,
                    Password = password
                };

                using SmtpClient smtp = new SmtpClient
                {
                    Host = hostAddress,
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = networkCredentials
                };
                
                smtp.Send(mailMessage);
            }
            catch (Exception em)
            {
                _ = MessageBox.Show(em.ToString());
            }
        }
    }
}

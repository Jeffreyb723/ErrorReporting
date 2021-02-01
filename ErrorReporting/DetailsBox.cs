using System.Drawing;
using System.Windows.Forms;

namespace ErrorReporting 
{
    /// <summary>
    /// Displays a message window, also known as a dialog box, with an optional display section, which presents information to the user. It is a modal window, blocking other
    /// actions in the application until the user closes it. A <see cref="DetailsBox"/> can contain text, buttons, and symbols that inform and instruct the user./>
    /// </summary>
    public partial class DetailsBox : Form
    {
        private bool _showDetails;

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private DetailsBox(string text, string caption, string details = null)
        {
            InitializeComponent();

            MessageLabel.Text = text;
            Text = caption;

            Height = System.Math.Max(MessageLabel.Height + 102, 168);
            Width = System.Math.Max(MessageLabel.Width + 102, 310);

            MessageLabel.Top = (WindowPanel.Height - MessageLabel.Height) / 2;
            ErrorImage.Top = (WindowPanel.Height - ErrorImage.Height) / 2;

            DetailsButton.Enabled = details != null;

            DetailsDisplay.Text = details;
            DetailsDisplay.Top = WindowPanel.Height + 42;
            DetailsDisplay.Height = 0;

            DetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            SendButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            WindowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        /// <summary>
        /// Displays a message box with the specified text, caption, and details.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="details">The text to display in the details section of the message box.</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, string details = null) =>
            new DetailsBox(text, caption, details).ShowDialog();

        private void DetailsButton_Click(object sender, System.EventArgs e)
        {
            _showDetails = !_showDetails;

            if (_showDetails)
            {
                DetailsButton.Image = new Bitmap(Properties.Resources.UpArrow);

                Height += 153;
            }
            else
            {
                DetailsButton.Image = new Bitmap(Properties.Resources.DownArrow);

                Height -= 153;
            }
        }
    }
}

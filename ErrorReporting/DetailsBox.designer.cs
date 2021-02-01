namespace ErrorReporting
{
    partial class DetailsBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ErrorImage = new System.Windows.Forms.PictureBox();
            this.DetailsDisplay = new System.Windows.Forms.TextBox();
            this.WindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.SendButton.Location = new System.Drawing.Point(92, 96);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(112, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send Error Report";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ExitButton.Location = new System.Drawing.Point(208, 96);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Don\'t Send";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailsButton.Enabled = false;
            this.DetailsButton.Image = global::ErrorReporting.Properties.Resources.DownArrow;
            this.DetailsButton.Location = new System.Drawing.Point(12, 96);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 23);
            this.DetailsButton.TabIndex = 0;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // WindowPanel
            // 
            this.WindowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowPanel.BackColor = System.Drawing.SystemColors.Window;
            this.WindowPanel.Controls.Add(this.MessageLabel);
            this.WindowPanel.Controls.Add(this.ErrorImage);
            this.WindowPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(294, 84);
            this.WindowPanel.TabIndex = 4;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(64, 35);
            this.MessageLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(35, 13);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.Text = "label1";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorImage
            // 
            this.ErrorImage.Image = global::ErrorReporting.Properties.Resources.ErrorImage;
            this.ErrorImage.Location = new System.Drawing.Point(26, 26);
            this.ErrorImage.Name = "ErrorImage";
            this.ErrorImage.Size = new System.Drawing.Size(32, 32);
            this.ErrorImage.TabIndex = 4;
            this.ErrorImage.TabStop = false;
            // 
            // DetailsDisplay
            // 
            this.DetailsDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.DetailsDisplay.Location = new System.Drawing.Point(13, 126);
            this.DetailsDisplay.Multiline = true;
            this.DetailsDisplay.Name = "DetailsDisplay";
            this.DetailsDisplay.ReadOnly = true;
            this.DetailsDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DetailsDisplay.Size = new System.Drawing.Size(269, 0);
            this.DetailsDisplay.TabIndex = 5;
            this.DetailsDisplay.WordWrap = false;
            // 
            // DetailsBox
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(294, 130);
            this.Controls.Add(this.DetailsDisplay);
            this.Controls.Add(this.WindowPanel);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsBox";
            this.WindowPanel.ResumeLayout(false);
            this.WindowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.PictureBox ErrorImage;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox DetailsDisplay;
    }
}
namespace ATNetCoreTelegramBot.WFA.UI
{
    partial class FrmReplyKeyboardMarkup
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
            SuspendLayout();
            // 
            // FrmReplyKeyboardMarkup
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 257);
            Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmReplyKeyboardMarkup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReplyKeyboardMarkup";
            Load += FrmReplyKeyboardMarkup_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
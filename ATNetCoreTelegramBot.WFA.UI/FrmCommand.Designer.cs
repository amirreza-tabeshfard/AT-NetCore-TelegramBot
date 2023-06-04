namespace ATNetCoreTelegramBot.WFA.UI;

partial class FrmCommand
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
        // FrmCommand
        // 
        AutoScaleDimensions = new SizeF(9F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(280, 257);
        Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmCommand";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Command";
        Load += FrmCommand_Load;
        ResumeLayout(false);
    }

    #endregion
}
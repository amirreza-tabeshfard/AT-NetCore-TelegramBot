namespace ATNetCoreTelegramBot.WFA.UI;

partial class FrmMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = default;

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
        this.components = new System.ComponentModel.Container();
        this.MenuStrip = new System.Windows.Forms.MenuStrip();
        this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
        this.MnuFile_StartStop = new System.Windows.Forms.ToolStripMenuItem();
        this.timer = new System.Windows.Forms.Timer(this.components);
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.toolStriplblCheckOnline = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStriplblSeperator1 = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStriplblListen = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStriplblSeperator2 = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStriplblCurrentDateTime = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStriplblSeperator3 = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStriplblDateTimeAge = new System.Windows.Forms.ToolStripStatusLabel();
        this.MenuStrip.SuspendLayout();
        this.statusStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // MenuStrip
        // 
        this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.MnuFile});
        this.MenuStrip.Location = new System.Drawing.Point(0, 0);
        this.MenuStrip.Name = "MenuStrip";
        this.MenuStrip.Size = new System.Drawing.Size(634, 24);
        this.MenuStrip.TabIndex = 1;
        this.MenuStrip.Text = "menuStrip1";
        // 
        // MnuFile
        // 
        this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.MnuFile_StartStop});
        this.MnuFile.Name = "MnuFile";
        this.MnuFile.Size = new System.Drawing.Size(37, 20);
        this.MnuFile.Text = "&File";
        // 
        // MnuFile_StartStop
        // 
        this.MnuFile_StartStop.Name = "MnuFile_StartStop";
        this.MnuFile_StartStop.Size = new System.Drawing.Size(180, 22);
        this.MnuFile_StartStop.Text = "Start/Stop";
        this.MnuFile_StartStop.Click += new System.EventHandler(this.MnuFile_StartStop_Click);
        // 
        // timer
        // 
        this.timer.Enabled = true;
        this.timer.Interval = 1000;
        this.timer.Tick += new System.EventHandler(this.Timer_Tick);
        // 
        // statusStrip
        // 
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.toolStriplblCheckOnline,
        this.toolStriplblSeperator1,
        this.toolStriplblListen,
        this.toolStriplblSeperator2,
        this.toolStriplblCurrentDateTime,
        this.toolStriplblSeperator3,
        this.toolStriplblDateTimeAge});
        this.statusStrip.Location = new System.Drawing.Point(0, 339);
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.Size = new System.Drawing.Size(634, 22);
        this.statusStrip.TabIndex = 8;
        this.statusStrip.Text = "statusStrip1";
        // 
        // toolStriplblCheckOnline
        // 
        this.toolStriplblCheckOnline.ForeColor = System.Drawing.Color.Red;
        this.toolStriplblCheckOnline.Name = "toolStriplblCheckOnline";
        this.toolStriplblCheckOnline.Size = new System.Drawing.Size(46, 17);
        this.toolStriplblCheckOnline.Text = "OffLine";
        // 
        // toolStriplblSeperator1
        // 
        this.toolStriplblSeperator1.Name = "toolStriplblSeperator1";
        this.toolStriplblSeperator1.Size = new System.Drawing.Size(10, 17);
        this.toolStriplblSeperator1.Text = "|";
        this.toolStriplblSeperator1.Visible = false;
        // 
        // toolStriplblListen
        // 
        this.toolStriplblListen.Name = "toolStriplblListen";
        this.toolStriplblListen.Size = new System.Drawing.Size(10, 17);
        this.toolStriplblListen.Text = " ";
        this.toolStriplblListen.Visible = false;
        // 
        // toolStriplblSeperator2
        // 
        this.toolStriplblSeperator2.Name = "toolStriplblSeperator2";
        this.toolStriplblSeperator2.Size = new System.Drawing.Size(10, 17);
        this.toolStriplblSeperator2.Text = "|";
        this.toolStriplblSeperator2.Visible = false;
        // 
        // toolStriplblCurrentDateTime
        // 
        this.toolStriplblCurrentDateTime.Name = "toolStriplblCurrentDateTime";
        this.toolStriplblCurrentDateTime.Size = new System.Drawing.Size(10, 17);
        this.toolStriplblCurrentDateTime.Text = " ";
        this.toolStriplblCurrentDateTime.Visible = false;
        // 
        // toolStriplblSeperator3
        // 
        this.toolStriplblSeperator3.Name = "toolStriplblSeperator3";
        this.toolStriplblSeperator3.Size = new System.Drawing.Size(10, 17);
        this.toolStriplblSeperator3.Text = "|";
        this.toolStriplblSeperator3.Visible = false;
        // 
        // toolStriplblDateTimeAge
        // 
        this.toolStriplblDateTimeAge.Name = "toolStriplblDateTimeAge";
        this.toolStriplblDateTimeAge.Size = new System.Drawing.Size(10, 17);
        this.toolStriplblDateTimeAge.Text = " ";
        this.toolStriplblDateTimeAge.Visible = false;
        // 
        // FrmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(634, 361);
        this.Controls.Add(this.statusStrip);
        this.Controls.Add(this.MenuStrip);
        this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.IsMdiContainer = true;
        this.Name = "FrmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Telegram Bot";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
        this.MenuStrip.ResumeLayout(false);
        this.MenuStrip.PerformLayout();
        this.statusStrip.ResumeLayout(false);
        this.statusStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MenuStrip;
    private System.Windows.Forms.ToolStripMenuItem MnuFile;
    private System.Windows.Forms.ToolStripMenuItem MnuFile_StartStop;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblCheckOnline;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblSeperator1;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblListen;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblSeperator2;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblCurrentDateTime;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblSeperator3;
    private System.Windows.Forms.ToolStripStatusLabel toolStriplblDateTimeAge;
}
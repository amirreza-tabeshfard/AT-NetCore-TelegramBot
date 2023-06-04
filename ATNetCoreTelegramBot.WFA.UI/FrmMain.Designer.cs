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
        components = new System.ComponentModel.Container();
        MenuStrip = new MenuStrip();
        MnuFile = new ToolStripMenuItem();
        MnuFile_StartStop = new ToolStripMenuItem();
        MnuManage = new ToolStripMenuItem();
        MnuManage_Groups = new ToolStripMenuItem();
        MnuManage_Users = new ToolStripMenuItem();
        timer = new System.Windows.Forms.Timer(components);
        statusStrip = new StatusStrip();
        toolStriplblCheckOnline = new ToolStripStatusLabel();
        toolStriplblSeperator1 = new ToolStripStatusLabel();
        toolStriplblListen = new ToolStripStatusLabel();
        toolStriplblSeperator2 = new ToolStripStatusLabel();
        toolStriplblCurrentDateTime = new ToolStripStatusLabel();
        toolStriplblSeperator3 = new ToolStripStatusLabel();
        toolStriplblDateTimeAge = new ToolStripStatusLabel();
        MenuStrip.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // MenuStrip
        // 
        MenuStrip.Items.AddRange(new ToolStripItem[] { MnuFile, MnuManage });
        MenuStrip.Location = new Point(0, 0);
        MenuStrip.Name = "MenuStrip";
        MenuStrip.Size = new Size(634, 24);
        MenuStrip.TabIndex = 1;
        MenuStrip.Text = "menuStrip1";
        // 
        // MnuFile
        // 
        MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuFile_StartStop });
        MnuFile.Name = "MnuFile";
        MnuFile.Size = new Size(37, 20);
        MnuFile.Text = "&File";
        // 
        // MnuFile_StartStop
        // 
        MnuFile_StartStop.Name = "MnuFile_StartStop";
        MnuFile_StartStop.Size = new Size(127, 22);
        MnuFile_StartStop.Text = "Start/Stop";
        MnuFile_StartStop.Click += MnuFile_StartStop_Click;
        // 
        // MnuManage
        // 
        MnuManage.DropDownItems.AddRange(new ToolStripItem[] { MnuManage_Groups, MnuManage_Users });
        MnuManage.Name = "MnuManage";
        MnuManage.Size = new Size(62, 20);
        MnuManage.Text = "&Manage";
        // 
        // MnuManage_Groups
        // 
        MnuManage_Groups.Name = "MnuManage_Groups";
        MnuManage_Groups.Size = new Size(180, 22);
        MnuManage_Groups.Text = "Groups";
        MnuManage_Groups.Click += MnuManage_Groups_Click;
        // 
        // MnuManage_Users
        // 
        MnuManage_Users.Name = "MnuManage_Users";
        MnuManage_Users.Size = new Size(180, 22);
        MnuManage_Users.Text = "Users";
        MnuManage_Users.Click += MnuManage_Users_Click;
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Interval = 1000;
        timer.Tick += Timer_Tick;
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { toolStriplblCheckOnline, toolStriplblSeperator1, toolStriplblListen, toolStriplblSeperator2, toolStriplblCurrentDateTime, toolStriplblSeperator3, toolStriplblDateTimeAge });
        statusStrip.Location = new Point(0, 339);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(634, 22);
        statusStrip.TabIndex = 8;
        statusStrip.Text = "statusStrip1";
        // 
        // toolStriplblCheckOnline
        // 
        toolStriplblCheckOnline.ForeColor = Color.Red;
        toolStriplblCheckOnline.Name = "toolStriplblCheckOnline";
        toolStriplblCheckOnline.Size = new Size(46, 17);
        toolStriplblCheckOnline.Text = "OffLine";
        // 
        // toolStriplblSeperator1
        // 
        toolStriplblSeperator1.Name = "toolStriplblSeperator1";
        toolStriplblSeperator1.Size = new Size(10, 17);
        toolStriplblSeperator1.Text = "|";
        toolStriplblSeperator1.Visible = false;
        // 
        // toolStriplblListen
        // 
        toolStriplblListen.Name = "toolStriplblListen";
        toolStriplblListen.Size = new Size(10, 17);
        toolStriplblListen.Text = " ";
        toolStriplblListen.Visible = false;
        // 
        // toolStriplblSeperator2
        // 
        toolStriplblSeperator2.Name = "toolStriplblSeperator2";
        toolStriplblSeperator2.Size = new Size(10, 17);
        toolStriplblSeperator2.Text = "|";
        toolStriplblSeperator2.Visible = false;
        // 
        // toolStriplblCurrentDateTime
        // 
        toolStriplblCurrentDateTime.Name = "toolStriplblCurrentDateTime";
        toolStriplblCurrentDateTime.Size = new Size(10, 17);
        toolStriplblCurrentDateTime.Text = " ";
        toolStriplblCurrentDateTime.Visible = false;
        // 
        // toolStriplblSeperator3
        // 
        toolStriplblSeperator3.Name = "toolStriplblSeperator3";
        toolStriplblSeperator3.Size = new Size(10, 17);
        toolStriplblSeperator3.Text = "|";
        toolStriplblSeperator3.Visible = false;
        // 
        // toolStriplblDateTimeAge
        // 
        toolStriplblDateTimeAge.Name = "toolStriplblDateTimeAge";
        toolStriplblDateTimeAge.Size = new Size(10, 17);
        toolStriplblDateTimeAge.Text = " ";
        toolStriplblDateTimeAge.Visible = false;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(9F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(634, 361);
        Controls.Add(statusStrip);
        Controls.Add(MenuStrip);
        Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        IsMdiContainer = true;
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Telegram Bot";
        WindowState = FormWindowState.Maximized;
        FormClosing += FrmMain_FormClosing;
        MenuStrip.ResumeLayout(false);
        MenuStrip.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip MenuStrip;
    private ToolStripMenuItem MnuFile;
    private ToolStripMenuItem MnuFile_StartStop;
    private System.Windows.Forms.Timer timer;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel toolStriplblCheckOnline;
    private ToolStripStatusLabel toolStriplblSeperator1;
    private ToolStripStatusLabel toolStriplblListen;
    private ToolStripStatusLabel toolStriplblSeperator2;
    private ToolStripStatusLabel toolStriplblCurrentDateTime;
    private ToolStripStatusLabel toolStriplblSeperator3;
    private ToolStripStatusLabel toolStriplblDateTimeAge;
    private ToolStripMenuItem MnuManage;
    private ToolStripMenuItem MnuManage_Groups;
    private ToolStripMenuItem MnuManage_Users;
}
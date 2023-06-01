namespace ATNetCoreTelegramBot.WFA.UI;

partial class FrmTelegramBot
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = default;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        statusStrip = new StatusStrip();
        toolStriplblCheckOnline = new ToolStripStatusLabel();
        groupBox1 = new GroupBox();
        btnEnd = new Button();
        btnStart = new Button();
        txtToken = new TextBox();
        statusStrip.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { toolStriplblCheckOnline });
        statusStrip.Location = new Point(0, 85);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(620, 22);
        statusStrip.TabIndex = 0;
        statusStrip.Text = "statusStrip1";
        // 
        // toolStriplblCheckOnline
        // 
        toolStriplblCheckOnline.ForeColor = Color.Red;
        toolStriplblCheckOnline.Name = "toolStriplblCheckOnline";
        toolStriplblCheckOnline.Size = new Size(46, 17);
        toolStriplblCheckOnline.Text = "OffLine";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnEnd);
        groupBox1.Controls.Add(btnStart);
        groupBox1.Controls.Add(txtToken);
        groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.RightToLeft = RightToLeft.Yes;
        groupBox1.Size = new Size(596, 62);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Token";
        // 
        // btnEnd
        // 
        btnEnd.BackColor = Color.Transparent;
        btnEnd.Image = Properties.Resources.Stop;
        btnEnd.Location = new Point(6, 21);
        btnEnd.Name = "btnEnd";
        btnEnd.Size = new Size(48, 34);
        btnEnd.TabIndex = 5;
        btnEnd.UseVisualStyleBackColor = false;
        btnEnd.Click += BtnEnd_Click;
        // 
        // btnStart
        // 
        btnStart.BackColor = Color.Transparent;
        btnStart.ForeColor = SystemColors.ControlText;
        btnStart.Image = Properties.Resources.Play;
        btnStart.Location = new Point(60, 21);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(48, 34);
        btnStart.TabIndex = 4;
        btnStart.UseVisualStyleBackColor = false;
        btnStart.Click += BtnStart_Click;
        // 
        // txtToken
        // 
        txtToken.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txtToken.Location = new Point(114, 25);
        txtToken.Name = "txtToken";
        txtToken.Size = new Size(476, 26);
        txtToken.TabIndex = 0;
        // 
        // FrmTelegramBot
        // 
        AutoScaleDimensions = new SizeF(11F, 22F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(620, 107);
        Controls.Add(groupBox1);
        Controls.Add(statusStrip);
        Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5, 4, 5, 4);
        MaximizeBox = false;
        Name = "FrmTelegramBot";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Telegram Bot";
        FormClosing += FrmTelegramBot_FormClosing;
        Load += FrmTelegramBot_Load;
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip;
    internal ToolStripStatusLabel toolStriplblCheckOnline;
    private GroupBox groupBox1;
    private TextBox txtToken;
    private Button btnStart;
    private Button btnEnd;
}


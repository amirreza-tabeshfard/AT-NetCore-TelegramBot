using DateTimeExtensions = ATNetCoreTelegramBot.Common.Extensions.DateTimeExtensions;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmMain : Form
{
    #region Field(s)

    private FrmTelegramBot _frmTelegramBot;
    private FrmGroupIndex frmGroupIndex;

    #endregion

    #region Constructor

    public FrmMain()
    {
        InitializeComponent();
    }

    #endregion

    #region Private Method(s)

    private void ResetAllControls()
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form.Name != "FrmTelegramBot")
                form.Close();
        }
    }

    private void GroupIndexShow()
    {
        frmGroupIndex = new FrmGroupIndex();

        if (this.MdiChildren.Count() == 1)
        {
            frmGroupIndex.MdiParent = this;
            frmGroupIndex.Show();
        }
        else
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "FrmGroupIndex")
                    form.Show();
            }
        }
    }

    private void Online()
    {
        toolStriplblCheckOnline.Text = "Online";
        toolStriplblCheckOnline.ForeColor = Color.Green;
        toolStriplblSeperator1.Visible = true;
        toolStriplblSeperator2.Visible = true;
        toolStriplblCurrentDateTime.Visible = true;
        toolStriplblDateTimeAge.Visible = true;
        toolStriplblListen.Visible = true;
        toolStriplblListen.Text = $"Start listening for @{FrmTelegramBot.myTelegramBotUser?.Username}";
        toolStriplblCurrentDateTime.Text = FrmTelegramBot.currentDateTime.ToString();
        toolStriplblDateTimeAge.Text = DateTimeExtensions.GetAge(FrmTelegramBot.currentDateTime);

        if (!string.IsNullOrEmpty(toolStriplblDateTimeAge.Text))
            toolStriplblSeperator3.Visible = true;

        GroupIndexShow();
    }

    private void Offline()
    {
        toolStriplblCheckOnline.Text = "OffLine";
        toolStriplblCheckOnline.ForeColor = Color.Red;
        toolStriplblSeperator1.Visible = false;
        toolStriplblSeperator2.Visible = false;
        toolStriplblSeperator3.Visible = false;
        toolStriplblCurrentDateTime.Visible = false;
        toolStriplblDateTimeAge.Visible = false;
        toolStriplblListen.Visible = false;
        toolStriplblListen.Text = default;
        toolStriplblCurrentDateTime.Text = default;
        toolStriplblDateTimeAge.Text = default;

        ResetAllControls();
    }

    private void CheckOnline(bool isOnline)
    {
        if (isOnline)
            Online();
        else
            Offline();
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    #endregion

    #region Event(s) ==> File

    private void MnuFile_StartStop_Click(object sender, EventArgs e)
    {
        _frmTelegramBot = new FrmTelegramBot();

        if (this.MdiChildren.Count() == 0)
        {
            _frmTelegramBot.MdiParent = this;
            _frmTelegramBot.Text = $"Telegram Bot (Start/Stop)";
            _frmTelegramBot.Show();
        }
        else
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "FrmTelegramBot")
                    form.Show();
            }
        }
    }

    #endregion

    private void Timer_Tick(object sender, EventArgs e)
    {
        if (_frmTelegramBot != null)
            if (!string.IsNullOrEmpty(_frmTelegramBot.toolStriplblCheckOnline.Text))
                CheckOnline((_frmTelegramBot.toolStriplblCheckOnline.Text == "Online") ? true : false);
    }
}
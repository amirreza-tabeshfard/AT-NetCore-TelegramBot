using Telegram.Bot;
using Telegram.Bot.Types;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmTelegramBot : Form
{
    #region Field(s)

    internal static DateTime currentDateTime;
    internal static User myTelegramBotUser;
    internal static bool isOnline;

    #endregion

    #region Constructor

    public FrmTelegramBot()
    {
        InitializeComponent();
    }

    #endregion

    #region Private Method(s)

    private void Online()
    {
        currentDateTime = DateTime.Now;
        txtToken.Enabled = false;
        btnStart.Enabled = false;
        btnEnd.Enabled = true;
        toolStriplblCheckOnline.Text = "Online";
        toolStriplblCheckOnline.ForeColor = System.Drawing.Color.Green;
        //Program.telegramBotClient = new TelegramBotClient(token: Program.Token, httpClient: null);
        //myTelegramBotUser = Program.telegramBotClient.GetMeAsync().Result;
        isOnline = true;
    }

    private void Offline()
    {
        txtToken.Enabled = true;
        btnStart.Enabled = true;
        btnEnd.Enabled = false;
        toolStriplblCheckOnline.Text = "OffLine";
        toolStriplblCheckOnline.ForeColor = System.Drawing.Color.Red;
        isOnline = false;
    }

    private void CheckOnline()
    {
        if (isOnline)
        {
            Program.Token = txtToken.Text;
            Online();
        }
        else
            Offline();
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmTelegramBot_Load(object sender, EventArgs e)
    {
        txtToken.Text = Program.Token;
        CheckOnline();
    }

    private void FrmTelegramBot_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (isOnline)
            e.Cancel = true;
        else
            e.Cancel = false;
    }

    #endregion

    #region Event(s) ==> Button

    private void BtnStart_Click(object sender, EventArgs e)
    {
        isOnline = true;
        CheckOnline();
        //Program.telegramBotClient.StartReceiving(updateHandler: default, receiverOptions: default, cancellationToken: default);
    }

    private void BtnEnd_Click(object sender, EventArgs e)
    {
        Offline();
        //if (Program.telegramBotClient != null)
        //    Program.telegramBotClient = default;
    }

    #endregion
}
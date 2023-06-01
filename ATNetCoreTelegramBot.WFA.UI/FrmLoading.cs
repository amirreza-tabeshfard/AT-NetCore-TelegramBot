namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmLoading : Form
{
    #region Field(s)



    #endregion

    #region Constructor

    public FrmLoading()
    {
        InitializeComponent();
    }

    #endregion

    #region Event(s): Timer

    private void Timer_Tick(object sender, EventArgs e)
    {
        this.Text = $"Loadinng: {progressBar.Value++}%";

        if (progressBar.Value == progressBar.Maximum)
        {
            timer.Enabled = false;
            this.Hide();
        }
    }

    #endregion
}
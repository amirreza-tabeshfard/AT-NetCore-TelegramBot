using Telegram.Bot.Types.ReplyMarkups;

namespace ATNetCoreTelegramBot.WFA.UI
{
    public partial class FrmReplyKeyboardMarkup : Form
    {
        #region Constructor

        public FrmReplyKeyboardMarkup()
        {
            InitializeComponent();
        }

        #endregion

        #region Internal Method(s)

        internal ReplyKeyboardMarkup Main()
        {
            KeyboardButton[][] keyboardButtons = default;
            ReplyKeyboardMarkup result = default;
            // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            keyboardButtons = new[]
            {
                new[]
                {
                    new KeyboardButton(text: "❓ سوالات متداول"),
                    new KeyboardButton(text: "👤 حساب کاربری من"),
                },
                new[]
                {
                    new KeyboardButton(text: "📜 قوانین"),
                    new KeyboardButton(text: "☎️ پشتیبانی"),
                    new KeyboardButton(text: "📨 ارتباط با ما"),
                },
            };
            // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            result = new ReplyKeyboardMarkup(keyboardButtons);
            // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            return result;
        }

        #endregion

        #region Event(s) ==> Form

        private void FrmReplyKeyboardMarkup_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
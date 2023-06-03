using Telegram.Bot.Types;

using ATNetCoreTelegramBot.Common.Extensions;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmUsers : Infrastructure.BaseController
{
    #region Constructor

    public FrmUsers()
    {
        InitializeComponent();
    }

    #endregion

    #region Private Method(s)

    private bool IsUserExist(User? user)
    {
        Models.SchemaTelegram.User userModel = default;
        bool result = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (user is not null)
            userModel = UnitOfWork
                        .SchemaTelegramUnitOfWork
                        .UserRepository
                        .GetByChatID(user.Id)
                        ;

        if (userModel is not null)
            result = true;
        else
            result = InsertUser(user);
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    private void RefreshAllDataGrid()
    {
        IEnumerable<Models.SchemaTelegram.User> allUsers = GetByAllUsers();
        RefreshAllDataGrid(allUsers);
    }

    private void RefreshAllDataGrid(IEnumerable<Models.SchemaTelegram.User> users)
    {
        dataGridView.DataSource = default;
        dataGridView.Rows.Clear();

        if (users is not null)
            if (users.Count() != 0)
            {
                foreach (var user in users)
                {
                    int rowIndex = this.dataGridView.Rows.Add();
                    var row = this.dataGridView.Rows[rowIndex];

                    row.Cells["ChatID"].Value = user.ChatID;
                    row.Cells["UserName"].Value = user.UserName;
                    row.Cells["FirstName"].Value = user.FirstName;
                    row.Cells["LastName"].Value = user.LastName;
                    row.Cells["IsBot"].Value = user.IsBot;
                    row.Cells["IsPremium"].Value = user.IsPremium;
                    row.Cells["LanguageCode"].Value = user.LanguageCode;
                    row.Cells["AddedToAttachmentMenu"].Value = user.AddedToAttachmentMenu;
                    row.Cells["CanJoinGroups"].Value = user.CanJoinGroups;
                    row.Cells["CanReadAllGroupMessages"].Value = user.CanReadAllGroupMessages;
                    row.Cells["SupportsInlineQueries"].Value = user.SupportsInlineQueries;
                    row.Cells["InsertDateTime"].Value = $"{user.InsertDateTime.ToLongPersianDate()} ({user.InsertDateTime.Hour}:{user.InsertDateTime.Minute})";
                }
            }
    }

    #endregion

    #region Method(s): CRUD

    private IEnumerable<Models.SchemaTelegram.User> GetByAllUsers()
    {
        IEnumerable<Models.SchemaTelegram.User> result = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        result = UnitOfWork
                    .SchemaTelegramUnitOfWork
                    .UserRepository
                    .GetByAllUsers()
                    ;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    private bool InsertUser(User? user)
    {
        Models.SchemaTelegram.User userModel = default;
        bool result = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (user is not null)
        {
            userModel = new Models.SchemaTelegram.User()
            {
                AddedToAttachmentMenu = user.AddedToAttachmentMenu,
                CanJoinGroups = user.CanJoinGroups,
                CanReadAllGroupMessages = user.CanReadAllGroupMessages,
                ChatID = user.Id,
                FirstName = user.FirstName,
                InsertDateTime = DateTime.Now,
                IsBot = user.IsBot,
                IsPremium = user.IsPremium,
                LanguageCode = user.LanguageCode,
                LastName = user.LastName,
                SupportsInlineQueries = user.SupportsInlineQueries,
                UserName = user.Username
            };

            UnitOfWork
                .SchemaTelegramUnitOfWork
                .UserRepository
                .Insert(userModel)
                ;

            UnitOfWork
                .SaveChanges();

            result = true;
        }
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    #endregion

    #region Internal Method(s)

    internal bool InitializeUser(User? user)
    {
        bool result = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        result = IsUserExist(user);
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmUsers_Load(object sender, EventArgs e)
    {
        RefreshAllDataGrid();
    }

    private void FrmUsers_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (FrmTelegramBot.isOnline)
            e.Cancel = true;
        else
            e.Cancel = false;
    }

    #endregion
}
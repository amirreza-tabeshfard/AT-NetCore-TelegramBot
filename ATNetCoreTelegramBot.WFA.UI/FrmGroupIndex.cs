using System.Data;
using System.Text;

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using ATNetCoreTelegramBot.Common.Extensions;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmGroupIndex : Infrastructure.BaseController
{
    #region Field(s)

    private FrmGroupInsert _frmGroupInsert;
    private FrmGroupUpdate _frmGroupUpdate;

    #endregion

    #region Field(s) ==> Telegram

    private long id = default(long);
    private string userName = default(string);

    #endregion

    #region Constructor

    public FrmGroupIndex()
    {
        InitializeComponent();
    }

    #endregion

    #region Private Method(s)

    private IEnumerable<Models.SchemaTelegram.Group> AllGroups()
    {
        IEnumerable<Models.SchemaTelegram.Group> _groups;

        _groups = UnitOfWork
                    .SchemaTelegramUnitOfWork
                    .GroupRepository
                    .GetByAllGroups
                    ();

        return _groups;
    }

    private IEnumerable<string> InitializeChannelAndGroups()
    {
        List<string> results = new List<string>();
        IEnumerable<Models.SchemaTelegram.Group> groups = AllGroups();

        if (groups != null)
            foreach (Models.SchemaTelegram.Group group in groups)
                results.Add(group.Name);

        return results;
    }

    private IEnumerable<string> InMemberOfGroups(IEnumerable<string> groups, long id)
    {
        List<string> result = new List<string>();

        if (groups != null)
        {
            foreach (string group in groups)
            {
                try
                {
                    Task<ChatMember> chatMember = Program.telegramBotClient.GetChatMemberAsync(group, id);

                    if (chatMember is not null)
                        if (chatMember.Result is not null)
                        {
                            if (chatMember.Result.Status.ToString().Length > 25)
                                result.Add(group);

                            if (chatMember.Result.Status.ToString() == "Left")
                                result.Add(group);
                        }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        return result;
    }

    private void RefreshAllDataGrid()
    {
        RefreshAllDataGrid(AllGroups());
    }

    private void RefreshAllDataGrid(IEnumerable<Models.SchemaTelegram.Group> groups)
    {
        dataGridView.DataSource = default;
        dataGridView.Rows.Clear();

        if (groups.Count() != 0)
        {
            foreach (var group in groups.OrderBy(current => current.Ordering))
            {
                int rowIndex = this.dataGridView.Rows.Add();
                var row = this.dataGridView.Rows[rowIndex];

                row.Cells["Id"].Value = group.Id;
                row.Cells["GroupName"].Value = group.Name;
                row.Cells["Ordering"].Value = group.Ordering;
                row.Cells["InsertDateTime"].Value = $"{group.InsertDateTime.ToLongPersianDate()} ({group.InsertDateTime.Hour}:{group.InsertDateTime.Minute})";
            }
        }

    }

    #endregion

    #region Internal Method(s)

    public bool? InitializeGroups(long id, string userName)
    {
        bool? result = default;
        IEnumerable<string> NamesOfGroupsThatTheUserIsNotAMember;
        IEnumerable<string> groupNames = InitializeChannelAndGroups();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (groupNames.Any())
        {
            NamesOfGroupsThatTheUserIsNotAMember = InMemberOfGroups(groupNames, id);

            if (NamesOfGroupsThatTheUserIsNotAMember.Count() != 0)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"کاربر گرامی (<b><i>{userName}</i></b>)");
                sb.AppendLine("جهت استفاده از این ربات باید عضو گروه های ذیل شوید.");
                sb.AppendLine();
                sb.AppendLine("👥 لیست گروه ها");

                foreach (var item in NamesOfGroupsThatTheUserIsNotAMember)
                {
                    string url = item.Replace("@", "https://t.me/");
                    sb.AppendLine($"🔘 <a href='{url}'>{item.Replace("@", "")}</a>");
                }

                Program.telegramBotClient.SendTextMessageAsync(chatId: id,
                                                             text: sb.ToString(),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: default,
                                                             disableWebPagePreview: default,
                                                             protectContent: default,
                                                             replyToMessageId: default,
                                                             allowSendingWithoutReply: default,
                                                             replyMarkup: default,
                                                             cancellationToken: CancellationToken.None
                                                             );

                result = true;
            }
            else
                result = false;
        }

        return result;
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmGroupIndex_Load(object sender, EventArgs e)
    {
        RefreshAllDataGrid();
    }

    private void FrmGroupIndex_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (FrmTelegramBot.isOnline)
            e.Cancel = true;
        else
            e.Cancel = false;
    }

    #endregion

    #region Event(s) ==> Menu(s)

    private void mnuFileDelete_Click(object sender, EventArgs e)
    {
        Guid id;
        int selectedRowCount = dataGridView.CurrentCell.RowIndex;
        var row = dataGridView.Rows[selectedRowCount];

        string textMessage = $"آیا می خواهید {row.Cells["GroupName"].Value} را حذف کنید ؟";
        string captionMessage = "حذف گروه";
        MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
        MessageBoxIcon messageBoxIcon = MessageBoxIcon.Question;
        MessageBoxDefaultButton messageBoxDefaultButton = MessageBoxDefaultButton.Button1;
        MessageBoxOptions messageBoxOptions = MessageBoxOptions.RtlReading;

        DialogResult result = MessageBox.Show(textMessage, captionMessage, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton, messageBoxOptions);

        switch (result)
        {
            case DialogResult.Yes:
                {
                    Guid.TryParse(row.Cells["Id"].Value.ToString(), out id);

                    if (id != default)
                    {
                        Models.SchemaTelegram.Group group = UnitOfWork
                                                            .SchemaTelegramUnitOfWork
                                                            .GroupRepository
                                                            .GetByID(id);

                        UnitOfWork
                            .SchemaTelegramUnitOfWork
                            .GroupRepository
                            .Delete(group)
                            ;

                        UnitOfWork
                            .SaveChanges();
                    }

                    RefreshAllDataGrid();
                }
                break;
        }
    }

    private void mnuFileInsert_Click(object sender, EventArgs e)
    {
        using (_frmGroupInsert = new FrmGroupInsert())
        {
            var result = _frmGroupInsert.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshAllDataGrid();
            }
        }
    }

    private void mnuFileUpdate_Click(object sender, EventArgs e)
    {
        Guid id = default;
        string name = default;
        int ordering = default;
        // **********************************
        int selectedRowCount = dataGridView.CurrentCell.RowIndex;
        var row = dataGridView.Rows[selectedRowCount];
        // **********************************
        Guid.TryParse(row.Cells["Id"].Value.ToString(), out id);
        name = row.Cells["GroupName"].Value.ToString();
        ordering = int.Parse(row.Cells["Ordering"].Value.ToString());
        // **********************************

        using (_frmGroupUpdate = new FrmGroupUpdate(id, name, ordering))
        {
            var result = _frmGroupUpdate.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshAllDataGrid();
            }
        }
    }

    #endregion

    #region Event(s) ==> ContextMenuStrip(s)

    private void ContextMenuStripRefresh_Click(object sender, EventArgs e)
    {
        RefreshAllDataGrid();
    }

    #endregion
}
using ATNetCoreTelegramBot.DAL;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmGroupUpdate : Infrastructure.BaseController
{
    #region Field(s)

    private readonly Guid _id;
    private readonly string _name;
    private readonly int _ordering;

    #endregion

    #region Constructor

    private FrmGroupUpdate()
    {
        InitializeComponent();
    }
    
    public FrmGroupUpdate(Guid id, string name, int ordering)
        :this()
    {
        _id = id;
        _name = name;
        _ordering = ordering;
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmGroupUpdate_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void FrmGroupUpdate_Load(object sender, EventArgs e)
    {
        txtName.Text = _name;
        numericOrdering.Value = _ordering;
    }

    #endregion

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtName.Text))
        {
            errorProvider.SetError(txtName, "کاربر گرامی گروه را وارد نکردید");
            return;
        }

        Models.SchemaTelegram.Group groupInDB = UnitOfWork
                                                    .SchemaTelegramUnitOfWork
                                                    .GroupRepository
                                                    .GetByName(txtName.Text)
                                                    ;

        if (groupInDB != null)
        {
            errorProvider.SetError(txtName, "کاربر گرامی نام گروه تکراری می باشد");
            return;
        }


        Models.SchemaTelegram.Group group = UnitOfWork
                                                .SchemaTelegramUnitOfWork
                                                .GroupRepository
                                                .GetByID(_id)
                                                ;

        if (group != null)
        {
            group.Name = txtName.Text;
            group.Ordering = (int)numericOrdering.Value;

            UnitOfWork
                .SchemaTelegramUnitOfWork
                .GroupRepository
                .Update(group)
                ;

            UnitOfWork
                .SaveChanges()
                ;

            FrmGroupUpdate_FormClosing(new object(), new FormClosingEventArgs(CloseReason.None, false));
        }
    }
}
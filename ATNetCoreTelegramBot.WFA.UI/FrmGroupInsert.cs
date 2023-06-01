namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmGroupInsert : Infrastructure.BaseController
{
    private Models.SchemaTelegram.Group group;

    #region Constructor
    
    public FrmGroupInsert()
    {
        InitializeComponent();
        group = new Models.SchemaTelegram.Group();
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmGroupInsert_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    #endregion

    #region Event(s) ==> Buttons

    private void btnInsert_Click(object sender, EventArgs e)
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
        
        group.Name = txtName.Text;
        group.Ordering = (int)numericOrdering.Value;
        group.InsertDateTime = DateTime.Now;

        UnitOfWork
            .SchemaTelegramUnitOfWork
            .GroupRepository
            .Insert(group)
            ;

        UnitOfWork
            .SaveChanges();

        FrmGroupInsert_FormClosing(new object(), new FormClosingEventArgs(CloseReason.None, false));
    }

    #endregion
}
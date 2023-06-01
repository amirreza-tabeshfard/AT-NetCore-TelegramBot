namespace ATNetCoreTelegramBot.WFA.UI.Infrastructure;

public partial class BaseController : Form
{
    #region Field(s)

    private DAL.UnitOfWork _unitOfWork;

    #endregion

    #region Properties

    protected virtual DAL.UnitOfWork UnitOfWork
    {
        get
        {
            if (_unitOfWork == null)
                _unitOfWork = new DAL.UnitOfWork();

            return (_unitOfWork);
        }
    }

    #endregion

    protected override void Dispose(bool disposing)
    {
        if (_unitOfWork != null)
        {
            _unitOfWork.Dispose();
            _unitOfWork = default;
        }

        base.Dispose(disposing);
    }
}
using ATNetCoreTelegramBot.DAL;

namespace ATNetCoreTelegramBot.WFA.UI.Infrastructure;

public partial class BaseController : Form
{
    #region Field(s)

    private UnitOfWork _unitOfWork;

    #endregion

    #region Properties

    protected virtual UnitOfWork UnitOfWork
    {
        get
        {
            if (_unitOfWork == null)
                _unitOfWork = new UnitOfWork();

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
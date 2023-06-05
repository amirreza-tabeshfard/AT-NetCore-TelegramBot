namespace ATNetCoreTelegramBot.Models.Data.Infrastructure;

internal class BaseController 
    : object
{
    private static DAL.UnitOfWork _unitOfWork;

    protected static DAL.UnitOfWork UnitOfWork
    {
        get
        {
            if (_unitOfWork is null)
                _unitOfWork = new DAL.UnitOfWork();

            return _unitOfWork;
        }
    }
}
namespace ATNetCoreTelegramBot.Common.Exceptions;

public class ClientForGetException : ApplicationException
{
    #region Constructor

    public ClientForGetException(string message)
        : base(message) { }

    public ClientForGetException(string message, Exception exception)
        : base(message, exception) { }

    #endregion
}
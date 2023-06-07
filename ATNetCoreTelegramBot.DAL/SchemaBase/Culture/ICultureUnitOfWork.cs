namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture
{
    public interface ICultureUnitOfWork
    {
        #region Properties

        All.IAllRepository AllRepository { get; }

        Argument2.IArgument2Repository Argument2Repository { get; }

        Argument4.IArgument4Repository Argument4Repository { get; }

        #endregion
    }
}
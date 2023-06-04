using ATNetCoreTelegramBot.DAL;

namespace ATNetCoreTelegramBot.Models.Data.Infrastructure
{
    internal class BaseController : object
    {
        private static UnitOfWork _unitOfWork;

        protected static UnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork is null)
                    _unitOfWork = new UnitOfWork();

                return _unitOfWork;
            }
        }

        internal static void InsertTableCounter(string tableName, int counter)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\t\t\t\t\t\tInsert Table ({tableName}): ");
            if (counter == default(int))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{counter}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{counter}");
            }
        }
    }
}

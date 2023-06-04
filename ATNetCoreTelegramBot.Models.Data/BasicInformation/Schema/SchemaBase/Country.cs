namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.Schema.SchemaBase
{
    public class Country : object
    {
        #region Field(s)

        private static int correctInsert = default(int);

        #endregion

        public static void Create(bool isPrintAllFailedValueInTheDatabase)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;

            correctInsert = Farsi_Iran(isPrintAllFailedValueInTheDatabase);

            Infrastructure.BaseController.InsertTableCounter(tableName: "Countries", counter: correctInsert);
        }

        private static int Farsi_Iran(bool isPrintAllFailedValueInTheDatabase)
        {
            correctInsert = DataRow.SchemaBase.Country.Insert(countryName: "ایران", correctInsert, isPrintAllFailedValueInTheDatabase);
            return correctInsert;
        }
    }
}
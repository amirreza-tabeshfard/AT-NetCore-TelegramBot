namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.Schema.SchemaBase
{
    public static class Province : object
    {
        #region Field(s)

        private static int correctInsert = default(int);

        #endregion

        public static void Create(bool isPrintAllFailedValueInTheDatabase)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;

            correctInsert = Farsi_Iran(isPrintAllFailedValueInTheDatabase);

            Infrastructure.BaseController.InsertTableCounter(tableName: "Provinces", counter: correctInsert);
        }

        private static int Farsi_Iran(bool isPrintAllFailedValueInTheDatabase)
        {
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "اردبیل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "اصفهان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "البرز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "ایلام", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "بوشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "تهران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "خراسان رضوی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "خراسان شمالی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "خوزستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "زنجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "سمنان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "فارس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "قزوین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "قم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "گلستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "گیلان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "لرستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "مازندران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "مرکزی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "هرمزگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "همدان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "کردستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "کرمان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "کرمانشاه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.Province.Insert(countryName: "ایران", provinceName: "یزد", correctInsert, isPrintAllFailedValueInTheDatabase);

            return correctInsert;
        }
    }
}
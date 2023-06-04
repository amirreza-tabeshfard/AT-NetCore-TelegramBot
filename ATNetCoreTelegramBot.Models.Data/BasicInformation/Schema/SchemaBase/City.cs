using System;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.Schema.SchemaBase
{
    public static class City : object
    {
        #region Field(s)

        private static int correctInsert = default(int);

        #endregion

        public static void Create(bool isPrintAllFailedValueInTheDatabase)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;

            correctInsert = Farsi_Iran(isPrintAllFailedValueInTheDatabase);

            Infrastructure.BaseController.InsertTableCounter(tableName: "Cities", counter: correctInsert);
        }

        private static int Farsi_Iran(bool isPrintAllFailedValueInTheDatabase)
        {
            #region آذربایجان شرقی ==>> 01

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "آذرشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "اسکو", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "اهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "بستان آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "بناب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "تبریز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "جلفا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "چاراویماق", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "خداآفرین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "سراب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "شبستر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "عجب شیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "مراغه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "مرند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "ملکان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "میانه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "هریس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "هشترود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "ورزقان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "کلیبر", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region آذربایجان غربی ==>> 02

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "ارومیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "اشنویه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "بوکان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "پلدشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "پیرانشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "تکاب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "چالدران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "چایپاره", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "خوی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "سردشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "سلماس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "شاهین دژ", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "شوط", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "ماکو", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "مهاباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "میاندوآب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "نقده", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region اردبیل ==>> 03

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "اردبیل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "بیله سوار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "پارس‌ آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "خلخال", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "سرعین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "گرمی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "مشگین شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "نمین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "نیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اردبیل", cityName: "کوثر", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region اصفهان ==>> 04

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "آران و بیدگل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "اردستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "اصفهان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "برخوار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "بوئین و میاندشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "تیران و کرون", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "چادگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "خمینی شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "خوانسار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "خور و بیابانک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "دهاقان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "سمیرم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "شاهین شهر و میمه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "شهرضا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "فریدن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "فریدون شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "فلاورجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "گلپایگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "لنجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "مبارکه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "نایین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "نجف آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "نطنز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "اصفهان", cityName: "کاشان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region البرز ==>> 05

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "البرز", cityName: "اشتهارد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "البرز", cityName: "ساوجبلاغ", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "البرز", cityName: "طالقان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "البرز", cityName: "فردیس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "البرز", cityName: "نظرآباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "البرز", cityName: "کرج", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region ایلام ==>> 06

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "آبدانان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "ایلام", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "ایوان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "دره شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "دهلران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "سیروان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "شیروان و چرداول", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "ملکشاهی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "ایلام", cityName: "مهران", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region بوشهر ==>> 07

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "بوشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "تنگستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "جم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "دشتستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "دشتی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "دیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "دیلم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "عسلویه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "گناوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "بوشهر", cityName: "کنگان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region تهران ==>> 08

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "اسلامشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "بهارستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "پاکدشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "پردیس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "پیشوا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "تهران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "دماوند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "رباط کریم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "ری", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "شمیرانات", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "شهریار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "فیروزکوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "قدس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "قرچک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "ملارد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "تهران", cityName: "ورامین", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region چهارمحال و بختیاری ==>> 09

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "اردل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "بروجن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "بن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "سامان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "شهرکرد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "فارسان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "لردگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "کوهرنگ", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "کیار", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region خراسان جنوبی ==>> 10

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "بشرویه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "بیرجند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "خوسف", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "درمیان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "زیرکوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "سرایان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "سربیشه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "طبس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "فردوس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "قاینات", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "نهبندان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region خراسان رضوی ==>> 11

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "باخرز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "بجستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "بردسکن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "بینالود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تایباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تخت جلگه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تربت جام", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تربت حیدریه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "جغتای", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "جوین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "چناران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "خلیل آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "خواف", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "خوشاب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "داورزن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "درگز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "رشتخوار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "زاوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "سبزوار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "سرخس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "فریمان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "قوچان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "گناباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "مشهد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "مه ولات", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "نیشابور", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "کاشمر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان رضوی", cityName: "کلات", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region خراسان شمالی ==>> 12

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "اسفراین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "بجنورد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "جاجرم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "راز و جرگلان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "شیروان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "فاروج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "گرمه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خراسان شمالی", cityName: "مانه و سملقان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region خوزستان ==>> 13

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "آبادان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "آغاجاری", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "امیدیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "اندیمشک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "اندیکا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "اهواز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "ایذه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "باغ ملک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "باوی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "بندر ماهشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "بهبهان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "حمیدیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "خرمشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "دزفول", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "دشت آزادگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "رامشیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "رامهرمز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "شادگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "شوش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "شوشتر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "گتوند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "لالی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "مسجد سلیمان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "هفتگل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "هندیجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "هویزه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "خوزستان", cityName: "کارون", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region زنجان ==>> 14

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "ابهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "ایجرود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "خدابنده", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "خرمدره", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "زنجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "سلطانیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "طارم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "زنجان", cityName: "ماهنشان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region سمنان ==>> 15

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "آرادان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "دامغان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "سرخه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "سمنان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "شاهرود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "گرمسار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "مهدی شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سمنان", cityName: "میامی", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region سیستان و بلوچستان ==>> 16

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "ایرانشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "بمپور", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "چابهار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "خاش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "دلگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "زابل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "زاهدان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "زهک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "سراوان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "سرباز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "سیب و سوران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "قصر قند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "مهرستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "میرجاوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "نیمروز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "نیک شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "هامون", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "هیرمند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "کنارک", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region فارس ==>> 17

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "آباده", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "ارسنجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "استهبان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "اقلید", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "بوانات", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "پاسارگاد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "جهرم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "خرامه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "خرم بید", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "خنج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "داراب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "رستم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "زرین دشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "سپیدان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "سروستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "شیراز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "فراشبند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "فسا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "فیروز آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "قیرو کارزین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "گراش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "لارستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "لامرد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "مرودشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "ممسنی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "مهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "نی ریز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "کازرون", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "فارس", cityName: "کوار", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region قزوین ==>> 18

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قزوین", cityName: "آبیک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قزوین", cityName: "آوج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قزوین", cityName: "البرز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قزوین", cityName: "بویین زهرا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قزوین", cityName: "تاکستان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قزوین", cityName: "قزوین", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region قم ==>> 19

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "قم", cityName: "قم", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region گلستان ==>> 20

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "آزاد شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "آق قلا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "بندر گز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "ترکمن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "رامیان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "علی آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "گالیکش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "گرگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "گمیشان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "گنبد کاووس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "مراوه تپه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "مینودشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "کردکوی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گلستان", cityName: "کلاله", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region گیلان ==>> 21

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "آستارا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "آستانه اشرفیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "املش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "بندر انزلی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "تالش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "رشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "رضوانشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "رودبار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "رودسر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "سیاهکل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "شفت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "صومعه سرا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "فومن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "لاهیجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "لنگرود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "گیلان", cityName: "ماسال", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region لرستان ==>> 22

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "ازنا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "الیگودرز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "بروجرد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "پلدختر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "خرم آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "دلفان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "دوره", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "دورود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "سلسله", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "لرستان", cityName: "کوهدشت", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region مازندران ==>> 23

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "آمل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "بابل", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "بابلسر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "بهشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "تنکابن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "جویبار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "چالوس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "رامسر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "ساری", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "سواد کوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "سیمرغ", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "عباس آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "فریدون کنار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "قائم شهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "گلوگاه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "محمود آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "میان درود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "نور", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "نوشهر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مازندران", cityName: "نکا", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region مرکزی ==>> 24

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "آشتیان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "اراک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "تفرش", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "خمین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "خنداب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "دلیجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "زرندیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "ساوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "شازند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "فراهان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "محلات", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "مرکزی", cityName: "کمیجان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region هرمزگان ==>> 25

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "ابوموسی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "بستک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "بشاگرد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "بندر لنگه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "بندعباس", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "پارسیان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "جاسک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "حاجی آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "خمیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "رودان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "سیریک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "قشم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "هرمزگان", cityName: "میناب", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region همدان ==>> 26

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "اسدآباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "بهار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "تویسرکان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "رزن", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "فامنین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "ملایر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "نهاوند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "همدان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "همدان", cityName: "کبودرآهنگ", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region کردستان ==>> 27

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "بانه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "بیجار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "دهگلان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "دیواندره", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "سروآباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "سقز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "سنندج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "قروه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "مریوان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کردستان", cityName: "کامیاران", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region کرمان ==>> 28

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "ارزوئیه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "انار", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "بافت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "بردسیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "بم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "جیرفت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "رابر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "راور", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "رفسنجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "رودبار جنوب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "ریگان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "زرند", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "سیرجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "شهر بابک", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "عنبر آباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "فاریاب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "فهرج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "قلعه گنج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "منوجان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "نرماشیر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "کرمان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "کهنوج", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمان", cityName: "کوهبنان", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region کرمانشاه ==>> 29

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "اسلام آباد غرب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "پاوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "ثلاث باباجانی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "جوانرود", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "دالاهو", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "روانسر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "سرپل ذهاب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "سنقر", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "صحنه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "قصر شیرین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "گیلانغرب", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "هرسین", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "کرمانشاه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کرمانشاه", cityName: "کنگاور", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region کهگیلویه و بویراحمد ==>> 30

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "باشت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "بهمئی", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "بویر احمد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "چرام", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "دنا", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "گچساران", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "لنده", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "کهگیلویه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "یاسوج", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            #region یزد ==>> 31

            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "ابرکوه", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "اردکان", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "بافق", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "بهاباد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "تفت", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "خاتم", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "صدوق", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "مهریز", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "میبد", correctInsert, isPrintAllFailedValueInTheDatabase);
            correctInsert = DataRow.SchemaBase.City.Insert(countryName: "ایران", provinceName: "یزد", cityName: "یزد", correctInsert, isPrintAllFailedValueInTheDatabase);

            #endregion

            return correctInsert;
        }
    }
}
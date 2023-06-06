namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.SchemaBase;

internal class City : Infrastructure.BaseController
{
    #region Field(s)

    private readonly CRUD _crud;

    #endregion

    #region Constructor

    public City()
    {
        _crud = new CRUD();
    }

    #endregion

    #region Private Method(s)

    private void Persian(ref int countInsert)
    {
        #region آذربایجان شرقی ==>> 01

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "آذرشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "اسکو", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "اهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "بستان آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "بناب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "تبریز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "جلفا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "چاراویماق", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "خداآفرین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "سراب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "شبستر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "عجب شیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "مراغه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "مرند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "ملکان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "میانه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "هریس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "هشترود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "ورزقان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", cityName: "کلیبر", ref countInsert);

        #endregion

        #region آذربایجان غربی ==>> 02

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "ارومیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "اشنویه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "بوکان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "پلدشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "پیرانشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "تکاب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "چالدران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "چایپاره", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "خوی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "سردشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "سلماس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "شاهین دژ", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "شوط", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "ماکو", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "مهاباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "میاندوآب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", cityName: "نقده", ref countInsert);

        #endregion

        #region اردبیل ==>> 03

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "اردبیل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "بیله سوار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "پارس‌ آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "خلخال", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "سرعین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "گرمی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "مشگین شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "نمین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "نیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", cityName: "کوثر", ref countInsert);

        #endregion

        #region اصفهان ==>> 04

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "آران و بیدگل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "اردستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "اصفهان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "برخوار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "بوئین و میاندشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "تیران و کرون", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "چادگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "خمینی شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "خوانسار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "خور و بیابانک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "دهاقان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "سمیرم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "شاهین شهر و میمه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "شهرضا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "فریدن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "فریدون شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "فلاورجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "گلپایگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "لنجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "مبارکه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "نایین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "نجف آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "نطنز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", cityName: "کاشان", ref countInsert);

        #endregion

        #region البرز ==>> 05

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", cityName: "اشتهارد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", cityName: "ساوجبلاغ", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", cityName: "طالقان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", cityName: "فردیس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", cityName: "نظرآباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", cityName: "کرج", ref countInsert);

        #endregion

        #region ایلام ==>> 06

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "آبدانان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "ایلام", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "ایوان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "دره شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "دهلران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "سیروان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "شیروان و چرداول", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "ملکشاهی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", cityName: "مهران", ref countInsert);

        #endregion

        #region بوشهر ==>> 07

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "بوشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "تنگستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "جم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "دشتستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "دشتی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "دیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "دیلم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "عسلویه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "گناوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", cityName: "کنگان", ref countInsert);

        #endregion

        #region تهران ==>> 08

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "اسلامشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "بهارستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "پاکدشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "پردیس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "پیشوا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "تهران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "دماوند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "رباط کریم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "ری", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "شمیرانات", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "شهریار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "فیروزکوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "قدس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "قرچک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "ملارد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", cityName: "ورامین", ref countInsert);

        #endregion

        #region چهارمحال و بختیاری ==>> 09

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "اردل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "بروجن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "بن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "سامان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "شهرکرد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "فارسان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "لردگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "کوهرنگ", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", cityName: "کیار", ref countInsert);

        #endregion

        #region خراسان جنوبی ==>> 10

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "بشرویه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "بیرجند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "خوسف", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "درمیان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "زیرکوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "سرایان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "سربیشه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "طبس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "فردوس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "قاینات", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", cityName: "نهبندان", ref countInsert);

        #endregion

        #region خراسان رضوی ==>> 11

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "باخرز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "بجستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "بردسکن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "بینالود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تایباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تخت جلگه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تربت جام", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "تربت حیدریه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "جغتای", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "جوین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "چناران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "خلیل آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "خواف", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "خوشاب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "داورزن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "درگز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "رشتخوار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "زاوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "سبزوار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "سرخس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "فریمان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "قوچان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "گناباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "مشهد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "مه ولات", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "نیشابور", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "کاشمر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", cityName: "کلات", ref countInsert);

        #endregion

        #region خراسان شمالی ==>> 12

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "اسفراین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "بجنورد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "جاجرم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "راز و جرگلان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "شیروان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "فاروج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "گرمه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", cityName: "مانه و سملقان", ref countInsert);

        #endregion

        #region خوزستان ==>> 13

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "آبادان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "آغاجاری", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "امیدیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "اندیمشک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "اندیکا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "اهواز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "ایذه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "باغ ملک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "باوی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "بندر ماهشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "بهبهان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "حمیدیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "خرمشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "دزفول", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "دشت آزادگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "رامشیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "رامهرمز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "شادگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "شوش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "شوشتر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "گتوند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "لالی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "مسجد سلیمان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "هفتگل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "هندیجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "هویزه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", cityName: "کارون", ref countInsert);

        #endregion

        #region زنجان ==>> 14

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "ابهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "ایجرود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "خدابنده", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "خرمدره", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "زنجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "سلطانیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "طارم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", cityName: "ماهنشان", ref countInsert);

        #endregion

        #region سمنان ==>> 15

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "آرادان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "دامغان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "سرخه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "سمنان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "شاهرود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "گرمسار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "مهدی شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", cityName: "میامی", ref countInsert);

        #endregion

        #region سیستان و بلوچستان ==>> 16

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "ایرانشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "بمپور", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "چابهار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "خاش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "دلگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "زابل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "زاهدان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "زهک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "سراوان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "سرباز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "سیب و سوران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "قصر قند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "مهرستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "میرجاوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "نیمروز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "نیک شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "هامون", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "هیرمند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", cityName: "کنارک", ref countInsert);

        #endregion

        #region فارس ==>> 17

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "آباده", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "ارسنجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "استهبان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "اقلید", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "بوانات", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "پاسارگاد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "جهرم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "خرامه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "خرم بید", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "خنج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "داراب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "رستم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "زرین دشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "سپیدان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "سروستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "شیراز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "فراشبند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "فسا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "فیروز آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "قیرو کارزین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "گراش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "لارستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "لامرد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "مرودشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "ممسنی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "مهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "نی ریز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "کازرون", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", cityName: "کوار", ref countInsert);

        #endregion

        #region قزوین ==>> 18

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", cityName: "آبیک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", cityName: "آوج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", cityName: "البرز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", cityName: "بویین زهرا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", cityName: "تاکستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", cityName: "قزوین", ref countInsert);

        #endregion

        #region قم ==>> 19

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قم", cityName: "قم", ref countInsert);

        #endregion

        #region گلستان ==>> 20

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "آزاد شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "آق قلا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "بندر گز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "ترکمن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "رامیان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "علی آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "گالیکش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "گرگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "گمیشان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "گنبد کاووس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "مراوه تپه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "مینودشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "کردکوی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", cityName: "کلاله", ref countInsert);

        #endregion

        #region گیلان ==>> 21

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "آستارا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "آستانه اشرفیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "املش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "بندر انزلی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "تالش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "رشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "رضوانشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "رودبار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "رودسر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "سیاهکل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "شفت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "صومعه سرا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "فومن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "لاهیجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "لنگرود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", cityName: "ماسال", ref countInsert);

        #endregion

        #region لرستان ==>> 22

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "ازنا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "الیگودرز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "بروجرد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "پلدختر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "خرم آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "دلفان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "دوره", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "دورود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "سلسله", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", cityName: "کوهدشت", ref countInsert);

        #endregion

        #region مازندران ==>> 23

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "آمل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "بابل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "بابلسر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "بهشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "تنکابن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "جویبار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "چالوس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "رامسر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "ساری", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "سواد کوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "سیمرغ", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "عباس آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "فریدون کنار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "قائم شهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "گلوگاه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "محمود آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "میان درود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "نور", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "نوشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", cityName: "نکا", ref countInsert);

        #endregion

        #region مرکزی ==>> 24

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "آشتیان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "اراک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "تفرش", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "خمین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "خنداب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "دلیجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "زرندیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "ساوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "شازند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "فراهان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "محلات", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", cityName: "کمیجان", ref countInsert);

        #endregion

        #region هرمزگان ==>> 25

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "ابوموسی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "بستک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "بشاگرد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "بندر لنگه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "بندعباس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "پارسیان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "جاسک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "حاجی آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "خمیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "رودان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "سیریک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "قشم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", cityName: "میناب", ref countInsert);

        #endregion

        #region همدان ==>> 26

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "اسدآباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "بهار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "تویسرکان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "رزن", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "فامنین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "ملایر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "نهاوند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "همدان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", cityName: "کبودرآهنگ", ref countInsert);

        #endregion

        #region کردستان ==>> 27

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "بانه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "بیجار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "دهگلان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "دیواندره", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "سروآباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "سقز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "سنندج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "قروه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "مریوان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", cityName: "کامیاران", ref countInsert);

        #endregion

        #region کرمان ==>> 28

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "ارزوئیه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "انار", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "بافت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "بردسیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "بم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "جیرفت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "رابر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "راور", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "رفسنجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "رودبار جنوب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "ریگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "زرند", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "سیرجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "شهر بابک", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "عنبر آباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "فاریاب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "فهرج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "قلعه گنج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "منوجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "نرماشیر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "کرمان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "کهنوج", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", cityName: "کوهبنان", ref countInsert);

        #endregion

        #region کرمانشاه ==>> 29

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "اسلام آباد غرب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "پاوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "ثلاث باباجانی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "جوانرود", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "دالاهو", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "روانسر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "سرپل ذهاب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "سنقر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "صحنه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "قصر شیرین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "گیلانغرب", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "هرسین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "کرمانشاه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", cityName: "کنگاور", ref countInsert);

        #endregion

        #region کهگیلویه و بویراحمد ==>> 30

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "باشت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "بهمئی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "بویر احمد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "چرام", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "دنا", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "گچساران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "لنده", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "کهگیلویه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", cityName: "یاسوج", ref countInsert);

        #endregion

        #region یزد ==>> 31

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "ابرکوه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "اردکان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "بافق", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "بهاباد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "تفت", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "خاتم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "صدوق", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "مهریز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "میبد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", cityName: "یزد", ref countInsert);

        #endregion
    }

    private void English(ref int countInsert)
    {
        #region 01 ==> East Azarbaijan

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Azarshahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Oskoo", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Ahar", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Bostan Abad", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Bonab", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Tabriz", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Jolfa", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Charavimagh", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Khoda Afarin", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Sarab", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Shabestar", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Ajabshir", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Maraghe", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Marand", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Malekan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Miane", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Haris", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Hashtrood", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Varzaghan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", cityName: "Kalibr", ref countInsert);

        #endregion

        #region 02 ==> Western Azerbaijan

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Orumieh", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Oshnavie", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Bukan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Poldasht", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Piranshahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Takab", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Chaldron", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Chaipare", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Khoy", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Sardasht", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Salmas", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Shahin Dej", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Shot", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Maku", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Mahabad", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Miandoab", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", cityName: "Naghde", ref countInsert);

        #endregion

        #region 03 ==> Ardebil

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Ardebil", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Bile Savar", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Pars Abad", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Khalkhal", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Sarein", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Garmi", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Meshgin Shahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Namin", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Nir", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", cityName: "Kosar", ref countInsert);

        #endregion

        #region 04 ==> Esfahan

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Aran and Bidgol", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Ardestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Esfahan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Barkhar", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Boeing and Miandasht", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Tiran o Karun", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Chadogan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Khomeini Shahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Khansaar", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Khor and Biabank", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Dehghan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Samirom", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Shahinshar va meime", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Shahreza", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Fereidoon", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Fereidoon Shahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Falavarjan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Golpaingan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Lanjan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Mobarake", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Naien", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Najaf Abad", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Natanz", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", cityName: "Kashan", ref countInsert);

        #endregion

        #region 05 ==> Alborz

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", cityName: "Eshtehard", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", cityName: "Savjilagh", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", cityName: "Taleghan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", cityName: "Fardis", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", cityName: "Nazar Abad", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", cityName: "Karaj", ref countInsert);

        #endregion

        #region 06 ==> Ilam

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Abdanan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Ilam", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Eivan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Dare Shahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Dehlaran", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Sirvan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Shirvan and Chardavol", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Malekshahi", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", cityName: "Mehran", ref countInsert);

        #endregion

        #region 07 ==> Bushehr

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Bushehr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Tangestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Jam", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Dashtestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Dashti", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Dier", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Deilan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Asalooie", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Gonave", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", cityName: "Kangan", ref countInsert);

        #endregion

        #region 08 ==> Tehran

        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Eslamshahr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Baharestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Pakdasht", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Pardis", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Pishva", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Tehran", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Damavand", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Robat karim", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Rey", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Shemiranat", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Shahriar", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Firuzkuh", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Ghods", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Gharchak", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Malard", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", cityName: "Varamin", ref countInsert);

        #endregion
    }

    #endregion

    #region Method(s)

    internal void CreateByDefault()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Table [ City ]  ==> ");

        int countInsert = default;

        Persian(ref countInsert);
        English(ref countInsert);

        if (countInsert is default(int))
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(countInsert);
    }

    #endregion

    internal class CRUD
    {
        #region Private Method(s)

        private int GetByCultureID(string languageCultureName)
        {
            int result = default;

            if (!string.IsNullOrEmpty(languageCultureName))
                result = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CultureRepository
                                .GetByLanguageCultureName(languageCultureName)
                                .FirstOrDefault()
                                .Id
                                ;

            return result;
        }

        private Guid GetByCountryID(string countryName)
        {
            Guid result = default;

            if (!string.IsNullOrEmpty(countryName))
                result = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CountryRepository
                                .GetByName(countryName)
                                .FirstOrDefault()
                                .Id
                                ;

            return result;
        }

        private Guid GetByProvinceID(Guid countryID, string provinceName)
        {
            Guid result = default;

            if (countryID != default(Guid))
                if (!string.IsNullOrEmpty(provinceName))
                    result = UnitOfWork
                                    .SchemaBaseUnitOfWork
                                    .ProvinceRepository
                                    .GetByCountryId_Name(countryID, provinceName)
                                    .FirstOrDefault()
                                    .Id
                                    ;

            return result;
        }

        private Models.SchemaBase.City GetByCity(string cityName)
        {
            Models.SchemaBase.City result = default;

            if (!string.IsNullOrEmpty(cityName))
                result = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CityRepository
                                .GetByName(cityName)
                                .FirstOrDefault()
                                ;

            return result;
        }

        #endregion

        internal void Insert(string languageCultureName,
                             string countryName,
                             string provinceName,
                             string cityName,
                             ref int countInsert)
        {
            Models.SchemaBase.City city = GetByCity(cityName);

            if (city is default(Models.SchemaBase.City))
            {
                city = new Models.SchemaBase.City()
                {
                    CultureId = GetByCultureID(languageCultureName),
                    ProvinceId = GetByProvinceID(GetByCountryID(countryName), provinceName),
                    Name = cityName
                };

                UnitOfWork
                    .SchemaBaseUnitOfWork
                    .CityRepository
                    .Insert(city);

                UnitOfWork
                    .SaveChanges();

                countInsert++;
            }
        }
    }
}
using MD.PersianDateTime.Standard;

namespace ATNetCoreTelegramBot.Common.Extensions;

public static class DateTimeExtensions
{
    private static void Swap(ref int x, ref int y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

    private static void Swap(ref System.DateTime x, ref System.DateTime y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

    public static System.DateTime AbsoluteStart(this System.DateTime dateTime)
    {
        return dateTime.Date;
    }

    public static System.DateTime AbsoluteEnd(this System.DateTime dateTime)
    {
        return AbsoluteStart(dateTime).AddDays(1).AddTicks(-1);
    }

    public static bool IsInRange(this System.DateTime currentDate, System.DateTime beginDate, System.DateTime endDate)
    {
        if (beginDate.Ticks > endDate.Ticks)
            Swap(ref beginDate, ref endDate);

        return currentDate >= beginDate && currentDate <= endDate;
    }

    public static System.Collections.Generic.IEnumerable<System.DateTime> GetDateRangeTo(this System.DateTime self, System.DateTime toDate)
    {
        //var range = Enumerable.Range(0, new System.TimeSpan(toDate.Ticks - self.Ticks).Days);

        //return from p in range
        //       select self.Date.AddDays(p);

        System.Collections.Generic.IEnumerable<int> range = default(System.Collections.Generic.IEnumerable<int>);
        System.Collections.Generic.IEnumerable<System.DateTime> result = default(System.Collections.Generic.IEnumerable<System.DateTime>);

        if (self.Ticks > toDate.Ticks)
            Swap(ref self, ref toDate);

        if (self.Ticks <= toDate.Ticks)
        {
            range = Enumerable.Range(0, new System.TimeSpan(toDate.Ticks - self.Ticks).Days);
            result = range
                     .Select(current => self.Date.AddDays(current));

            return result;
        }

        return null;
    }

    public static bool IsDate(this string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            System.DateTime dt;
            return System.DateTime.TryParse(s: input, result: out dt);
        }
        return false;
    }

    public static System.DateTime ToDateTime(this object o)
    {
        System.DateTime dt;
        try
        {
            dt = System.Convert.ToDateTime(o);
        }
        catch (System.Exception)
        {
            dt = System.DateTime.Now;
        }
        return dt;
    }

    public static string ToSqlFriendly(this System.DateTime? dt)
    {
        return dt?.ToString("yyy-MM-dd hh:mm:ss");
    }

    public static string GetAge(this System.DateTime birthDate, out int day, out int month, out int year, out int week)
    {
        var x = System.DateTime.Now - birthDate;
        var age = System.DateTime.MinValue + x;
        year = age.Year - 1;
        month = age.Month - 1;
        day = age.Day - 1;
        week = day / 7;
        day = day % 7;
        var r = string.Empty;
        if (year != 0) r += $"{year} سال ";
        if (month != 0) r += $"{month} ماه ";
        if (week != 0) r += $"{week} هفته ";
        if (day != 0) r += $"{day} روز ";
        return r;
    }

    public static string GetAge(this System.DateTime birthDate)
    {
        var x = System.DateTime.Now - birthDate;
        var age = System.DateTime.MinValue + x;
        int year = age.Year - 1;
        int month = age.Month - 1;
        int day = age.Day - 1;
        int week = day / 7;
        day = day % 7;
        var r = string.Empty;
        if (year != 0) r += $"{year} سال ";
        if (month != 0) r += $"{month} ماه ";
        if (week != 0) r += $"{week} هفته ";
        if (day != 0) r += $"{day} روز ";
        return r;
    }

    public static int CalculateAge(this System.DateTime? birthDate)
    {
        if (!birthDate.HasValue)
            return 0;

        var today = System.DateTime.Today;
        var age = today.Year - birthDate.Value.Year;

        if (birthDate > today.AddYears(-age))
            age--;

        return age;
    }

    public static System.Collections.Generic.IEnumerable<System.DateTime> MonthsBetween(System.DateTime d0, System.DateTime d1)
    {
        return Enumerable.Range(0, (d1.Year - d0.Year) * 12 + (d1.Month - d0.Month) + 1).Select(m => new System.DateTime(d0.Year, d0.Month, 1).AddMonths(m));
    }

    public static System.Collections.Generic.IEnumerable<System.DateTime> GetDaysBetween(System.DateTime fromDate, System.DateTime toDate)
    {
        return Enumerable.Range(0, toDate.Subtract(fromDate).Days + 1).Select(x => fromDate.AddDays(x).Date);
    }

    #region تاریخ شمسی [ Solar Date ]

    public static void SplitSolarDate(string stringPersianDate, out int y, out int m, out int d)
    {
        stringPersianDate = stringPersianDate
                            .Replace("۰", "0")
                            .Replace("۱", "1")
                            .Replace("۲", "2")
                            .Replace("۳", "3")
                            .Replace("۴", "4")
                            .Replace("۵", "5")
                            .Replace("۶", "6")
                            .Replace("۷", "7")
                            .Replace("۸", "8")
                            .Replace("۹", "9");

        if (stringPersianDate.IndexOf('/') < 2)
        {
            y = 1300;
            m = 1;
            d = 1;
        }
        else
        {
            var strItems = new string[3];
            var itemCounter = 0;

            foreach (var ch in stringPersianDate)
            {
                if (ch == '/')
                    itemCounter++;
                else
                    strItems[itemCounter] += ch;
            }

            try
            {
                y = int.Parse(strItems[2]);
                m = int.Parse(strItems[1]);
                d = int.Parse(strItems[0]);
                if (d > y)
                    Swap(ref d, ref y);
            }
            catch
            {
                y = 1300;
                m = 1;
                d = 1;
            }
        }
    }

    public static bool IsValidPersianDateTime(this string persianDate)
    {
        return PersianDateTime.TryParse(persianDate, out _);
    }

    public static string ToPersianDate(this System.DateTime input, string format = null)
    {
        var persianDateTime = new PersianDateTime(input)
        {
            PersianNumber = false
        };

        if (System.String.IsNullOrEmpty(format))
        {
            return persianDateTime.ToString("yyyy/MM/dd");
        }

        return persianDateTime.ToString(format);
    }

    public static string ToLongPersianDate(this System.DateTime input)
    {
        return input.ToPersianDate("dddd d MMMM yyyy");
    }

    public static string ToPersianDate(this System.DateTime? input, string format = null)
    {
        if (!input.HasValue)
            return System.String.Empty;

        return ToPersianDate(input.Value, format);
    }

    public static string ToPersianDateTime(this System.DateTime input, bool includeHourSign = false)
    {
        return input.ToPersianDate($"yyyy/MM/dd{(includeHourSign ? " ساعت " : " ")}HH:mm");
    }

    #endregion

    #region تاریخ میلادی [ Gregorian Date ]

    public static System.DateTime ToGregorianDateTime(this string persianDate)
    {
        return PersianDateTime.Parse(persianDate).ToDateTime();
    }

    public static System.DateTime ToGregorianDateTime(this int persianDate)
    {
        return PersianDateTime.Parse(persianDate).ToDateTime();
    }

    #endregion

    #region زمان تاریخ نسبی [ Relative Date Time ]

    const int SECOND = 1;
    const int MINUTE = 60 * SECOND;
    const int HOUR = 60 * MINUTE;
    const int DAY = 24 * HOUR;
    const int MONTH = 30 * DAY;

    public static string ToRelativeDate(this System.DateTime dateTime)
    {
        var ts = new System.TimeSpan(System.DateTime.Now.Ticks - dateTime.Ticks);
        var delta = System.Math.Abs(ts.TotalSeconds);
        if (delta < 1 * MINUTE)
        {
            return ts.Seconds <= 1 ? "لحظه ای قبل" : ts.Seconds + " ثانیه قبل";
        }
        if (delta < 2 * MINUTE)
        {
            return "یک دقیقه قبل";
        }
        if (delta < 45 * MINUTE)
        {
            return ts.Minutes + " دقیقه قبل";
        }
        if (delta < 90 * MINUTE)
        {
            return "یک ساعت قبل";
        }
        if (delta < 24 * HOUR)
        {
            return ts.Hours + " ساعت قبل";
        }
        if (delta < 48 * HOUR)
        {
            return "دیروز";
        }
        if (delta < 30 * DAY)
        {
            return ts.Days + " روز قبل";
        }
        if (delta < 12 * MONTH)
        {
            var months = System.Convert.ToInt32(System.Math.Floor((double)ts.Days / 30));
            return months <= 1 ? "یک ماه قبل" : months + " ماه قبل";
        }
        var years = System.Convert.ToInt32(System.Math.Floor((double)ts.Days / 365));
        return years <= 1 ? "یک سال قبل" : years + " سال قبل";
    }

    public static string ToFutureRelativeDate(this System.DateTime dateTime)
    {
        var ts = new System.TimeSpan(dateTime.Ticks - System.DateTime.Now.Ticks);
        var delta = System.Math.Abs(ts.TotalSeconds);
        if (delta < 1 * MINUTE)
        {
            return ts.Seconds == 1 ? "لحظه ای بعد" : ts.Seconds + " ثانیه بعد";
        }
        if (delta < 2 * MINUTE)
        {
            return "یک دقیقه بعد";
        }
        if (delta < 45 * MINUTE)
        {
            return ts.Minutes + " دقیقه بعد";
        }
        if (delta < 90 * MINUTE)
        {
            return "یک ساعت بعد";
        }
        if (delta < 24 * HOUR)
        {
            return ts.Hours + " ساعت بعد";
        }
        if (delta < 48 * HOUR)
        {
            return "فردا";
        }
        if (delta < 30 * DAY)
        {
            return ts.Days + " روز بعد";
        }
        if (delta < 12 * MONTH)
        {
            var months = System.Convert.ToInt32(System.Math.Floor((double)ts.Days / 30));
            return months <= 1 ? "یک ماه بعد" : months + " ماه بعد";
        }
        var years = System.Convert.ToInt32(System.Math.Floor((double)ts.Days / 365));
        return years <= 1 ? "یک سال بعد" : years + " سال بعد";
    }

    #endregion
}

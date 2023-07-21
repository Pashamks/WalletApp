
namespace WalletBusinessLogic.Extentions
{
    public static class DateExtentions
    {
        public static bool IsDateInCurrentWeek(this DateTime date)
        {
            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

            DateTime endOfWeek = startOfWeek.AddDays(6);

            return date >= startOfWeek && date <= endOfWeek;
        }
        public static bool IsDateStartOfSeason(this DateTime date)
        {
            return date.Day != 1 ? false : date.Month == 3 || date.Month == 6 || date.Month == 9 || date.Month == 12;
        }
        public static bool IsDateSecondDaytOfSeason(this DateTime date)
        {
            return date.Day != 2 ? false : date.Month == 3 || date.Month == 6 || date.Month == 9 || date.Month == 12;
        }

    }
}

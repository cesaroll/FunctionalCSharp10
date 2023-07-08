namespace Models;

public static class DateTimeExtensions
{
    public static IEnumerable<(int year, int month)> GetYearMonths(this DateTime time) =>
        time.Year.GetYearMonths();

    public static IEnumerable<(int year, int month)> GetYearMonths(this int year) =>
        Enumerable.Range(1, 12).Select(month => (year, month));
}

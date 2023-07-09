namespace Models;
public static class DateTimeExtensions
{
    public static Year ToYear(this DateTime dateTime) => new(dateTime.Year);

    public static IEnumerable<Month> GetDecadeMonths(this DateTime dateTime) =>
        Enumerable.Range(dateTime.Year.ToDecadeBeginning(), 10)
            .Select(Year => new Year(Year))
            .SelectMany(Year => Year.Months);

    public static int ToDecadeBeginning(this int year) => year / 10 * 10 + 1;

}

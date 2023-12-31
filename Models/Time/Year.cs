namespace Models.Time;

public record struct Year(int Number)
{
    public Month GetMonth(int ordinal) =>
        ordinal >= 1 && ordinal <= 12
        ? new(this, ordinal)
        : throw new ArgumentException(nameof(ordinal)); // Avoid throwing exceptions  from the domain model

    public IEnumerable<Month> TryGetMonth(int ordinal) // aka Optional object
    {
        if (ordinal >= 1 && ordinal <= 12) yield return new(this, ordinal);
    }

    public IEnumerable<Month> Months =>
        this.GetMonths(this);

    public Year DecadeBeginning => new(this.Number / 10 * 10 + 1);

    public IEnumerable<Year> Decade =>
        Enumerable.Range(this.DecadeBeginning.Number, 10)
        .Select(number => new Year(number));

    public IEnumerable<Month> GetMonths(Year year) =>
        Enumerable.Range(1, 12).Select(ordinal => new Month(year, ordinal));
}

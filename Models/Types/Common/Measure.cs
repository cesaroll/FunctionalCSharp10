namespace Models.Types.Common;

public abstract record Measure(string Unit);

public record DiscreteMeasure(string Unit, uint Value) : Measure(Unit);
public record ContinuosMeasure(string Unit, decimal Value) : Measure(Unit);

public static class MeasureExtensions
{
    public static Measure AsDiscriminatedUnion(this Measure m) =>
        m switch
        {
            DiscreteMeasure or ContinuosMeasure => m,
            _ => throw new InvalidOperationException(
                $"Not defined for object of type {m?.GetType().Name ?? "<null>"}")
        };

    public static TResult MapAny<TResult>(this Measure m,
        Func<DiscreteMeasure, TResult> discrete,
        Func<ContinuosMeasure, TResult> continuos) =>
        m.AsDiscriminatedUnion() switch
        {
            DiscreteMeasure d => discrete(d),
            ContinuosMeasure c => continuos(c),
            _ => default!
        };
}

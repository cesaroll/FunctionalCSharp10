using Models.Types.Common;

namespace Models.Common;

public static class MeasureTransforms
{
    public static (Measure a, Measure b) SplitInHalves(this Measure m) => m.MapAny(
        d => (d with { Value = (d.Value +1) / 2}, d with { Value = d.Value / 2 }),
        c =>
        {
            Measure half = c with { Value = c.Value / 2 };
            return (half, half);
        }
    );

    // public static (Measure a, Measure b) SplitInHalves(this Measure m) =>
    //     m.AsDiscriminatedUnion() switch
    //     {
    //         DiscreteMeasure d => d.SplitInHalves(),
    //         ContinuosMeasure c => c.SplitInHalves(),
    //         _ => default!
    //     };

    // private static (Measure a, Measure b) SplitInHalves(this DiscreteMeasure d) =>
    //     (d with { Value = (d.Value +1) / 2}, d with { Value = d.Value / 2 });

    // private static (Measure a, Measure b) SplitInHalves(this ContinuosMeasure c)
    // {
    //     var half = c with { Value = c.Value / 2 };
    //     return (half, half);
    // }
}

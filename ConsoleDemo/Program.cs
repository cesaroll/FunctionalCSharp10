using Models.Types.Components;
using Models.Types.Common;

Part bc547 = new(Guid.NewGuid(), "Transistor BC547", new Models.Types.StockKeepingUnit("ELTRBC5476"));

// Option<Part> a = new Some<Part>(bc547);
Option<Part> a = bc547;

// Option<Part> b = new None<Part>();
Option<Part> b = None.Value;

Report(a, b);

bool Contains(string s, string target) =>
    s.Contains(target, StringComparison.OrdinalIgnoreCase);

string Remove(string s, string target) =>
    s.Replace(target, "", StringComparison.OrdinalIgnoreCase).Trim();

Report(
    a.Filter(part => Contains(part.Name, "resistor"))
        .Map(part => part with { Name = Remove(part.Name, "resistor")})
        .Map(part => part.Name)
        .Reduce("Nothing here"),

    a.Map(part => part with {Name = "BC 547"})
        .Map(part => part.Name)
        .Reduce("Nothing here"),

    b.Map(part => part with {Name = "BC 547"})
        .Map(part => part.Name)
        .Reduce("Nothing here")

);

void Report(params object[] items)
{
    foreach(object item in items) Console.WriteLine(item);
    Console.WriteLine(new string('-', 80));
}


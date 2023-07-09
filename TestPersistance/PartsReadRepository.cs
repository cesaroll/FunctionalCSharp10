using Application.Persistance;
using Models.Types;

namespace TestPersistance;

public class PartsReadRepository : IReadOnlyRepository<Part>
{
    public IEnumerable<Part> GetAll() => new[]
    {
        new Part ("Bobina 123", new StockKeepingUnit("BOB123")),
        new Part ("Transistor 4456", new StockKeepingUnit("TR456")),
        new Part ("Resistencia 45654", new StockKeepingUnit("RES4654")),
        new Part ("LED Amarillo 111", new StockKeepingUnit("LEDA111")),
        new Part ("LED Rojo 222", new StockKeepingUnit("LEDR222")),
        new Part ("LED Verde 333", new StockKeepingUnit("LEDV333")),
        new Part ("Capacitor 230uF 25v", new StockKeepingUnit("CAP230UF25V")),
        new Part ("Capacitor 130uF 25v", new StockKeepingUnit("CAP130UF25V")),
        new Part ("Bateria 9V", new StockKeepingUnit("BAT9V")),
        new Part ("Bateria 1.5V", new StockKeepingUnit("BAT1.5V"))
    };
}

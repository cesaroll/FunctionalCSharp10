using Models.Types.Common;

namespace Application.Persistance;

public interface IReadOnlyRepository<T>
{
    IEnumerable<T> GetAll();
    Option<T> TryFind(Guid id);
}

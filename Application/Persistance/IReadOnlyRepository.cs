namespace Application.Persistance;

public interface IReadOnlyRepository<T>
{
    IEnumerable<T> GetAll();
}

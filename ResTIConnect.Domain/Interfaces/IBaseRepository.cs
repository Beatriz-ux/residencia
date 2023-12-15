using ResTIConnect.Domain.Common;

namespace ResTIConnect.Domain.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    void Create(T entity); //mesmo estando void pode ter um retorno
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(Guid id, CancellationToken cancellationToken); //Task é uma tarefa assincrona
    Task<List<T>> GetAll(CancellationToken cancellationToken);
}

namespace Interface;
public interface IBaseRepository<T> 
{
    void Create(object obj);
    void Update(object obj);
    void Insert(object obj);
    void Delete(object obj);

    Task<List<T> > GetAll(CancellationToken cancellationToken);

}

namespace Interface;
public interface IMedicoRepository<Medico> : IBaseRepository<Medico>
{
    public void Create(object obj){
        throw new NotImplementedException();
    }

    public void Update(object obj){
        throw new NotImplementedException();
    }

    public void Insert(object obj){
        throw new NotImplementedException();
    }

    public void Delete(object obj){
        throw new NotImplementedException();
    }

    public Task<List<Medico> > GetAll(CancellationToken cancellationToken){
        throw new NotImplementedException();
    }

}

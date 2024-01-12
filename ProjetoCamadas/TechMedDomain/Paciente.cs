namespace TechMedDomain;
using Interface;
public class Paciente : Pessoa , IBaseRepository<Paciente>{
    public string? Endereco {get; set;}
    public string? Telefone {get; set;}
    public ICollection<Atendimento>? Atendimentos {get;}

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

    public Task<List<Paciente> > GetAll(CancellationToken cancellationToken){
        throw new NotImplementedException();
    }

}

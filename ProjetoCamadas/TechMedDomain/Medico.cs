namespace TechMedDomain;
using Interface;
public class Medico : Pessoa , IBaseRepository<Medico>{
    public required string CRM {get; set;}
    public string? Especialidade {get; set;}
    public decimal? Salario {get; set;}
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

    public Task<List<Medico> > GetAll(CancellationToken cancellationToken){
        throw new NotImplementedException();
    }
}
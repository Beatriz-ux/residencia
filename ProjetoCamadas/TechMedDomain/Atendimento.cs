namespace TechMedDomain;
using Interface;
public class Atendimento: IBaseRepository<Atendimento>{
    public int AtendimentoId {get; set;}
    public int MedicoId {get; set;} //melhorias: encapsular o acesso a essa propriedade
    public required Medico Medico {get; set;}

    public required int PacienteId {get; set;}
    public Paciente Paciente {get; set;} //forço a criação da FK

    public ICollection<Exame> Exames {get;}

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

    public Task<List<Atendimento> > GetAll(CancellationToken cancellationToken){
        throw new NotImplementedException();
    }
}

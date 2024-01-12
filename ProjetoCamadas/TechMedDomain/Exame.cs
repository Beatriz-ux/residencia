namespace TechMedDomain;
using Interface;
public class Exame: IBaseRepository<Exame>{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Tipo { get; set; }
    public double Preco { get; set; }

    //atendimento tem varios exames, então atendimento tem uma lista de exames, e cada exame tem um atendimento

    public int AtendimentoId {get; set;}
    //public ICollection<Atendimento> Atendimentos{ get; set; }
    public required Atendimento Atendimento {get; set;} //forço a criação da FK

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

    public Task<List<Exame> > GetAll(CancellationToken cancellationToken){
        throw new NotImplementedException();
    }
}

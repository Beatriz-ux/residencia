namespace Domain;

public class Exame{
    public int Id {get; set;}
    public string Local {get; set;}
    public DateTime DataHora {get; set;}
    public ICollection<Atendimento>? Atendimentos {get; set;}
}

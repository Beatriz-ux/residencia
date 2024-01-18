namespace TechMed.Medico;
public class Medicoz
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public double Salario { get; set; }

    // Construtor que gera um novo GUID para cada instância
        public Medicoz()
        {
            Id = Guid.NewGuid();
        }

}

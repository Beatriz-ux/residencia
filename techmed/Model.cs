using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

namespace Techmed.Model;
public class TechmedContext: DbContext
{
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Medico> Medicos { get; set; }

    public TechmedContext()
    {
        //Database.EnsureDeleted(); aqui é para apagar e criar dnv
        //Database.EnsureCreated(); // comentei isso para não subir na migration
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var stringConexao = "server=localhost;user=dotnet;password=tic2023;database=tech";
        var serverVersion = ServerVersion.AutoDetect(stringConexao);

        optionsBuilder.UseMySql(stringConexao,serverVersion);
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Paciente>(p => {
            p.ToTable("Pacientes");
            p.HasKey(p => p.Id);
        });
        modelBuilder.Entity<Medico>(m => {
            m.ToTable("Medicos");
            m.HasKey(m => m.Id);
        });
    }



}

public abstract class Pessoa{
    public int Id { get; set; }
    public string Nome { get; set; }
}

public class Paciente : Pessoa{
    public string Cpf { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
}

public class Medico : Pessoa{
    public string Especialidade { get; set; }
    public double Salario { get; set; }
}

// public class Consulta{
//     public int Id { get; set; }
//     public DateTime Data_Inicio { get; set; }
//     public DateTime Hora { get; set; }
//     public double Valor { get; set; }
//     public Paciente Paciente { get; set; }
//     public Medico Medico { get; set; }
// }

// public class Exame{
//     public int Id { get; set; }
//     public string Nome { get; set; }
//     public int Tipo { get; set; }
//     public double Preco { get; set; }
// }

// public class TiposExames{
//     public int Id { get; set; }
//     public string Nome { get; set; }
// }

// public class ConsultaExame{
//     public int Id { get; set; }
//     public Consulta Consulta { get; set; }
//     public Exame Exame { get; set; }
// }

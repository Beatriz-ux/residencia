// See https://aka.ms/new-console-template for more information
using Techmed.Model;

var db = new TechmedContext();

var paciente = new Paciente{
    Nome = "João",
    Cpf = "123456789",
    Endereco = "Rua 1",
    Telefone = "123456789"
};

var medico = new Medico{
    Nome = "Maria",
    Especialidade = "Cardiologista",
    Salario = 10000
};

db.Pacientes.Add(paciente);
db.Medicos.Add(medico);

db.SaveChanges();

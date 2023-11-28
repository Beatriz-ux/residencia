// See https://aka.ms/new-console-template for more information
using semana4.P004;
using System.Globalization;
using System.Reflection;

List<Treinador> treinadores = new List<Treinador>();
List<Cliente> clientes = new List<Cliente>();

//Treinadores
string nome = "Bia";
DateTime dataNascimento = DateTime.ParseExact("19/02/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
string cpf = "12345678901";
string cref = "1234556";
try
{

    App.cadastrarTreinador(nome, dataNascimento, cpf, cref, treinadores);

}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{

    nome = "Treinador 1";
    dataNascimento = DateTime.ParseExact("19/02/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
    cpf = "12345678901"; //não pode mesmo cpf
    cref = "123455";

    App.cadastrarTreinador(nome, dataNascimento, cpf, cref, treinadores);

}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{

    nome = "Treinador 2";
    dataNascimento = DateTime.ParseExact("19/02/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
    cpf = "99345678901";
    cref = "1234557";

    App.cadastrarTreinador(nome, dataNascimento, cpf, cref, treinadores);

}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{

    nome = "Igor";
    dataNascimento = DateTime.ParseExact("19/02/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
    cpf = "99999999999"; //não pode mesmo cpf
    cref = "129996";

    App.cadastrarTreinador(nome, dataNascimento, cpf, cref, treinadores);

}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


//Clientes
nome = "Carol";
dataNascimento = DateTime.ParseExact("09/12/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
cpf = "12345678901";
float altura = 1.80f;
float peso = 80f;
try
{

    App.cadastrarCliente(nome, dataNascimento, cpf, altura, peso, clientes);

}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


nome = "Ana";
dataNascimento = DateTime.ParseExact("09/02/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
cpf = "12345678903";
altura = 1.80f;
peso = 80f;
try
{

    App.cadastrarCliente(nome, dataNascimento, cpf, altura, peso, clientes);

}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

App.listaTreinadores(treinadores);
App.listaClientes(clientes);


//RELATORIO
//Treinadores com idade entre dois valores
try
{

    App.relatorioIntervaloIdade(treinadores.Cast<Pessoa>().ToList(), 30, 21);//min e max trocados não pode
}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{

    App.relatorioIntervaloIdade(treinadores.Cast<Pessoa>().ToList(), 20, 22);//min e max trocados não pode
}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//2. Clientes com idade entre dois valores
try
{

    App.relatorioIntervaloIdade(clientes.Cast<Pessoa>().ToList(), 20, 31);
}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


//3. Clientes com IMC (peso/altura*altura) maior que um valor informado,em ordem crescente
Console.WriteLine("Informe o IMC:");
try{
    App.relatorioImcMaiorQue(clientes, 20);
}catch(ArgumentException c){
    Console.WriteLine(c.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//4. Clientes em ordem alfabética
Console.WriteLine("Clientes em ordem alfabética");
try
{

    App.relatorioOrdemAlfabetica(clientes.Cast<Pessoa>().ToList());
}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}


//5. Clientes do mais velho para mais novo
Console.WriteLine("Clientes do mais velho para o mais novo");
try
{

    App.relatorioClienteDoMaisVelho(clientes.Cast<Pessoa>().ToList());
}
catch (ArgumentException c)
{
    Console.WriteLine(c.Message);
}
//6. Treinadores e clientes aniversariantes do mês informado
Console.WriteLine("Informe o mês desejado:");
List<Pessoa> pessoas = new List<Pessoa>();
pessoas.AddRange(treinadores.Cast<Pessoa>().ToList());
pessoas.AddRange(clientes.Cast<Pessoa>().ToList());

App.relatorioEncontrarAniversariantes(pessoas, 2);




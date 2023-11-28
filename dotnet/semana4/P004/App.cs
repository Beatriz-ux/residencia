using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace semana4.P004
{
    public static class App
    {
        public static void relatorioIntervaloIdade(List<Pessoa> p, int idadeMin, int idadeMax)
        {
            if (idadeMin > idadeMax)
                throw new Exception("Idade mínima não pode ser maior que a idade máxima");
            List<Pessoa> pessoasIntervalo = p.Where(p => p.Idade >= idadeMin && p.Idade <= idadeMax).OrderBy(p => p.Idade).ThenBy(p => p.Nome).ToList();
            Console.WriteLine($"Resultado com idade entre {idadeMin} e {idadeMax}");
            listaPessoas(pessoasIntervalo);
            //List<Pessoa> pessoasIntervalo = p.Where(p => p. && p.getPreco() <= maximo).OrderBy(p => p.getPreco()).ThenBy(p => p.getNome()).ToList();

        }
        public static void relatorioClienteDoMaisVelho(List<Pessoa> pessoas)
        {
            if (pessoas.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }
            List<Pessoa> pessoasOrdernada = pessoas.OrderByDescending(p => p.Idade).ToList();
            listaPessoas(pessoasOrdernada);
        }


        public static void relatorioEncontrarAniversariantes(List<Pessoa> pessoas, int mesDesejado)
        {
            if (pessoas.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }
            if (mesDesejado < 1 || mesDesejado > 12)
            {
                throw new ArgumentException("Mês inválido");
            }
            List<Pessoa> pessoasAniver = pessoas.Where(p => p.DataNascimento.Month == mesDesejado).ToList();
            if (pessoasAniver.Count == 0)
            {
                throw new Exception("Não há aniversariantes neste mês");
            }
            Console.WriteLine("Aniversariantes do mês "+mesDesejado);
            listaPessoas(pessoasAniver);
        }
        
        public static void relatorioImcMaiorQue(List<Cliente> clientes, float imc)
        {
            if (clientes.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }
            List<Cliente> clientesImc = clientes.Where(c => CalcularImc(c) > imc).OrderBy(c => CalcularImc(c)).ToList();
            if (clientesImc.Count == 0)
            {
                throw new Exception("Não há clientes com IMC maior que " + imc);
            }
            Console.WriteLine("Clientes com IMC maior que " + imc);
            listaClientes(clientesImc);
        }

        public static float CalcularImc(Cliente c){
            return c.Peso / (c.Altura * c.Altura);

        }
        public static void relatorioOrdemAlfabetica(List<Pessoa> p)
        {
            if (p.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }
            List<Pessoa> pessoasOrdemAlfabetica = p.OrderBy(p => p.Nome).ToList();
            Console.WriteLine("Resultado em ordem alfabética");
            listaPessoas(pessoasOrdemAlfabetica);
        }
        public static void listaPessoas(List<Pessoa> t)
        {
            foreach (Pessoa pessoa in t)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Idade);
                Console.WriteLine(pessoa.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine();
            }
        }
        public static void listaClientes(List<Cliente> clientes)
        {
            Console.WriteLine("Clientes:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Idade);
                Console.WriteLine(cliente.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine(cliente.Altura);
                Console.WriteLine(cliente.Peso);
                Console.WriteLine(CalcularImc(cliente));
                Console.WriteLine();
            }
        }
        public static void listaTreinadores(List<Treinador> treinadores)
        {
            if (treinadores.Count == 0)
            {
                throw new ArgumentException("Não há treinadores");
            }
            Console.WriteLine("Treinadores:");
            foreach (Treinador treinador in treinadores)
            {
                Console.WriteLine(treinador.Nome);
                Console.WriteLine(treinador.Idade);
                Console.WriteLine(treinador.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine();
            }
        }

        public static Treinador cadastrarTreinador(string nome, DateTime dataNascimento, string cpf, string cref, List<Treinador> treinadores)
        {
            Treinador t = new Treinador();
            t.Nome = nome;
            t.DataNascimento = dataNascimento;
            t.Cpf = cpf;
            t.CREF = cref;
            if (Treinador.CpfExiste(treinadores.Cast<Pessoa>().ToList(), cpf))
            {
                throw new Exception("CPF já cadastrado");
            }
            if (Treinador.CrefExiste(treinadores, cref))
            {
                throw new Exception("CREF já cadastrado");
            }
            treinadores.Add(t);



            return t;
        }
        public static Cliente cadastrarCliente(string nome, DateTime dataNascimento, string cpf, float altura, float peso, List<Cliente> clientes)
        {
            Cliente t = new Cliente();
            t.Nome = nome;
            t.DataNascimento = dataNascimento;
            t.Cpf = cpf;
            t.Altura = altura;
            t.Peso = peso;
            if (Cliente.CpfExiste(clientes.Cast<Pessoa>().ToList(), cpf))
            {
                throw new Exception("CPF já cadastrado");
            }
            clientes.Add(t);



            return t;
        }



    }
}
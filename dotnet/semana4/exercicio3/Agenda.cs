using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana4.exercicio3
{
    public class Agenda
    {
        List<Contato> contatos = new List<Contato>();
        public void AdicionarContato(Contato contato){
            //verificar se o contato já existe com o mesmo cpf
            try{

            if (contatos.Any(c => c.CPF == contato.CPF)){
                throw new ArgumentException("Já existe um contato com o mesmo CPF");
            
            }
            Console.WriteLine("Contato adicionado com sucesso");
            }
            catch(ArgumentException e){
                Console.WriteLine(e.Message);
            }
            contatos.Add(contato);
        }
    }

    public class Contato{
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
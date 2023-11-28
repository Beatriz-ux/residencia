using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana4.P004
{
    public class Pessoa
    {
        private string _cpf;
        private DateTime _dataNascimento;

        public string Nome { get; set; }
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Data de nascimento não pode ser maior que a data atual");
                }
                _dataNascimento = value;

            }
        }
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                
                    if (value.Length != 11)
                    {
                        throw new ArgumentException("CPF deve ter 11 dígitos");
                    }
                    _cpf = value;
                
            }
        }

        public static bool CpfExiste(List<Pessoa> pessoas, string cpf)
        {
            return pessoas.Any(p => p.Cpf == cpf);
        }

        


        public int Idade
        {
            get
            {
                int idade = DateTime.Now.Year - DataNascimento.Year;
                if (DateTime.Now < DataNascimento.AddYears(idade)) idade--;
                return idade;
            }
        }



    }
}
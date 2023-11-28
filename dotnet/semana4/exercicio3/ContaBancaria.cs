using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3
{
    public class ContaBancaria
    {
        private float _saldo;
        public float Saldo
        {
            get { return _saldo; }
            set
            {
                try
                {

                    if (value < 0)
                    {
                        throw new ArgumentException("Saldo não pode ser negativo");
                    }
                    _saldo = value;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}
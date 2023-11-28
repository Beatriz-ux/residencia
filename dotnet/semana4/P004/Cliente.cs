using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana4.P004
{
    public class Cliente : Pessoa
    {
        private float _altura;
        private float _peso;
        public float Altura
        {
            get { return _altura; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Altura não pode ser negativa");
                }
                else
                    _altura = value;

            }
        }
        public float Peso
        {
            get { return _peso; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Peso não pode ser negativo");
                }

                _peso = value;

            }
        }

    }
}
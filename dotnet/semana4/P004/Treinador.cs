using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana4.P004
{
    public class Treinador : Pessoa
    {

        public string CREF { get; set; }
        public static bool CrefExiste(List<Treinador> treinadores, string cREF)
        {
            if(treinadores.Any(t => t.CREF == cREF))
                return true;
            return false;
        }
    }
}
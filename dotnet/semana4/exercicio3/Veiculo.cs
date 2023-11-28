using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace semana4.exercicio3
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Cor{ get; set; }

        public int IdadeVeiculo{
            get{
                return DateTime.Now.Year - int.Parse(Ano);
            }
        }
        
    }
}
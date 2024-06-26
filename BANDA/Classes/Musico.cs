using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANDA.Classes
{
    public class Musico : Pessoa
    {
        private List<Banda> bandas;

        public Musico() { 
            bandas = new List<Banda>();
        }
        public Musico(string cpf, string nome, int idade) : base(cpf, nome, idade) {
            bandas = new List<Banda>();
        }

        public bool IngressarEmBanda(Banda banda)
        {
            if(!bandas.Contains(banda)) { 
                bandas.Add(banda);
                banda.AdicionarMusico(this);
                return true;
            }
            return false;
        }

        public bool SairDeBanda(Banda banda)
        {
            if (bandas.Contains(banda))
            {
                bandas.Remove(banda);
                banda.RemoverMusico(this);
                return true;
            }
            return false;
        }
    }
}

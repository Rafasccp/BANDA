using BANDA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANDA
{
    public class Singleton
    {
        private Singleton()
        {
            musicos = new List<Musico>() {
                new Baterista("121.123.123-12","Ringo Star", 20),
                new Baixista("222.123.123-12", "Paul McCartney", 20),
                new Guitarrista("222.333.123-12", "George Harrison", 20),
                new Vocalista("222.333.444-12", "John Lennon", 20)
        };
            bandas = new List<Banda>(){
                new Banda(1, "The Beatles", new List<Musico>(){
                    musicos[0], musicos[1], musicos[2], musicos[3]
                })
            };
        }

        private static Singleton instance;

        public static Singleton Instance { get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            } 
        }

        public List<Musico> musicos;
        public List<Banda> bandas;

        public Musico? BuscarMusico(string cpf)
        {
            return musicos.Find(m => m.Cpf == cpf);
        }

        public Banda? BuscarBanda(int codigo)
        {
            return bandas.Find(m => m.Codigo == codigo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANDA.Classes
{
    public class Banda
    {
        private int codigo;
        private string nome;
        private List<Musico> musicos;

        public int Codigo { get => codigo; }
        public string Nome { get => nome; set => nome = value; }
        private List<Musico> Musicos { get => musicos; }

        public Banda(int codigo, string nome, List<Musico> musicos) : this(codigo, nome)
        {
            this.musicos = musicos;
        }

        public Banda(int codigo, string nome) : this(codigo)
        {
            Nome = nome;
        }

        public Banda(int codigo)
        {
            this.codigo = codigo;
            musicos = new List<Musico>();
        }

        public bool AdicionarMusico(Musico musico)
        {
            if (!musicos.Contains(musico))
            {
                musicos.Add(musico);
                musico.IngressarEmBanda(this);
                return true;
            }
            return false;
        }

        public bool RemoverMusico(Musico musico)
        {
            if (musicos.Contains(musico)){
                musicos.Remove(musico);
                musico.SairDeBanda(this);
                return true;
            }
            return false;
        }
    }
}

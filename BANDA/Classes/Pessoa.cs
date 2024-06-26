using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANDA.Classes
{
    public class Pessoa
    {
        private string cpf;
        private string nome;
        private int idade;

        public string Cpf { get => cpf; }
        public string Nome { get => nome; set=>nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public Pessoa(string cpf, string nome, int idade){
            this.cpf = cpf;
            Nome = nome;
            Idade = idade;
        }

        public Pessoa() { }
    }
}

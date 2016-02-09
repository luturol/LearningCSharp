using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraApp
{
    class Usuario
    {
         
        public String nome { get; set; }

        private String sobrenome { get { return nome; } set { this.nome = nome; } }

        public Usuario(String nome, String sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
    }
}

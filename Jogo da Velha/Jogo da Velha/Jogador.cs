using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_da_Velha
{
    class Jogador
    {
        private string nome;
        private int vitorias;

        public Jogador(string nome)
        {
            vitorias = 0;
            this.nome = nome;
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }

        public int Vitorias
        {
            get
            {
                return this.vitorias;
            }

            set
            {
                this.vitorias = value;
            }
        }

        public string toString()
        {
            string msg = "";
            msg += "Nome: " + Nome;
            msg += "\nVitorias: " + Vitorias;
            return msg;
        }
    }
}

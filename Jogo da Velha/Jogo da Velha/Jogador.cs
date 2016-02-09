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

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getVitorias()
        {
            return vitorias;
        }

        public string toString()
        {
            string msg = "";
            msg += "Nome: " + getNome();
            msg += "\nVitorias: " + getVitorias();
            return msg;
        }
    }
}

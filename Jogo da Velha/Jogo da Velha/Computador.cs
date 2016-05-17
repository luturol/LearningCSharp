using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_da_Velha
{
    class Computador
    {
        private Random jogada;
        private int vitorias;

        public Computador()
        {
            jogada = new Random();
            vitorias = 0;
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

        public int[] jogar()
        {
            int x = jogada.Next(0,3);
            int y = jogada.Next(0,3);
            
            int[] posicao = new int[2];
            
            posicao[0] = x;
            posicao[1] = y;
            
            return posicao;
        }
    }
}

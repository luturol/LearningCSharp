using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_da_Velha
{
    class Tabuleiro
    {
        private string[][] t;
        private int jogadasDisponiveis;

        public Tabuleiro()
        {
            t = new string[3][];
            jogadasDisponiveis = 9;
            populaTabuleiro();
        }

        public void setJogadasDisponiveis(int jogadas)
        {
            jogadasDisponiveis -= jogadas;
        }

        public int getJogadasDisponiveis()
        {
            return jogadasDisponiveis;
        }

        public void populaTabuleiro()
        {
            //Criando jagged array
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new string[3];
            }

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < t[i].Length; j++)
                {
                    t[i][j] = "k";
                }
            }


        }

        public Boolean verificaJogada(int x, int y)
        {
            //Verifica se a Jogada é válida
            if (x < t.Length && x >= 0)
            {
                if (y < t[x].Length && y >= 0)
                {
                    string jog = t[x][y];
                    string k = "k";
                    if (jog.CompareTo(k) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        public void mudarPosicao(int x, int y, string jogada)
        { //Muda a posição
            t[x][y] = jogada;
        }

        public string toString()
        {
            string msg = "";

            //Monta tabuleiro
            for (int i = 0; i < t.Length; i++)
            {

                msg += i + " ";
                for (int j = 0; j < t[i].Length; j++)
                {
                    msg += t[i][j];
                    if (j == 2)
                        continue;
                    else
                        msg += " - ";
                }
                if (i == 2)
                    continue;
                else
                    msg += "\n  -   -   -\n";
            }
            msg += "\nJogadas Disponiveis: " + getJogadasDisponiveis() + "\n";
            return msg;
        }

        public void mostraTabuleiro()
        {
            string m = toString();
            Console.WriteLine(m);
        }

        public string quemVenceu()
        {
            //TODO: Verificar todas as posições e ver quem venceu

            return "";
        }

        public Boolean xVencedor()
        {
            //TODO: Verificar todas as posições possíveis se possuem 3 X e retornar true, se não false
            Boolean vencedor = false;
            //Verificar na Horizontal
            vencedor = verificaVencedorHorizontal("X");
            if (vencedor)
                return vencedor;
            vencedor = verificaVencedorVertical("X");
            if (vencedor)
                return vencedor;
            vencedor = verificaVencedorDiagonal("X");
            if (vencedor)
                return vencedor;
            return vencedor;
        }

        public Boolean oVencedor()
        {
            //TODO: Verificar todas as posições possíveis se possuem 3 X e retornar true, se não false
            Boolean vencedor = false;
            //Verificar na Horizontal
            vencedor = verificaVencedorHorizontal("O");
            if (vencedor)
                return vencedor;
            vencedor = verificaVencedorVertical("O");
            if (vencedor)
                return vencedor;
            vencedor = verificaVencedorDiagonal("O");
            if (vencedor)
                return vencedor;
            return vencedor;
        }

        public Boolean verificaVencedorHorizontal(string jogada)
        {
            Boolean venceu = false;
            for (int i = 0; i < t.Length; i++)
            {

                if (t[i][0].CompareTo(jogada) == 0 && t[i][1].CompareTo(jogada) == 0 && t[i][2].CompareTo(jogada) == 0)
                {
                    venceu = true;
                }
            }

            return venceu;
        }

        public Boolean verificaVencedorVertical(string jogada)
        {
            Boolean venceu = false;
            for (int i = 0; i < t.Length; i++)
            {

                if (t[0][i].CompareTo(jogada) == 0 && t[1][i].CompareTo(jogada) == 0 && t[2][i].CompareTo(jogada) == 0)
                {
                    venceu = true;
                }
            }

            return venceu;
        }

        public Boolean verificaVencedorDiagonal(string jogada)
        {
            Boolean venceu = false;

            if (t[0][0].CompareTo(jogada) == 0 && t[1][1].CompareTo(jogada) == 0 && t[2][2].CompareTo(jogada) == 0)
            {
                venceu = true;
            }

            if (t[0][2].CompareTo(jogada) == 0 && t[1][1].CompareTo(jogada) == 0 && t[2][0].CompareTo(jogada) == 0)
            {
                venceu = true;
            }

            return venceu;
        }

        public string[][] getTabuleiro()
        {
            return t;
        }

    }
}

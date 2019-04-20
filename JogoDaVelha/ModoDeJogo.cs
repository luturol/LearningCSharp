using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoDaVelha
{
    class ModoDeJogo
    {
        private ConsoleKeyInfo cki;
        private Tabuleiro tabuleiro;
        public Boolean acabou;
        public Jogador player;
        public Jogador player2;

        public ModoDeJogo()
        {
            cki = new ConsoleKeyInfo();
            tabuleiro = new Tabuleiro();
            acabou = false;
            selecionarModoDeJogo();

        }

        public void selecionarModoDeJogo()
        {
            tabuleiro.mostraTabuleiro();
            Console.WriteLine("Deseja jogar como?");
            Console.WriteLine("1 - P vs C");
            Console.WriteLine("2 - P vs P");

            cki = Console.ReadKey(true);

            if (cki.Key == ConsoleKey.D1)
            {
                PvsC();
            }
            else if (cki.Key == ConsoleKey.D2)
            {
                PvsP();
            }
        }

        public Jogador criaJogador()
        {

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Jogador j = new Jogador(nome);
            return j;
        }

        public void limpaTela()
        {
            Console.Clear();
        }

        public void PvsC()
        {
            //TODO: Alternar o Computador com o Jogador
            //TODO: Fazer o bot mais inteligente
            //TODO: Modificar para não encerrar se der velha ou se acabar as jogadas
            //TODO: Refatorar
            limpaTela();

            Computador pc = new Computador();
            player = criaJogador();
            limpaTela();
            do
            {
                limpaTela();
                Console.ForegroundColor = ConsoleColor.Green; //Muda cor do Tabuleiro
                tabuleiro.mostraTabuleiro();

                Boolean jogadaPlayer = false;

                while (!jogadaPlayer)
                {
                    jogadaPlayer = jogada("X");
                }

                Boolean jogadaPC = false;

                while (!jogadaPC)
                {
                    jogadaPC = jogadaComputador("O");
                }
                limpaTela();
                tabuleiro.mostraTabuleiro();
                vencedorPvsC();

            } while (!acabou);

        }

        public Boolean jogadaComputador(string vez)
        {
            //TODO: Melhorar jogada do Computador!
            //TODO: Verificar jogada incial do player e escolher uma posição contra
            //TODO: Fazer um algoritmo que verifique qual é a posição ideal para vencer
            //TODO: Fazer um algoritmo que verifique qual é a posição ideal pro usuário não vencer
            Random r = new Random();
            int randomX = r.Next(0, 3);
            int randomY = r.Next(0, 3);

            int centro = 1;
            if (tabuleiro.verificaJogada(centro, centro)) //Primeira jogada sempre no centro
            {
                tabuleiro.mudarPosicao(centro, centro, vez);
                return true;
            }
            else if (tabuleiro.verificaJogada(randomX, randomY))//Joga numa posição aleatória se válida
            {
                tabuleiro.mudarPosicao(randomX, randomY, vez);
                tabuleiro.setJogadasDisponiveis(1);
                return true;
            }
            return false;
        }

        public Boolean jogada(string vez)
        {
            //TODO: Ver de quem é a jogada e conferir se alguém já venceu
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (tabuleiro.verificaJogada(x, y))
            {
                tabuleiro.mudarPosicao(x, y, vez);
                tabuleiro.setJogadasDisponiveis(1);
                return true;
            }
            else
            {
                Console.WriteLine("Jogada invalida");
                return false;
            }
        }

        public string[][] melhorJogadaComputador()
        {
            //TODO: Verificar todas as posições e retonrar um jogada que proporcione a vitória do computador

            //Tabuleiro
            string[][] jagged = tabuleiro.getTabuleiro();



            return jagged;
        }

        public void PvsP()
        {
            //TODO: Modificar o PvsC para ter dois jogadores
            //Precisa de dois jogadores e controlar as suas jogadas
            limpaTela();
            player = criaJogador();
            player2 = criaJogador();
            limpaTela();
            Boolean vezJogador = false;
            do
            {
                limpaTela();
                Console.ForegroundColor = ConsoleColor.Green; //Muda cor do Tabuleiro
                tabuleiro.mostraTabuleiro();
                if (!vezJogador)
                {
                    Boolean jogadaPlayer = false;
                    Console.WriteLine("Vez do jogador " + player.Nome);
                    while (!jogadaPlayer)
                    {
                        jogadaPlayer = jogada("X");
                    }
                    vezJogador = true;

                    vencedor();
                }
                else if (vezJogador)
                {
                    Boolean jogadaP2 = false;
                    Console.WriteLine("Vez do jogador " + player2.Nome);
                    while (!jogadaP2)
                    {
                        jogadaP2 = jogada("O");
                    }

                    vezJogador = false;
                    vencedor();
                }


            } while (!acabou);
            tabuleiro.mostraTabuleiro();

        }

        public Boolean vencedor()
        {
            //TODO: Refatorar
            //TODO: Alternar Jogadores
            int jogda = tabuleiro.getJogadasDisponiveis();
            if (jogda == 0)
                acabou = true;
            else if (tabuleiro.xVencedor())
            {
                limpaTela();
                tabuleiro.mostraTabuleiro();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jogador " + player.Nome + " Venceu!!!");
                cki = Console.ReadKey(true);
                acabou = true;
            }
            else if (tabuleiro.oVencedor())
            {
                limpaTela();
                tabuleiro.mostraTabuleiro();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jogador " + player2.Nome + " Venceu!!");
                cki = Console.ReadKey(true);

                acabou = true;
            }
            return acabou;
        }
        public Boolean vencedorPvsC()
        {
            //TODO: Alternar o Computador com o Jogador
            //TODO: Refatorar
            int jogda = tabuleiro.getJogadasDisponiveis();
            if (jogda == 0)
                acabou = true;
            else if (tabuleiro.xVencedor())
            {
                limpaTela();
                tabuleiro.mostraTabuleiro();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jogador " + player.Nome + " Venceu!!!");
                cki = Console.ReadKey(true);
                acabou = true;
            }
            else if (tabuleiro.oVencedor())
            {
                limpaTela();
                tabuleiro.mostraTabuleiro();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jogador O Venceu!!");
                cki = Console.ReadKey(true);

                acabou = true;
            }
            return acabou;
        }
    }
}
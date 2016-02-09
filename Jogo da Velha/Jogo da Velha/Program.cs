using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_da_Velha
{
    class Program
    {
        static ConsoleKeyInfo cki = new ConsoleKeyInfo(); //Global

        static void Main(string[] args)
        {
            
            ConfigurarJanela();
            ConfigurarCorDaFonte(ConsoleColor.Green);
            
            menu();
            
        }
        static void ConfigurarJanela()
        {
            Console.Title = "Jogo da Velha - By Rafael Ahrons";
            Console.BufferHeight = 40;
            Console.BufferWidth = 100;
            Console.SetWindowSize(100, 40);
        }

        static void ConfigurarCorDaFonte(ConsoleColor corDaFonte)
        {
            Console.ForegroundColor = corDaFonte;
        }

        static void menu()
        {
            //TODO: Jogo só acaba se um usuário quiser encerrar a partida            
            Tabuleiro tabuleiro = new Tabuleiro();
            ModoDeJogo modoDeJogo;
            do
            {                
                modoDeJogo = new ModoDeJogo();
                
            } while (!modoDeJogo.acabou);
        }
    }

}

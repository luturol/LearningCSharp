using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigurarJanela();
            ConfigurarCorDaFonte(ConsoleColor.Green);

            menu();

        }
        static void ConfigurarJanela()
        {
            Console.Title = "Jogo da Velha - By Rafael Ahrons";
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

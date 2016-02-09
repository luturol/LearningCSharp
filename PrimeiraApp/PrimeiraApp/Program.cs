using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraApp
{
    class Program
    {
        static List<Usuario> listUsuario;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");
            menu(true);
        }

        static void menu(Boolean iniciar)
        {
            String opcao = "";
            int op = 20;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            Console.WriteLine("1 - Cadastrar Usuario");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("0 - Sair");

            //Para ler oq foi digitado
            cki = Console.ReadKey(true);
            Console.WriteLine("Testando");

            if (cki.Key == ConsoleKey.D1)
            {
                cadastraUsuario();
            }

            if (cki.Key == ConsoleKey.D2)
            {
                listarUsuarios();
            }

        }
        static void cadastraUsuario()
        {
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Sobrenome: ");
            String sobrenome = Console.ReadLine();

            if (nome != "" && sobrenome != "")
            {
                Usuario usuario = new Usuario(nome, sobrenome);
                Console.WriteLine(usuario.nome);
            }

            return;

        }
        static Boolean listarUsuarios()
        {
            return false;
        }

        static void ConfiguararTela()
        {
            Console.Title = "Cadastro de Usuarios";
            Console.BufferHeight = 40;
            Console.BufferWidth = 40;
            Console.SetWindowSize(100, 40);
        }
    }
}

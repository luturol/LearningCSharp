using System;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        private static ConsoleKeyInfo lastPressed;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var readKeyTask = new Task(ReadKey);
            var countNumbersTaks = new Task(CountNumbers);

            countNumbersTaks.Start();
            readKeyTask.Start();

            Task.WaitAll(new Task[] { countNumbersTaks, readKeyTask });
        }

        private static void CountNumbers()
        {
            int i = 0;
            while (true)
            {
                i++;                
                Console.WriteLine(i.ToString());

                if(lastPressed != default)
                {
                    Console.WriteLine("Ultima tecla pressionada: " + lastPressed.KeyChar);
                }

                Thread.Sleep(1000);
            }
        }

        private static void ReadKey()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);
                lastPressed = key;
                Console.WriteLine("Tecla pressionada: " + key.KeyChar);
            }
        }
    }
}

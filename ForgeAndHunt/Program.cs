using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System;

namespace ForgeAndHunt
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Forgin sword will take 12 hours");
            var forge = new Forge().Craft("sword");
            var hunt = new Hunt().WillHunt("Rats");

            var list = new List<Task>() { forge, hunt };

            while (list.Count > 0)
            {
                Task finishedTaks = await Task.WhenAny(list);
                if (finishedTaks == forge)
                {
                    Console.WriteLine("forge is ready");
                }
                else if (finishedTaks == hunt)
                {
                    Console.WriteLine("hunt is ready");
                }

                list.Remove(finishedTaks);
            }
            Console.WriteLine(string.Format("Finished in {0}s", stopwatch.ElapsedMilliseconds / 1000));
        }
    }
}

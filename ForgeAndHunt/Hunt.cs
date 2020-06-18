using System.Threading.Tasks;
using System;

namespace ForgeAndHunt
{
    public class Hunt
    {
        public async Task<Monster> WillHunt(string creatureToHunt)
        {            
            Console.WriteLine(string.Format("Hunting {0}", creatureToHunt));
            await Task.Delay(10000);          

            Console.WriteLine(string.Format("Finished huting {0}", creatureToHunt));
            
            var monster = new Monster();
            monster.Name = creatureToHunt;
            return monster;
        }
    }
}

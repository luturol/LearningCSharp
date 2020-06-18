using System.Threading.Tasks;
using System;

namespace ForgeAndHunt
{
    public class Forge
    {
        public async Task<Sword> Craft(string swordName)
        {            
            Console.WriteLine(string.Format("Crafting {0}", swordName));
            await Task.Delay(12000);           

            Console.WriteLine(string.Format("{0} finished crafting", swordName));

            var sword = new Sword();
            sword.Name = swordName;
            return sword;
        }
    }
}

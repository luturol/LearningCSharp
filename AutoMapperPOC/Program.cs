using System;
using Mapper;
using Models;

namespace AutoMapperPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mapper = MapperConfig.Configure();

            var sword = new Sword(){
                Id = 0,
                Name = "Fire Sword",
                ElementType = "Fire",
                AttackDamage = 32,
                Deffense = 26,
                Type = "One handed sword"
            };

            SwordDTO dto = mapper.Map<SwordDTO>(sword);

            Console.WriteLine(string.Format("SwordDTO = {0} {1} {2} {3} {4}", dto.Name, dto.Type, dto.ElementType, dto.AttackDamage, dto.Deffense));
        }
    }
}

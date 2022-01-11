using System;
using Xunit;

namespace ContatosTestes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var nome = Faker.Name.FullName();            
            var firstName = Faker.Name.First();
            var email = Faker.Internet.Email();
            var telefone = Faker.Phone.Number();
            var empresa = Faker.Company.Name();
            var endereco = Faker.Address.StreetName();

            Console.WriteLine($"Full Name: { nome }");
            Console.WriteLine($"First Name: { firstName }");
            Console.WriteLine($"Email: { email }");
            Console.WriteLine($"Telefone: { telefone }");
            Console.WriteLine($"Empresa: { empresa }");
            Console.WriteLine($"Endereco: { endereco }");
        }
    }
}

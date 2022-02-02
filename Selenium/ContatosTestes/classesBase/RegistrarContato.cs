using System;
using OpenQA.Selenium;

namespace ContatosTestes.classesBase
{
    public class RegistrarContato
    {
        private ContatoDTO _contato = null;
        private IWebDriver _driver = null;

        public RegistrarContato()
        {
            _driver = Driver.GetInstance();

            _contato = new ContatoDTO
            {
                Nome = Faker.Name.FullName()
            };

            Random numeroAleatorio = new Random();
            int numeroSorteado = numeroAleatorio.Next(1, 4);
            switch (numeroSorteado)
            {
                case 1:
                    _contato.EstadoCivil = "Solteiro";
                    break;
                case 2:
                    _contato.EstadoCivil = "Casado";
                    break;
                case 3:
                    _contato.EstadoCivil = "Viúvo";
                    break;
                case 4:
                    _contato.EstadoCivil = "Outros";
                    break;
                default:
                    _contato.EstadoCivil = "Outros";
                    break;
            }

            _contato.Endereco = Faker.Address.StreetAddress();
            _contato.Cidade = Faker.Address.City();

            string[] siglasEstados = 
            {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
                "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            };

            numeroSorteado = numeroAleatorio.Next(0, 26);

            _contato.Estado = siglasEstados[numeroSorteado];
            _contato.Cep = Faker.Address.ZipCode();
            _contato.Telefone = Faker.Phone.Number();
            _contato.Email = Faker.Internet.Email();
        }

    }
}
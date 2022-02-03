using System;
using OpenQA.Selenium;
using Selenium;

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

        public ContatoDTO CadastrarContato()
        {
            _driver.Wait(By.LinkText("Contato"));
            _driver.ClickButton(By.LinkText("Contato"));

            _driver.Wait(By.Name("btnCriar"));
            _driver.ClickButton(By.Name("btnCriar"));

            _driver.Wait(By.Id("nomeId"));
            _driver.SetValue(By.Id("nomeId"), _contato.Nome);

            _driver.ClickButton(By.Id(_contato.EstadoCivil));

            _driver.SetValue(By.Id("enderecoId"), _contato.Endereco);

            _driver.SetValue(By.Id("cidadeId"), _contato.Cidade);

            _driver.SetValue(By.Id("cepId"), _contato.Cep);

            _driver.SetSelectByValue(By.Id("estadoId"), _contato.Estado);

            _driver.SetValue(By.Id("telefoneId"), _contato.Telefone);

            _driver.SetValue(By.Id("emailId"), _contato.Email);

            _driver.SubmitButton(By.Name("btnGravar"));

            // _driver.Quit();

            return _contato;
        }
    }
}
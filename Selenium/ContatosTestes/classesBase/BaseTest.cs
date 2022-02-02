using System.IO;
using Microsoft.Extensions.Configuration;
using Selenium;
using Xunit;

namespace ContatosTestes.classesBase
{
    public abstract class BaseTest
    {
        public IConfiguration configuration;
        public string emailPadrao { get; set; }
        public string senhaPadrao { get; set; }

        public BaseTest()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();

            emailPadrao = "selenium1@mail.com";
            senhaPadrao = "Mudar@123";
        }

        public void Login(Browser browser, string email, string senha)
        {
            RegistrarLogin registrarLogin = new RegistrarLogin(configuration, browser);
            registrarLogin.CarregarPagina();
            var usuarioLogado = registrarLogin.Login(email, senha);            

            Assert.NotNull(usuarioLogado);
            Assert.True(usuarioLogado.Contains(email));
        }
    }
}
using ContatosTestes.classesBase;
using Selenium;
using Xunit;

namespace ContatosTestes.casoTeste
{
    public class RegistrarContatoTeste : BaseTest
    {
        private void CadastrarContato(Browser browser)
        {
            Login(browser, emailPadrao, senhaPadrao);
            RegistrarContato registrarContato = new RegistrarContato();
            var contatoDto = registrarContato.CadastrarContato();

            Assert.NotNull(contatoDto);
        }

        [Fact(DisplayName = "Registrar Contato")]
        public void TestarChrome()
        {
            CadastrarContato(Browser.Chrome);            
        }
    }
}
using System.Linq;
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

            PesquisarContato pesquisarContato = new PesquisarContato();
            var lista = pesquisarContato.PesquisarContatoPorNome(contatoDto);

            Assert.NotNull(contatoDto);
            Assert.True(lista.Any());
            Assert.Equal(lista[0], contatoDto.Nome);
            Assert.Equal(lista[1], contatoDto.Email);
        }

        [Fact(DisplayName = "Registrar Contato")]
        public void TestarChrome()
        {
            CadastrarContato(Browser.Chrome);            
        }
    }
}
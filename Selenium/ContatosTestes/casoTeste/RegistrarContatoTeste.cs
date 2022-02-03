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
            var nomeCadastrado = contatoDto.Nome;

            Assert.NotNull(contatoDto);
            Assert.True(lista.Any());
            Assert.Equal(lista[0], contatoDto.Nome);
            Assert.Equal(lista[1], contatoDto.Email);

            var contatoEditado = registrarContato.EditarContato();
            var listaEditada = pesquisarContato.PesquisarContatoPorNome(contatoEditado);

            Assert.NotNull(contatoEditado);         
            Assert.NotEqual(nomeCadastrado, contatoEditado.Nome);
            Assert.True(listaEditada.Any());
            Assert.Equal(listaEditada[0], contatoEditado.Nome);
            Assert.Equal(listaEditada[1], contatoEditado.Email);
        }

        [Fact(DisplayName = "Registrar Contato")]
        public void TestarChrome()
        {
            CadastrarContato(Browser.Chrome);            
        }
    }
}
using ContatosTestes.classesBase;
using Selenium;
using Xunit;

namespace ContatosTestes.casoTeste
{
    public class RegistrarLoginTeste : BaseTest
    {
        private string _email { get; set; }
        private string _senha { get; set; }

        public RegistrarLoginTeste()
        {
            _email = Faker.Internet.Email();
            _senha = "Mudar@123";
        }

        private void Executar(Browser browser, string email, string senha)
        {
            RegistrarLogin registrarLogin = new RegistrarLogin(configuration, browser);
            registrarLogin.CarregarPagina();
            var emailLogado = registrarLogin.RegistrarUsuario(email, senha);
            registrarLogin.FecharPagina();

            Assert.NotEmpty(emailLogado);
            Assert.Equal(email, emailLogado);
        }

        private void ExecutarJaRegistrado(Browser browser, string email, string senha)
        {
            RegistrarLogin registrarLogin = new RegistrarLogin(configuration, browser);
            registrarLogin.CarregarPagina();
            var mensagem = registrarLogin.UsuarioJaRegistrado(email, senha);
            registrarLogin.FecharPagina();

            Assert.NotEmpty(mensagem);
            Assert.True(mensagem.Contains("already"));
            Assert.True(mensagem.Contains(email));
        }

        [Fact(DisplayName = "Chrome - Registrar e Logar Usuário")]
        public void TestarChrome()
        {
            Executar(Browser.Chrome, _email, _senha);
            ExecutarJaRegistrado(Browser.Chrome, _email, _senha);

        }

        [Fact(Skip = "Teste FireFox somente removendo o Skip")]
        public void TestarFireFox()
        {
            Executar(Browser.Firefox, _email, _senha);
            ExecutarJaRegistrado(Browser.Firefox, _email, _senha);
        }
    }
}
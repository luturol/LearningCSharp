using Jogo_da_Velha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JogoDaVelhaTest
{
    
    
    /// <summary>
    ///Esta é uma classe de teste para JogadorTest e pretende
    ///conter todos os Testes de Unidade de JogadorTest
    ///</summary>
    [TestClass()]
    public class JogadorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtém ou define o contexto de teste o qual fornece
        ///informações sobre e funcionalidade para a execução de teste atual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de teste adicionais
        // 
        //Podem ser usados os seguintes atributos adicionais enquanto escreve os testes:
        //
        //Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para executar código depois que todos os testes já forem executados
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para executar código antes de executar cada teste
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para executar código depois da execução de cada teste
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Um teste para Jogador Construtor
        ///</summary>
        [TestMethod()]
        public void JogadorConstructorTest()
        {
            string nome = string.Empty; // TODO: Inicializar com um valor apropriado
            Jogador target = new Jogador(nome);
            Assert.Inconclusive("TODO: Implemente código para verificar destino");
        }

        /// <summary>
        ///Um teste para getNome
        ///</summary>
        [TestMethod()]
        public void getNomeTest()
        {
            string nome = string.Empty; // TODO: Inicializar com um valor apropriado
            Jogador target = new Jogador(nome); // TODO: Inicializar com um valor apropriado
            string expected = string.Empty; // TODO: Inicializar com um valor apropriado
            string actual;
            actual = target.getNome();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verificar a exatidão deste método de teste.");
        }

        /// <summary>
        ///Um teste para getVitorias
        ///</summary>
        [TestMethod()]
        public void getVitoriasTest()
        {
            string nome = string.Empty; // TODO: Inicializar com um valor apropriado
            Jogador target = new Jogador(nome); // TODO: Inicializar com um valor apropriado
            int expected = 0; // TODO: Inicializar com um valor apropriado
            int actual;
            actual = target.getVitorias();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verificar a exatidão deste método de teste.");
        }

        /// <summary>
        ///Um teste para setNome
        ///</summary>
        [TestMethod()]
        public void setNomeTest()
        {
            string nome = string.Empty; // TODO: Inicializar com um valor apropriado
            Jogador target = new Jogador(nome); // TODO: Inicializar com um valor apropriado
            string nome1 = string.Empty; // TODO: Inicializar com um valor apropriado
            target.setNome(nome1);
            Assert.Inconclusive("Um método que não retorna um valor não pode ser verificado.");
        }

        /// <summary>
        ///Um teste para toString
        ///</summary>
        [TestMethod()]
        public void toStringTest()
        {
            string nome = string.Empty; // TODO: Inicializar com um valor apropriado
            Jogador target = new Jogador(nome); // TODO: Inicializar com um valor apropriado
            string expected = string.Empty; // TODO: Inicializar com um valor apropriado
            string actual;
            actual = target.toString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verificar a exatidão deste método de teste.");
        }
    }
}

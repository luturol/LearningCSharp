using Jogo_da_Velha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JogoDaVelhaTest
{
    
    
    /// <summary>
    ///Esta é uma classe de teste para TabuleiroTest e pretende
    ///conter todos os Testes de Unidade de TabuleiroTest
    ///</summary>
    [TestClass()]
    public class TabuleiroTest
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
        ///Um teste para Tabuleiro Construtor
        ///</summary>
        [TestMethod()]
        public void TabuleiroConstructorTest()
        {
            Tabuleiro target = new Tabuleiro();
            Assert.Inconclusive("TODO: Implemente código para verificar destino");
        }

        /// <summary>
        ///Um teste para getJogadasDisponiveis
        ///</summary>
        [TestMethod()]
        public void getJogadasDisponiveisTest()
        {
            Tabuleiro target = new Tabuleiro(); // TODO: Inicializar com um valor apropriado
            int expected = 0; // TODO: Inicializar com um valor apropriado
            int actual;
            actual = target.getJogadasDisponiveis();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verificar a exatidão deste método de teste.");
        }

        /// <summary>
        ///Um teste para populaTabuleiro
        ///</summary>
        [TestMethod()]
        public void populaTabuleiroTest()
        {
            Tabuleiro target = new Tabuleiro(); // TODO: Inicializar com um valor apropriado
            target.populaTabuleiro();
            Assert.Inconclusive("Um método que não retorna um valor não pode ser verificado.");
        }

        /// <summary>
        ///Um teste para setJogadasDisponiveis
        ///</summary>
        [TestMethod()]
        public void setJogadasDisponiveisTest()
        {
            Tabuleiro target = new Tabuleiro(); // TODO: Inicializar com um valor apropriado
            int jogadas = 0; // TODO: Inicializar com um valor apropriado
            target.setJogadasDisponiveis(jogadas);
            Assert.Inconclusive("Um método que não retorna um valor não pode ser verificado.");
        }

        /// <summary>
        ///Um teste para toString
        ///</summary>
        [TestMethod()]
        public void toStringTest()
        {
            Tabuleiro target = new Tabuleiro(); // TODO: Inicializar com um valor apropriado
            string expected = string.Empty; // TODO: Inicializar com um valor apropriado
            string actual;
            actual = target.toString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verificar a exatidão deste método de teste.");
        }

        /// <summary>
        ///Um teste para verificaJogada
        ///</summary>
//        [TestMethod()]
//        public void verificaJogadaTest()
//        {
//            Tabuleiro target = new Tabuleiro(); // TODO: Inicializar com um valor apropriado
//            bool expected = false; // TODO: Inicializar com um valor apropriado
//            bool actual;
//            actual = target.verificaJogada();
//            Assert.AreEqual(expected, actual);
//            Assert.Inconclusive("Verificar a exatidão deste método de teste.");
//        }
    }
}

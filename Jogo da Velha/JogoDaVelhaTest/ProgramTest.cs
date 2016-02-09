using Jogo_da_Velha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JogoDaVelhaTest
{
    
    
    /// <summary>
    ///Esta é uma classe de teste para ProgramTest e pretende
    ///conter todos os Testes de Unidade de ProgramTest
    ///</summary>
    [TestClass()]
    public class ProgramTest
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
        ///Um teste para mostraTabuleiro
        ///</summary>
//        [TestMethod()]
//        [DeploymentItem("Jogo da Velha.exe")]
//        public void mostraTabuleiroTest()
//        {
//           Tabuleiro_Accessor tabuleiro = null; // TODO: Inicializar com um valor apropriado
//            Program_Accessor.mostraTabuleiro(tabuleiro);
//            Assert.Inconclusive("Um método que não retorna um valor não pode ser verificado.");
//        }
    }
}

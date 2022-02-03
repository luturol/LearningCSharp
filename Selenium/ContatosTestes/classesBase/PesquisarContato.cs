using System.Collections.Generic;
using OpenQA.Selenium;
using Selenium;

namespace ContatosTestes.classesBase
{
    public class PesquisarContato
    {
        private IWebDriver webDriver;

        public PesquisarContato()
        {
            webDriver = Driver.GetInstance();
        }

        public List<string> PesquisarContatoPorNome(ContatoDTO contatoDTO)
        {
            webDriver.Wait(By.Id("nomeFiltro"));
            webDriver.SetValue(By.Id("nomeFiltro"), contatoDTO.Nome);
           
            webDriver.ClickButton(By.Name("btnFiltrar"));

            return webDriver.GetTableValues(By.Id("tabelaId"));
        }

        public string PesquisarContatoPorNomePosDelete(ContatoDTO contatoDTO)
        {
            webDriver.Wait(By.Id("nomeFiltro"));
            webDriver.SetValue(By.Id("nomeFiltro"), contatoDTO.Nome);
           
            webDriver.ClickButton(By.Name("btnFiltrar"));

            webDriver.Wait(By.ClassName("alert"));

            return webDriver.GetValue(By.ClassName("alert"));
        }
    }
}
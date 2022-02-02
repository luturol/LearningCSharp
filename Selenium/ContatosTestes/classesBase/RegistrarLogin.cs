using ContatosTestes.classesBase;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using Selenium;

namespace ContatosTestes.classesBase
{
    public class RegistrarLogin : BaseClass
    {
        public RegistrarLogin(IConfiguration configuration, Browser browser) : base(configuration, browser)
        {

        }

        public string RegistrarUsuario(string email, string senha)
        {
            var by = By.Id("RegistrarId");
            webDriver.Wait(by);
            webDriver.ClickButton(by);

            webDriver.Wait(By.XPath("/html/body/div/main/div/div/form/h4"));

            webDriver.SetValue(By.Id("Input_Email"), email);
            webDriver.SetValue(By.Id("Input_Password"), senha);
            webDriver.SetValue(By.Id("Input_ConfirmPassword"), senha);

            webDriver.SubmitButton(By.ClassName("btn"));

            webDriver.Wait(By.Id("confirm-link"));
            webDriver.ClickButton(By.Id("confirm-link"));

            webDriver.Wait(By.LinkText("Logar"));
            webDriver.ClickButton(By.LinkText("Logar"));

            webDriver.Wait(By.Id("Input_Email"));
            webDriver.SetValue(By.Id("Input_Email"), email);
            webDriver.SetValue(By.Id("Input_Password"), senha);
            webDriver.ClickButton(By.Id("Input_RememberMe"));

            webDriver.SubmitButton(By.ClassName("btn"));

            webDriver.Wait(By.Id("UserIdentityEmailId"));
            
            return webDriver.GetValue(By.Id("UserIdentityEmailId"));
        }
    }
}
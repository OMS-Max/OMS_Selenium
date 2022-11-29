using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OMS_Selenium;

public class LoginPreAuthOP
{
    public const string page_url = "https://www2.oms-app.com/users/pre_authorisations/new";
    public const string email_address = "max.harrison@oxfordmedicalsimulation.com";
    public By email_field = By.Id("session_email");
    public By continue_button = By.Name("commit");
    
    
    IWebDriver _driver;
    IWebElement element;
    public LoginPreAuthOP(IWebDriver drv)
    {
        _driver = drv;
    }

    public LoginPreAuthOP LoadPage()
    {
        _driver.Navigate().GoToUrl(page_url);
        System.Threading.Thread.Sleep(2000);
        return this;
    }

        public LoginPreAuthOP EnterEmail()
    {
        _driver.FindElement(email_field).Click();
        element.SendKeys(email_address);
        return this;
    }

    public LoginPreAuthOP Submit()
    {
        _driver.FindElement(continue_button).Click();
        return this;
    }
}
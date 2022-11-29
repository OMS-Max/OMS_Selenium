using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OMS_Selenium;



public class Tests
{
    IWebDriver _driver;

    

    [OneTimeSetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();
    }

    [Test]
    public void Test1()
    {
        LoginPreAuthOP loginPreAuthOP = new LoginPreAuthOP(_driver).LoadPage().EnterEmail().Submit();
        Assert.Pass();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _driver.Close();
    }
}
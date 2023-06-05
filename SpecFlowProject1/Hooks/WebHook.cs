using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();

           
        }


        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
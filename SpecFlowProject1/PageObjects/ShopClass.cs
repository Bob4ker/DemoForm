using OpenQA.Selenium;
using SpecFlowProject1.Hooks;

namespace SpecFlowProject1.PageObjects
{

    public class ShopClass
    {
        public IWebDriver driver ;
        public ShopClass()
        {
            driver = WebHook.driver;
        }
        private string url = "https://demoqa.com/automation-practice-form";
        private IWebElement woodenBlinds => driver.FindElement(By.XPath("//span[normalize-space()='Wooden Blinds']"));
        private IWebElement acceptCookies => driver.FindElement(By.XPath("//span[contains(@class,'cookieConsent--standOut__button')]"));
        private IWebElement firstName => driver.FindElement(By.XPath("//*[@id=\"firstName\"]"));
        private IWebElement lastName => driver.FindElement(By.XPath("//*[@id=\"lastName\"]"));
        private IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
        private IWebElement selectGender => driver.FindElement(By.XPath("//*[@id=\"genterWrapper\"]/div[2]/div[1]/label"));
        private IWebElement mobileNumber => driver.FindElement(By.XPath("//*[@id=\"userNumber\"]"));
        private IWebElement dateOfBirth => driver.FindElement(By.XPath("//*[@id=\"dateOfBirthInput\"]"));
        private IWebElement selectHobbies  => driver.FindElement(By.XPath("//*[@id=\"hobbiesWrapper\"]/div[2]/div[1]/label"));
        private IWebElement fileForPicture => driver.FindElement(By.XPath("//input[@id='uploadPicture']"));
        private IWebElement currentAddress => driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        private IWebElement selectState => driver.FindElement(By.XPath("//div[contains(text(),'Select State')]"));
        private IWebElement selectCity => driver.FindElement(By.XPath("//div[@id='stateCity-wrapper']//div[3]"));
        private IWebElement submitButton => driver.FindElement(By.XPath("//button[@id='submit']"));




        public void NavigateToURl()
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
        public void SelectWoodenBlinds()
        {
            if (driver.FindElement(By.XPath("//div[@class='cookieConsent cookieConsent--standOut show']")).Displayed)
            {
                acceptCookies.Click();
            }
            woodenBlinds.Click();
        }


        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterFirstName(string ray)
        {
            firstName.SendKeys(ray);
        }

        public void EnterLastName(string bob)
        {
            lastName.SendKeys(bob);
        }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void SelectGender()
        {
            selectGender.Click();
        }

        public void EnterMobileNumber(string number)
        {
            mobileNumber.SendKeys(number);
        }


        public void EnterDateOfBirth(string bdate)
        {
            dateOfBirth.SendKeys(bdate);
        }

        public void SelectHobbies()
        {
            selectHobbies.Click();
        }

        public void ChooseFileForPicture()
        {
            fileForPicture.Click();
        }

        public void EnterCurrentAddress(string address)
        {
            currentAddress.SendKeys(address);
        }

        public void SelectState()
        {
            selectState.Click();
        }
       
        public void SelectCity()
        {
            selectCity.Click();
        }

        public void ClickSubmitButton()
        {
            submitButton.Click();
        }

        public bool DemoqaRegistrationPageIsDisplayed()
        {
            return driver.Url.Contains("https://demoqa.com/automation-practice-form");
        }

    }
}

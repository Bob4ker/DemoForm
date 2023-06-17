using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Hooks;
using System.Security.Cryptography.X509Certificates;

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
        private object selectDay;

        public ShopClass(object selectDay)
        {
            this.selectDay = selectDay;
        }

        private object dateOfBirth;

        private IWebElement woodenBlinds => driver.FindElement(By.XPath("//span[normalize-space()='Wooden Blinds']"));
        private IWebElement acceptCookies => driver.FindElement(By.XPath("//span[contains(@class,'cookieConsent--standOut__button')]"));
        private IWebElement firstName => driver.FindElement(By.XPath("//*[@id=\"firstName\"]"));
        private IWebElement lastName => driver.FindElement(By.XPath("//*[@id=\"lastName\"]"));
        private IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
        private IWebElement selectGender => driver.FindElement(By.XPath("//*[@id=\"genterWrapper\"]/div[2]/div[1]/label"));
        private IWebElement mobileNumber => driver.FindElement(By.XPath("//*[@id=\"userNumber\"]"));
        private IWebElement dateOfBirthButton => driver.FindElement(By.XPath("//*[@id=\"dateOfBirthInput\"]"));
        private IWebElement selectYear => driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
        private IWebElement selectMonth => driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
        private IWebElement selectDay30 => driver.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[2]/div[5]/div[6]"));
        //private IWebElement selectDay30th => driver.FindElement(By.CssSelector("#dateOfBirth > div.react-datepicker__tab-loop > div.react-datepicker-popper > div > div > div.react-datepicker__month-container > div.react-datepicker__month > div:nth-child(5) > div.react-datepicker__day.react-datepicker__day--030"));
        //private IWebElement enterSubject => driver.FindElement(By.CssSelector(".subjects-auto-complete__value-container.subjects-auto-complete__value-container--is-multi.css-1hwfws3"));

        //private IWebElement selectHobbies  => driver.FindElement(By.XPath("//label[normalize-space()='Music']"));
        //private IWebElement fileForPicture => driver.FindElement(By.XPath("//input[@id='uploadPicture']"));
        //private IWebElement currentAddress => driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        //private IWebElement selectState => driver.FindElement(By.XPath("//div[contains(text(),'Select State')]"));
        //private IWebElement selectCity => driver.FindElement(By.XPath("//div[@id='stateCity-wrapper']//div[3]"));
        //private IWebElement submitButton => driver.FindElement(By.XPath("//button[@id='submit']"));




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

        public void EnterFirstName(string firstname)
        {
            firstName.SendKeys(firstname);
        }

        public void EnterLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void SelectGender()
        {
            selectGender.Click();
        }

        //public void EnterSubject(string subject)
        //{
        //    enterSubject.SendKeys(subject);
        //}

        public void EnterMobileNumber(string number)
        {
            mobileNumber.SendKeys(number);
        }

        public void ClickDateOfBirthButton()
        {
            dateOfBirthButton.Click();
        }
        //{
        //    dateOfBirth.Click();
        //    dateOfBirth.Clear();
        //    dateOfBirth.SendKeys(bdate);
        //}

        public void EnterDOB(string year, string month, string day)
        {
            //dateOfBirth.Click();
            //dateOfBirth.Clear();
            SelectElement select = new SelectElement(selectYear);
            select.SelectByValue(year);
            
            SelectElement select1 = new SelectElement(selectMonth);
            select1.SelectByIndex(10);


            //SelectElement select1 = SelectElement(selectMonth);
            //select1.SelectByValue(month);

            SelectElement select2 = new SelectElement(selectDay30);
            select2.SelectByText(day);
            
            
           

            //SelectElement select2 = new SelectElement(selectDay);
            //select2.SelectByValue(day);
            //selectDay.Click();
            //selectDay.SendKeys(day);
        }


        //public void SelectMonth(string month)
        //{
        //    selectMonth.SendKeys(month);
        //}


        //public void EnterSubjectAs(string tester)
        //{
        //    enterSubject.SendKeys(tester);
        //}



        //public void SelectHobbies()
        //{
        //    selectHobbies.Click();
        //}

        //public void ChooseFileForPicture()
        //{
        //    fileForPicture.Click();
        //}

        //public void EnterCurrentAddress(string address)
        //{
        //    currentAddress.SendKeys(address);
        //}

        //public void SelectState()
        //{
        //    selectState.Click();
        //}

        //public void SelectCity()
        //{
        //    selectCity.Click();
        //}

        //public void ClickSubmitButton()
        //{
        //    submitButton.Click();
        //}

        //public bool DemoqaRegistrationPageIsDisplayed()
        //{
        //    return driver.Url.Contains("https://demoqa.com/automation-practice-form");
        //}

    }

    public class DatePickerPage
    {
        private IWebDriver driver;

        public DatePickerPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}

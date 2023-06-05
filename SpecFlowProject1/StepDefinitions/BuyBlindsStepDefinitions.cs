using OpenQA.Selenium;
using SpecFlowProject1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BuyBlindsStepDefinitions
    {
        ShopClass shopClass = new ShopClass();
        //Login_Class login_Class = new Login_Class();


        [Given(@"I am on the website ""([^""]*)""")]
        public void GivenIAmOnTheWebsite(string url)
        {
            shopClass.NavigateToUrl(url);
        }

        [When(@"I enter firstname ""([^""]*)""")]
        public void WhenIEnterFirstname(string ray)
        {
            shopClass.EnterFirstName(ray);
        }

        [When(@"I enter lastname ""([^""]*)""")]
        public void WhenIEnterLastname(string bob)
        {
            shopClass.EnterLastName(bob);
        }

        [When(@"I enter email address ""([^""]*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            shopClass.EnterEmailAddress(email);
        }

        [When(@"I enter mobile number ""([^""]*)""")]
        public void WhenIEnterMobileNumber(string number)
        {
            shopClass.EnterMobileNumber(number);
        }

        [When(@"I enter date of birth ""([^""]*)""")]
        public void WhenIEnterDateOfBirth(string bdate)
        {
            shopClass.EnterDateOfBirth(bdate);
        }


        [When(@"I enter current address ""([^""]*)""")]
        public void WhenIEnterCurrentAddress(string address)
        {
            shopClass.EnterCurrentAddress(address);
        }


        [When(@"I select gender")]
        public void WhenISelectGender()
        {
            shopClass.SelectGender();
        }


        [When(@"I enter click to select hobbies")]
        public void WhenIEnterClickToSelectHobbies()
        {
            shopClass.SelectHobbies();
        }

        [When(@"I choose file for picture")]
        public void WhenIChooseFileForPicture()
        {
            shopClass.ChooseFileForPicture();
        }

      

        [When(@"I select state")]
        public void WhenISelectState()
        {
            shopClass.SelectState();
        }

        [When(@"I select city")]
        public void WhenISelectCity()
        {
            shopClass.SelectCity();
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            shopClass.ClickSubmitButton();
        }

        [Then(@"demoqa registration page is diplayed")]
        public void ThenDemoqaRegistrationPageIsDiplayed()
        {
            throw new PendingStepException();
        }






    }
}

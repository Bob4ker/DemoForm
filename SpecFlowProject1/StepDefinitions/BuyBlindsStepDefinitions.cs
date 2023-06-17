using FluentAssertions;
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
        public void WhenIEnterFirstname(string firstname)
        {
            shopClass.EnterFirstName(firstname);
        }

        [When(@"I enter lastname ""([^""]*)""")]
        public void WhenIEnterLastname(string lastname)
        {
            shopClass.EnterLastName(lastname);
        }

        [When(@"I enter email address ""([^""]*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            shopClass.EnterEmailAddress(email);
        }


        [When(@"I select gender")]
        public void WhenISelectGender()
        {
            shopClass.SelectGender();
        }




        [When(@"I enter mobile number ""([^""]*)""")]
        public void WhenIEnterMobileNumber(string number)
        {
            shopClass.EnterMobileNumber(number);
        }

      

        [When(@"I click date of birth button")]
        public void WhenIClickDateOfBirthButton()
        {
            shopClass.ClickDateOfBirthButton();
        }


        [When(@"I enter dob as ""([^""]*)"", ""([^""]*)"", ""([^""]*)"",""")]
        public void WhenIEnterDobAs(string year, string month, string day)
        {
            shopClass.EnterDOB(year, month, day);
        }


        //[When(@"I enter subject as ""([^""]*)""")]
        //public void WhenIEnterSubjectAs(string tester)
        //{
        //    shopClass.EnterSubjectAs(tester);
        //}


        //[When(@"I enter current address ""([^""]*)""")]
        //public void WhenIEnterCurrentAddress(string address)
        //{
        //    shopClass.EnterCurrentAddress(address);
        //}



        //[When(@"I enter click to select hobbies")]
        //public void WhenIEnterClickToSelectHobbies()
        //{
        //    shopClass.SelectHobbies();
        //}

        //[When(@"I choose file for picture")]
        //public void WhenIChooseFileForPicture()
        //{
        //    shopClass.ChooseFileForPicture();
        //}



        //[When(@"I select state")]
        //public void WhenISelectState()
        //{
        //    shopClass.SelectState();
        //}

        //[When(@"I select city")]
        //public void WhenISelectCity()
        //{
        //    shopClass.SelectCity();
        //}

        //[When(@"I click submit button")]
        //public void WhenIClickSubmitButton()
        //{
        //    shopClass.ClickSubmitButton();
        //}

        //[Then(@"demoqa registration page is diplayed")]
        //public void ThenDemoqaRegistrationPageIsDiplayed()
        //{
        //    throw new PendingStepException();
        //}






    }
}

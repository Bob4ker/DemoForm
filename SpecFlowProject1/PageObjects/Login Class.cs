using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.PageObjects
{
    public class Login_Class
    {
        public IWebDriver driver;
        public Login_Class()
        {
            driver = WebHook.driver;
        }

        public string name = "Chris";

        public void NameOfAStudent()
        {
            Console.WriteLine(name);
        }
    }
}

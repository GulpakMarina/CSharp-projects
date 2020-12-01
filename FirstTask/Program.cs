using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{

  
    class Program
    {
        SignInUpPage signPage;

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void SetUp()
        {
            signPage = new SignInUpPage();
        }

        [Test]
        public void TestSingIn()
        {
            
            signPage.SignInUp.Click();

            signPage.Email.SendKeys("gulpakmarina@gmail.com");
            signPage.Pass.SendKeys("lenovo13");

            signPage.Wait.Until(ExpectedConditions.ElementToBeClickable(signPage.SignIn));
            signPage.SignIn.Click();
        }

        [TearDown]
        public void TearDown()
        {
            signPage.Diver.Close();
        }

    }
}

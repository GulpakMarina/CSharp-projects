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
    class SignInUpPage
    {
        public IWebDriver Diver { get; private set; }
        public WebDriverWait Wait { get; private set; }

        public SignInUpPage()
        {
            Diver = new ChromeDriver();
            Diver.Navigate().GoToUrl("https://eventsexpress-qa.azurewebsites.net/home/events?page=1");
            PageFactory.InitElements(Diver, this);
            Wait = new WebDriverWait(Diver, TimeSpan.FromSeconds(10));
        }

        [FindsBy(How = How.CssSelector, Using = ".mt-5 > span")]
        public IWebElement SignInUp { get; private set; }

        [FindsBy(How = How.CssSelector, Using = ".MuiDialog-root [name=\"email\"]")]
        public IWebElement Email { get; private set; }

        [FindsBy(How = How.CssSelector, Using = ".MuiDialog-root [name=\"password\"]")]
        public IWebElement Pass { get; private set; }

        [FindsBy(How = How.CssSelector, Using = ".MuiDialogActions-root [value=\"Login\"]")]
        public IWebElement SignIn { get; private set; }
    }
}

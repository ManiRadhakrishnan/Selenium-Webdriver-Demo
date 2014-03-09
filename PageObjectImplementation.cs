using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAutomation
{
    class PearsonHomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText , Using = "Primary")]
        public IWebElement primaryLink;

        [FindsBy(How = How.LinkText, Using = "Secondary")]
        public IWebElement secondaryLink;

        [FindsBy(How = How.LinkText, Using = "Further Education")]
        public IWebElement furtherEducationLink;


        public PearsonHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void clickPrimaryLink()
        {
            primaryLink.Click();
        }
    }
  }
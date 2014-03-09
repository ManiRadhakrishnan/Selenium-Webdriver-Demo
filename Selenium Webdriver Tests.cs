using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace TestAutomation
{
    [TestFixture]
    public class Driver
    {
        IWebDriver driver;

        [TestFixtureSetUp]
        public void SetUp()
        {
            //Navigate to the site
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://uk.pearson.com/");
           
        }

        [TestFixtureTearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }


         [Test, Description("Launch Pearson and verify Home page is displayed")]
        public void Test001_LaunchPearson()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.LinkText("About us"));
            });
            
             String title = driver.Title;
            Assert.AreEqual("Home : Pearson UK", title);
            driver.Manage().Window.Maximize();
        }



        [Test, Description("Test the about Home page is displayed")]
        public void Test002_AboutUS()
        {
            //Navigate to the site
            bool IsElementPresent;
            driver.FindElement(By.LinkText("About us")).Click();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.CssSelector(".title > h1:nth-child(1)"));
            });
            IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);
            driver.FindElement(By.LinkText("The Pearson Group")).Click();
            IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);
            driver.FindElement(By.LinkText("Contact us")).Click();
            IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);

            driver.FindElement(By.LinkText("Media")).Click();
            IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);

            driver.FindElement(By.LinkText("News")).Click();
            IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);

        }


        [Test, Description("Test the Primary page is displayed properly")]
        public void Test003_PrimaryTab()
        {
            bool IsElementPresent;
            PearsonHomePage homepage = new PearsonHomePage(driver);
            homepage.clickPrimaryLink();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Welcome to Pearson Primary')]")).Displayed;
            Assert.True(IsElementPresent);
            IsElementPresent = driver.FindElement(By.LinkText("Find your local consultant")).Displayed;
            Assert.True(IsElementPresent);
        }

        [Test, Description("Test the Secondary page is displayed properly")]
        public void Test004_SecondryTab()
        {   
            bool IsElementPresent;
            PearsonHomePage homepage = new PearsonHomePage(driver);
            homepage.secondaryLink.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Improving teaching and learning for all')]")).Displayed;
            Assert.True(IsElementPresent);
            IsElementPresent = driver.FindElement(By.LinkText("Qualifications and specifications")).Displayed;
            Assert.True(IsElementPresent);
            
        }

        [Test, Description("Test if Further Education page is displayed properly")]
        public void Test005_FurtherEducaionTab()
        {
            bool IsElementPresent;
            PearsonHomePage homepage = new PearsonHomePage(driver);
            homepage.furtherEducationLink.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            //IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(4) > h2:nth-child(1) > b:nth-child(1)")).Displayed;
            IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Going further for Further Education')]")).Displayed;
            Assert.True(IsElementPresent);

        }

        [Test, Description("Test if Higher Education page is displayed properly")]
        public void Test006_HigherEducaionTab()
        {
            bool IsElementPresent;
            driver.FindElement(By.LinkText("Higher Education")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Breakthrough to a new world of learning')]")).Displayed;
            //IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(3) > h2:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);
            IsElementPresent = driver.FindElement(By.LinkText("training and support")).Displayed;
            Assert.True(IsElementPresent);
            
        }
        
        [Test, Description("Test if All other Tab-Pages are displayed properly")]
        public void Test007_OtherTabs()
        {
            bool IsElementPresent;
            driver.FindElement(By.LinkText("Work Based Learning")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Learning at work')]")).Displayed;
            //IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(3) > h2:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);
            IsElementPresent = driver.FindElement(By.LinkText("register online")).Displayed;
            Assert.True(IsElementPresent);


            driver.FindElement(By.LinkText("Professional")).Click();
           // IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(3) > h2:nth-child(1) > b:nth-child(1)")).Displayed;
            IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'A lifetime of learning')]")).Displayed;
            Assert.True(IsElementPresent);
            IsElementPresent = driver.FindElement(By.LinkText("Customer services")).Displayed;
            Assert.True(IsElementPresent);


            driver.FindElement(By.LinkText("Shop")).Click();
            IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;
            Assert.True(IsElementPresent);
        }

        [Test, Description("Test if Search is working fine")]
        public void Test008_Search()
        {
            bool IsElementPresent;
            
            driver.FindElement(By.CssSelector("#headsearch > input:nth-child(1)")).SendKeys("Invalid Search Text");
            driver.FindElement(By.CssSelector("#headsearch > input:nth-child(2)")).Submit();

            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.Id("search-results"));
            });
            
            IsElementPresent = driver.FindElement(By.Id("search-results")).Displayed;
            Assert.True(IsElementPresent);
            driver.FindElement(By.LinkText("Home")).Click();

        }

        [Test, Description("Test if Online Services link is working fine")]
        public void Test009_OnlineServices()
        {
            bool IsElementPresent;
            string originalHandle = driver.CurrentWindowHandle;

            driver.FindElement(By.CssSelector("a.cboxElement")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            driver.FindElement(By.CssSelector(".services > ul:nth-child(2) > li:nth-child(3) > a:nth-child(3)")).Click();
            
            //driver.FindElement(By.Id("elementThatOpensChildWindow")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            string popupHandle = string.Empty;
            ICollection<string> windowHandles = driver.WindowHandles;

            foreach (string handle in windowHandles)
            {
                if (handle != originalHandle)
                {
                    popupHandle = handle; break;
                }
            }

            //switch to new window 

            driver.SwitchTo().Window(popupHandle);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            String title1 = driver.Title;
            Assert.AreEqual("Active Learn: Login", title1);

            driver.FindElement(By.Name("Close this message")).Click();

            driver.FindElement(By.Id("username")).SendKeys("Mrkrishna84");
            driver.FindElement(By.Id("password")).SendKeys("invalid");
            driver.FindElement(By.Id("schcode")).SendKeys("321");
            driver.FindElement(By.Id("login-submit")).Click();

            //driver.FindElement(By.CssSelector("#login-form > p:nth-child(1) > div:nth-child(3)"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            IsElementPresent = driver.FindElement(By.ClassName("form_warning")).Displayed;
            Assert.True(IsElementPresent);

            driver.Close();
            
            driver.SwitchTo().Window(originalHandle);

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            driver.FindElement(By.Id("cboxClose")).Click();
            
        }


    }
}

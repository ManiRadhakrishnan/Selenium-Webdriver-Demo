{\rtf1\ansi\ansicpg1252\cocoartf1265
{\fonttbl\f0\fswiss\fcharset0 ArialMT;}
{\colortbl;\red255\green255\blue255;\red26\green26\blue26;\red16\green60\blue192;\red255\green255\blue193;
}
\paperw11900\paperh16840\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\deftab720
\pard\pardeftab720

\f0\fs26 \cf2 using System;\
using System.Collections.Generic;\
using System.Linq;\
using System.Text;\
using System.Drawing;\
using NUnit.Framework;\
using OpenQA.Selenium;\
using OpenQA.Selenium.Firefox;\
using OpenQA.Selenium.Chrome;\
using {\field{\*\fldinst{HYPERLINK "http://openqa.selenium.ie/"}}{\fldrslt \cf3 \ul \ulc3 OpenQA.Selenium.IE}};\
using OpenQA.Selenium.Support.UI;\
\
\
namespace TestAutomation\
\{\
\'a0 \'a0 [TestFixture]\
\'a0 \'a0 public class Driver\
\'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 IWebDriver driver;\
\
\'a0 \'a0 \'a0 \'a0 [TestFixtureSetUp]\
\'a0 \'a0 \'a0 \'a0 public void SetUp()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //Navigate to the site\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver = new FirefoxDriver();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Navigate().GoToUrl("{\field{\*\fldinst{HYPERLINK "http://uk.pearson.com/"}}{\fldrslt \cf3 \ul \ulc3 http://uk.\cf2 \cb4 \ulnone pearson\cf3 \cb1 \ul .com/}}");\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\
\'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 [TestFixtureTearDown]\
\'a0 \'a0 \'a0 \'a0 public void CloseBrowser()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Close();\
\'a0 \'a0 \'a0 \'a0 \}\
\
\
\'a0 \'a0 \'a0 \'a0 \'a0[Test, Description("Launch \cb4 Pearson\cb1  and verify Home page is displayed")]\
\'a0 \'a0 \'a0 \'a0 public void Test001_LaunchPearson()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 return d.FindElement(By.LinkText("About us"));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \});\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0String title = driver.Title;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.AreEqual("Home : \cb4 Pearson\cb1  UK", title);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Window.Maximize();\
\'a0 \'a0 \'a0 \'a0 \}\
\
\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test the about Home page is displayed")]\
\'a0 \'a0 \'a0 \'a0 public void Test002_AboutUS()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //Navigate to the site\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("About us")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 return d.FindElement(By.CssSelector(".title > h1:nth-child(1)"));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \});\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("The \cb4 Pearson\cb1  Group")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Contact us")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Media")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("News")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\'a0 \'a0 \'a0 \'a0 \}\
\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test the Primary page is displayed properly")]\
\'a0 \'a0 \'a0 \'a0 public void Test003_PrimaryTab()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 PearsonHomePage homepage = new PearsonHomePage(driver);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 homepage.clickPrimaryLink();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Welcome to \cb4 Pearson\cb1  Primary')]")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.LinkText("Find your local consultant")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test the Secondary page is displayed properly")]\
\'a0 \'a0 \'a0 \'a0 public void Test004_SecondryTab()\
\'a0 \'a0 \'a0 \'a0 \{ \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 PearsonHomePage homepage = new PearsonHomePage(driver);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 homepage.secondaryLink.Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Improving teaching and learning for all')]")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.LinkText("Qualifications and specifications")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test if Further Education page is displayed properly")]\
\'a0 \'a0 \'a0 \'a0 public void Test005_FurtherEducaionTab()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 PearsonHomePage homepage = new PearsonHomePage(driver);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 homepage.furtherEducationLink.Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(4) > h2:nth-child(1) > b:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Going further for Further Education')]")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test if Higher Education page is displayed properly")]\
\'a0 \'a0 \'a0 \'a0 public void Test006_HigherEducaionTab()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Higher Education")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Breakthrough to a new world of learning')]")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(3) > h2:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.LinkText("training and support")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \}\
\'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test if All other Tab-Pages are displayed properly")]\
\'a0 \'a0 \'a0 \'a0 public void Test007_OtherTabs()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Work Based Learning")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'Learning at work')]")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(3) > h2:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.LinkText("register online")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Professional")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0// IsElementPresent = driver.FindElement(By.CssSelector("div.text:nth-child(3) > h2:nth-child(1) > b:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.XPath("//*[contains(text(), 'A lifetime of learning')]")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.LinkText("Customer services")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Shop")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.CssSelector(".title > h1:nth-child(1)")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test if Search is working fine")]\
\'a0 \'a0 \'a0 \'a0 public void Test008_Search()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.CssSelector("#headsearch > input:nth-child(1)")).SendKeys("Invalid Search Text");\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.CssSelector("#headsearch > input:nth-child(2)")).Submit();\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 return d.FindElement(By.Id("search-results"));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \});\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.Id("search-results")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.LinkText("Home")).Click();\
\
\'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 [Test, Description("Test if Online Services link is working fine")]\
\'a0 \'a0 \'a0 \'a0 public void Test009_OnlineServices()\
\'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 bool IsElementPresent;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 string originalHandle = driver.CurrentWindowHandle;\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.CssSelector("a.cboxElement")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.CssSelector(".services > ul:nth-child(2) > li:nth-child(3) > a:nth-child(3)")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //driver.FindElement(By.Id("elementThatOpensChildWindow")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 string popupHandle = string.Empty;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 ICollection<string> windowHandles = driver.WindowHandles;\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 foreach (string handle in windowHandles)\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 if (handle != originalHandle)\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \{\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 popupHandle = handle; break;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \}\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 \}\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //switch to new window\'a0\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.SwitchTo().Window(popupHandle);\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 String title1 = driver.Title;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.AreEqual("Active Learn: Login", title1);\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.Name("Close this message")).Click();\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.Id("username")).SendKeys("Mrkrishna84");\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.Id("password")).SendKeys("invalid");\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.Id("schcode")).SendKeys("321");\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.Id("login-submit")).Click();\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 //driver.FindElement(By.CssSelector("#login-form > p:nth-child(1) > div:nth-child(3)"));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 IsElementPresent = driver.FindElement(By.ClassName("form_warning")).Displayed;\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 Assert.True(IsElementPresent);\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Close();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.SwitchTo().Window(originalHandle);\
\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0 driver.FindElement(By.Id("cboxClose")).Click();\
\'a0 \'a0 \'a0 \'a0 \'a0 \'a0\'a0\
\'a0 \'a0 \'a0 \'a0 \}\
\
\
\'a0 \'a0 \}\
\}\
\
}
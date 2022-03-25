using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Certifaction_Test
{
    internal class Scenarioone
    {
     
 
        public class CERTBase
        {
            IWebDriver driver;

            [Test]
            public void Scenario1()
            {

                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(300));
                driver.Url = ("https://www.lambdatest.com/selenium-playground/");
                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement SimpleFormDemo = driver.FindElement(By.XPath("//div[1]/section[2]/div/div/div[1]/div[1]/ul/li[1]/a")); SimpleFormDemo.Click();
                WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                String expectedurlsimpleformdemo = driver.Url;
                Assert.AreEqual(expectedurlsimpleformdemo, "https://www.lambdatest.com/selenium-playground/simple-form-demo","Url are matching");
                string Expectedmessage = "Welcome to LambdaTest";
                IWebElement EnterMessage = driver.FindElement(By.Id("user-message"));
                EnterMessage.SendKeys("Welcome to LambdaTest");
                WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement GetCheckValuebutton = driver.FindElement(By.Id("showInput"));
                GetCheckValuebutton.Click();
                WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement CheckmsgIscorrect = driver.FindElement(By.Id("message"));
                String Actualmessage=CheckmsgIscorrect.Text;
                WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                Assert.AreEqual(Expectedmessage, Actualmessage, "Correct Message in Right Section");
                WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                driver.Close();
            }

       
               
        }
    }

}



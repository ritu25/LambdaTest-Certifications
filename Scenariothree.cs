using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Certifaction_Test
{
    internal class Scenariothree
    {
     
 
        public class CERTBase
        {
            IWebDriver driver;

            [Test]
            public void Scenario3()
            {

                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(300));
                driver.Url = ("https://www.lambdatest.com/selenium-playground");
                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Inputformsubmit = driver.FindElement(By.XPath("//div[1]/section[2]/div/div/div[1]/div[1]/ul/li[5]/a")); Inputformsubmit.Click();
                WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
                //IWebElement Submitblank = driver.FindElement(By.XPath("//button[@type='submit']")); Submitblank.Click();
                IWebElement Submit = driver.FindElement(By.XPath("//button[@type='submit']")); Submit.Click();
                WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Firstname = driver.FindElement(By.Id("name"));
                Firstname.SendKeys("Tester");
                WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Email = driver.FindElement(By.Id("inputEmail4"));
                Email.SendKeys("tester@email.com");
                WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Password = driver.FindElement(By.Id("inputPassword4"));
                Password.SendKeys("testerpassword");
                WebDriverWait wait6= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Company = driver.FindElement(By.Id("company"));
                Company.SendKeys("Automation Pty");
                WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Website = driver.FindElement(By.Id("websitename"));
                Website.SendKeys("www.tester.com");
                WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Country = driver.FindElement(By.Name("country"));
                Country.SendKeys("United States");
                WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement City = driver.FindElement(By.Id("inputCity"));
                City.SendKeys("New York");
                WebDriverWait wait10= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Address1 = driver.FindElement(By.Id("inputAddress1"));
                Address1.SendKeys("22");
                WebDriverWait wait11= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Address2 = driver.FindElement(By.Id("inputAddress2"));
                Address2.SendKeys("Wanderland");
                WebDriverWait wait12= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement State = driver.FindElement(By.Id("inputState"));
                State.SendKeys("CS");
                WebDriverWait wait13= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement ZIPCode = driver.FindElement(By.Id("inputZip"));
                ZIPCode.SendKeys("0000");
                 WebDriverWait wait14= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement Submitbutton= driver.FindElement(By.XPath("//button[@type='submit']")); Submitbutton.Click();
                String SuccessMessage = driver.FindElement(By.XPath("//div[1]/section[3]/div/div/div[2]/div/p")).Text;
                String ExpectedMessage = "Thanks for contacting us, we will get back to you shortly.";
                WebDriverWait wait15= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                Assert.AreEqual(SuccessMessage, ExpectedMessage, "Correct Slider Value");
                WebDriverWait wait16= new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                driver.Close();
            }

            
        }
    }

}



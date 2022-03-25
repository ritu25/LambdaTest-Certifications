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
    internal class Scenariotwo
    {
     
 
        public class CERTBase
        {
            IWebDriver driver;

            [Test]
            public void Scenario2()
            {

                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(300));
                driver.Url = ("https://www.lambdatest.com/selenium-playground");
                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                IWebElement DragandDropSliders = driver.FindElement(By.XPath("//div[1]/section[2]/div/div/div[1]/div[2]/ul/li[3]/a")); DragandDropSliders.Click();
                WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
               // IWebElement sliderfifteen = driver.FindElement(By.CssSelector("sp__range-success > .sp__range"));
                WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                //Actions builder = new Actions(driver);
                //IWebElement from = driver.FindElement(By.XPath("//input[@value='15']"));
                //IWebElement to = driver.FindElement(By.XPath("//input[@value='95']"));
                //builder.DragAndDrop(from, to).Perform();
                DragandDropSliders.SendKeys("95");
                String Actuavalue = driver.FindElement(By.XPath("//input[@value='95']")).Text;
                WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                Assert.AreEqual(95, Actuavalue, "Correct Slider Value");
                WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
                driver.Close();
            }

            
        }
    }

}



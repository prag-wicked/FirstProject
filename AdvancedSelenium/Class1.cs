using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AdvancedSelenium
{
    
    public class Class1
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://toolsqa.com/";

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("camera");           
          
            driver.FindElement(By.ClassName("nav-input")).Click();

            
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var imagesLink = wait.Until(d =>
           {
               var elements = driver.FindElements(By.ClassName("s-access-image cfMarker"));
               if (elements.Count > 0)
                   return elements[0];
               return null;
           });

            imagesLink.Click();
        }
    }
}

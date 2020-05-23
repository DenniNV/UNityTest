using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;

namespace Selenium_WebTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("q")).SendKeys("unit testing" + Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.CssSelector("cite"));
            var results = driver.FindElements(By.CssSelector("cite"));
            if(results.Any(result => result.Text.Contains("en.wikipedia.org › wiki › Unit_testing")))
            {
                driver.Navigate().GoToUrl("http://en.wikipedia.org");
                driver.FindElement(By.Name("search")).SendKeys("NUnit"+Keys.Enter);
            }
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Unit_testing");
            results = driver.FindElements(By.CssSelector("a"));
            if(results.Any(result => result.Text.Contains("Русский")))
            {
                Console.WriteLine("Job done!");
            }
        }
    }
}

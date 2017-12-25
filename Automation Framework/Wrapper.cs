using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation_Framework
{
    public class WebDriverWrapper : IDisposable
    {
        private IWebDriver webdriver;
        private WebDriverWait wait;
        private long defaultTimeoutInSec;

        public WebDriverWrapper()
        {
            defaultTimeoutInSec = 10;
            webdriver = new ChromeDriver();
            wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(defaultTimeoutInSec));
        }

        public void Dispose()
        {
            webdriver.Close();
            webdriver.Quit();
        }

        public void Click(By by)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            webdriver.FindElement(by).Click();
        }

        public void OpenPage(string baseUrl)
        {
            webdriver.Navigate().GoToUrl(baseUrl);
        }

        public string GetUrl()
        {
            return webdriver.Url;
        }

        public string GetTitle()
        {
            return webdriver.Title;
        }

        public void Type(By by, string text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            webdriver.FindElement(by).SendKeys(text);
        }
    }
}

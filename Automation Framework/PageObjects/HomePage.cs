using OpenQA.Selenium;

namespace Automation_Framework.PageObjects
{
    class HomePage
    {
        protected WebDriverWrapper webdriver;
        protected string baseUrl = "http://www.quizful.net/";
        protected By enterLink = By.XPath("//*[contains(text(),'войти')]");

        public HomePage(WebDriverWrapper webdriver)
        {
            this.webdriver = webdriver;
        }

        public HomePage Open()
        {
            webdriver.OpenPage(baseUrl);
            return new HomePage(webdriver);
        }

        public void ClickEnter()
        {

            webdriver.Click(enterLink);
        }
    }
}

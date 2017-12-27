using OpenQA.Selenium;

namespace Automation_Framework.PageObjects
{
    class HomePage : BasePageObject
    {
        protected By enterLink = By.XPath("//*[contains(text(),'войти')]");
        protected By enterBlockTitle = By.XPath("//div[@id='login-form']/div[@class='title']");

        public HomePage(WebDriverWrapper webdriver) : base(webdriver)
        {
            PageUrl = "http://www.quizful.net/";
        }

        public void ClickOnEnterLink()
        {
            webdriver.Click(enterLink);
        }

    }
}

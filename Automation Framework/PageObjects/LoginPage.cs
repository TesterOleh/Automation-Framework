using OpenQA.Selenium;

namespace Automation_Framework.PageObjects
{
    class LoginPage : BasePageObject
    {
        protected By usernameField = By.XPath("//input[@id='login']");
        protected By passwordField = By.XPath("//input[@type='password']");
        protected By enterButton = By.XPath("//input[@type='submit']");
        protected By exitLink = By.XPath("//a[text()='выйти']");

        public LoginPage(WebDriverWrapper webdriver) : base(webdriver)
        {
            PageUrl = "http://www.quizful.net/LoginAction.loginForm";
        }

        public LoginPage EnterUsername(string username)
        {
            webdriver.Type(usernameField,username);
            return new LoginPage(webdriver);
        }

        public LoginPage EnterPassword(string password)
        {
            webdriver.Type(passwordField,password);
            return new LoginPage(webdriver);
        }

        public LoginPage ClickEnterButton()
        {
            webdriver.Click(enterButton);
            return new LoginPage(webdriver);
        }

        public bool IsLoggedIn()
        {
            return webdriver.IsElementDisplayed(exitLink);
        }
    }
}

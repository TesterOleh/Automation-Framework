using Automation_Framework.PageObjects;
using Automation_Framework.Tests;
using NUnit.Framework;

namespace Automation_Framework
{
    class LoginTest : BaseTest
    { 
        [Test]
        public void Login()
        {
            HomePage home = new HomePage(webdriver);

            home.Open();
            Assert.AreEqual("http://www.quizful.net/test", webdriver.GetUrl());
            Assert.AreEqual("Quizful - тесты онлайн", webdriver.GetTitle());

            home.ClickOnEnterLink();
            Assert.AreEqual("http://www.quizful.net/LoginAction.loginForm", webdriver.GetUrl());

            LoginPage login = new LoginPage(webdriver);
            login.EnterUsername("temp0").EnterPassword("temp0").ClickEnterButton();
            Assert.AreEqual(login.IsLoggedIn(),true);
        }

    }
}

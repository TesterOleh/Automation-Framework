using Automation_Framework.PageObjects;
using Automation_Framework.Tests;
using NUnit.Framework;

namespace Automation_Framework
{
    class Login : BaseTest
    { 
        [Test]
        public void LoginTest()
        {
            HomePage home = new HomePage(webdriver);
            home.Open().ClickEnter();


 
        }

    }
}

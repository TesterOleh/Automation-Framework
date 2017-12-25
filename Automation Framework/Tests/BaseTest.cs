using NUnit.Framework;

namespace Automation_Framework.Tests
{
    [TestFixture]
    class BaseTest
    {
        public WebDriverWrapper webdriver;

        [SetUp]
        public void Setup()
        {
            webdriver = new WebDriverWrapper();
        }

        [TearDown]
        public void TearDown()
        {
            webdriver.Dispose();
        }
    }
}

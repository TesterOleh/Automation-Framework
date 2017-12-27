namespace Automation_Framework.PageObjects
{
    class BasePageObject
    {
        protected WebDriverWrapper webdriver;
        private string pageUrl { get; set; }

        protected string PageUrl
        {
            get => pageUrl;
            set => pageUrl = value;
        }

        protected BasePageObject(WebDriverWrapper webdriver)
        {
            this.webdriver = webdriver;
        }

        public BasePageObject Open()
        {
            webdriver.OpenPage(pageUrl);
            return new BasePageObject(webdriver);
        }
    }
}

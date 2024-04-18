using OpenQA.Selenium;

namespace Sharp_UI_Tests
{
    public class AbstractPage
    {

        IWebDriver driver;
        ApplicationManager manager;

        public AbstractPage(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}

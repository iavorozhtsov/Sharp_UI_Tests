using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Sharp_UI_Tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;

        protected LoginPage loginPage;

        private static string baseUrl = "http://localhost:5000";
        private static string loginUrl = baseUrl + "/login";
        private static string signUpUrl = baseUrl + "/signup";
        private static string profileUrl = baseUrl + "/profile";
        private static string warningMessage = "Please check your login details and try again.";

        public ApplicationManager()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");

            driver = new ChromeDriver(options);
            
            loginPage = new LoginPage(this);


        }

        public IWebDriver Driver
        { 
            get
            {
                return driver;
            } 
        }

        public LoginPage Auth
        {
            get
            {
                return loginPage;
            }
        }

        public void Close()
        {
           // if (driver != null) driver.Quit();
        }

        public static string GetLoginUrl()
        {
            return loginUrl;
        }

        public static string GetWarningMessage()
        {
            return warningMessage;
        }
    }
}
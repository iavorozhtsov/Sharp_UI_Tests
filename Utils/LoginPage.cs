using OpenQA.Selenium;

namespace Sharp_UI_Tests
{
    public class LoginPage
    {
        ApplicationManager manager;
        
        private IWebElement fieldEmail;
        private IWebElement fieldPassword;
        private IWebElement buttonLogin;
        private IWebElement warning;
        public LoginPage(ApplicationManager manager)
        {
            this.manager = manager;
        }

        public LoginPage OpenLoginPage()
        {
            manager.Driver.Url = ApplicationManager.GetLoginUrl();
            
            return this;
        }

        public LoginPage Login(Account account)
        {
            manager.Driver.FindElement(By.LinkText("Login")).Click();
            fieldEmail = manager.Driver.FindElement(By.Name("email"));
            fieldEmail.Click();
            fieldEmail.SendKeys(account.GetUserName());

            fieldPassword = manager.Driver.FindElement(By.Name("password"));
            fieldPassword.Click();
            fieldPassword.SendKeys(account.GetPassword());
            buttonLogin = manager.Driver.FindElement(By.CssSelector(".button"));
            buttonLogin.Click();

            return this;
        }

        public string GetWarningMessage()
        {
            string s = null;

            if (manager.Driver.FindElements(By.ClassName("notification")).Count > 0)
            {
                warning = manager.Driver.FindElements(By.ClassName("notification"))[0];
                s = warning.Text;
            }

            return s;
        }
    }
}
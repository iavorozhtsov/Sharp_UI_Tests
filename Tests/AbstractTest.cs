using NUnit.Framework;

namespace Sharp_UI_Tests
{
    public class AbstractTests
    {

        protected ApplicationManager app;
        
        public AbstractTests()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void TearDown()
        {
            app.Close();
        }
    }
}
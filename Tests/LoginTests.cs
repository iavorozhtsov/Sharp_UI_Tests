using NUnit.Framework;


namespace Sharp_UI_Tests
{
    [TestFixture]
    class LoginTests : AbstractTests
    {
        
        public LoginTests()
        {
            app.Auth.OpenLoginPage();
        }

        [SetUp]
        public void Init() 
        {
            
        }
        
        [Test]
        public void ValidLoginTest()
        {
            app.Auth.Login(new Account("1234", "John", "4321"));
        }

        [Test]
        public void InvalidLoginTest()
        {
            app.Auth.Login(new Account("1234@432", "John", "4321"));
            Assert.AreEqual(app.Auth.GetWarningMessage(), app.Auth.GetWarningMessage());
        }
    }
}

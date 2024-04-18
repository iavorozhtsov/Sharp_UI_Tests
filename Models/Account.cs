namespace Sharp_UI_Tests
{
    public class Account
    {
        private string userName;
        private string name;
        private string password;

        public Account(string userName, string name, string password)
        {
            this.userName = userName;
            this.name = name;
            this.password = password;
        }

        public string GetUserName()
        {
            return userName;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}
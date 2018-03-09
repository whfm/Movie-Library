using System;

namespace Login_Data
{
    [Serializable]
    public partial class LoginData
    {
        private string username;
        private string passwordhint;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string PasswordHint
        {
            get { return passwordhint; }
            set { passwordhint = value; }
        }

        private string password;

        public LoginData()
        {
            this.password = "pass";
            this.username = "username";
            this.passwordhint = "hint";
        }
        public LoginData(string username, string password, string passwordhint)
        {
            this.passwordhint = passwordhint;
            this.username = username;
            this.password = password;
        }
        public override String ToString()
        {
            String state;
            state = this.username + "|" + this.password + "|" + this.passwordhint;
            return state;
        }
    }
}

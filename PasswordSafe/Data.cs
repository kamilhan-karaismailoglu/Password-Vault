using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class Data
    {
        private string title;
        private string url;
        private string username;
        private string password;
        private string passwordLast1;
        private string passwordLast2;
        private string passwordLast3;
        private string updateTime;

        public string Title { get => title; set => title = value; }
        public string Url { get => url; set => url = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string PasswordLast1 { get => passwordLast1; set => passwordLast1 = value; }
        public string PasswordLast2 { get => passwordLast2; set => passwordLast2 = value; }
        public string PasswordLast3 { get => passwordLast3; set => passwordLast3 = value; }
        public string UpdateTime { get => updateTime; set => updateTime = value; }
    }
}

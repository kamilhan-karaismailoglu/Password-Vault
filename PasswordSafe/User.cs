using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class User
    {
        private string username;
        private string email;
        private string password;
        public static string err = "Email and Password Does Not Mach!";

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }   

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(err,"Error");
        }

        public static bool Isequal(User user1, User user2)
        {
            if (user1==null || user2==null)
            {
                return false;
            }

            if (user1.password != user2.password)
            {
                return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace PasswordVault
{
    public partial class LoginPage : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "18IVcO9yPkdVhQ5BHb8gqi3APblryPNGrHwrV01g",
            BasePath = "https://passwordsafe-645a9-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;
        public static readonly string a = "Us3Rs";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void UsernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"' || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }

        Form registerPage = new RegisterPage();
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            registerPage.ShowDialog();
        }
   
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                if (passwordTxt.Text != String.Empty && emailTxt.Text != String.Empty)
                {
                    FirebaseResponse res = client.Get(@MD5Encryption(a) + "/" + MD5Encryption(emailTxt.Text));
                    User resUser = res.ResultAs<User>();
                    User curUser = new User() { Email = MD5Encryption(emailTxt.Text), Password = MD5Encryption(passwordTxt.Text) };

                    if (User.Isequal(resUser, curUser))
                    {
                        Form homePage = new HomePage(passwordTxt.Text, emailTxt.Text,resUser.Username);
                        this.Hide();
                        homePage.ShowDialog();
                    }
                    else
                    {
                        User.ShowError();
                    }
                }
                else
                {
                    MessageBox.Show("Make Sure You Fill In All Fields", "Error");
                }
            }
            catch
            {
                MessageBox.Show("No Inernet or Conneciton Problem", "Error");
            }  
        }

        private string MD5Encryption(string encryptionText)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(encryptionText);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();

            foreach (byte ba in array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        private void ShowLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (passwordTxt.PasswordChar != '\0')
            {
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                passwordTxt.PasswordChar = '·';
            }
        }
    }
}
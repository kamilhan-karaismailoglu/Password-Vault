using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net.Mail;
using System.Security.Cryptography;
using Firebase.Database;
using Firebase.Database.Query;
using System.IO;


namespace PasswordVault
{
    public partial class RegisterPage : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "18IVcO9yPkdVhQ5BHb8gqi3APblryPNGrHwrV01g",
            BasePath = "https://passwordsafe-645a9-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void PasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"' || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }

        private void UsernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"' || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }

        private void RegisterPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            usernameTxt.Clear();
            emailTxt.Clear();
            passwordTxt.Clear();
            passwordAgainTxt.Clear();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                if (passwordTxt.Text != String.Empty && passwordAgainTxt.Text != String.Empty && usernameTxt.Text != String.Empty && emailTxt.Text != String.Empty)
                {
                    if (passwordTxt.Text != passwordAgainTxt.Text)
                    {
                        MessageBox.Show("Make Sure You Enter The Same Password", "Error");
                    }
                    else
                    {
                        if (!CheckEmailFormat(emailTxt.Text))
                        {
                            MessageBox.Show("Check Your Email Address", "Error");
                        }
                        else
                        {
                            if (usernameTxt.Text.Length >= 3)
                            {
                                if (passwordTxt.Text.Length >= 8)
                                {
                                    if (CheckEmail(MD5Encryption(emailTxt.Text)))
                                    {
                                        Cryption c = new Cryption();
                                        User newUser = new User
                                        {
                                            Email = MD5Encryption(emailTxt.Text),
                                            Username = c.EncryptText(usernameTxt.Text, passwordTxt.Text),
                                            Password = MD5Encryption(passwordTxt.Text)
                                        };

                                        SetResponse set = client.Set(@MD5Encryption(LoginPage.a) + "/" + MD5Encryption(emailTxt.Text), newUser);

                                        Data emptyData = new Data
                                        {
                                            Title = "",
                                            Url = "",
                                            Username = "",
                                            Password = "",
                                            PasswordLast1 = "",
                                            PasswordLast2 = "",
                                            PasswordLast3 = "",
                                        };
                                        SetResponse set2 = client.Set(@MD5Encryption(emailTxt.Text) + "/" + "emptyData", emptyData);

                                        MessageBox.Show("Registration Successful! Please Login", "Info");
                                        usernameTxt.Clear();
                                        emailTxt.Clear();
                                        passwordTxt.Clear();
                                        passwordAgainTxt.Clear();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email Previously Registered", "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password Must Be At Least 8 Characters", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username Must Be At Least 3 Characters", "Error");
                            }
                        }
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

        private bool CheckEmailFormat(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
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

        private bool CheckEmail(string email)
        {
            string firebaseDatabaseUrl = "https://passwordsafe-645a9-default-rtdb.firebaseio.com";
            string firebaseDatabaseSecret = "18IVcO9yPkdVhQ5BHb8gqi3APblryPNGrHwrV01g";

            var firebaseClient = new FirebaseClient( firebaseDatabaseUrl,
                                                            new FirebaseOptions
                                                            {
                                                                AuthTokenAsyncFactory = () => Task.FromResult(firebaseDatabaseSecret)
                                                            });


            var query = firebaseClient.Child(MD5Encryption(LoginPage.a)).OrderByKey().EqualTo(email).OnceAsync<object>();
                    var queryResult = query.Result;

                    if (queryResult.Count > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }   
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (passwordAgainTxt.PasswordChar != '\0')
            {
                passwordAgainTxt.PasswordChar = '\0';
            }
            else
            {
                passwordAgainTxt.PasswordChar = '·';
            }
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

        private void passwordAgainTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"' || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }
    }
}

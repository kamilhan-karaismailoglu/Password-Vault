using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
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

namespace PasswordVault
{
    public partial class SavePage : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "18IVcO9yPkdVhQ5BHb8gqi3APblryPNGrHwrV01g",
            BasePath = "https://passwordsafe-645a9-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;

        static Cryption c = new Cryption();

        public SavePage()
        {
            InitializeComponent();
        }
    
        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTxt.Text != String.Empty && titleTxt.Text != String.Empty && usernameTxt.Text != String.Empty && urlTxt.Text != String.Empty)
                {                   
                   if (titleTxt.Text.Length>=3)
                   {
                        var searchResult = await SearchInDatabase(c.EncryptText(titleTxt.Text, HomePage.Key));

                        if (!searchResult.Contains(c.EncryptText(titleTxt.Text, HomePage.Key)))
                        {
                            await Insert();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Title Previously Registered", "Error");
                        }
                   }
                    else
                    {
                        MessageBox.Show("Title Must Be At Least 3 Characters", "Error");
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

        private void SavePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            titleTxt.Clear();
            urlTxt.Clear();
            usernameTxt.Clear();
            passwordTxt.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void PasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"' || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
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

        private async Task<List<string>> SearchInDatabase(string searchTerm)
        {
            var resultList = new List<string>();

            client = new FireSharp.FirebaseClient(ifc);

            FirebaseResponse response = await client.GetAsync(MD5Encryption(HomePage.Email));
            var result = response.Body;
            var data = JsonConvert.DeserializeObject<Dictionary<string, Data>>(result);

            foreach (var item in data)
            {
                string d = item.Value.Title;
                resultList.Add(d);
            }

            return resultList;
        }
         
        private async Task Insert()
        {
            var newData = new Data
            {
                Title = c.EncryptText(titleTxt.Text, HomePage.Key),
                Url = c.EncryptText(urlTxt.Text, HomePage.Key),
                Username = c.EncryptText(usernameTxt.Text, HomePage.Key),
                Password = c.EncryptText(passwordTxt.Text, HomePage.Key),
                PasswordLast1 = "",
                PasswordLast2 = "",
                PasswordLast3 = "",
                UpdateTime = c.EncryptText(DateTime.Now.ToString(), HomePage.Key)
            };

            SetResponse response = await client.SetAsync(MD5Encryption(HomePage.Email)+"/"+c.EncryptText(titleTxt.Text, HomePage.Key), newData);
            Data result = response.ResultAs<Data>();

            if (result.Title != null)
            {
                MessageBox.Show("Registration Successful!", "Info");
            }                
            else
            {
                MessageBox.Show("Registration Failed!", "Error");
            }
        }
    }
}
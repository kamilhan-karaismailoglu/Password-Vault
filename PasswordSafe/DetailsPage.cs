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
using static PasswordVault.PasswordStrengthChecker;

namespace PasswordVault
{
    public partial class DetailsPage : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "18IVcO9yPkdVhQ5BHb8gqi3APblryPNGrHwrV01g",
            BasePath = "https://passwordsafe-645a9-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;

        static Cryption c = new Cryption();
        static Data data;
        static Data newData = null;

        public DetailsPage(string title)
        {
            InitializeComponent();

            client = new FireSharp.FirebaseClient(ifc);
            FirebaseResponse res = client.Get(@MD5Encryption(HomePage.Email) + "/" + title);

            data = res.ResultAs<Data>();

            titleTxt.Text = c.DecryptText(data.Title, HomePage.Key);
            usernameTxt.Text = c.DecryptText(data.Username, HomePage.Key);
            urlTxt.Text = c.DecryptText(data.Url, HomePage.Key);
            passwordTxt.Text = c.DecryptText(data.Password, HomePage.Key);

            this.Text = "Details: " + c.DecryptText(data.Title, HomePage.Key);
            UpdateTimeLbl.Text = "Last Update Time: " + c.DecryptText(data.UpdateTime, HomePage.Key);

            if (data.PasswordLast1 != "")
            {
                passwordLast1Txt.Text = c.DecryptText(data.PasswordLast1, HomePage.Key);
                Similiar1Lbl.Text = GenerateSimiliar(c.DecryptText(data.Password, HomePage.Key), c.DecryptText(data.PasswordLast1, HomePage.Key)).ToString("0.000");
            }
            if (data.PasswordLast2 != "")
            {
                passwordLast2Txt.Text = c.DecryptText(data.PasswordLast2, HomePage.Key);
                Similiar2Lbl.Text = GenerateSimiliar(c.DecryptText(data.Password, HomePage.Key), c.DecryptText(data.PasswordLast2, HomePage.Key)).ToString("0.000");
            }
            if (data.PasswordLast3 != "")
            {
                passwordLast3Txt.Text = c.DecryptText(data.PasswordLast3, HomePage.Key);
                Similiar3Lbl.Text = GenerateSimiliar(c.DecryptText(data.Password, HomePage.Key), c.DecryptText(data.PasswordLast3, HomePage.Key)).ToString("0.000");
            }
            GeneratePasswordRate(c.DecryptText(data.Password, HomePage.Key));
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

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                if (passwordTxt.Text != String.Empty && usernameTxt.Text != String.Empty && urlTxt.Text != String.Empty)
                {
                    if (c.EncryptText(titleTxt.Text,HomePage.Key) != data.Title)
                    {
                        if (titleTxt.Text.Length>=3)
                        {
                            var searchResult = await SearchInDatabase(c.EncryptText(titleTxt.Text, HomePage.Key));

                            if (!searchResult.Contains(c.EncryptText(titleTxt.Text, HomePage.Key)))
                            {
                                newData = null;
                                if (c.EncryptText(passwordTxt.Text, HomePage.Key) == data.Password)
                                {
                                    newData = new Data
                                    {
                                        Title = c.EncryptText(titleTxt.Text, HomePage.Key),
                                        Url = c.EncryptText(urlTxt.Text, HomePage.Key),
                                        Username = c.EncryptText(usernameTxt.Text, HomePage.Key),
                                        Password = c.EncryptText(passwordTxt.Text, HomePage.Key),
                                        PasswordLast1 = c.EncryptText(passwordLast1Txt.Text, HomePage.Key),
                                        PasswordLast2 = c.EncryptText(passwordLast2Txt.Text, HomePage.Key),
                                        PasswordLast3 = c.EncryptText(passwordLast3Txt.Text, HomePage.Key),
                                        UpdateTime = c.EncryptText(DateTime.Now.ToString(), HomePage.Key)
                                    };
                                }
                                else
                                {
                                    newData = new Data
                                    {
                                        Title = c.EncryptText(titleTxt.Text, HomePage.Key),
                                        Url = c.EncryptText(urlTxt.Text, HomePage.Key),
                                        Username = c.EncryptText(usernameTxt.Text, HomePage.Key),
                                        Password = c.EncryptText(passwordTxt.Text, HomePage.Key),
                                        PasswordLast1 = data.Password,
                                        PasswordLast2 = data.PasswordLast1,
                                        PasswordLast3 = data.PasswordLast2,
                                        UpdateTime = c.EncryptText(DateTime.Now.ToString(), HomePage.Key)
                                    };
                                }
                                await DeleteOldData(data.Title);
                                bool result = await InsertNewData(newData);
                                if (result)
                                {
                                    MessageBox.Show("Registration Successful!", "Info");
                                }
                                else
                                {
                                    MessageBox.Show("Registration Failed!", "Error");
                                }
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
                        if (c.EncryptText(passwordTxt.Text, HomePage.Key) == data.Password)
                        {
                            newData = new Data
                            {
                                Title = c.EncryptText(titleTxt.Text, HomePage.Key),
                                Url = c.EncryptText(urlTxt.Text, HomePage.Key),
                                Username = c.EncryptText(usernameTxt.Text, HomePage.Key),
                                Password = c.EncryptText(passwordTxt.Text, HomePage.Key),
                                PasswordLast1 = c.EncryptText(passwordLast1Txt.Text, HomePage.Key),
                                PasswordLast2 = c.EncryptText(passwordLast2Txt.Text, HomePage.Key),
                                PasswordLast3 = c.EncryptText(passwordLast3Txt.Text, HomePage.Key),
                                UpdateTime = c.EncryptText(DateTime.Now.ToString(), HomePage.Key)
                            };
                        }
                        else
                        {
                            newData = new Data
                            {
                                Title = c.EncryptText(titleTxt.Text, HomePage.Key),
                                Url = c.EncryptText(urlTxt.Text, HomePage.Key),
                                Username = c.EncryptText(usernameTxt.Text, HomePage.Key),
                                Password = c.EncryptText(passwordTxt.Text, HomePage.Key),
                                PasswordLast1 = data.Password,
                                PasswordLast2 = data.PasswordLast1,
                                PasswordLast3 = data.PasswordLast2,
                                UpdateTime = c.EncryptText(DateTime.Now.ToString(), HomePage.Key)
                            };
                        }

                        if (!(newData.Title==data.Title 
                            && newData.Password==data.Password
                            && newData.Url==data.Url 
                            && newData.PasswordLast1 == data.PasswordLast1 
                            && newData.PasswordLast2== data.PasswordLast2 
                            && newData.PasswordLast3 == data.PasswordLast3
                            && newData.Username == data.Username))
                        {
                            await DeleteOldData(data.Title);
                            bool result = await InsertNewData(newData);
                            if (result)
                            {
                                MessageBox.Show("Registration Successful!", "Info");
                            }
                            else
                            {
                                MessageBox.Show("Registration Failed!", "Error");
                            }
                            this.Close();
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

        private void PasswordLast3Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"' || e.KeyChar == Convert.ToChar("'"))
            {
                e.Handled = true;
            }
        }

        private double GenerateSimiliar(string str1, string str2)
        {
            List<string> bigram1 = new List<string>();
            List<string> bigram2 = new List<string>();

            for (int i = 1; i < str1.Length; i++)
            {
                if (str1[i].ToString() != " " && bigram1.Contains(str1[i - 1].ToString() + str1[i].ToString()) == false)
                {
                    bigram1.Add(str1[i - 1].ToString() + str1[i].ToString());
                }
                else if (str1[i].ToString() == " " && bigram1.Contains("_" + str1[i + 1].ToString()) == false && bigram1.Contains(str1[i - 1].ToString() + "_") == false)
                {
                    bigram1.Add(str1[i - 1].ToString() + "_");
                    bigram1.Add("_" + str1[i + 1].ToString());
                    i++;
                }
            }

            for (int i = 1; i < str2.Length; i++)
            {
                if (str2[i].ToString() != " " && bigram2.Contains(str2[i - 1].ToString() + str2[i].ToString()) == false)
                {
                    bigram2.Add(str2[i - 1].ToString() + str2[i].ToString());
                }
                else if (str2[i].ToString() == " " && bigram2.Contains("_" + str2[i + 1].ToString()) == false && bigram2.Contains(str2[i - 1].ToString() + "_") == false)
                {
                    bigram2.Add(str2[i - 1].ToString() + "_");
                    bigram2.Add("_" + str2[i + 1].ToString());
                    i++;
                }
            }

            List<string> intersection = new List<string>();

            foreach (var item in bigram1)
            {
                foreach (var item2 in bigram2)
                {
                    if (item == item2)
                    {
                        intersection.Add(item);
                    }
                }
            }

            var difference1 = bigram1.Except(bigram2).ToList();
            var difference2 = bigram2.Except(bigram1).ToList();

            int intersectionCount = intersection.Count; 
            int f1 = difference1.Count;              
            int f2 = difference2.Count;              

            double coefficient1=0.5;
            double coefficient2=0.5;

            double formul = intersectionCount / (intersectionCount + (coefficient1 * f1) + (coefficient2 * f2));   

            return formul;
        }

        private void GeneratePasswordRate(string pwd)
        {
            PasswordStrengthChecker checker = new PasswordStrengthChecker();

            int score = checker.GeneratePasswordScore(pwd);
            PasswordStrength strength;
            strength = checker.GetPasswordStrength(pwd);
            passwordRateLbl.Text =score.ToString()+" - " +strength.ToString(); ;
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
    
        private async Task<bool> InsertNewData(Data newData)
        {
            SetResponse response = await client.SetAsync(MD5Encryption(HomePage.Email) + "/" + newData.Title, newData);
            Data result = response.ResultAs<Data>();

            if (result.Title != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> DeleteOldData(string dataTitle)
        {
            client = new FireSharp.FirebaseClient(ifc);
            var response = await client.DeleteAsync(MD5Encryption(HomePage.Email) + "/" + dataTitle);
            return true;
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
    }
}
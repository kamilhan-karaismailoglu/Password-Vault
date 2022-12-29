using Firebase.Database;
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
    public partial class HomePage : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "18IVcO9yPkdVhQ5BHb8gqi3APblryPNGrHwrV01g",
            BasePath = "https://passwordsafe-645a9-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;

        static public string Key;
        static public string Email;
        static string randomPassword;
        static List<Data> listData;
        static bool selected;
        static Cryption c = new Cryption();

        public HomePage(string _key, string _email, string username)
        {
            InitializeComponent();

            randomPassword = CreatePassword();
            randomPasswordLbl.Text = randomPassword;
            
            listData = new List<Data>();
            Key = _key;
            Email = _email;
            this.Text = c.DecryptText(username, Key)+"'s Password Vault";
            ListDatasAsync();

            TableGridView.RowHeadersVisible = false;
            TableGridView.RowTemplate.Height = 40;
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "";
            dgvBtn.Text = "Details";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.Width = 100;
            TableGridView.Columns.Add(dgvBtn);
            TableGridView.AllowUserToAddRows = false;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        Form savePage = new SavePage();
        private void NewDataBtn_Click(object sender, EventArgs e)
        {
            listData.Clear();
            savePage.ShowDialog();
            ListDatasAsync();
            selected = false;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            randomPassword = CreatePassword();
            randomPasswordLbl.Text = randomPassword;
            copyPasswordBtn.Enabled = true;
        }

        private string CreatePassword()
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,?!#&%=";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 27; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void CopyPasswordBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(randomPassword);
            copyPasswordBtn.Enabled = false;
        }

        private async Task ListDatasAsync()
        {   
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                TableGridView.DataSource = null;

                FirebaseResponse response = await client.GetAsync(MD5Encryption(Email));
                var result = response.Body;
                var data = JsonConvert.DeserializeObject<Dictionary<string, Data>>(result);

                foreach (var item in data)
                {
                    Data d = item.Value;

                    if (d.Title != "")
                    {
                        d.Title = c.DecryptText(item.Value.Title,Key);                        
                        d.Url = c.DecryptText(item.Value.Url,Key);                        
                        d.Username = c.DecryptText(item.Value.Username,Key);                        
                        d.Password = c.DecryptText(item.Value.Password,Key);                        
                        listData.Add(d);
                    }
                }

                TableGridView.DataSource = listData;

                TableGridView.Columns[5].Visible = false;
                TableGridView.Columns[6].Visible = false;
                TableGridView.Columns[7].Visible = false;
                TableGridView.Columns[8].Visible = false;

                TableGridView.Columns[1].Width = 180;
                TableGridView.Columns[2].Width = 215;
                TableGridView.Columns[3].Width = 150;
                TableGridView.Columns[4].Width = 150;

                TableGridView.ClearSelection();
            }
            catch
            {
                MessageBox.Show("No Inernet or Conneciton Problem", "Error");
            }
        }

        Form detailsPage;
        private void TableGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = true;
            if (e.ColumnIndex == 0)
            {
                try
                {
                    client = new FireSharp.FirebaseClient(ifc);
                    detailsPage = new DetailsPage(c.EncryptText(TableGridView.CurrentRow.Cells[1].Value.ToString(), Key));
                    detailsPage.ShowDialog();
                    listData.Clear();
                    ListDatasAsync();
                    selected = false;
                }
                catch
                {
                    MessageBox.Show("No Inernet or Conneciton Problem", "Error");
                }              
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Delete the Data?", "Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        bool result = await DeleteData(c.EncryptText(TableGridView.CurrentRow.Cells[1].Value.ToString(), Key));
                        if (result)
                        {
                            MessageBox.Show("Delete Successful!", "Info");
                            listData.Clear();
                            ListDatasAsync();
                            selected = false;
                        }  
                    }
                    catch
                    {
                        MessageBox.Show("No Inernet or Conneciton Problem", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the Data to be Deleted!", "Error");
            }
           
        }

        private async Task<bool> DeleteData(string dataTitle)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                var response = await client.DeleteAsync(MD5Encryption(Email) + "/" + dataTitle);
                return true;
            }
            catch
            {
                MessageBox.Show("No Inernet or Conneciton Problem", "Error");
                return false;
            }
        }

        private void TableGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(TableGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            TableGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Gray;

            Timer timer = new Timer();
            timer.Interval = 700;
            timer.Tick += (s, args) => { TableGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = SystemColors.ActiveCaption; timer.Stop(); };
            timer.Start();         
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

        Form login = new LoginPage();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Login Out?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                login.ShowDialog();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listData.Clear();
            ListDatasAsync();
        }
    }
}
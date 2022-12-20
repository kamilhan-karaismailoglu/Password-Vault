namespace PasswordVault
{
    partial class DetailsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsPage));
            this.showLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.urlLbl = new System.Windows.Forms.Label();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.passwordLast1Lbl = new System.Windows.Forms.Label();
            this.passwordLast1Txt = new System.Windows.Forms.TextBox();
            this.passwordLast2Lbl = new System.Windows.Forms.Label();
            this.passwordLast2Txt = new System.Windows.Forms.TextBox();
            this.passwordLast3Lbl = new System.Windows.Forms.Label();
            this.passwordLast3Txt = new System.Windows.Forms.TextBox();
            this.UpdateTimeLbl = new System.Windows.Forms.Label();
            this.Similiar1Lbl = new System.Windows.Forms.Label();
            this.Similiar2Lbl = new System.Windows.Forms.Label();
            this.Similiar3Lbl = new System.Windows.Forms.Label();
            this.similarityRatesGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordRateLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.similarityRatesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showLinkLbl
            // 
            this.showLinkLbl.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.showLinkLbl.AutoSize = true;
            this.showLinkLbl.LinkColor = System.Drawing.Color.Black;
            this.showLinkLbl.Location = new System.Drawing.Point(475, 193);
            this.showLinkLbl.Name = "showLinkLbl";
            this.showLinkLbl.Size = new System.Drawing.Size(34, 13);
            this.showLinkLbl.TabIndex = 19;
            this.showLinkLbl.TabStop = true;
            this.showLinkLbl.Text = "Show";
            this.showLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLinkLbl_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxt.Location = new System.Drawing.Point(213, 181);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '·';
            this.passwordTxt.Size = new System.Drawing.Size(246, 33);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLast3Txt_KeyPress);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLbl.Location = new System.Drawing.Point(96, 133);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(111, 26);
            this.usernameLbl.TabIndex = 22;
            this.usernameLbl.Text = "Username:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTxt.Location = new System.Drawing.Point(213, 130);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(246, 33);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLast3Txt_KeyPress);
            // 
            // urlLbl
            // 
            this.urlLbl.AutoSize = true;
            this.urlLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urlLbl.Location = new System.Drawing.Point(154, 82);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(53, 26);
            this.urlLbl.TabIndex = 21;
            this.urlLbl.Text = "URL:";
            // 
            // urlTxt
            // 
            this.urlTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urlTxt.Location = new System.Drawing.Point(213, 79);
            this.urlTxt.MaxLength = 75;
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(246, 33);
            this.urlTxt.TabIndex = 2;
            this.urlTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLast3Txt_KeyPress);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBtn.Location = new System.Drawing.Point(94, 520);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(374, 42);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // passwordLast1Lbl
            // 
            this.passwordLast1Lbl.AutoSize = true;
            this.passwordLast1Lbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLast1Lbl.Location = new System.Drawing.Point(44, 50);
            this.passwordLast1Lbl.Name = "passwordLast1Lbl";
            this.passwordLast1Lbl.Size = new System.Drawing.Size(151, 26);
            this.passwordLast1Lbl.TabIndex = 26;
            this.passwordLast1Lbl.Text = "Prior Password:";
            // 
            // passwordLast1Txt
            // 
            this.passwordLast1Txt.Enabled = false;
            this.passwordLast1Txt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLast1Txt.Location = new System.Drawing.Point(201, 47);
            this.passwordLast1Txt.MaxLength = 30;
            this.passwordLast1Txt.Name = "passwordLast1Txt";
            this.passwordLast1Txt.Size = new System.Drawing.Size(253, 33);
            this.passwordLast1Txt.TabIndex = 5;
            this.passwordLast1Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLast3Txt_KeyPress);
            // 
            // passwordLast2Lbl
            // 
            this.passwordLast2Lbl.AutoSize = true;
            this.passwordLast2Lbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLast2Lbl.Location = new System.Drawing.Point(23, 102);
            this.passwordLast2Lbl.Name = "passwordLast2Lbl";
            this.passwordLast2Lbl.Size = new System.Drawing.Size(172, 26);
            this.passwordLast2Lbl.TabIndex = 29;
            this.passwordLast2Lbl.Text = "2. Prior Password:";
            // 
            // passwordLast2Txt
            // 
            this.passwordLast2Txt.Enabled = false;
            this.passwordLast2Txt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLast2Txt.Location = new System.Drawing.Point(201, 99);
            this.passwordLast2Txt.MaxLength = 30;
            this.passwordLast2Txt.Name = "passwordLast2Txt";
            this.passwordLast2Txt.Size = new System.Drawing.Size(253, 33);
            this.passwordLast2Txt.TabIndex = 6;
            this.passwordLast2Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLast3Txt_KeyPress);
            // 
            // passwordLast3Lbl
            // 
            this.passwordLast3Lbl.AutoSize = true;
            this.passwordLast3Lbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLast3Lbl.Location = new System.Drawing.Point(23, 156);
            this.passwordLast3Lbl.Name = "passwordLast3Lbl";
            this.passwordLast3Lbl.Size = new System.Drawing.Size(172, 26);
            this.passwordLast3Lbl.TabIndex = 32;
            this.passwordLast3Lbl.Text = "3. Prior Password:";
            // 
            // passwordLast3Txt
            // 
            this.passwordLast3Txt.Enabled = false;
            this.passwordLast3Txt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLast3Txt.Location = new System.Drawing.Point(201, 153);
            this.passwordLast3Txt.MaxLength = 30;
            this.passwordLast3Txt.Name = "passwordLast3Txt";
            this.passwordLast3Txt.Size = new System.Drawing.Size(253, 33);
            this.passwordLast3Txt.TabIndex = 7;
            this.passwordLast3Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLast3Txt_KeyPress);
            // 
            // UpdateTimeLbl
            // 
            this.UpdateTimeLbl.AutoSize = true;
            this.UpdateTimeLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateTimeLbl.Location = new System.Drawing.Point(99, 577);
            this.UpdateTimeLbl.Name = "UpdateTimeLbl";
            this.UpdateTimeLbl.Size = new System.Drawing.Size(360, 26);
            this.UpdateTimeLbl.TabIndex = 33;
            this.UpdateTimeLbl.Text = "Last Update Time: 00.00.0000 00:00:00";
            this.UpdateTimeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Similiar1Lbl
            // 
            this.Similiar1Lbl.AutoSize = true;
            this.Similiar1Lbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Similiar1Lbl.Location = new System.Drawing.Point(470, 50);
            this.Similiar1Lbl.Name = "Similiar1Lbl";
            this.Similiar1Lbl.Size = new System.Drawing.Size(61, 26);
            this.Similiar1Lbl.TabIndex = 34;
            this.Similiar1Lbl.Text = "0.000";
            // 
            // Similiar2Lbl
            // 
            this.Similiar2Lbl.AutoSize = true;
            this.Similiar2Lbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Similiar2Lbl.Location = new System.Drawing.Point(470, 102);
            this.Similiar2Lbl.Name = "Similiar2Lbl";
            this.Similiar2Lbl.Size = new System.Drawing.Size(61, 26);
            this.Similiar2Lbl.TabIndex = 35;
            this.Similiar2Lbl.Text = "0.000";
            // 
            // Similiar3Lbl
            // 
            this.Similiar3Lbl.AutoSize = true;
            this.Similiar3Lbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Similiar3Lbl.Location = new System.Drawing.Point(470, 156);
            this.Similiar3Lbl.Name = "Similiar3Lbl";
            this.Similiar3Lbl.Size = new System.Drawing.Size(61, 26);
            this.Similiar3Lbl.TabIndex = 36;
            this.Similiar3Lbl.Text = "0.000";
            // 
            // similarityRatesGroupBox
            // 
            this.similarityRatesGroupBox.Controls.Add(this.passwordLast2Lbl);
            this.similarityRatesGroupBox.Controls.Add(this.Similiar3Lbl);
            this.similarityRatesGroupBox.Controls.Add(this.passwordLast1Txt);
            this.similarityRatesGroupBox.Controls.Add(this.Similiar2Lbl);
            this.similarityRatesGroupBox.Controls.Add(this.passwordLast1Lbl);
            this.similarityRatesGroupBox.Controls.Add(this.Similiar1Lbl);
            this.similarityRatesGroupBox.Controls.Add(this.passwordLast2Txt);
            this.similarityRatesGroupBox.Controls.Add(this.passwordLast3Txt);
            this.similarityRatesGroupBox.Controls.Add(this.passwordLast3Lbl);
            this.similarityRatesGroupBox.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.similarityRatesGroupBox.Location = new System.Drawing.Point(14, 293);
            this.similarityRatesGroupBox.Name = "similarityRatesGroupBox";
            this.similarityRatesGroupBox.Size = new System.Drawing.Size(553, 209);
            this.similarityRatesGroupBox.TabIndex = 37;
            this.similarityRatesGroupBox.TabStop = false;
            this.similarityRatesGroupBox.Text = "Similarity Rate Between Current And Prior Passwords";
            // 
            // passwordRateLbl
            // 
            this.passwordRateLbl.AutoSize = true;
            this.passwordRateLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordRateLbl.Location = new System.Drawing.Point(208, 233);
            this.passwordRateLbl.Name = "passwordRateLbl";
            this.passwordRateLbl.Size = new System.Drawing.Size(49, 26);
            this.passwordRateLbl.TabIndex = 38;
            this.passwordRateLbl.Text = "rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "Password Rate:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLbl.Location = new System.Drawing.Point(154, 29);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(56, 26);
            this.titleLbl.TabIndex = 41;
            this.titleLbl.Text = "Title:";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleTxt.Location = new System.Drawing.Point(213, 26);
            this.titleTxt.MaxLength = 30;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(246, 33);
            this.titleTxt.TabIndex = 40;
            // 
            // DetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 612);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordRateLbl);
            this.Controls.Add(this.similarityRatesGroupBox);
            this.Controls.Add(this.UpdateTimeLbl);
            this.Controls.Add(this.showLinkLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.urlLbl);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.UpdateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetailsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details: xxx";
            this.similarityRatesGroupBox.ResumeLayout(false);
            this.similarityRatesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel showLinkLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label passwordLast1Lbl;
        private System.Windows.Forms.TextBox passwordLast1Txt;
        private System.Windows.Forms.Label passwordLast2Lbl;
        private System.Windows.Forms.TextBox passwordLast2Txt;
        private System.Windows.Forms.Label passwordLast3Lbl;
        private System.Windows.Forms.TextBox passwordLast3Txt;
        private System.Windows.Forms.Label UpdateTimeLbl;
        private System.Windows.Forms.Label Similiar1Lbl;
        private System.Windows.Forms.Label Similiar2Lbl;
        private System.Windows.Forms.Label Similiar3Lbl;
        private System.Windows.Forms.GroupBox similarityRatesGroupBox;
        private System.Windows.Forms.Label passwordRateLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox titleTxt;
    }
}
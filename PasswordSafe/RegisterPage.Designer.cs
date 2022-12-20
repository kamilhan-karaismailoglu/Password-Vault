namespace PasswordVault
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.titleLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.passwordAgainLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordAgainTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.showLinkLbl = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Imprint MT Shadow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(118, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(209, 42);
            this.titleLbl.TabIndex = 13;
            this.titleLbl.Text = "REGISTER";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.Location = new System.Drawing.Point(130, 133);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(72, 26);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "E-Mail:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLbl.Location = new System.Drawing.Point(91, 90);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(111, 26);
            this.usernameLbl.TabIndex = 11;
            this.usernameLbl.Text = "Username:";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTxt.Location = new System.Drawing.Point(208, 130);
            this.emailTxt.MaxLength = 50;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(219, 33);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxt_KeyPress);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTxt.Location = new System.Drawing.Point(208, 87);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(219, 33);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxt_KeyPress);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SignUpBtn.Location = new System.Drawing.Point(36, 315);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(391, 42);
            this.SignUpBtn.TabIndex = 5;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // passwordAgainLbl
            // 
            this.passwordAgainLbl.AutoSize = true;
            this.passwordAgainLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordAgainLbl.Location = new System.Drawing.Point(31, 245);
            this.passwordAgainLbl.Name = "passwordAgainLbl";
            this.passwordAgainLbl.Size = new System.Drawing.Size(170, 26);
            this.passwordAgainLbl.TabIndex = 17;
            this.passwordAgainLbl.Text = "Password (Again):";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLbl.Location = new System.Drawing.Point(99, 178);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(103, 26);
            this.passwordLbl.TabIndex = 16;
            this.passwordLbl.Text = "Password:";
            // 
            // passwordAgainTxt
            // 
            this.passwordAgainTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordAgainTxt.Location = new System.Drawing.Point(208, 242);
            this.passwordAgainTxt.MaxLength = 30;
            this.passwordAgainTxt.Name = "passwordAgainTxt";
            this.passwordAgainTxt.PasswordChar = '·';
            this.passwordAgainTxt.Size = new System.Drawing.Size(219, 33);
            this.passwordAgainTxt.TabIndex = 4;
            this.passwordAgainTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordAgainTxt_KeyPress);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxt.Location = new System.Drawing.Point(208, 175);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '·';
            this.passwordTxt.Size = new System.Drawing.Size(219, 33);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTxt_KeyPress);
            // 
            // showLinkLbl
            // 
            this.showLinkLbl.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.showLinkLbl.AutoSize = true;
            this.showLinkLbl.LinkColor = System.Drawing.Color.Black;
            this.showLinkLbl.Location = new System.Drawing.Point(393, 211);
            this.showLinkLbl.Name = "showLinkLbl";
            this.showLinkLbl.Size = new System.Drawing.Size(34, 13);
            this.showLinkLbl.TabIndex = 6;
            this.showLinkLbl.TabStop = true;
            this.showLinkLbl.Text = "Show";
            this.showLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLinkLbl_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(393, 278);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 376);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.showLinkLbl);
            this.Controls.Add(this.passwordAgainLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordAgainTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.SignUpBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label passwordAgainLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordAgainTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.LinkLabel showLinkLbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
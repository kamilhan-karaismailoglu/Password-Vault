namespace PasswordVault
{
    partial class HomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.NewDataBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.randomPasswordLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copyPasswordBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.loginOutBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableGridView
            // 
            this.TableGridView.AllowUserToAddRows = false;
            this.TableGridView.AllowUserToDeleteRows = false;
            this.TableGridView.AllowUserToResizeColumns = false;
            this.TableGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TableGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableGridView.EnableHeadersVisualStyles = false;
            this.TableGridView.GridColor = System.Drawing.SystemColors.Control;
            this.TableGridView.Location = new System.Drawing.Point(18, 12);
            this.TableGridView.Margin = new System.Windows.Forms.Padding(0);
            this.TableGridView.MultiSelect = false;
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.ReadOnly = true;
            this.TableGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TableGridView.RowHeadersVisible = false;
            this.TableGridView.RowHeadersWidth = 40;
            this.TableGridView.RowTemplate.DividerHeight = 1;
            this.TableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableGridView.Size = new System.Drawing.Size(800, 460);
            this.TableGridView.TabIndex = 1;
            this.TableGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableGridView_CellClick);
            this.TableGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableGridView_CellDoubleClick);
            // 
            // NewDataBtn
            // 
            this.NewDataBtn.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewDataBtn.Location = new System.Drawing.Point(830, 61);
            this.NewDataBtn.Name = "NewDataBtn";
            this.NewDataBtn.Size = new System.Drawing.Size(278, 42);
            this.NewDataBtn.TabIndex = 3;
            this.NewDataBtn.Text = "Add New";
            this.NewDataBtn.UseVisualStyleBackColor = true;
            this.NewDataBtn.Click += new System.EventHandler(this.NewDataBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createBtn.Location = new System.Drawing.Point(6, 37);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(266, 38);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create New";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // randomPasswordLbl
            // 
            this.randomPasswordLbl.AutoSize = true;
            this.randomPasswordLbl.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomPasswordLbl.Location = new System.Drawing.Point(6, 140);
            this.randomPasswordLbl.Name = "randomPasswordLbl";
            this.randomPasswordLbl.Size = new System.Drawing.Size(138, 20);
            this.randomPasswordLbl.TabIndex = 6;
            this.randomPasswordLbl.Text = "Random Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copyPasswordBtn);
            this.groupBox1.Controls.Add(this.randomPasswordLbl);
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(830, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Strong Password";
            // 
            // copyPasswordBtn
            // 
            this.copyPasswordBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.copyPasswordBtn.Location = new System.Drawing.Point(6, 81);
            this.copyPasswordBtn.Name = "copyPasswordBtn";
            this.copyPasswordBtn.Size = new System.Drawing.Size(266, 38);
            this.copyPasswordBtn.TabIndex = 6;
            this.copyPasswordBtn.Text = "Copy Password";
            this.copyPasswordBtn.UseVisualStyleBackColor = true;
            this.copyPasswordBtn.Click += new System.EventHandler(this.CopyPasswordBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.Location = new System.Drawing.Point(830, 109);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(278, 42);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete Selected";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // loginOutBtn
            // 
            this.loginOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginOutBtn.FlatAppearance.BorderSize = 0;
            this.loginOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginOutBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loginOutBtn.Location = new System.Drawing.Point(1013, 12);
            this.loginOutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginOutBtn.Name = "loginOutBtn";
            this.loginOutBtn.Size = new System.Drawing.Size(95, 30);
            this.loginOutBtn.TabIndex = 9;
            this.loginOutBtn.Text = "Login Out";
            this.loginOutBtn.UseVisualStyleBackColor = false;
            this.loginOutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshBtn.Location = new System.Drawing.Point(901, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(98, 30);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 487);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.loginOutBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewDataBtn);
            this.Controls.Add(this.TableGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xxx\'s Password Vault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TableGridView;
        private System.Windows.Forms.Button NewDataBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label randomPasswordLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button copyPasswordBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button loginOutBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}
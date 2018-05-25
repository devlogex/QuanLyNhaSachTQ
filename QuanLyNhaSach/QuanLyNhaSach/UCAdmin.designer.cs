namespace QuanLyNhaSach
{
    partial class UCAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSearchAccount = new System.Windows.Forms.PictureBox();
            this.txbSearchAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRemoveAccount = new System.Windows.Forms.PictureBox();
            this.pbUpdateAccount = new System.Windows.Forms.PictureBox();
            this.pbAddAccount = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAccount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pbSearchAccount);
            this.panel1.Controls.Add(this.txbSearchAccount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbRemoveAccount);
            this.panel1.Controls.Add(this.pbUpdateAccount);
            this.panel1.Controls.Add(this.pbAddAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 55);
            this.panel1.TabIndex = 3;
            // 
            // pbSearchAccount
            // 
            this.pbSearchAccount.BackColor = System.Drawing.Color.Gainsboro;
            this.pbSearchAccount.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchAccount.Image")));
            this.pbSearchAccount.Location = new System.Drawing.Point(915, 14);
            this.pbSearchAccount.Name = "pbSearchAccount";
            this.pbSearchAccount.Size = new System.Drawing.Size(37, 22);
            this.pbSearchAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchAccount.TabIndex = 5;
            this.pbSearchAccount.TabStop = false;
            this.pbSearchAccount.Click += new System.EventHandler(this.pbSearchAccount_Click);
            // 
            // txbSearchAccount
            // 
            this.txbSearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchAccount.Location = new System.Drawing.Point(685, 14);
            this.txbSearchAccount.Name = "txbSearchAccount";
            this.txbSearchAccount.Size = new System.Drawing.Size(224, 22);
            this.txbSearchAccount.TabIndex = 2;
            this.txbSearchAccount.Text = "Tìm tài khoản";
            this.txbSearchAccount.TextChanged += new System.EventHandler(this.txbSearchAccount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(172, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xóa tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(90, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sửa tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm tài khoản";
            // 
            // pbRemoveAccount
            // 
            this.pbRemoveAccount.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveAccount.Image")));
            this.pbRemoveAccount.Location = new System.Drawing.Point(182, 3);
            this.pbRemoveAccount.Name = "pbRemoveAccount";
            this.pbRemoveAccount.Size = new System.Drawing.Size(56, 33);
            this.pbRemoveAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveAccount.TabIndex = 0;
            this.pbRemoveAccount.TabStop = false;
            this.pbRemoveAccount.Click += new System.EventHandler(this.pbRemoveAccount_Click);
            // 
            // pbUpdateAccount
            // 
            this.pbUpdateAccount.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdateAccount.Image")));
            this.pbUpdateAccount.Location = new System.Drawing.Point(96, 3);
            this.pbUpdateAccount.Name = "pbUpdateAccount";
            this.pbUpdateAccount.Size = new System.Drawing.Size(63, 33);
            this.pbUpdateAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdateAccount.TabIndex = 0;
            this.pbUpdateAccount.TabStop = false;
            this.pbUpdateAccount.Click += new System.EventHandler(this.pbUpdateAccount_Click);
            // 
            // pbAddAccount
            // 
            this.pbAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("pbAddAccount.Image")));
            this.pbAddAccount.Location = new System.Drawing.Point(13, 3);
            this.pbAddAccount.Name = "pbAddAccount";
            this.pbAddAccount.Size = new System.Drawing.Size(63, 33);
            this.pbAddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddAccount.TabIndex = 0;
            this.pbAddAccount.TabStop = false;
            this.pbAddAccount.Click += new System.EventHandler(this.pbAddAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(356, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách Tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvAccount);
            this.panel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 432);
            this.panel2.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.userName,
            this.passWord,
            this.displayName,
            this.type});
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersVisible = false;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(978, 432);
            this.dtgvAccount.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Tên đăng nhập";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // passWord
            // 
            this.passWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passWord.DataPropertyName = "passWord";
            this.passWord.HeaderText = "Mật khẩu";
            this.passWord.Name = "passWord";
            this.passWord.ReadOnly = true;
            // 
            // displayName
            // 
            this.displayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displayName.DataPropertyName = "displayName";
            this.displayName.HeaderText = "Tên hiển thị";
            this.displayName.Name = "displayName";
            this.displayName.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Nhóm người dùng";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // UCAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "UCAdmin";
            this.Size = new System.Drawing.Size(978, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSearchAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSearchAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRemoveAccount;
        private System.Windows.Forms.PictureBox pbUpdateAccount;
        private System.Windows.Forms.PictureBox pbAddAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}

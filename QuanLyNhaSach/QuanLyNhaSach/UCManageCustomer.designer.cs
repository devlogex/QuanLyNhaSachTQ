namespace QuanLyNhaSach
{
    partial class UCManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCManageCustomer));
            this.pbSearchCustomer = new System.Windows.Forms.PictureBox();
            this.txbSearchCustomer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvManageCustomer = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRemoveCustomer = new System.Windows.Forms.PictureBox();
            this.pbUpdateCustomer = new System.Windows.Forms.PictureBox();
            this.pbAddCustomer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbHistoryBill = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSearchCustomer
            // 
            this.pbSearchCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.pbSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchCustomer.Image")));
            this.pbSearchCustomer.Location = new System.Drawing.Point(920, 15);
            this.pbSearchCustomer.Name = "pbSearchCustomer";
            this.pbSearchCustomer.Size = new System.Drawing.Size(37, 22);
            this.pbSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchCustomer.TabIndex = 5;
            this.pbSearchCustomer.TabStop = false;
            this.pbSearchCustomer.Click += new System.EventHandler(this.pbSearchCustomer_Click);
            // 
            // txbSearchCustomer
            // 
            this.txbSearchCustomer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCustomer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchCustomer.Location = new System.Drawing.Point(690, 15);
            this.txbSearchCustomer.Name = "txbSearchCustomer";
            this.txbSearchCustomer.Size = new System.Drawing.Size(224, 23);
            this.txbSearchCustomer.TabIndex = 0;
            this.txbSearchCustomer.Text = "Tìm khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvManageCustomer);
            this.panel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 429);
            this.panel2.TabIndex = 5;
            // 
            // dtgvManageCustomer
            // 
            this.dtgvManageCustomer.AllowUserToAddRows = false;
            this.dtgvManageCustomer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.name,
            this.address,
            this.phonenumber,
            this.email,
            this.owe});
            this.dtgvManageCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageCustomer.Location = new System.Drawing.Point(0, 0);
            this.dtgvManageCustomer.Name = "dtgvManageCustomer";
            this.dtgvManageCustomer.ReadOnly = true;
            this.dtgvManageCustomer.RowHeadersVisible = false;
            this.dtgvManageCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageCustomer.Size = new System.Drawing.Size(978, 429);
            this.dtgvManageCustomer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(332, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(145, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xóa KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(79, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sửa KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm KH";
            // 
            // pbRemoveCustomer
            // 
            this.pbRemoveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveCustomer.Image")));
            this.pbRemoveCustomer.Location = new System.Drawing.Point(148, 3);
            this.pbRemoveCustomer.Name = "pbRemoveCustomer";
            this.pbRemoveCustomer.Size = new System.Drawing.Size(40, 34);
            this.pbRemoveCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveCustomer.TabIndex = 0;
            this.pbRemoveCustomer.TabStop = false;
            this.pbRemoveCustomer.Click += new System.EventHandler(this.pbRemoveCustomer_Click);
            // 
            // pbUpdateCustomer
            // 
            this.pbUpdateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdateCustomer.Image")));
            this.pbUpdateCustomer.Location = new System.Drawing.Point(82, 3);
            this.pbUpdateCustomer.Name = "pbUpdateCustomer";
            this.pbUpdateCustomer.Size = new System.Drawing.Size(40, 34);
            this.pbUpdateCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdateCustomer.TabIndex = 0;
            this.pbUpdateCustomer.TabStop = false;
            this.pbUpdateCustomer.Click += new System.EventHandler(this.pbUpdateCustomer_Click);
            // 
            // pbAddCustomer
            // 
            this.pbAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbAddCustomer.Image")));
            this.pbAddCustomer.Location = new System.Drawing.Point(18, 3);
            this.pbAddCustomer.Name = "pbAddCustomer";
            this.pbAddCustomer.Size = new System.Drawing.Size(40, 34);
            this.pbAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddCustomer.TabIndex = 0;
            this.pbAddCustomer.TabStop = false;
            this.pbAddCustomer.Click += new System.EventHandler(this.pbAddCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pbHistoryBill);
            this.panel1.Controls.Add(this.pbSearchCustomer);
            this.panel1.Controls.Add(this.txbSearchCustomer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbRemoveCustomer);
            this.panel1.Controls.Add(this.pbUpdateCustomer);
            this.panel1.Controls.Add(this.pbAddCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 59);
            this.panel1.TabIndex = 4;
            // 
            // pbHistoryBill
            // 
            this.pbHistoryBill.Image = ((System.Drawing.Image)(resources.GetObject("pbHistoryBill.Image")));
            this.pbHistoryBill.Location = new System.Drawing.Point(215, 3);
            this.pbHistoryBill.Name = "pbHistoryBill";
            this.pbHistoryBill.Size = new System.Drawing.Size(40, 34);
            this.pbHistoryBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistoryBill.TabIndex = 7;
            this.pbHistoryBill.TabStop = false;
            this.pbHistoryBill.Click += new System.EventHandler(this.pbHistoryBill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(205, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lịch sử mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(211, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xóa KH";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã khách hàng";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên khách hàng";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Số điện thoại";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // owe
            // 
            this.owe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.owe.DataPropertyName = "owe";
            this.owe.HeaderText = "Số nợ";
            this.owe.Name = "owe";
            this.owe.ReadOnly = true;
            // 
            // UCManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "UCManageCustomer";
            this.Size = new System.Drawing.Size(978, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearchCustomer;
        private System.Windows.Forms.TextBox txbSearchCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRemoveCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvManageCustomer;
        private System.Windows.Forms.PictureBox pbUpdateCustomer;
        private System.Windows.Forms.PictureBox pbAddCustomer;
        private System.Windows.Forms.PictureBox pbHistoryBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn owe;
    }
}

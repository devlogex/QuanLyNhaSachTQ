namespace QuanLyNhaSach
{
    partial class UCManageBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCManageBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbHistoryImport = new System.Windows.Forms.PictureBox();
            this.pbSearchBook = new System.Windows.Forms.PictureBox();
            this.txbSearchBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRemoveBook = new System.Windows.Forms.PictureBox();
            this.pbUpdateBook = new System.Windows.Forms.PictureBox();
            this.pbAddBook = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvManageBook = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBook)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pbHistoryImport);
            this.panel1.Controls.Add(this.pbSearchBook);
            this.panel1.Controls.Add(this.txbSearchBook);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbRemoveBook);
            this.panel1.Controls.Add(this.pbUpdateBook);
            this.panel1.Controls.Add(this.pbAddBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 59);
            this.panel1.TabIndex = 2;
            // 
            // pbHistoryImport
            // 
            this.pbHistoryImport.Image = ((System.Drawing.Image)(resources.GetObject("pbHistoryImport.Image")));
            this.pbHistoryImport.Location = new System.Drawing.Point(214, 3);
            this.pbHistoryImport.Name = "pbHistoryImport";
            this.pbHistoryImport.Size = new System.Drawing.Size(40, 34);
            this.pbHistoryImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistoryImport.TabIndex = 6;
            this.pbHistoryImport.TabStop = false;
            this.pbHistoryImport.Click += new System.EventHandler(this.pbHistoryImport_Click);
            // 
            // pbSearchBook
            // 
            this.pbSearchBook.BackColor = System.Drawing.Color.Gainsboro;
            this.pbSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchBook.Image")));
            this.pbSearchBook.Location = new System.Drawing.Point(927, 15);
            this.pbSearchBook.Name = "pbSearchBook";
            this.pbSearchBook.Size = new System.Drawing.Size(37, 22);
            this.pbSearchBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchBook.TabIndex = 5;
            this.pbSearchBook.TabStop = false;
            this.pbSearchBook.Click += new System.EventHandler(this.pbSearchBook_Click);
            // 
            // txbSearchBook
            // 
            this.txbSearchBook.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchBook.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchBook.Location = new System.Drawing.Point(697, 15);
            this.txbSearchBook.Name = "txbSearchBook";
            this.txbSearchBook.Size = new System.Drawing.Size(224, 23);
            this.txbSearchBook.TabIndex = 2;
            this.txbSearchBook.Text = "Tìm sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(199, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lịch sử nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(141, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xóa sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(79, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sửa sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm sách";
            // 
            // pbRemoveBook
            // 
            this.pbRemoveBook.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveBook.Image")));
            this.pbRemoveBook.Location = new System.Drawing.Point(144, 3);
            this.pbRemoveBook.Name = "pbRemoveBook";
            this.pbRemoveBook.Size = new System.Drawing.Size(40, 34);
            this.pbRemoveBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveBook.TabIndex = 0;
            this.pbRemoveBook.TabStop = false;
            this.pbRemoveBook.Click += new System.EventHandler(this.pbRemoveBook_Click);
            // 
            // pbUpdateBook
            // 
            this.pbUpdateBook.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdateBook.Image")));
            this.pbUpdateBook.Location = new System.Drawing.Point(82, 3);
            this.pbUpdateBook.Name = "pbUpdateBook";
            this.pbUpdateBook.Size = new System.Drawing.Size(39, 34);
            this.pbUpdateBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdateBook.TabIndex = 0;
            this.pbUpdateBook.TabStop = false;
            this.pbUpdateBook.Click += new System.EventHandler(this.pbUpdateBook_Click);
            // 
            // pbAddBook
            // 
            this.pbAddBook.Image = ((System.Drawing.Image)(resources.GetObject("pbAddBook.Image")));
            this.pbAddBook.Location = new System.Drawing.Point(13, 3);
            this.pbAddBook.Name = "pbAddBook";
            this.pbAddBook.Size = new System.Drawing.Size(48, 34);
            this.pbAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddBook.TabIndex = 0;
            this.pbAddBook.TabStop = false;
            this.pbAddBook.Click += new System.EventHandler(this.pbAddBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(390, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách Sách";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 37);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvManageBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 429);
            this.panel2.TabIndex = 7;
            // 
            // dtgvManageBook
            // 
            this.dtgvManageBook.AllowUserToAddRows = false;
            this.dtgvManageBook.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.nameBook,
            this.nameCategory,
            this.author,
            this.priceIn,
            this.count});
            this.dtgvManageBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageBook.Location = new System.Drawing.Point(0, 0);
            this.dtgvManageBook.Name = "dtgvManageBook";
            this.dtgvManageBook.ReadOnly = true;
            this.dtgvManageBook.RowHeadersVisible = false;
            this.dtgvManageBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageBook.Size = new System.Drawing.Size(978, 429);
            this.dtgvManageBook.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Mã sách";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nameBook
            // 
            this.nameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameBook.DataPropertyName = "name";
            this.nameBook.HeaderText = "Tên sách";
            this.nameBook.Name = "nameBook";
            this.nameBook.ReadOnly = true;
            // 
            // nameCategory
            // 
            this.nameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCategory.DataPropertyName = "nameCategory";
            this.nameCategory.HeaderText = "Thể loại sách";
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Tác giả";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // priceIn
            // 
            this.priceIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceIn.DataPropertyName = "priceIn";
            this.priceIn.HeaderText = "Đơn giá";
            this.priceIn.Name = "priceIn";
            this.priceIn.ReadOnly = true;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // UCManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UCManageBook";
            this.Size = new System.Drawing.Size(978, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBook)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAddBook;
        private System.Windows.Forms.PictureBox pbRemoveBook;
        private System.Windows.Forms.PictureBox pbUpdateBook;
        private System.Windows.Forms.TextBox txbSearchBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbSearchBook;
        private System.Windows.Forms.PictureBox pbHistoryImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvManageBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
}

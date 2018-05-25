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
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvManageBook = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nmPriceTo = new System.Windows.Forms.NumericUpDown();
            this.ckbPrice = new System.Windows.Forms.CheckBox();
            this.nmPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbCount = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCountTo = new System.Windows.Forms.NumericUpDown();
            this.nmCountFrom = new System.Windows.Forms.NumericUpDown();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.ckbCategory = new System.Windows.Forms.CheckBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbHistoryImport = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRemoveBook = new System.Windows.Forms.PictureBox();
            this.pbUpdateBook = new System.Windows.Forms.PictureBox();
            this.pbAddBook = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBook)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFrom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBook)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 37);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvManageBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 353);
            this.panel2.TabIndex = 7;
            // 
            // dtgvManageBook
            // 
            this.dtgvManageBook.AllowUserToAddRows = false;
            this.dtgvManageBook.AllowUserToDeleteRows = false;
            this.dtgvManageBook.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.name,
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
            this.dtgvManageBook.Size = new System.Drawing.Size(978, 353);
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
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên sách";
            this.name.Name = "name";
            this.name.ReadOnly = true;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.nmPriceTo);
            this.panel4.Controls.Add(this.ckbPrice);
            this.panel4.Controls.Add(this.nmPriceFrom);
            this.panel4.Controls.Add(this.txbAuthor);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.ckbCount);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.nmCountTo);
            this.panel4.Controls.Add(this.nmCountFrom);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Controls.Add(this.ckbCategory);
            this.panel4.Controls.Add(this.txbBookName);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 70);
            this.panel4.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(892, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 47);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(724, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // nmPriceTo
            // 
            this.nmPriceTo.Enabled = false;
            this.nmPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPriceTo.ForeColor = System.Drawing.Color.Blue;
            this.nmPriceTo.Location = new System.Drawing.Point(782, 6);
            this.nmPriceTo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmPriceTo.Name = "nmPriceTo";
            this.nmPriceTo.Size = new System.Drawing.Size(84, 22);
            this.nmPriceTo.TabIndex = 25;
            // 
            // ckbPrice
            // 
            this.ckbPrice.AutoSize = true;
            this.ckbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPrice.ForeColor = System.Drawing.Color.Blue;
            this.ckbPrice.Location = new System.Drawing.Point(542, 8);
            this.ckbPrice.Name = "ckbPrice";
            this.ckbPrice.Size = new System.Drawing.Size(54, 20);
            this.ckbPrice.TabIndex = 28;
            this.ckbPrice.Text = "Giá :";
            this.ckbPrice.UseVisualStyleBackColor = true;
            this.ckbPrice.CheckedChanged += new System.EventHandler(this.ckbPrice_CheckedChanged);
            // 
            // nmPriceFrom
            // 
            this.nmPriceFrom.Enabled = false;
            this.nmPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPriceFrom.ForeColor = System.Drawing.Color.Blue;
            this.nmPriceFrom.Location = new System.Drawing.Point(634, 6);
            this.nmPriceFrom.Name = "nmPriceFrom";
            this.nmPriceFrom.Size = new System.Drawing.Size(84, 22);
            this.nmPriceFrom.TabIndex = 26;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthor.ForeColor = System.Drawing.Color.Blue;
            this.txbAuthor.Location = new System.Drawing.Point(86, 39);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(147, 22);
            this.txbAuthor.TabIndex = 21;
            this.txbAuthor.TextChanged += new System.EventHandler(this.txbAuthor_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(724, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ckbCount
            // 
            this.ckbCount.AutoSize = true;
            this.ckbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCount.ForeColor = System.Drawing.Color.Blue;
            this.ckbCount.Location = new System.Drawing.Point(542, 35);
            this.ckbCount.Name = "ckbCount";
            this.ckbCount.Size = new System.Drawing.Size(86, 20);
            this.ckbCount.TabIndex = 24;
            this.ckbCount.Text = "Số lượng :";
            this.ckbCount.UseVisualStyleBackColor = true;
            this.ckbCount.CheckedChanged += new System.EventHandler(this.ckbCount_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tác giả :";
            // 
            // nmCountTo
            // 
            this.nmCountTo.Enabled = false;
            this.nmCountTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountTo.ForeColor = System.Drawing.Color.Blue;
            this.nmCountTo.Location = new System.Drawing.Point(782, 33);
            this.nmCountTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCountTo.Name = "nmCountTo";
            this.nmCountTo.Size = new System.Drawing.Size(84, 22);
            this.nmCountTo.TabIndex = 20;
            // 
            // nmCountFrom
            // 
            this.nmCountFrom.Enabled = false;
            this.nmCountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountFrom.ForeColor = System.Drawing.Color.Blue;
            this.nmCountFrom.Location = new System.Drawing.Point(634, 34);
            this.nmCountFrom.Name = "nmCountFrom";
            this.nmCountFrom.Size = new System.Drawing.Size(84, 22);
            this.nmCountFrom.TabIndex = 22;
            // 
            // cbCategory
            // 
            this.cbCategory.Enabled = false;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.Blue;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(342, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(176, 24);
            this.cbCategory.TabIndex = 17;
            // 
            // ckbCategory
            // 
            this.ckbCategory.AutoSize = true;
            this.ckbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCategory.ForeColor = System.Drawing.Color.Blue;
            this.ckbCategory.Location = new System.Drawing.Point(254, 8);
            this.ckbCategory.Name = "ckbCategory";
            this.ckbCategory.Size = new System.Drawing.Size(82, 20);
            this.ckbCategory.TabIndex = 18;
            this.ckbCategory.Text = "Thể loại :";
            this.ckbCategory.UseVisualStyleBackColor = true;
            this.ckbCategory.CheckedChanged += new System.EventHandler(this.ckbCategory_CheckedChanged);
            // 
            // txbBookName
            // 
            this.txbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBookName.ForeColor = System.Drawing.Color.Blue;
            this.txbBookName.Location = new System.Drawing.Point(86, 6);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(147, 22);
            this.txbBookName.TabIndex = 16;
            this.txbBookName.TextChanged += new System.EventHandler(this.txbBookName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên sách :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pbHistoryImport);
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
            this.panel1.Size = new System.Drawing.Size(978, 62);
            this.panel1.TabIndex = 2;
            // 
            // pbHistoryImport
            // 
            this.pbHistoryImport.Image = ((System.Drawing.Image)(resources.GetObject("pbHistoryImport.Image")));
            this.pbHistoryImport.Location = new System.Drawing.Point(223, 3);
            this.pbHistoryImport.Name = "pbHistoryImport";
            this.pbHistoryImport.Size = new System.Drawing.Size(40, 34);
            this.pbHistoryImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistoryImport.TabIndex = 22;
            this.pbHistoryImport.TabStop = false;
            this.pbHistoryImport.Click += new System.EventHandler(this.pbHistoryImport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(208, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lịch sử nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(150, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Xóa sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(88, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sửa sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thêm sách";
            // 
            // pbRemoveBook
            // 
            this.pbRemoveBook.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveBook.Image")));
            this.pbRemoveBook.Location = new System.Drawing.Point(153, 3);
            this.pbRemoveBook.Name = "pbRemoveBook";
            this.pbRemoveBook.Size = new System.Drawing.Size(40, 34);
            this.pbRemoveBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveBook.TabIndex = 15;
            this.pbRemoveBook.TabStop = false;
            this.pbRemoveBook.Click += new System.EventHandler(this.pbRemoveBook_Click);
            // 
            // pbUpdateBook
            // 
            this.pbUpdateBook.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdateBook.Image")));
            this.pbUpdateBook.Location = new System.Drawing.Point(91, 3);
            this.pbUpdateBook.Name = "pbUpdateBook";
            this.pbUpdateBook.Size = new System.Drawing.Size(39, 34);
            this.pbUpdateBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdateBook.TabIndex = 16;
            this.pbUpdateBook.TabStop = false;
            this.pbUpdateBook.Click += new System.EventHandler(this.pbUpdateBook_Click);
            // 
            // pbAddBook
            // 
            this.pbAddBook.Image = ((System.Drawing.Image)(resources.GetObject("pbAddBook.Image")));
            this.pbAddBook.Location = new System.Drawing.Point(22, 3);
            this.pbAddBook.Name = "pbAddBook";
            this.pbAddBook.Size = new System.Drawing.Size(48, 34);
            this.pbAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddBook.TabIndex = 17;
            this.pbAddBook.TabStop = false;
            this.pbAddBook.Click += new System.EventHandler(this.pbAddBook_Click);
            // 
            // UCManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UCManageBook";
            this.Size = new System.Drawing.Size(978, 525);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBook)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFrom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvManageBook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown nmPriceTo;
        private System.Windows.Forms.CheckBox ckbPrice;
        private System.Windows.Forms.NumericUpDown nmPriceFrom;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmCountTo;
        private System.Windows.Forms.NumericUpDown nmCountFrom;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.CheckBox ckbCategory;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbHistoryImport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRemoveBook;
        private System.Windows.Forms.PictureBox pbUpdateBook;
        private System.Windows.Forms.PictureBox pbAddBook;
    }
}

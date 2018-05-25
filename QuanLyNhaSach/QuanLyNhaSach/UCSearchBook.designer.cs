namespace QuanLyNhaSach
{
    partial class UCSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSearchBook));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvListBook = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.ckbCategory = new System.Windows.Forms.CheckBox();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.nmPriceTo = new System.Windows.Forms.NumericUpDown();
            this.ckbPrice = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbCount = new System.Windows.Forms.CheckBox();
            this.nmPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmCountTo = new System.Windows.Forms.NumericUpDown();
            this.nmCountFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvListBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 447);
            this.panel2.TabIndex = 5;
            // 
            // dtgvListBook
            // 
            this.dtgvListBook.AllowUserToAddRows = false;
            this.dtgvListBook.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.nameCategory,
            this.author,
            this.count,
            this.priceIn});
            this.dtgvListBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListBook.Location = new System.Drawing.Point(0, 0);
            this.dtgvListBook.Name = "dtgvListBook";
            this.dtgvListBook.ReadOnly = true;
            this.dtgvListBook.RowHeadersVisible = false;
            this.dtgvListBook.Size = new System.Drawing.Size(590, 447);
            this.dtgvListBook.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Sách";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // nameCategory
            // 
            this.nameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCategory.DataPropertyName = "nameCategory";
            this.nameCategory.HeaderText = "Thể loại";
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
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // priceIn
            // 
            this.priceIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceIn.DataPropertyName = "priceIn";
            this.priceIn.HeaderText = "Giá";
            this.priceIn.Name = "priceIn";
            this.priceIn.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(354, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 47);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tra cứu Sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 78);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.txbAuthor);
            this.panel4.Controls.Add(this.ckbCategory);
            this.panel4.Controls.Add(this.txbBookName);
            this.panel4.Controls.Add(this.nmPriceTo);
            this.panel4.Controls.Add(this.ckbPrice);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.ckbCount);
            this.panel4.Controls.Add(this.nmPriceFrom);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.nmCountTo);
            this.panel4.Controls.Add(this.nmCountFrom);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(590, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 447);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 214);
            this.panel3.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(259, 189);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 38);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Enabled = false;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.Blue;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(96, 45);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(243, 24);
            this.cbCategory.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthor.ForeColor = System.Drawing.Color.Blue;
            this.txbAuthor.Location = new System.Drawing.Point(96, 80);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(282, 22);
            this.txbAuthor.TabIndex = 11;
            this.txbAuthor.TextChanged += new System.EventHandler(this.txbAuthor_TextChanged);
            // 
            // ckbCategory
            // 
            this.ckbCategory.AutoSize = true;
            this.ckbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCategory.ForeColor = System.Drawing.Color.Blue;
            this.ckbCategory.Location = new System.Drawing.Point(9, 47);
            this.ckbCategory.Name = "ckbCategory";
            this.ckbCategory.Size = new System.Drawing.Size(82, 20);
            this.ckbCategory.TabIndex = 14;
            this.ckbCategory.Text = "Thể loại :";
            this.ckbCategory.UseVisualStyleBackColor = true;
            this.ckbCategory.CheckedChanged += new System.EventHandler(this.ckbCategory_CheckedChanged);
            // 
            // txbBookName
            // 
            this.txbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBookName.ForeColor = System.Drawing.Color.Blue;
            this.txbBookName.Location = new System.Drawing.Point(96, 6);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(282, 22);
            this.txbBookName.TabIndex = 12;
            this.txbBookName.TextChanged += new System.EventHandler(this.txbBookName_TextChanged);
            // 
            // nmPriceTo
            // 
            this.nmPriceTo.Enabled = false;
            this.nmPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPriceTo.ForeColor = System.Drawing.Color.Blue;
            this.nmPriceTo.Location = new System.Drawing.Point(282, 142);
            this.nmPriceTo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmPriceTo.Name = "nmPriceTo";
            this.nmPriceTo.Size = new System.Drawing.Size(103, 22);
            this.nmPriceTo.TabIndex = 8;
            // 
            // ckbPrice
            // 
            this.ckbPrice.AutoSize = true;
            this.ckbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPrice.ForeColor = System.Drawing.Color.Blue;
            this.ckbPrice.Location = new System.Drawing.Point(9, 145);
            this.ckbPrice.Name = "ckbPrice";
            this.ckbPrice.Size = new System.Drawing.Size(54, 20);
            this.ckbPrice.TabIndex = 12;
            this.ckbPrice.Text = "Giá :";
            this.ckbPrice.UseVisualStyleBackColor = true;
            this.ckbPrice.CheckedChanged += new System.EventHandler(this.ckbPrice_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ckbCount
            // 
            this.ckbCount.AutoSize = true;
            this.ckbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCount.ForeColor = System.Drawing.Color.Blue;
            this.ckbCount.Location = new System.Drawing.Point(9, 110);
            this.ckbCount.Name = "ckbCount";
            this.ckbCount.Size = new System.Drawing.Size(86, 20);
            this.ckbCount.TabIndex = 13;
            this.ckbCount.Text = "Số lượng :";
            this.ckbCount.UseVisualStyleBackColor = true;
            this.ckbCount.CheckedChanged += new System.EventHandler(this.ckbCount_CheckedChanged);
            // 
            // nmPriceFrom
            // 
            this.nmPriceFrom.Enabled = false;
            this.nmPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPriceFrom.ForeColor = System.Drawing.Color.Blue;
            this.nmPriceFrom.Location = new System.Drawing.Point(96, 142);
            this.nmPriceFrom.Name = "nmPriceFrom";
            this.nmPriceFrom.Size = new System.Drawing.Size(103, 22);
            this.nmPriceFrom.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tác giả :";
            // 
            // nmCountTo
            // 
            this.nmCountTo.Enabled = false;
            this.nmCountTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountTo.ForeColor = System.Drawing.Color.Blue;
            this.nmCountTo.Location = new System.Drawing.Point(282, 107);
            this.nmCountTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCountTo.Name = "nmCountTo";
            this.nmCountTo.Size = new System.Drawing.Size(103, 22);
            this.nmCountTo.TabIndex = 10;
            // 
            // nmCountFrom
            // 
            this.nmCountFrom.Enabled = false;
            this.nmCountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountFrom.ForeColor = System.Drawing.Color.Blue;
            this.nmCountFrom.Location = new System.Drawing.Point(96, 107);
            this.nmCountFrom.Name = "nmCountFrom";
            this.nmCountFrom.Size = new System.Drawing.Size(103, 22);
            this.nmCountFrom.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sách :";
            // 
            // UCSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCSearchBook";
            this.Size = new System.Drawing.Size(978, 525);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvListBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.CheckBox ckbCategory;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.NumericUpDown nmPriceTo;
        private System.Windows.Forms.CheckBox ckbPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbCount;
        private System.Windows.Forms.NumericUpDown nmPriceFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmCountTo;
        private System.Windows.Forms.NumericUpDown nmCountFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}

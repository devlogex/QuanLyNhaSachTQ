namespace QuanLyNhaSach
{
    partial class UCBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBill));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txbMoneyOwe = new System.Windows.Forms.TextBox();
            this.txbReceiveMoney = new System.Windows.Forms.TextBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpkBill = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateBookBill = new System.Windows.Forms.Button();
            this.btnRemoveBookBill = new System.Windows.Forms.Button();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddBookBill = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbAddBill = new System.Windows.Forms.PictureBox();
            this.pbRemoveBill = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.pbHistoryBill = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbAddCustomer = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 468);
            this.panel2.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgvBill);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(632, 322);
            this.panel8.TabIndex = 2;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idBook,
            this.nameBook,
            this.nameCategory,
            this.author,
            this.count,
            this.priceOut});
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(632, 322);
            this.dtgvBill.TabIndex = 1;
            this.dtgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // idBook
            // 
            this.idBook.HeaderText = "idBook";
            this.idBook.Name = "idBook";
            this.idBook.ReadOnly = true;
            this.idBook.Visible = false;
            // 
            // nameBook
            // 
            this.nameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameBook.HeaderText = "Sách";
            this.nameBook.Name = "nameBook";
            this.nameBook.ReadOnly = true;
            // 
            // nameCategory
            // 
            this.nameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCategory.HeaderText = "Thể loại";
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.HeaderText = "Tác giả";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // priceOut
            // 
            this.priceOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceOut.HeaderText = "Đơn giá bán";
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCheckOut);
            this.panel6.Controls.Add(this.txbMoneyOwe);
            this.panel6.Controls.Add(this.txbReceiveMoney);
            this.panel6.Controls.Add(this.txbTotalPrice);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(632, 108);
            this.panel6.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(470, 6);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(156, 97);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txbMoneyOwe
            // 
            this.txbMoneyOwe.Location = new System.Drawing.Point(109, 76);
            this.txbMoneyOwe.Name = "txbMoneyOwe";
            this.txbMoneyOwe.ReadOnly = true;
            this.txbMoneyOwe.Size = new System.Drawing.Size(344, 20);
            this.txbMoneyOwe.TabIndex = 11;
            this.txbMoneyOwe.Text = "0";
            // 
            // txbReceiveMoney
            // 
            this.txbReceiveMoney.Location = new System.Drawing.Point(109, 45);
            this.txbReceiveMoney.Name = "txbReceiveMoney";
            this.txbReceiveMoney.Size = new System.Drawing.Size(344, 20);
            this.txbReceiveMoney.TabIndex = 12;
            this.txbReceiveMoney.Text = "0";
            this.txbReceiveMoney.TextChanged += new System.EventHandler(this.txbReceiveMoney_TextChanged);
            this.txbReceiveMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbReceiveMoney_KeyPress);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(109, 13);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(344, 20);
            this.txbTotalPrice.TabIndex = 13;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.txbTotalPrice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Còn lại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số tiền trả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(632, 38);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(264, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa đơn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dtpkBill);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbCustomer);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(632, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 89);
            this.panel3.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(158, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Sách";
            // 
            // dtpkBill
            // 
            this.dtpkBill.Location = new System.Drawing.Point(153, 8);
            this.dtpkBill.Name = "dtpkBill";
            this.dtpkBill.Size = new System.Drawing.Size(190, 20);
            this.dtpkBill.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ngày lập hóa đơn :";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(115, 38);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(228, 21);
            this.cbCustomer.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Khách hàng :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnUpdateBookBill);
            this.panel4.Controls.Add(this.btnRemoveBookBill);
            this.panel4.Controls.Add(this.nmCount);
            this.panel4.Controls.Add(this.btnAddBookBill);
            this.panel4.Controls.Add(this.txbPrice);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(632, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 116);
            this.panel4.TabIndex = 7;
            // 
            // btnUpdateBookBill
            // 
            this.btnUpdateBookBill.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBookBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBookBill.Location = new System.Drawing.Point(232, 68);
            this.btnUpdateBookBill.Name = "btnUpdateBookBill";
            this.btnUpdateBookBill.Size = new System.Drawing.Size(114, 39);
            this.btnUpdateBookBill.TabIndex = 11;
            this.btnUpdateBookBill.Text = "Sửa sách";
            this.btnUpdateBookBill.UseVisualStyleBackColor = false;
            this.btnUpdateBookBill.Click += new System.EventHandler(this.btnUpdateBookBill_Click);
            // 
            // btnRemoveBookBill
            // 
            this.btnRemoveBookBill.BackColor = System.Drawing.Color.DarkGray;
            this.btnRemoveBookBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBookBill.Location = new System.Drawing.Point(126, 68);
            this.btnRemoveBookBill.Name = "btnRemoveBookBill";
            this.btnRemoveBookBill.Size = new System.Drawing.Size(105, 39);
            this.btnRemoveBookBill.TabIndex = 12;
            this.btnRemoveBookBill.Text = "Xóa sách";
            this.btnRemoveBookBill.UseVisualStyleBackColor = false;
            this.btnRemoveBookBill.Click += new System.EventHandler(this.btnRemoveBookBill_Click);
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(76, 3);
            this.nmCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(267, 20);
            this.nmCount.TabIndex = 10;
            // 
            // btnAddBookBill
            // 
            this.btnAddBookBill.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddBookBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookBill.Location = new System.Drawing.Point(10, 68);
            this.btnAddBookBill.Name = "btnAddBookBill";
            this.btnAddBookBill.Size = new System.Drawing.Size(110, 39);
            this.btnAddBookBill.TabIndex = 9;
            this.btnAddBookBill.Text = "Thêm sách";
            this.btnAddBookBill.UseVisualStyleBackColor = false;
            this.btnAddBookBill.Click += new System.EventHandler(this.btnAddBookBill_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(76, 39);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(267, 20);
            this.txbPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng";
            // 
            // pbAddBill
            // 
            this.pbAddBill.Image = ((System.Drawing.Image)(resources.GetObject("pbAddBill.Image")));
            this.pbAddBill.Location = new System.Drawing.Point(14, 3);
            this.pbAddBill.Name = "pbAddBill";
            this.pbAddBill.Size = new System.Drawing.Size(72, 33);
            this.pbAddBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddBill.TabIndex = 0;
            this.pbAddBill.TabStop = false;
            this.pbAddBill.Click += new System.EventHandler(this.pbAddBill_Click);
            // 
            // pbRemoveBill
            // 
            this.pbRemoveBill.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveBill.Image")));
            this.pbRemoveBill.Location = new System.Drawing.Point(97, 3);
            this.pbRemoveBill.Name = "pbRemoveBill";
            this.pbRemoveBill.Size = new System.Drawing.Size(66, 33);
            this.pbRemoveBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveBill.TabIndex = 0;
            this.pbRemoveBill.TabStop = false;
            this.pbRemoveBill.Click += new System.EventHandler(this.pbRemoveBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo hóa đơn mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(94, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hủy hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pbHistoryBill);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pbAddCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbRemoveBill);
            this.panel1.Controls.Add(this.pbAddBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 57);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.cbBook);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(632, 146);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(346, 263);
            this.panel7.TabIndex = 8;
            // 
            // cbBook
            // 
            this.cbBook.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(0, 0);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(346, 263);
            this.cbBook.TabIndex = 1;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
            // 
            // pbHistoryBill
            // 
            this.pbHistoryBill.Image = ((System.Drawing.Image)(resources.GetObject("pbHistoryBill.Image")));
            this.pbHistoryBill.Location = new System.Drawing.Point(243, 3);
            this.pbHistoryBill.Name = "pbHistoryBill";
            this.pbHistoryBill.Size = new System.Drawing.Size(40, 34);
            this.pbHistoryBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistoryBill.TabIndex = 11;
            this.pbHistoryBill.TabStop = false;
            this.pbHistoryBill.Click += new System.EventHandler(this.pbHistoryBill_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(234, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Lịch sử mua";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(178, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Thêm KH";
            // 
            // pbAddCustomer
            // 
            this.pbAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbAddCustomer.Image")));
            this.pbAddCustomer.Location = new System.Drawing.Point(181, 2);
            this.pbAddCustomer.Name = "pbAddCustomer";
            this.pbAddCustomer.Size = new System.Drawing.Size(40, 34);
            this.pbAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddCustomer.TabIndex = 8;
            this.pbAddCustomer.TabStop = false;
            this.pbAddCustomer.Click += new System.EventHandler(this.pbAddCustomer_Click);
            // 
            // UCBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCBill";
            this.Size = new System.Drawing.Size(978, 525);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbAddBill;
        private System.Windows.Forms.PictureBox pbRemoveBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txbMoneyOwe;
        private System.Windows.Forms.TextBox txbReceiveMoney;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpkBill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateBookBill;
        private System.Windows.Forms.Button btnRemoveBookBill;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Button btnAddBookBill;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.PictureBox pbHistoryBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbAddCustomer;
    }
}

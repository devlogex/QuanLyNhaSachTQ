namespace QuanLyNhaSach
{
    partial class UCReportCount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReportBook = new System.Windows.Forms.Button();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvReportCount = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 78);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(382, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 47);
            this.label9.TabIndex = 1;
            this.label9.Text = "Báo cáo tồn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnReportBook);
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.nmMonth);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 447);
            this.panel2.TabIndex = 7;
            // 
            // btnReportBook
            // 
            this.btnReportBook.BackColor = System.Drawing.Color.DarkGray;
            this.btnReportBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBook.ForeColor = System.Drawing.Color.Blue;
            this.btnReportBook.Location = new System.Drawing.Point(457, 3);
            this.btnReportBook.Name = "btnReportBook";
            this.btnReportBook.Size = new System.Drawing.Size(82, 36);
            this.btnReportBook.TabIndex = 7;
            this.btnReportBook.Text = "Thống kê";
            this.btnReportBook.UseVisualStyleBackColor = false;
            this.btnReportBook.Click += new System.EventHandler(this.btnReportBook_Click);
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.ForeColor = System.Drawing.Color.Blue;
            this.nmYear.Location = new System.Drawing.Point(149, 12);
            this.nmYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nmYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(48, 23);
            this.nmYear.TabIndex = 5;
            this.nmYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // nmMonth
            // 
            this.nmMonth.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMonth.ForeColor = System.Drawing.Color.Blue;
            this.nmMonth.Location = new System.Drawing.Point(95, 12);
            this.nmMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMonth.Name = "nmMonth";
            this.nmMonth.Size = new System.Drawing.Size(48, 23);
            this.nmMonth.TabIndex = 6;
            this.nmMonth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng/Năm :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvReportCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 402);
            this.panel3.TabIndex = 0;
            // 
            // dtgvReportCount
            // 
            this.dtgvReportCount.AllowUserToAddRows = false;
            this.dtgvReportCount.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvReportCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.bookName,
            this.firstCount,
            this.addCount,
            this.lastCount});
            this.dtgvReportCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvReportCount.Location = new System.Drawing.Point(0, 0);
            this.dtgvReportCount.Name = "dtgvReportCount";
            this.dtgvReportCount.ReadOnly = true;
            this.dtgvReportCount.RowHeadersVisible = false;
            this.dtgvReportCount.Size = new System.Drawing.Size(978, 402);
            this.dtgvReportCount.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookName.DataPropertyName = "bookName";
            this.bookName.HeaderText = "Sách";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // firstCount
            // 
            this.firstCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstCount.DataPropertyName = "firstCount";
            this.firstCount.HeaderText = "Tồn đầu";
            this.firstCount.Name = "firstCount";
            this.firstCount.ReadOnly = true;
            // 
            // addCount
            // 
            this.addCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addCount.DataPropertyName = "addCount";
            this.addCount.HeaderText = "Phát sinh";
            this.addCount.Name = "addCount";
            this.addCount.ReadOnly = true;
            // 
            // lastCount
            // 
            this.lastCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastCount.DataPropertyName = "lastCount";
            this.lastCount.HeaderText = "Tồn cuối";
            this.lastCount.Name = "lastCount";
            this.lastCount.ReadOnly = true;
            // 
            // UCReportCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCReportCount";
            this.Size = new System.Drawing.Size(978, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReportBook;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvReportCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn addCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCount;
    }
}

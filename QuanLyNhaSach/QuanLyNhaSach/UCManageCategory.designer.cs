namespace QuanLyNhaSach
{
    partial class UCManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCManageCategory));
            this.pbSearchCategory = new System.Windows.Forms.PictureBox();
            this.txbSearchCategory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvManageCategory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRemoveCategory = new System.Windows.Forms.PictureBox();
            this.pbUpdateCategory = new System.Windows.Forms.PictureBox();
            this.pbAddCategory = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCategory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSearchCategory
            // 
            this.pbSearchCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.pbSearchCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchCategory.Image")));
            this.pbSearchCategory.Location = new System.Drawing.Point(921, 14);
            this.pbSearchCategory.Name = "pbSearchCategory";
            this.pbSearchCategory.Size = new System.Drawing.Size(37, 22);
            this.pbSearchCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchCategory.TabIndex = 5;
            this.pbSearchCategory.TabStop = false;
            // 
            // txbSearchCategory
            // 
            this.txbSearchCategory.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchCategory.Location = new System.Drawing.Point(691, 14);
            this.txbSearchCategory.Name = "txbSearchCategory";
            this.txbSearchCategory.Size = new System.Drawing.Size(224, 23);
            this.txbSearchCategory.TabIndex = 2;
            this.txbSearchCategory.Text = "Tìm thể loại sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvManageCategory);
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 415);
            this.panel2.TabIndex = 5;
            // 
            // dtgvManageCategory
            // 
            this.dtgvManageCategory.AllowUserToAddRows = false;
            this.dtgvManageCategory.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.name});
            this.dtgvManageCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgvManageCategory.Name = "dtgvManageCategory";
            this.dtgvManageCategory.ReadOnly = true;
            this.dtgvManageCategory.RowHeadersVisible = false;
            this.dtgvManageCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageCategory.Size = new System.Drawing.Size(978, 415);
            this.dtgvManageCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(344, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách Thể loại sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(151, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xóa TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(86, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sửa TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm TL";
            // 
            // pbRemoveCategory
            // 
            this.pbRemoveCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveCategory.Image")));
            this.pbRemoveCategory.Location = new System.Drawing.Point(153, 3);
            this.pbRemoveCategory.Name = "pbRemoveCategory";
            this.pbRemoveCategory.Size = new System.Drawing.Size(40, 34);
            this.pbRemoveCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveCategory.TabIndex = 0;
            this.pbRemoveCategory.TabStop = false;
            this.pbRemoveCategory.Click += new System.EventHandler(this.pbRemoveCategory_Click);
            // 
            // pbUpdateCategory
            // 
            this.pbUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdateCategory.Image")));
            this.pbUpdateCategory.Location = new System.Drawing.Point(85, 3);
            this.pbUpdateCategory.Name = "pbUpdateCategory";
            this.pbUpdateCategory.Size = new System.Drawing.Size(40, 34);
            this.pbUpdateCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdateCategory.TabIndex = 0;
            this.pbUpdateCategory.TabStop = false;
            this.pbUpdateCategory.Click += new System.EventHandler(this.pbUpdateCategory_Click);
            // 
            // pbAddCategory
            // 
            this.pbAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbAddCategory.Image")));
            this.pbAddCategory.Location = new System.Drawing.Point(16, 3);
            this.pbAddCategory.Name = "pbAddCategory";
            this.pbAddCategory.Size = new System.Drawing.Size(40, 34);
            this.pbAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddCategory.TabIndex = 0;
            this.pbAddCategory.TabStop = false;
            this.pbAddCategory.Click += new System.EventHandler(this.pbAddCategory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pbSearchCategory);
            this.panel1.Controls.Add(this.txbSearchCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbRemoveCategory);
            this.panel1.Controls.Add(this.pbUpdateCategory);
            this.panel1.Controls.Add(this.pbAddCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 60);
            this.panel1.TabIndex = 4;
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
            this.id.HeaderText = "Mã thể loại";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên thể loại";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // UCManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "UCManageCategory";
            this.Size = new System.Drawing.Size(978, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearchCategory;
        private System.Windows.Forms.TextBox txbSearchCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRemoveCategory;
        private System.Windows.Forms.PictureBox pbUpdateCategory;
        private System.Windows.Forms.PictureBox pbAddCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvManageCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

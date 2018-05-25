using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FAddBook : Form
    {
        private static FAddBook instance;

        public static FAddBook Instance
        {
            get { if (instance == null) instance = new FAddBook(); return instance; }
            set => instance = value;
        }

        public FAddBook()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Method
        public void LoadForm()
        {
            LoadCategoryIntoCombobox(cbCategory);
        }
        public void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryBookDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        public bool AddBook(string name, int idCategory, string author, int count, int priceIn)
        {
            return BookDAO.Instance.AddBook(name, idCategory, author, count, priceIn);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }

        #region Event
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txbBookName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sách ");
                return;
            }
            if (txbAuthor.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tác giả");
                return;
            }
            if (txbPrice.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá sách");
                return;
            }
            if(cbCategory.SelectedItem==null)
            {
                MessageBox.Show("Bạn chưa chọn thể loại sách");
                return;
            }
            string name = txbBookName.Text;
            int idCategory = (cbCategory.SelectedItem as CategoryBook).ID;
            string author = txbAuthor.Text;
            int count = 0;
            int priceIn = Int32.Parse(txbPrice.Text);
            

            if (AddBook(name, idCategory, author, count, priceIn))
            {
                MessageBox.Show("Thêm sách thành công!");
                //load lại FManageBook
                if (updateForm != null)
                {
                    updateForm(this, new EventArgs());
                }
            }
            else
                MessageBox.Show("Thêm sách thất bại !");
        }
        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

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
    public partial class FUpdateBook : Form
    {
        private Book book;
        public Book Book { get => book; set => book = value; }

        public FUpdateBook(Book book)
        {
            InitializeComponent();

            this.Book = book;
            LoadForm();
        }
        #region Mothod
        public void LoadForm()
        {
            LoadCategoryIntoCombobox(cbCategory);
            txbBookName.Text = book.Name;
            txbAuthor.Text = book.Author;
            txbPrice.Text = book.PriceIn.ToString();

            //selected in combobox

            CategoryBook category = CategoryBookDAO.Instance.GetCategoryBookByBookID(book.ID);
            int index = -1;
            int i = 0;
            foreach (CategoryBook item in cbCategory.Items)
            {
                if (item.ID == category.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbCategory.SelectedIndex = index;
        }
        public void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryBookDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        public bool UpdateBook(int id, string name, int idCategory, string author, int count, float priceIn)
        {
            return BookDAO.Instance.UpdateBook(id, name, idCategory, author, count, priceIn);
        }
        #endregion

        private event EventHandler updateForm;
        public event EventHandler UpdateForm
        {
            add { updateForm += value; }
            remove { updateForm -= value; }
        }

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
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
            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn thể loại sách");
                return;
            }

            int id = Book.ID;
            string name = txbBookName.Text;
            int idCategory = (cbCategory.SelectedItem as CategoryBook).ID;
            string author = txbAuthor.Text;
            float price = (float)Double.Parse(txbPrice.Text);
            int count = Book.Count;

            if (UpdateBook(id, name, idCategory, author, count, price))
            {
                MessageBox.Show("Cập nhật sách thành công !");
                //load lại FManageBook
                if (updateForm != null)
                {
                    updateForm(this, new EventArgs());
                }
            }
            else
                MessageBox.Show("Cập nhật sách thất bại !");
        }
        #endregion

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;

namespace QuanLyNhaSach
{
    public partial class UCImportBook : UserControl
    {
        private int minImport;
        private int maxCount;
        public UCImportBook()
        {
            InitializeComponent();
            LoadForm();
        }

        #region Method
        public void LoadForm()
        {
            btnUpdateBook.Enabled = false;
            btnRemoveBook.Enabled = false;
            btnAddBook.Enabled = false;
            pbSaveImportBook.Enabled = false;
            pbRemoveImportBook.Enabled = false;

            dtpkDateIn.Value = DateTime.Now;
            minImport = ThamSoDAO.Instance.GetMinImport();
            maxCount = ThamSoDAO.Instance.GetMaxCount();

            LoadListBookIntoCB(cbListBook);
        }
        public void LoadListBookIntoCB(ComboBox cb)
        {
            cb.DataSource = BookDAO.Instance.GetListBook();
            cb.DisplayMember = "name";
        }
        public void RemoveAllBookInImportBook()
        {
            while (dtgvListBook.Rows.Count != 0)
            {
                dtgvListBook.Rows.RemoveAt(0);
            }
        }
        public void RemoveBookInImportBook(int index)
        {
            try
            {
                dtgvListBook.Rows.RemoveAt(index);
                int i = index;
                while (i < dtgvListBook.Rows.Count)
                {
                    dtgvListBook.Rows[i].Cells["STT"].Value = i;
                    i++;
                }
            }
            catch { }
        }
        public void UpdateBookInImportBook(int index)
        {
            if (dtgvListBook.Rows[index].Cells["idBook"].Value != null)
            {
                dtgvListBook.Rows[index].Cells["count"].Value = nmCount.Value;
                dtgvListBook.Rows[index].Cells["priceIn"].Value = txbPrice.Text;
            }
        }
        public void AddBookIntoImportBook(Book book)
        {
            int index = dtgvListBook.Rows.Count;
            int idBook = book.ID;
            string nameBook = book.Name;
            string author = book.Author;
            int count = (int)nmCount.Value;
            float priceIn = (float)Double.Parse(txbPrice.Text);
            string nameCategory = CategoryBookDAO.Instance.GetCategoryBookByBookID(idBook).Name;
            for (int i = 0; i < dtgvListBook.Rows.Count; i++)
            {
                if (Int32.Parse(dtgvListBook.Rows[i].Cells["idBook"].Value.ToString()) == idBook)
                {
                    dtgvListBook.Rows[i].Cells["count"].Value = (Int32.Parse(dtgvListBook.Rows[i].Cells["count"].Value.ToString()) + Int32.Parse(nmCount.Value.ToString()));
                    dtgvListBook.Rows[i].Cells["priceIn"].Value = txbPrice.Text;
                    return;
                }
            }
            dtgvListBook.Rows.Add(index, idBook, nameBook, nameCategory, author, count, priceIn);

        }
        public void SaveImportBook(DateTime date)
        {
            if (!ImportBookDAO.Instance.InsertImportBook(date))
            {
                MessageBox.Show("Có lỗi khi lưu phiếu nhập sách !");
                return;
            }

            for (int i = 0; i < dtgvListBook.Rows.Count; i++)
            {
                int idBook = Int32.Parse(dtgvListBook.Rows[i].Cells["idBook"].Value.ToString());
                int count = Int32.Parse(dtgvListBook.Rows[i].Cells["count"].Value.ToString());
                float priceIn = (float)Double.Parse(dtgvListBook.Rows[i].Cells["priceIn"].Value.ToString());
                if (!ImportBookInfoDAO.Instance.InsertImportBookInfo(idBook, count, priceIn))
                {
                    MessageBox.Show(String.Format("Có lỗi khi lưu sách {0}", dtgvListBook.Rows[i].Cells["nameBook"].Value));
                    return;
                }
            }
            MessageBox.Show("Lưu phiếu nhập sách thành công !");
        }

        #endregion

        #region Event
        private void pbAddImportBook_Click(object sender, EventArgs e)
        {
            RemoveAllBookInImportBook();

            btnUpdateBook.Enabled = true;
            btnRemoveBook.Enabled = true;
            btnAddBook.Enabled = true;
            pbSaveImportBook.Enabled = true;
            pbRemoveImportBook.Enabled = true;

        }
        private void pbRemoveImportBook_Click(object sender, EventArgs e)
        {
            RemoveAllBookInImportBook();

            btnUpdateBook.Enabled = false;
            btnRemoveBook.Enabled = false;
            btnAddBook.Enabled = false;
            pbSaveImportBook.Enabled = false;
            pbRemoveImportBook.Enabled = false;
        }
        private void pbSaveImportBook_Click(object sender, EventArgs e)
        {
            DateTime date = dtpkDateIn.Value;
            SaveImportBook(date);

            btnUpdateBook.Enabled = false;
            btnRemoveBook.Enabled = false;
            btnAddBook.Enabled = false;
            pbSaveImportBook.Enabled = false;
            pbRemoveImportBook.Enabled = false;
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = cbListBook.SelectedItem as Book;

            if ((int)nmCount.Value < minImport)
            {
                MessageBox.Show("Số lượng nhập phải ít nhất là :" + minImport);
                return;
            }
            if (BookDAO.Instance.GetBookByBookID(book.ID).Count >= maxCount)
            {
                MessageBox.Show("Chỉ nhập các sách có lượng tồn ít hơn " + maxCount);
                return;
            }

            AddBookIntoImportBook(book);

            #region Selected in dtgv when add after delete a row

            for (int j = 0; j < dtgvListBook.SelectedRows.Count; j++)
                dtgvListBook.Rows[dtgvListBook.SelectedRows[j].Index].Selected = false;
            for (int i = 0; i < dtgvListBook.Rows.Count; i++)
            {
                if (Int32.Parse(dtgvListBook.Rows[i].Cells["idBook"].Value.ToString()) == (cbListBook.SelectedItem as Book).ID)
                {
                    dtgvListBook.Rows[i].Selected = true;
                    break;
                }
            }
            #endregion
        }
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvListBook.SelectedCells[0].OwningRow.Index;
                RemoveBookInImportBook(index);
            }
            catch { }
        }
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvListBook.SelectedCells[0].OwningRow.Index;
                UpdateBookInImportBook(index);
            }
            catch { }
        }

        private void cbListBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < dtgvListBook.SelectedRows.Count; j++)
                dtgvListBook.Rows[dtgvListBook.SelectedRows[j].Index].Selected = false;

            for (int i = 0; i < dtgvListBook.Rows.Count; i++)
            {
                if (Int32.Parse(dtgvListBook.Rows[i].Cells["idBook"].Value.ToString()) == ((sender as ComboBox).SelectedItem as Book).ID)
                {
                    dtgvListBook.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void dtgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListBook.SelectedCells.Count > 0)
            {
                int idBook = Int32.Parse(dtgvListBook.SelectedCells[0].OwningRow.Cells["idBook"].Value.ToString());
                foreach (Book item in BookDAO.Instance.GetListBook())
                {
                    if (item.ID == idBook)
                        cbListBook.SelectedItem = item;
                }
                int index = -1;
                int i = 0;
                foreach (Book item in cbListBook.Items)
                {
                    if (item.ID == idBook)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbListBook.SelectedIndex = index;
            }
        }
        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbHistoryImport_Click(object sender, EventArgs e)
        {
            FListImportBook f = new FListImportBook();
            f.ShowDialog();
        }

        private void pbAddBook_Click(object sender, EventArgs e)
        {
            FAddBook f = new FAddBook();
            f.ShowDialog();
            this.LoadListBookIntoCB(cbListBook);
        }

        private void pbAddCategory_Click(object sender, EventArgs e)
        {
            FAddCategory f = new FAddCategory();
            f.ShowDialog();
        }

        #endregion


        //private void pbAddImportBook_MouseHover(object sender, EventArgs e)
        //{
        //    pbAddImportBook.BackColor = Color.LightBlue;
        //}

        //private void pbAddImportBook_MouseLeave(object sender, EventArgs e)
        //{
        //    pbAddImportBook.BackColor = Color.LightSkyBlue;
        //}
    }
}

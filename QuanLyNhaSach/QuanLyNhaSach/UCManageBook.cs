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
    public partial class UCManageBook : UserControl
    {
        public UCManageBook()
        {
            InitializeComponent();
            LoadForm();

        }
        #region Method
        public void LoadForm()
        {
            LoadListBook();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageBook.Rows.Count; i++)
                {
                    dtgvManageBook.Rows[i].Cells["STT"].Value = i + 1;
                }
            };

            LoadListCategory();
        }
        public void LoadListCategory()
        {
            cbCategory.DataSource = CategoryBookDAO.Instance.GetListCategory();
            cbCategory.DisplayMember = "name";
        }
        public void LoadListBook()
        {
            dtgvManageBook.DataSource = BookDAO.Instance.LoadListBook();
            for (int i = 0; i < dtgvManageBook.Rows.Count; i++)
            {
                dtgvManageBook.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public void SearchBook()
        {
            dtgvManageBook.DataSource = BookDAO.Instance.LoadListBook();
            if (txbBookName.Text != "")
            {
                List<Book> list = BookDAO.Instance.SearchBookByName(txbBookName.Text);
                for (int i = 0; i < dtgvManageBook.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvManageBook.Rows[i].Cells["name"].Value.ToString() == list[j].Name)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvManageBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbCategory.Checked == true)
            {
                for (int i = 0; i < dtgvManageBook.RowCount; i++)
                {
                    if (dtgvManageBook.Rows[i].Cells["nameCategory"].Value.ToString() != (cbCategory.SelectedItem as CategoryBook).Name)
                    {
                        dtgvManageBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (txbAuthor.Text != "")
            {
                List<Book> list = BookDAO.Instance.SearchBookByAuthor(txbAuthor.Text);
                for (int i = 0; i < dtgvManageBook.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvManageBook.Rows[i].Cells["author"].Value.ToString() == list[j].Author)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvManageBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbCount.Checked == true)
            {
                for (int i = 0; i < dtgvManageBook.RowCount; i++)
                {
                    if ((int)dtgvManageBook.Rows[i].Cells["count"].Value < (int)nmCountFrom.Value ||
                        (int)dtgvManageBook.Rows[i].Cells["count"].Value > (int)nmCountTo.Value)
                    {
                        dtgvManageBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbPrice.Checked == true)
            {
                for (int i = 0; i < dtgvManageBook.RowCount; i++)
                {
                    if ((float)Double.Parse(dtgvManageBook.Rows[i].Cells["priceIn"].Value.ToString()) < (int)nmPriceFrom.Value ||
                        (float)Double.Parse(dtgvManageBook.Rows[i].Cells["priceIn"].Value.ToString()) > (int)nmPriceTo.Value)
                    {
                        dtgvManageBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        public bool RemoveBookByBookID(int id)
        {
            return BookDAO.Instance.RemoveBookByBookID(id);
        }
        #endregion

        #region Event
        private void pbAddBook_Click(object sender, EventArgs e)
        {
            FAddBook f = new FAddBook();
            f.UpdateForm += F_LoadAfterAdd;
            f.ShowDialog();
        }
        private void F_LoadAfterAdd(object sender, EventArgs e)
        {
            LoadListBook();

            for (int i = 0; i < dtgvManageBook.SelectedRows.Count; i++)
            {
                dtgvManageBook.SelectedRows[i].Selected = false;
            }
            dtgvManageBook.Rows[dtgvManageBook.Rows.Count - 1].Selected = true;
        }
        private void pbUpdateBook_Click(object sender, EventArgs e)
        {
            if(dtgvManageBook.SelectedCells.Count==0)
            {
                MessageBox.Show("Bạn chưa chọn sách để sửa");
                return;
            }

            Book book = BookDAO.Instance.GetBookByBookID(Int32.Parse(dtgvManageBook.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString()));
            FUpdateBook f = new FUpdateBook(book);
            f.UpdateForm += F_LoadAfterUpdate;
            f.ShowDialog();
        }
        private void F_LoadAfterUpdate(object sender, EventArgs e)
        {
            LoadListBook();

            for (int i = 0; i < dtgvManageBook.SelectedRows.Count; i++)
            {
                dtgvManageBook.SelectedRows[i].Selected = false;
            }

            Book book = (sender as FUpdateBook).Book;
            int index = 0;
            while(Int32.Parse(dtgvManageBook.Rows[index].Cells["ID"].Value.ToString())!=book.ID)
            {
                index++;
            }
            dtgvManageBook.Rows[index].Selected = true;
        }
        private void pbRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvManageBook.SelectedCells.Count > 0)
                {
                    int id = Int32.Parse(dtgvManageBook.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    if (RemoveBookByBookID(id))
                    {
                        MessageBox.Show("Đã xóa thành công !");
                        LoadListBook();
                    }
                    else
                        MessageBox.Show("Xóa không thành công !");

                }
                else
                    MessageBox.Show("Bạn chưa chọn sách ");
            }
            catch { MessageBox.Show("Xóa không thành công !"); }
        }
        private void pbHistoryImport_Click(object sender, EventArgs e)
        {
            FListImportBook f = new FListImportBook();
            f.ShowDialog();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBook();
        }
        private void ckbCategory_CheckedChanged(object sender, EventArgs e)
        {
            cbCategory.Enabled = ckbCategory.Checked == true;

            if (ckbCategory.Checked == false)
                SearchBook();
        }
        private void ckbCount_CheckedChanged(object sender, EventArgs e)
        {
            nmCountFrom.Enabled = ckbCount.Checked == true;
            nmCountTo.Enabled = ckbCount.Checked == true;

            if (ckbCount.Checked == false)
                SearchBook();
        }
        private void ckbPrice_CheckedChanged(object sender, EventArgs e)
        {
            nmPriceFrom.Enabled = ckbPrice.Checked == true;
            nmPriceTo.Enabled = ckbPrice.Checked == true;

            if (ckbPrice.Checked == false)
                SearchBook();
        }
        private void txbBookName_TextChanged(object sender, EventArgs e)
        {
            if (txbBookName.Text == "")
                SearchBook();
        }
        private void txbAuthor_TextChanged(object sender, EventArgs e)
        {
            if (txbAuthor.Text == "")
                SearchBook();
        }
        #endregion
    }
}
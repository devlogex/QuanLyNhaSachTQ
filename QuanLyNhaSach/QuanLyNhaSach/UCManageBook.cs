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
        }


        public void LoadListBook()
        {
            dtgvManageBook.DataSource = BookDAO.Instance.LoadListBook();
            for (int i = 0; i < dtgvManageBook.Rows.Count; i++)
            {
                dtgvManageBook.Rows[i].Cells["STT"].Value = i + 1;
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
        private void pbSearchBook_Click(object sender, EventArgs e)
        {
            LoadListBook();
            if (txbSearchBook.Text != "")
            {
                List<Book> list = BookDAO.Instance.SearchBookByName(txbSearchBook.Text);
                for (int i = 0; i < dtgvManageBook.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvManageBook.Rows[i].Cells["nameBook"].Value.ToString() == list[j].Name)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvManageBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        private void pbHistoryImport_Click(object sender, EventArgs e)
        {
            FListImportBook f = new FListImportBook();
            f.ShowDialog();

        }

        #endregion
    }
}
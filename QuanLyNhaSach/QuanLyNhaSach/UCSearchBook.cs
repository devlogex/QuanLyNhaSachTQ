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
    public partial class UCSearchBook : UserControl
    {
        BindingSource listBook = new BindingSource();
        public UCSearchBook()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Method
        public void LoadForm()
        {
            LoadListCategory();
            dtgvListBook.DataSource = listBook;
            listBook.DataSource = BookDAO.Instance.LoadListBook();
        }
        public void LoadListCategory()
        {
            cbCategory.DataSource = CategoryBookDAO.Instance.GetListCategory();
            cbCategory.DisplayMember = "name";
        }
        public void SearchBook()
        {
            listBook.DataSource = BookDAO.Instance.LoadListBook();
            if (txbBookName.Text != "")
            {
                List<Book> list = BookDAO.Instance.SearchBookByName(txbBookName.Text);
                for (int i = 0; i < dtgvListBook.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvListBook.Rows[i].Cells["name"].Value.ToString() == list[j].Name)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvListBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbCategory.Checked == true)
            {
                for (int i = 0; i < dtgvListBook.RowCount; i++)
                {
                    if (dtgvListBook.Rows[i].Cells["nameCategory"].Value.ToString() != (cbCategory.SelectedItem as CategoryBook).Name)
                    {
                        dtgvListBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (txbAuthor.Text != "")
            {
                List<Book> list = BookDAO.Instance.SearchBookByAuthor(txbAuthor.Text);
                for (int i = 0; i < dtgvListBook.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvListBook.Rows[i].Cells["author"].Value.ToString() == list[j].Author)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvListBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbCount.Checked == true)
            {
                for (int i = 0; i < dtgvListBook.RowCount; i++)
                {
                    if ((int)dtgvListBook.Rows[i].Cells["count"].Value < (int)nmCountFrom.Value ||
                        (int)dtgvListBook.Rows[i].Cells["count"].Value > (int)nmCountTo.Value)
                    {
                        dtgvListBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbPrice.Checked == true)
            {
                for (int i = 0; i < dtgvListBook.RowCount; i++)
                {
                    if ((float)Double.Parse(dtgvListBook.Rows[i].Cells["priceIn"].Value.ToString()) < (int)nmPriceFrom.Value ||
                        (float)Double.Parse(dtgvListBook.Rows[i].Cells["priceIn"].Value.ToString()) > (int)nmPriceTo.Value)
                    {
                        dtgvListBook.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }


        #endregion

        #region Event
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

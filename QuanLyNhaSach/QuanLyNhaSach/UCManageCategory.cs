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
    public partial class UCManageCategory : UserControl
    {
        BindingSource categoryList = new BindingSource();
        public UCManageCategory()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Method
        public void LoadForm()
        {
            dtgvManageCategory.DataSource = categoryList;
            LoadListCategory();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageCategory.Rows.Count; i++)
                {
                    dtgvManageCategory.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryBookDAO.Instance.GetListCategory();
            for (int i = 0; i < dtgvManageCategory.Rows.Count; i++)
            {
                dtgvManageCategory.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public bool RemoveCategoryByCategoryID(int id)
        {
            return CategoryBookDAO.Instance.RemoveCategoryByCategoryID(id);
        }

        #endregion

        #region Event
        private void pbAddCategory_Click(object sender, EventArgs e)
        {
            FAddCategory f = new FAddCategory();
            f.UpdateForm += F_LoadAfterAdd;
            f.ShowDialog();
        }
        private void F_LoadAfterAdd(object sender, EventArgs e)
        {
            LoadListCategory();

            for(int i=0;i<dtgvManageCategory.SelectedRows.Count;i++)
            {
                dtgvManageCategory.SelectedRows[i].Selected = false;
            }
            dtgvManageCategory.Rows[dtgvManageCategory.Rows.Count - 1].Selected = true;
        }
        private void pbUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dtgvManageCategory.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sách để sửa");
                return;
            }

            CategoryBook category = new CategoryBook(Int32.Parse(dtgvManageCategory.SelectedRows[0].Cells["id"].Value.ToString()),dtgvManageCategory.SelectedRows[0].Cells["name"].Value.ToString());
            FUpdateCategory f = new FUpdateCategory(category);
            f.UpdateForm += F_LoadAfterUpdate;
            f.ShowDialog();
        }
        private void F_LoadAfterUpdate(object sender, EventArgs e)
        {
            LoadListCategory();

            for (int i = 0; i < dtgvManageCategory.SelectedRows.Count; i++)
            {
                dtgvManageCategory.SelectedRows[i].Selected = false;
            }

            CategoryBook category = (sender as FUpdateCategory).Category;
            int index = 0;
            while (Int32.Parse(dtgvManageCategory.Rows[index].Cells["ID"].Value.ToString()) != category.ID)
            {
                index++;
            }
            dtgvManageCategory.Rows[index].Selected = true;
        }
        private void pbRemoveCategory_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (dtgvManageCategory.SelectedCells.Count > 0)
                {
                    int id = Int32.Parse(dtgvManageCategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    if (RemoveCategoryByCategoryID(id))
                    {
                        MessageBox.Show("Đã xóa thành công !");
                        LoadListCategory();
                    }
                    else
                        MessageBox.Show("Xóa không thành công !");

                }
                else
                    MessageBox.Show("Bạn chưa chọn sách ");
            //}
            //catch { MessageBox.Show("Xóa không thành công !"); }
        }
        #endregion


    }
}

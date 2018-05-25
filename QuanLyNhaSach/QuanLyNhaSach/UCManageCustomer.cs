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
    public partial class UCManageCustomer : UserControl
    {
        BindingSource customerList = new BindingSource();
        public UCManageCustomer()
        {
            InitializeComponent();
            LoadForm();
        }
        #region Medthod
        public void LoadForm()
        {
            dtgvManageCustomer.DataSource = customerList;
            LoadListCustomer();
            this.Load += delegate (object sender, EventArgs e) {
                for (int i = 0; i < dtgvManageCustomer.Rows.Count; i++)
                {
                    dtgvManageCustomer.Rows[i].Cells["STT"].Value = i + 1;
                }
            };
        }
        public void LoadListCustomer()
        {
            customerList.DataSource = CustomerDAO.Instance.GetListCustomer();
            for (int i = 0; i < dtgvManageCustomer.Rows.Count; i++)
            {
                dtgvManageCustomer.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        public bool RemoveCustomerByCustomerID(int id)
        {
            return CustomerDAO.Instance.RemoveCustomerByCustomerID(id);
        }
        #endregion

        #region Event
        private void pbAddCustomer_Click(object sender, EventArgs e)
        {
            FAddCustomer f = new FAddCustomer();
            f.UpdateForm += F_LoadAfterAdd;
            f.ShowDialog();
        }

        private void F_LoadAfterAdd(object sender, EventArgs e)
        {
            LoadListCustomer();
            for (int i = 0; i < dtgvManageCustomer.SelectedRows.Count; i++)
            {
                dtgvManageCustomer.SelectedRows[i].Selected = false;
            }
            dtgvManageCustomer.Rows[dtgvManageCustomer.Rows.Count - 1].Selected = true;
        }

        private void pbUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dtgvManageCustomer.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sách để sửa");
                return;
            }

            Customer customer = CustomerDAO.Instance.GetCustomerByCustomerID((int)dtgvManageCustomer.SelectedRows[0].Cells["id"].Value);
            FUpdateCustomer f = new FUpdateCustomer(customer);
            f.UpdateForm += F_LoadAfterUpdate;
            f.ShowDialog();
        }

        private void F_LoadAfterUpdate(object sender, EventArgs e)
        {
            LoadListCustomer();

            for (int i = 0; i < dtgvManageCustomer.SelectedRows.Count; i++)
            {
                dtgvManageCustomer.SelectedRows[i].Selected = false;
            }

            Customer customer = (sender as FUpdateCustomer).Customer;
            int index = 0;
            while (Int32.Parse(dtgvManageCustomer.Rows[index].Cells["ID"].Value.ToString()) != customer.ID)
            {
                index++;
            }
            dtgvManageCustomer.Rows[index].Selected = true;
        }

        private void pbRemoveCustomer_Click(object sender, EventArgs e)
        {
            int id = (int)dtgvManageCustomer.SelectedRows[0].Cells["id"].Value;
            try
            {
                RemoveCustomerByCustomerID(id);
                MessageBox.Show("Xóa khách hàng thành công !");
                LoadListCustomer();
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        private void pbSearchCustomer_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
            if (txbSearchCustomer.Text != "")
            {
                List<Customer> list = CustomerDAO.Instance.SearchCustomerByName(txbSearchCustomer.Text);
                for (int i = 0; i < dtgvManageCustomer.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvManageCustomer.Rows[i].Cells["name"].Value.ToString() == list[j].Name)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvManageCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        private void pbHistoryBill_Click(object sender, EventArgs e)
        {
            FListBill f = new FListBill();
            f.ShowDialog();
        }
        #endregion


    }
}

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
    public partial class UCCollectMoney : UserControl
    {
        public UCCollectMoney()
        {
            InitializeComponent();
            LoadForm();
        }
        private bool check;
        BindingSource customerList = new BindingSource();
        void LoadForm()
        {
            pbSaveCollectMoney.Enabled = false;
            pbRemoveCollectMoney.Enabled = false;
            dtpkDate.Enabled = false;
            txbMoney.Enabled = false;

            dtgvCustomer.DataSource = customerList;
            LoadListCustomer();
            check = ThamSoDAO.Instance.GetCheck();

            txbDate.Text = dtpkDate.Value.ToString();
            txbMoneyCollect.Text = "0";
        }
        void LoadListCustomer()
        {
            customerList.DataSource = CustomerDAO.Instance.GetListCustomer();
        }

        public void SaveCollectMoney(Customer customer, DateTime date, float moneyCollect)
        {
            if (!CollectMoneyDAO.Instance.SaveCollectMoney(customer.ID, date, moneyCollect))
            {
                MessageBox.Show("Có lỗi khi lưu phiếu nhập !");
                return;
            }
            MessageBox.Show("Lưu phiếu nhập thành công !");
            CustomerDAO.Instance.UpdateCustomer(customer.ID, customer.Name, customer.Address, customer.Phonenumber, customer.Email, customer.Owe - moneyCollect);
            LoadListCustomer();
            txbMoney.Text = "0";
        }
        public void RemoveAllInCollectMoney()
        {
            txbName.Text = "";
            txbPhoneNumber.Text = "";
            txbMoneyCollect.Text = "0";
            txbEmail.Text = "";
            txbAddress.Text = "";
        }

        private void txbMoney_TextChanged(object sender, EventArgs e)
        {
            try // lỗi khi xóa hết text
            {
                int idCustomer = Int32.Parse(dtgvCustomer.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                Customer customer = CustomerDAO.Instance.GetCustomerByCustomerID(idCustomer);

                if (customer.Owe < (float)Double.Parse(txbMoney.Text) && check)
                {
                    MessageBox.Show("Số tiền thu cao hơn số tiền nợ của khách hàng !");
                    txbMoney.Text = "0";
                    return;
                }

                txbMoneyCollect.Text = txbMoney.Text;
            }
            catch { }
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            txbDate.Text = dtpkDate.Value.ToString();
        }

        private void pbAddCollectMoney_Click(object sender, EventArgs e)
        {
            RemoveAllInCollectMoney();

            pbSaveCollectMoney.Enabled = true;
            pbRemoveCollectMoney.Enabled = true;
            dtpkDate.Enabled = true;
            txbMoney.Enabled = true;
        }

        private void txbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbSaveCollectMoney_Click(object sender, EventArgs e)
        {
            int idCustomer = Int32.Parse(dtgvCustomer.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            Customer customer = CustomerDAO.Instance.GetCustomerByCustomerID(idCustomer);
            DateTime date = dtpkDate.Value;
            if (txbMoneyCollect.Text == null)
            {
                MessageBox.Show("Chưa nhập số tiền thu !");
                return;
            }
            float moneyCollect = (float)Double.Parse(txbMoneyCollect.Text);


            SaveCollectMoney(customer, date, moneyCollect);

            pbSaveCollectMoney.Enabled = false;
            pbRemoveCollectMoney.Enabled = false;
            dtpkDate.Enabled = false;
            txbMoney.Enabled = false;
        }

        private void pbRemoveCollectMoney_Click(object sender, EventArgs e)
        {
            RemoveAllInCollectMoney();

            pbSaveCollectMoney.Enabled = false;
            pbRemoveCollectMoney.Enabled = false;
            dtpkDate.Enabled = false;
            txbMoney.Enabled = false;
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbName.Text = dtgvCustomer.SelectedRows[0].Cells["name"].Value.ToString();
            txbPhoneNumber.Text = dtgvCustomer.SelectedRows[0].Cells["phoneNumber"].Value.ToString();
            txbEmail.Text = dtgvCustomer.SelectedRows[0].Cells["email"].Value.ToString();
            txbAddress.Text = dtgvCustomer.SelectedRows[0].Cells["address"].Value.ToString();
        }
    }
}

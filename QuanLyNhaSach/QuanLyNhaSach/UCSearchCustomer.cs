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
    public partial class UCSearchCustomer : UserControl
    {
        BindingSource listCustomer = new BindingSource();
        public UCSearchCustomer()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            dtgvListCustomer.DataSource = listCustomer;
            listCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
        }
        public void SearchCustomer()
        {
            listCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            if (txbCustomerName.Text != "")
            {
                List<Customer> list = CustomerDAO.Instance.SearchCustomerByName(txbCustomerName.Text);
                for (int i = 0; i < dtgvListCustomer.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvListCustomer.Rows[i].Cells["name"].Value.ToString() == list[j].Name)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvListCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (txbPhoneNumber.Text != "")
            {
                List<Customer> list = CustomerDAO.Instance.SearchCustomerByPhoneNumber(txbPhoneNumber.Text);
                for (int i = 0; i < dtgvListCustomer.RowCount; i++)
                {
                    int j = 0;
                    for (; j < list.Count; j++)
                    {
                        if (dtgvListCustomer.Rows[i].Cells["phoneNumber"].Value.ToString() == list[j].Phonenumber)
                            break;
                    }
                    if (j == list.Count)
                    {
                        dtgvListCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (ckbOwe.Checked == true)
            {
                for (int i = 0; i < dtgvListCustomer.RowCount; i++)
                {
                    if ((float)Double.Parse(dtgvListCustomer.Rows[i].Cells["owe"].Value.ToString()) < (int)nmOweFrom.Value ||
                        (float)Double.Parse(dtgvListCustomer.Rows[i].Cells["owe"].Value.ToString()) > (int)nmOweTo.Value)
                    {
                        dtgvListCustomer.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void ckbOwe_CheckedChanged(object sender, EventArgs e)
        {
            nmOweFrom.Enabled = ckbOwe.Checked == true;
            nmOweTo.Enabled = ckbOwe.Checked == true;

            if (ckbOwe.Checked == false)
                SearchCustomer();
        }

        private void txbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txbCustomerName.Text == "")
                SearchCustomer();
        }

        private void txbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txbPhoneNumber.Text == "")
                SearchCustomer();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }
    }
}

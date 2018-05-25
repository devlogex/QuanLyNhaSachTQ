using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.DTO;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach
{
    public partial class UCBill : UserControl
    {
        public UCBill()
        {
            InitializeComponent();
            LoadForm();
        }

        private float percentPrice;
        private float maxOwe;
        private float minCount;


        #region Method
        public void LoadForm()
        {
            LoadListBookIntoCB(cbBook);
            LoadListCustomerIntoCB(cbCustomer);

            dtpkBill.Value = DateTime.Now;

            percentPrice = ThamSoDAO.Instance.GetPercentPrice();
            maxOwe = ThamSoDAO.Instance.GetMaxOwe();
            minCount = ThamSoDAO.Instance.GetMinCount();

            txbPrice.Text = ((cbBook.SelectedItem as Book).PriceIn * percentPrice).ToString();

            btnAddBookBill.Enabled = false;
            btnRemoveBookBill.Enabled = false;
            btnUpdateBookBill.Enabled = false;
            btnCheckOut.Enabled = false;
        }

        public void LoadListBookIntoCB(ComboBox cb)
        {
            cb.DataSource = BookDAO.Instance.GetListBook();
            cb.DisplayMember = "name";
        }
        public void LoadListCustomerIntoCB(ComboBox cb)
        {
            cbCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            cb.DisplayMember = "name";
        }
        public void AddBookIntoBill(Book book)
        {
            int index = dtgvBill.Rows.Count;
            int idBook = book.ID;
            string nameBook = book.Name;
            string author = book.Author;
            int count = (int)nmCount.Value;
            float priceOut = (float)Double.Parse(txbPrice.Text);
            string nameCategory = CategoryBookDAO.Instance.GetCategoryBookByBookID(idBook).Name;


            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if ((int)dtgvBill.Rows[i].Cells["idBook"].Value == idBook)
                {
                    dtgvBill.Rows[i].Cells["count"].Value = (Int64.Parse(dtgvBill.Rows[i].Cells["count"].Value.ToString()) + Int64.Parse(nmCount.Value.ToString()));
                    return;
                }
            }
            dtgvBill.Rows.Add(index, idBook, nameBook, nameCategory, author, count, priceOut);
        }
        public void RemoveBookInBill(int index)
        {
            try
            {
                dtgvBill.Rows.RemoveAt(index);
                int i = index;
                while (i < dtgvBill.Rows.Count)
                {
                    dtgvBill.Rows[i].Cells["STT"].Value = i;
                    i++;
                }
            }
            catch { }
        }
        public void RemoveAllBookInBill()
        {
            while (dtgvBill.Rows.Count != 0)
            {
                dtgvBill.Rows.RemoveAt(0);
            }
        }
        public void UpdateBookInBill(int index)
        {
            if (dtgvBill.Rows[index].Cells["idBook"].Value != null)
            {
                dtgvBill.Rows[index].Cells["count"].Value = (int)nmCount.Value;
            }
        }
        public void UpdateBillValue()
        {
            txbTotalPrice.Text = (Double.Parse(txbTotalPrice.Text) + Double.Parse(txbPrice.Text) * (int)nmCount.Value).ToString();
        }
        public void CheckOutBill()
        {
            Customer customer = cbCustomer.SelectedItem as Customer;
            DateTime date = dtpkBill.Value;
            float billValue = (float)Double.Parse(txbTotalPrice.Text);
            float oweNow = (float)Double.Parse(txbMoneyOwe.Text); //tiền nợ cho hóa đơn lần này
            float payBack = (float)Double.Parse(txbMoneyOwe.Text);//tiền thối lại cho khách
            if (oweNow < 0)
            {
                oweNow = 0;
                payBack = -payBack;
            }
            else
            {
                payBack = 0; ;
            }

            if (!BillDAO.Instance.InsertBill(customer, date, billValue, oweNow))
            {
                MessageBox.Show("Có lỗi khi thêm hóa đơn !");
                return;
            }

            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                int idBook = (int)dtgvBill.Rows[i].Cells["idBook"].Value;
                int count = (int)dtgvBill.Rows[i].Cells["count"].Value;
                float priceOut = (float)Double.Parse(dtgvBill.Rows[i].Cells["priceOut"].Value.ToString());

                if (!BillInfoDAO.Instance.InsertBillInfo(idBook, count, priceOut))
                {
                    MessageBox.Show("Có lỗi khi thêm sách vào hóa đơn !");
                    return;
                }
            }

            MessageBox.Show(String.Format("Thông tin hóa đơn :\nKhách hàng :{0} \nTrị giá hóa đơn :{1}\nSố tiền trả :{2}\nNợ :{3}\nTiền thối lại :{4}", customer.Name, txbTotalPrice.Text, txbReceiveMoney.Text, oweNow, payBack),"Hóa đơn");
            if (oweNow > 0)
            {
                CustomerDAO.Instance.UpdateCustomer(customer.ID, customer.Name, customer.Address, customer.Phonenumber, customer.Email, customer.Owe + oweNow);
            }
        }
        public bool CheckBook(Book book)
        {
            int countOut = (int)nmCount.Value;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if ((int)dtgvBill.Rows[i].Cells["idBook"].Value == book.ID)
                {
                    countOut = countOut + (int)dtgvBill.Rows[i].Cells["count"].Value;
                }
            }
            if ((book.Count - countOut) < minCount)
            {
                if (book.Count - minCount > 0)
                    MessageBox.Show("Số lượng sách trong kho cho phép bán là " + (book.Count - minCount));
                else
                    MessageBox.Show("Số lượng sách trong kho không đủ để cho phép bán ");
                return false;
            }
            return true;
        }
        public bool CheckCustomer(Customer customer)
        {
            if (customer.Owe > maxOwe)
            {
                MessageBox.Show("Khách hàng nợ quá " + maxOwe + " nên không thể tiếp tục mua sách ");
                return false;
            }
            else if ((customer.Owe + (float)Double.Parse(txbMoneyOwe.Text)) > maxOwe)
            {
                MessageBox.Show("Nợ cũ và nợ lần này của khách hàng vượt quá quy định nên không thể thanh toán");
                return false;
            }
            return true;
        }
        #endregion

        private void pbAddBill_Click(object sender, EventArgs e)
        {
            RemoveAllBookInBill();

            btnAddBookBill.Enabled = true;
            btnRemoveBookBill.Enabled = true;
            btnUpdateBookBill.Enabled = true;
            btnCheckOut.Enabled = true;

        }
        private void pbRemoveBill_Click(object sender, EventArgs e)
        {
            RemoveAllBookInBill();

            btnAddBookBill.Enabled = false;
            btnRemoveBookBill.Enabled = false;
            btnUpdateBookBill.Enabled = false;
            btnCheckOut.Enabled = false;
        }

        private void btnAddBookBill_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = cbBook.SelectedItem as Book;
                if (CheckBook(book))
                {
                    AddBookIntoBill(book);
                    UpdateBillValue();
                }
            }
            catch { }
        }

        private void btnRemoveBookBill_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvBill.SelectedCells[0].OwningRow.Index;
                RemoveBookInBill(index);
            }
            catch { }
        }

        private void btnUpdateBookBill_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvBill.SelectedCells[0].OwningRow.Index;
                UpdateBookInBill(index);
                UpdateBillValue();
            }
            catch { }
        }

        private void txbReceiveMoney_TextChanged(object sender, EventArgs e)
        {
            txbMoneyOwe.Text = (Double.Parse(txbTotalPrice.Text) - Double.Parse(txbReceiveMoney.Text)).ToString();
        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {
            txbMoneyOwe.Text = (Int64.Parse(txbTotalPrice.Text) - Int32.Parse(txbReceiveMoney.Text)).ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dtgvBill.Rows.Count==0)
            {
                MessageBox.Show("Không có sách trong hóa đơn !");
                return;
            }
            if (CheckCustomer(cbCustomer.SelectedItem as Customer))
            {
                CheckOutBill();
            }
        }

        private void txbReceiveMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbPrice.Text = ((cbBook.SelectedItem as Book).PriceIn * percentPrice).ToString();
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if (Int32.Parse(dtgvBill.Rows[i].Cells["idBook"].Value.ToString()) == ((sender as ComboBox).SelectedItem as Book).ID)
                {
                    for (int j = 0; j < dtgvBill.Rows.Count; j++)
                        dtgvBill.Rows[j].Selected = false;
                    dtgvBill.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvBill.SelectedCells.Count > 0)
            {
                int idBook = (int)dtgvBill.SelectedCells[0].OwningRow.Cells["idBook"].Value;
                foreach (Book item in BookDAO.Instance.GetListBook())
                {
                    if (item.ID == idBook)
                        cbBook.SelectedItem = item;
                }
                int index = -1;
                int i = 0;
                foreach (Book item in cbBook.Items)
                {
                    if (item.ID == idBook)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbBook.SelectedIndex = index;
            }
        }

        private void pbAddCustomer_Click(object sender, EventArgs e)
        {
            FAddCustomer f = new FAddCustomer();
            f.ShowDialog();

            this.LoadListCustomerIntoCB(cbCustomer);
        }

        private void pbHistoryBill_Click(object sender, EventArgs e)
        {
            FListBill f = new FListBill();
            f.ShowDialog();
        }
    }
}

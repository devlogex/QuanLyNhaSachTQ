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
    public partial class UCAdmin : UserControl
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public UCAdmin(Account acc)
        {
            InitializeComponent();

            this.Acc = acc;
            LoadForm();
        }
        public void LoadForm()
        {
            LoadAccount();
            this.Load += delegate (object sender, EventArgs e)
            {
                for (int i = 0; i < dtgvAccount.RowCount; i++)
                    dtgvAccount.Rows[i].Cells["STT"].Value = i + 1;
            };
        }

        public void LoadAccount()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetListAccount();
            for (int i = 0; i < dtgvAccount.RowCount; i++)
                dtgvAccount.Rows[i].Cells["STT"].Value = i + 1;
        }
        private void pbAddAccount_Click(object sender, EventArgs e)
        {
            FAddAccount f = new FAddAccount();
            f.UpdateListAccount += F_UpdateListAccount;
            f.ShowDialog();
        }

        private void F_UpdateListAccount(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void pbUpdateAccount_Click(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản để sửa");
                return;
            }
            Account acc = AccountDAO.Instance.GetAccountByUserName(dtgvAccount.SelectedRows[0].Cells["userName"].Value.ToString());
            if(this.Acc==acc)
            {
                MessageBox.Show("Không cho sửa tài khoản đang đăng nhập ở đây !");
                return;
            }
            FUpdateAccount f = new FUpdateAccount(acc);
            f.UpdateListAccount += F_UpdateListAccount;
            f.ShowDialog();
        }

        private void pbRemoveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = dtgvAccount.SelectedCells[0].OwningRow.Cells["userName"].Value.ToString();
                Account acc = AccountDAO.Instance.GetAccountByUserName(userName);
                if (acc.Type == 0)
                {
                    MessageBox.Show("Không thể xóa tài khoản admin !");
                    return;
                }
                if (AccountDAO.Instance.RemoveAccountByUserName(userName))
                {
                    MessageBox.Show("Xóa tài khoản thành công !");
                    LoadAccount();
                }
                else
                    MessageBox.Show("Xóa không thành công ");
            }
            catch { MessageBox.Show("Có lỗi khi xóa"); }
        }

        private void txbSearchAccount_TextChanged(object sender, EventArgs e)
        {
            if (txbSearchAccount.Text == "")
                LoadAccount();
        }

        private void pbSearchAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Account acc = AccountDAO.Instance.GetAccountByUserName(txbSearchAccount.Text);
                List<Account> list = new List<Account>();
                list.Add(acc);
                dtgvAccount.DataSource = list;
                dtgvAccount.Rows[0].Cells["STT"].Value = 1;
            }
            catch
            {
                List<Account> list = new List<Account>();
                dtgvAccount.DataSource = list;
            }
            
        }
    }
}

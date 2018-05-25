using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FManager : Form
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public FManager(Account acc)
        {
            InitializeComponent();

            this.Acc = acc;
            LoadForm();
        }

        public void LoadForm()
        {
            itemDisplayName.Text = this.Acc.DisplayName;

            pnUserControl.Controls.Clear();
            UCDefault uc = new UCDefault();
            uc.MyEvent += Uc_MyEvent;
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Uc_MyEvent(object sender, EventLoadForm e)
        {
            switch(e.NameEvent)
            {
                case "pbAddBook_Click":
                    {
                        FAddBook f = new FAddBook();
                        f.ShowDialog();
                        break;
                    }
                case "pbAddCustomer_Click":
                    {
                        FAddCustomer f = new FAddCustomer();
                        f.ShowDialog();
                        break;
                    }
                case "pbAddCategory_Click":
                    {
                        FAddCategory f = new FAddCategory();
                        f.ShowDialog();
                        break;
                    }
                case "pbAddImportBook_Click":
                    {
                        pnUserControl.Controls.Clear();
                        UCImportBook uc = new UCImportBook();
                        pnUserControl.Controls.Add(uc);
                        uc.BringToFront();
                        break;
                    }
                case "pbAddBill_Click":
                    {
                        pnUserControl.Controls.Clear();
                        UCBill uc = new UCBill();
                        pnUserControl.Controls.Add(uc);
                        uc.BringToFront();
                        break;
                    }
                case "pbAddCollectMoney_Click":
                    {
                        pnUserControl.Controls.Clear();
                        UCCollectMoney uc = new UCCollectMoney();
                        pnUserControl.Controls.Add(uc);
                        uc.BringToFront();
                        break;
                    }
            }
        }

        #region Event
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCManageBook uc = new UCManageBook();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCManageCustomer uc = new UCManageCustomer();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void quảnLýThểLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCManageCategory uc = new UCManageCategory();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }



        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCDefault uc = new UCDefault();
            uc.MyEvent += Uc_MyEvent;
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void lậpPhiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCImportBook uc = new UCImportBook();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCBill uc = new UCBill();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void lậpPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCCollectMoney uc = new UCCollectMoney();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void báoCáoTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCReportCount uc = new UCReportCount();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void báoCáoNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCReportOwe uc = new UCReportOwe();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void traCứuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCSearchBook uc = new UCSearchBook();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void traCứuKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCSearchCustomer uc = new UCSearchCustomer();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCSystem uc = new UCSystem();
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnUserControl.Controls.Clear();
            UCAdmin uc = new UCAdmin(this.Acc);
            pnUserControl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void itemAccount_Click(object sender, EventArgs e)
        {
            FUpdateAccount f = new FUpdateAccount(this.Acc);
            f.UpdateListAccount += delegate (object _sender, EventArgs _e)
            {
                Account acc = AccountDAO.Instance.GetAccountByUserName(this.Acc.UserName);
                this.Acc = acc;
                itemDisplayName.Text = this.Acc.DisplayName;
            };
            f.ShowDialog();
        }

        private void itemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}

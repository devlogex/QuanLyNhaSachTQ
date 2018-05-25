﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach
{
    public partial class UCSystem : UserControl
    {
        public UCSystem()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadForm()
        {
            nmUD1.Value = ThamSoDAO.Instance.GetMinImport();
            nmUD2.Value = ThamSoDAO.Instance.GetMaxCount();
            nmUD3.Value = (int)ThamSoDAO.Instance.GetMaxOwe();
            nmUD4.Value = ThamSoDAO.Instance.GetMinCount();
            txbPercentPrice.Text = (ThamSoDAO.Instance.GetPercentPrice() * 100).ToString();
            cbQD4.Checked = (ThamSoDAO.Instance.GetCheck() == true);
        }
        private void btnUpdateSystem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ThamSoDAO.Instance.SetMinImport((int)nmUD1.Value) &&
                ThamSoDAO.Instance.SetMaxCount((int)nmUD2.Value) &&
                ThamSoDAO.Instance.SetMaxOwe((float)nmUD3.Value) &&
                ThamSoDAO.Instance.SetMinCount((int)nmUD4.Value) &&
                ThamSoDAO.Instance.SetPercentPrice((float)Double.Parse(txbPercentPrice.Text) / 100) &&
                ThamSoDAO.Instance.SetCheck(Convert.ToInt32(cbQD4.Checked == true)))
                    MessageBox.Show("Cập nhật thành công ");
                else
                    MessageBox.Show("Cập nhật không thành công ");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi !");
            }
        }
        private void txbPercentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '.') && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

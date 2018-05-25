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
    public partial class UCReportOwe : UserControl
    {
        public UCReportOwe()
        {
            InitializeComponent();
        }
        public bool CheckReportOwe(int month, int year)
        {
            return ReportOweDAO.Instance.CheckReportOwe(month, year);
        }
        public void LoadReportOwe(int month, int year)
        {
            dtgvReportOwe.DataSource = ReportOweDAO.Instance.LoadReportOwe(month, year);
            for (int i = 0; i < dtgvReportOwe.Rows.Count; i++)
            {
                dtgvReportOwe.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void CreateReportOwe(int month, int year)
        {

            if (!ReportOweDAO.Instance.InsertReportOwe(month, year))
            {
                MessageBox.Show("Có lỗi khi tạo báo cáo tháng!");
                return;
            }

            List<int> listCustomerID = CustomerDAO.Instance.GetListCustomerID();
            List<CollectMoney> listCollectMoney = CollectMoneyDAO.Instance.GetListCollectMoneyByTime(month, year);// trong thang xu ly
            List<Bill> listBill = BillDAO.Instance.GetListBillByTime(month, year); // trong thang xu ly

            foreach (int idCustomer in listCustomerID)
            {
                float firstOwe = 0;
                float lastOwe = 0;
                float addOwe = 0;
                float payInCollectMoney = 0;

                foreach (Bill item in listBill)
                {
                    if (item.IdCustomer == idCustomer)
                    {
                        addOwe += item.Owe;
                    }
                }
                foreach (CollectMoney item in listCollectMoney)
                {
                    if (item.IdCustomer == idCustomer)
                    {
                        payInCollectMoney += item.Money;
                    }
                }

                DateTime date = (new DateTime(year, month, 1)).AddMonths(-1); // thang truoc
                if (ReportOweDAO.Instance.CheckReportOwe(date.Month, date.Year))
                {
                    ReportOweInfo rpI = ReportOweInfoDAO.Instance.GetReportOweInfoByTimeAndCustomerID(date.Month, date.Year, idCustomer);
                    if (rpI != null)
                        firstOwe = rpI.LastOwe;
                    else
                        firstOwe = 0;
                }
                else
                {
                    firstOwe = 0;
                }
                lastOwe = firstOwe + addOwe - payInCollectMoney;

                if (!ReportOweInfoDAO.Instance.InsertReportOweInfo(month, year, idCustomer, firstOwe, addOwe, lastOwe))
                {
                    MessageBox.Show("Có lỗi khi tạo báo cáo tháng!");
                    return;
                }
            }
        }
        public void UpdateReportOwe(int month, int year)
        {
            ReportOweInfoDAO.Instance.RemoveAllReportOweInfoInTime(month, year);
            ReportOweDAO.Instance.RemoveReportOwe(month, year);
            CreateReportOwe(month, year);
        }
        private void btnReportOwe_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime date = new DateTime((int)nmYear.Value, (int)nmMonth.Value, today.Day);
            if (date > today)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
                return;
            }

            if (CheckReportOwe(date.Month, date.Year))
            {
                if (today.Month == date.Month && today.Year == date.Year)
                {
                    UpdateReportOwe(date.Month, date.Year);
                    LoadReportOwe(date.Month, date.Year);
                }
                else
                {
                    LoadReportOwe(date.Month, date.Year);
                }
            }
            else
            {
                CreateReportOwe(date.Month, date.Year);
                LoadReportOwe(date.Month, date.Year);
            }
        }
    }
}

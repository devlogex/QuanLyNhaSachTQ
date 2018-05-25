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
    public partial class UCReportCount : UserControl
    {
        public UCReportCount()
        {
            InitializeComponent();
        }
        public bool CheckReportCount(int month, int year)
        {
            return ReportCountDAO.Instance.CheckReportCount(month, year);
        }
        public void LoadReportCount(int month, int year)
        {
            dtgvReportCount.DataSource = ReportCountDAO.Instance.LoadReportCount(month, year);
            for (int i = 0; i < dtgvReportCount.Rows.Count; i++)
            {
                dtgvReportCount.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void CreateReportCount(int month, int year)
        {

            if (!ReportCountDAO.Instance.InsertReportCount(month, year))
            {
                MessageBox.Show("Có lỗi khi tạo báo cáo tháng!");
                return;
            }


            List<int> listBookID = BookDAO.Instance.GetListBookID();
            List<ImportBookInfo> listImportBookInfo = ImportBookInfoDAO.Instance.GetListImportBookInfoByTime(month, year);// trong thang xu ly
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfoByTime(month, year); // trong thang xu ly

            foreach (int idBook in listBookID)
            {
                int firstCount = 0;
                int lastCount = 0;
                int addCount = 0;
                int countBookInBill = 0;

                foreach (BillInfo item in listBillInfo)
                {
                    if (item.IdBook == idBook)
                    {
                        countBookInBill += item.Count;
                    }
                }
                foreach (ImportBookInfo item in listImportBookInfo)
                {
                    if (item.IDBook == idBook)
                    {
                        addCount += item.Count;
                    }
                }

                DateTime date = (new DateTime(year, month, 1)).AddMonths(-1); // thang truoc
                if (ReportCountDAO.Instance.CheckReportCount(date.Month, date.Year))
                {
                    ReportCountInfo rpI = ReportCountInfoDAO.Instance.GetReportCountInfoByTimeAndBookID(date.Month, date.Year, idBook);
                    if (rpI != null)
                        firstCount = rpI.LastCount;
                    else
                        firstCount = 0;
                }
                else
                {
                    firstCount = 0;
                }
                lastCount = firstCount + addCount - countBookInBill;

                if (!ReportCountInfoDAO.Instance.InsertReportCountInfo(month, year, idBook, firstCount, addCount, lastCount))
                {
                    MessageBox.Show("Có lỗi khi tạo báo cáo tháng!");
                    return;
                }
            }

        }
        public void UpdateReportCount(int month, int year)
        {
            ReportCountInfoDAO.Instance.RemoveAllReportCountInfoInTime(month, year);
            ReportCountDAO.Instance.RemoveReportCount(month, year);
            CreateReportCount(month, year);
        }
        private void btnReportBook_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime date = new DateTime((int)nmYear.Value, (int)nmMonth.Value, today.Day);
            //DateTime dateFrom = new DateTime(date.Year,date.Month,1);
            //DateTime dateTo = dateFrom.AddMonths(1).AddDays(-1);

            if (date > today)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
                return;
            }

            if (CheckReportCount(date.Month, date.Year))
            {
                if (today.Month == date.Month && today.Year == date.Year)
                {
                    UpdateReportCount(date.Month, date.Year);
                    LoadReportCount(date.Month, date.Year);
                }
                else
                {
                    LoadReportCount(date.Month, date.Year);
                }
            }
            else
            {
                CreateReportCount(date.Month, date.Year);
                LoadReportCount(date.Month, date.Year);
            }

        }
    }
}

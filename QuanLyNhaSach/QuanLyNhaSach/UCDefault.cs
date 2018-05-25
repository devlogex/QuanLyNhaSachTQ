using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class UCDefault : UserControl
    {
        public UCDefault()
        {
            InitializeComponent();
        }
        private event EventHandler<EventLoadForm> myEvent;
        public event EventHandler<EventLoadForm> MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        private void pbAddBook_Click(object sender, EventArgs e)
        {
            if (myEvent != null)
                myEvent(this, new EventLoadForm("pbAddBook_Click"));
        }

        private void pbAddCustomer_Click(object sender, EventArgs e)
        {
            if (myEvent != null)
                myEvent(this, new EventLoadForm("pbAddCustomer_Click"));
        }

        private void pbAddCategory_Click(object sender, EventArgs e)
        {
            if (myEvent != null)
                myEvent(this, new EventLoadForm("pbAddCategory_Click"));
        }

        private void pbAddImportBook_Click(object sender, EventArgs e)
        {
            if (myEvent != null)
                myEvent(this, new EventLoadForm("pbAddImportBook_Click"));
        }

        private void pbAddBill_Click(object sender, EventArgs e)
        {
            if (myEvent != null)
                myEvent(this, new EventLoadForm("pbAddBill_Click"));
        }

        private void pbAddCollectMoney_Click(object sender, EventArgs e)
        {
            if (myEvent != null)
                myEvent(this, new EventLoadForm("pbAddCollectMoney_Click"));
        }
    }
    public class EventLoadForm : EventArgs
    {
        private string nameEvent;
        public string NameEvent { get => nameEvent; set => nameEvent = value; }
        public EventLoadForm(string nameEvent)
        {
            this.NameEvent = nameEvent;
        }
    }
}

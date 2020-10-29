using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BasicQueuingSystem.QueuingForm;

namespace BasicQueuingSystem
{
    public partial class CashierWindowQueue : Form
    {

        CustomerViewForm cv;

        public CashierWindowQueue()
        {
            InitializeComponent();
            timer1.Start();
            cv = new CustomerViewForm();
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void CashierWindowQueue_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            try
            {
                cv.Show();
                cv.lblNowServing.Text = CashierClass.CashierQueue.Peek();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("No number queued.");
            }
            CashierClass.CashierQueue.Dequeue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}

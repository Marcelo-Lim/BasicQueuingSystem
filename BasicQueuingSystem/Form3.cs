using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BasicQueuingSystem.QueuingForm;
using static BasicQueuingSystem.CashierWindowQueue;

namespace BasicQueuingSystem
{
    public partial class CustomerViewForm : Form
    {
        CashierClass cashier;
        public CustomerViewForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void lblNowServing_Click(object sender, EventArgs e)
        {

        }
    }
}

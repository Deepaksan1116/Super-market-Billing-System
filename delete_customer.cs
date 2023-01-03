using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_Market_Billing_System;

namespace Super_Market_Billing_Application
{
    public partial class delete_customer : Form
    {
        public delete_customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CustomerRespository c10 = new CustomerRespository();
            //Customer c11 = new Customer();
            //c11.Customer_id = textBox1.Text;
            //c10.Delete_customer(c11);
            //MessageBox.Show("deletd");
            Select_Customer s1 = new Select_Customer();
            s1.Show();

        }
    }
}

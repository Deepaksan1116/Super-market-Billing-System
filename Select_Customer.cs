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
    public partial class Select_Customer : Form
    {
        public Select_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Customer c12=new Customer();
           Address a14 = new Address();
           c12.Customer_id = textBox1.Text;
           CustomerRespository c13 = new CustomerRespository();
           c13.Get_customer(c12,a14);
           //label2.Text = c13.Get_customer(c12,a14);
           MessageBox.Show("selected");
        }
    }
}

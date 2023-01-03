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
    public partial class Edit_Customer : Form
    {
        public Edit_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Customer c1 = new Customer();
            //CustomerRespository c4 = new CustomerRespository();
            //Customers c9 = new Customers();
            //Address a5 = new Address();
            //c1.Customer_id = textBox1.Text;
           
            //a5.House_no = textBox3.Text;
            //a5.Street_name = textBox4.Text;
            //a5.Village_name = textBox5.Text;
            //a5.District = textBox6.Text;
            //a5.Pincode = textBox7.Text;
            //c1.Name = textBox8.Text;
            //c1.Address_details = a5;
            //c4.Update_customer(c1, a5);
            //MessageBox.Show("updated ");
            delete_customer d1 = new delete_customer();
            d1.Show();

        }
    }
}

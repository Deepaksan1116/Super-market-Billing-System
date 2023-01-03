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
    public partial class insert_customer : Form
    {
        public insert_customer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Customer c5 = new Customer();
            //Customers c6 = new Customers();
            //Address a1 = new Address();
            //CustomerRespository c8 = new CustomerRespository();
            //a1.House_no = textBox4.Text;
            //a1.Street_name = textBox5.Text;
            //a1.Village_name = textBox6.Text;
            //a1.District = textBox7.Text;
            //a1.Pincode = textBox8.Text;
            //c5.Name = textBox1.Text;
            //c5.Contact_number = textBox2.Text;
            //c5.Customer_id = textBox3.Text;
            //c5.Address_details = a1;
            //c6.Add_customer(c5);
            //c8.Insert_Customer(c5, a1);


            //MessageBox.Show("insertd");
         Edit_Customer e2 = new Edit_Customer();
         e2.Show();

            
            

        }
    }
}

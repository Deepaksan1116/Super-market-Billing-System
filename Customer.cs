using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market_Billing_System
{
    public class Customer:Human
    {
        string X = "v";
        string _customer_id;

        public string Customer_id
        {
            get { return _customer_id; }
            set { _customer_id = value; }
        }
        public Customer(string name, string phonenumber, Address details,string customerid)
        {
          
            this.Name = name;
            this.Contact_number = phonenumber;
            this.Address_details =details;
            this.Customer_id = customerid;

        }
        public Customer()
        {

        }
        public string Generate_Customer_id()
        {
            string x =" cust_id";
            string c = x+X;
            return c;
        }
        
    }
}

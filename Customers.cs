using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market_Billing_System
{
   public class Customers
    {
        List<Customer> customer_list = new List<Customer>();

        public List<Customer> Customer_list
        {
            get { return customer_list; }
            set { customer_list = value; }
        }
        public void Add_customer(Customer cust)
        {
            Customer cust1 = new Customer(cust.Name, cust.Contact_number, cust.Address_details,cust.Generate_Customer_id());
            customer_list.Add(cust1);
        }
        public void Remove_customer(Customer rem)
        {
            foreach (Customer item in customer_list)
            {
                if (rem.Customer_id == item.Customer_id)
                {
                    customer_list.Remove(item);
                    break;
                }

            }

        }
        public void Edit_customer(Customer edt)
        {

            foreach (Customer item in customer_list)
            {
                if (item.Customer_id == edt.Customer_id||item.Contact_number==edt.Contact_number)
                {
                    item.Address_details = edt.Address_details;
                    item.Contact_number = edt.Contact_number;
                    break;
                }

            }
        }
        public Customer Get_Customer_Details(Customer cus)
        {
            Customer temp = new Customer();
             foreach (Customer item in customer_list)
             {
                 if (cus.Customer_id == item.Customer_id)
                 {
                     temp = item;
                 }
                
             }
             return temp;
        }
      



    }
}

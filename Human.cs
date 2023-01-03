using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market_Billing_System
{
    public class Human
    {
        Address _address_details;

        public Address Address_details
        {
            get { return _address_details; }
            set { _address_details = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _contact_number;

        public string Contact_number
        {
            get { return _contact_number; }
            set 
            {
                if (value.Length == 10)
                {
                    _contact_number = value;
                }
            }
        }
        public Human()
        {

        }

    }
}

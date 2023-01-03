using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market_Billing_System
{
    class Product
    {

        string _product_id;
        string _product_name;
        float _product_price;
        float _central_tax;
        float _state_tax;
        double _tax_amount;

        public string Product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public string Product_name
        {
            get { return _product_name; }
            set { _product_name = value; }
        }

        public float Product_price
        {
            get { return _product_price; }
            set { _product_price = value; }
        }

        public float Central_tax
        {
            get { return _central_tax; }
            set { _central_tax = value; }
        }

        public float State_tax
        {
            get { return _state_tax; }
            set { _state_tax = value; }
        }

        public double Tax_amount
        {
            get { return _tax_amount; }
            set { _tax_amount = value; }
        }

        public string Get_product_name()
        {
            string product_name = string.Empty;
            if (Mydictionary.Product_names.ContainsKey(Product_id))
            {
                product_name = Mydictionary.Product_names[Product_id];
            }
            return product_name;
        }

        public float Get_product_price()
        {
            float price_ = 0;
            if (Mydictionary.Product_prices.ContainsKey(Product_id))
            {
                price_ = Mydictionary.Product_prices[Product_id];
            }
            return price_;
        }

        public float Get_central_tax()
        {
            float c_tax = 0;
            float amount = 0;

            if (Mydictionary.Central_tax_percentage.ContainsKey(Product_id))
            {
                c_tax = Mydictionary.Central_tax_percentage[Product_id];
            }
            amount = (c_tax / 100) * Get_product_price();
            return amount;
        }

        public float Get_state_tax()
        {
            float s_tax = 0;
            float amount = 0;

            if (Mydictionary.State_tax_percentage.ContainsKey(Product_id))
            {
                s_tax = Mydictionary.State_tax_percentage[Product_id];
            }
            amount = (s_tax / 100) * Get_product_price();
            return amount;
        }

        public double Get_tax_amount()
        {
            double total = 0;
            total = Get_product_price() + Get_central_tax() + Get_state_tax();
            return total;
        }


    }
}

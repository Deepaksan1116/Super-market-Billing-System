//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Super_Market_Billing_System
//{
//    public class Products
//    {
//        List<Product> Product_List = new List<Product>();

//        uint _product_qty;
//        double _product_with_qty_amount;

//        public uint Prdouct_qty
//        {
//            get { return _product_qty; }
//            set { _product_qty = value; }
//        }

//        public double Product_with_qty_amount
//        {
//            get { return _product_with_qty_amount; }
//            set { _product_with_qty_amount = value; }
//        }

//        public void Add_product(Product prt)
//        {

//            Product_List.Add(new Product { Product_id = prt.Product_id, Product_name = prt.Get_product_name(), Product_price = prt.Get_product_price(), Central_tax = prt.Get_central_tax(), State_tax = prt.Get_state_tax(), Tax_amount = prt.Tax_amount });

//        }
//        public void Remove_product(Product rem)
//        {
//            foreach (Product item in Product_List)
//            {
//                if (item.Product_id == rem.Product_id)
//                {
//                    Product_List.Remove(item);
//                    break;
//                }
//            }
//        }

//        public Product Get_product_details(Product final)
//        {
//            Product temp = new Product();
//            foreach (Product item in Product_List)
//            {
//                if (final.Product_id == item.Product_id)
//                {
//                    temp = item;
//                }
//            }
//            return temp;
//        }

//        public double Product_total()
//        {
//            double price = 0;
//            foreach (Product item in Product_List)
//            {
//                price = item.Product_price *_product_qty;
//            }
//            return price;
//        }


//    }
//}


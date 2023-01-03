using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Super_Market_Billing_System
{
    public class CustomerRespository
    {
        Exception ex = new Exception();
        string connectionString = "Server=.\\SQLEXPRESS;database=SuperMarket; integrated security=true;";
        public void Insert_Customer(Customer c1,Address a2)
        {
            
            SqlConnection con = new SqlConnection();
            
            con.ConnectionString=connectionString;
            con.Open();
            if(con.State==ConnectionState.Open)
            {
            SqlCommand comm = new SqlCommand();
            comm.Connection = con;
            comm.CommandText = "insert into customers (customer_id,customer_name,customer_number,door_number,street_name,village_name,district_name,pincode)VALUES(@customer_id,@customer_name,@customer_number,@door_number,@street_name,@village_name,@district_name,@pincode)";

            comm.Parameters.AddWithValue("@customer_id", c1.Customer_id);
                comm.Parameters.AddWithValue("@customer_name",c1.Name);
                comm.Parameters.AddWithValue("@customer_number", c1.Contact_number);
                comm.Parameters.AddWithValue("@door_number",a2.House_no);
                comm.Parameters.AddWithValue("@street_name", a2.Street_name);
                comm.Parameters.AddWithValue("@village_name", a2.Village_name);
                comm.Parameters.AddWithValue("@district_name", a2.District);
                comm.Parameters.AddWithValue("@pincode", a2.Pincode);


               
                comm.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                throw new Exception(ex.Message,ex.InnerException);
            }

        }
        public void Delete_customer(Customer c2)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "delete from customers where customer_id='" + c2.Customer_id + "'";
                comm.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }
        public void Update_customer(Customer c3,Address a4)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandText = "update customers set customer_name='" + c3.Name + "',door_number='" + a4.House_no + "',street_name='"+a4.Village_name+"',district_name='"+a4.District+"',pincode='"+a4.Pincode+"' where customer_id='"+c3.Customer_id+"'";

               
                con.Close();
            }
            else
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        
            public void Get_customer(Customer c4 ,Address a5)
            {
                
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;

                comm.CommandText = "select * from customers where customer_id='"+c4.Customer_id+"'";
                SqlDataReader dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    c4.Customer_id = dr["customer_id"].ToString();

                }
                dr.Close();
                con.Close();
               
            
            }
            else
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            }
    }
    }


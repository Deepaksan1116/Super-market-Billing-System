using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market_Billing_System
{
   public  class Address
    {
       
       
           string _house_no;
           string _street_name;
           string _village_name;
           string _taluk_name;
           string _pincode;
           string _district;

           public string House_no
           {
               get { return _house_no; }
               set
               {
                   if (value.Length >= 1 && value.Length <= 6)
                   {
                       _house_no = value;
                   }
               }
           }

           public string Street_name
           {
               get { return _street_name; }
               set
               {
                   if (value.Length >= 4 && value.Length <= 20)
                   {
                       _street_name = value;
                   }
               }
           }

           public string Village_name
           {
               get { return _village_name; }
               set
               {
                   if (value.Length >= 4 && value.Length <= 20)
                   {
                       _village_name = value;
                   }
               }
           }

           public string Taluk_name
           {
               get { return _taluk_name; }
               set
               {
                   if (value.Length >= 4 && value.Length <= 20)
                   {
                       _taluk_name = value;
                   }
               }
           }

           public string Pincode
           {
               get { return _pincode; }
               set
               {
                   if (value.Length == 6)
                   {
                       _pincode = value;
                   }
               }
           }


           public string District
           {
               get { return _district; }
               set
               {
                   if (value.Length >= 4 && value.Length <= 20)
                   {
                       _district = value;
                   }
               }
           }
       }

    }


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
   public  class CustomerBLL
    {
      public bool insertCustomer(Customer customer)
       {
           return new CustomerDAL().insertCustomer(customer);
       }
       public bool delCustomer(Customer customer)
      {
          return new CustomerDAL().delCustomer(customer);
      }
       public DataTable GetAllUsersInTable()
       {
           return new DAL.CustomerDAL().GetAllInUsers();
       }
       public string getM(string m)
       {
           return new TMS.DAL.CustomerDAL().getM(m);
       }
       public bool updateCust(Customer cust, string name)
       {
           return new TMS.DAL.CustomerDAL().updateCust(cust, name);
       }

   
  
    }
}

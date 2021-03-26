using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TMS.Common;
using TMS.DAL;
namespace TMS.BLL
{
   public class UserBLL
    {
       public DataTable GetAllUsersInTable()
       {
           return new DAL.UserDAL().GetAllInUsers();
       }
       public bool updateUser(User user,string n)
       {
           return new UserDAL().updateUser(user,n);
       }
       public bool insertUser(User user)
       {
           return new UserDAL().insertUser(user);
       }
       public string checkLogin(User user)
       {
           return new DAL.UserDAL().checkLogin(user);
       }
       public bool delUser(User user)
       {
           return new UserDAL().delUser(user);
       }

    }
}

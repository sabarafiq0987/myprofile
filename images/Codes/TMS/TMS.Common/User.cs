using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Common
{
  public  class User
    {

      public User()
      {
          // TODO: Complete member initialization
      }
      public string Name { get; set;}
      
      public string Password { get; set; }


      public string FullName { get; set; }

      public string Type { get; set; }

      public string IsActive { get; set; }
      
    }
}

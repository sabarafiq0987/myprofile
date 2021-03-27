using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS.Common
{
   public class Worker
    {
       public string FullName { get; set; }
       public string CNIC { get; set; }
       public string Address{ get; set; }
       public string MobileNo{ get; set; }
       public string EmgContact { get; set; }
       public DateTime JoinDate{ get; set; }
       public string IsActive { get; set; }
    }
}

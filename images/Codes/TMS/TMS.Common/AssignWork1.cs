using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TMS.Common
{
   public class AssignWork1
    {
       public string Name { get; set; }
       public int Task { get; set; }
       public int Comp{ get; set; }
       public int pend { get; set; }
       public string total { get; set; }
       public string C { set; get; }
       public float P { set; get; }
       public DateTime due { get; set; }
       public string R { get; set; }
       public bool isCompleted { get; set; }
       public bool Isdue { get; set; }
    }
}

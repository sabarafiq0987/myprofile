using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMS.Common;
using TMS.DAL;
namespace TMS.BLL
{
    public class AssignWork1BLL
    {
        public List<AssignWork1>getAllWorkAssignmentInList()
        {
            return new TMS.DAL.AssignWork1DAL().getAllWorkAssignmentINList();
        }

        public bool insertW(AssignWork1 obj)
        {
           return new TMS.DAL.AssignWork1DAL().insertW(obj);
        }

        public object getAllWorkAssignmentInListF()
        {
            return new TMS.DAL.AssignWork1DAL().getAllWorkAssignmentINListF();
        }
    }
}

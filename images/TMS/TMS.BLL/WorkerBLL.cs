using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
    public class WorkerBLL
    {
        public bool insertWorker(Worker w)
        {
            return new WorkerDAL().insertWorker(w);
        }


        public DataTable GetAllWorkersInTable()
        {
            return new WorkerDAL().GetAllInWorker();
        }

        public bool delWorker(Worker selectedWorker)
        {
            return new WorkerDAL().delWorker(selectedWorker);
        }

        public bool updateWorker(Worker worker1, string name3)
        {
            return new WorkerDAL().updateWorker(worker1, name3);
        }
    }
}

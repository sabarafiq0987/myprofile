using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMS.Common;
using TMS.DAL;
using System.Data;
namespace TMS.BLL
{
public class MeasurementBLL
    {
    public DataTable getAllMeasurmentsFromFile(string path)
    {
        return new TMS.DAL.MeasurementDAL().getAllMeasurmentsFromFile(path);
    }
    public DataTable getM()
    {
        return new TMS.DAL.MeasurementDAL().getM();
    }
    }
}

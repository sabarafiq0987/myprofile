using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class searchWorker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = new TMS.BLL.WorkerBLL().GetAllWorkersInTable();
            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
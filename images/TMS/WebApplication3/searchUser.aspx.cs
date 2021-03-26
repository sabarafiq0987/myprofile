using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;

namespace WebApplication3
{
    public partial class searchUser : System.Web.UI.Page
    {
        public User selectedUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = new TMS.BLL.UserBLL().GetAllUsersInTable();
            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow r = GridView1.SelectedRow;
            selectedUser.FullName= r.Cells[0].Text;
            selectedUser.Name = r.Cells[1].Text;
            selectedUser.Password = r.Cells[2].Text;
            selectedUser.Type= r.Cells[3].Text;
            selectedUser.IsActive= Convert.ToString(r.Cells[4].Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("createUser.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class loginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["isLogin"] = false;
            if (!IsPostBack)
            {
                Session["isLogin"] = false;
                this.ddUserName.DataSource = new TMS.BLL.UserBLL().GetAllUsersInTable();
                this.ddUserName.DataTextField = "Username";
                this.ddUserName.DataValueField = "Username";
                this.ddUserName.DataBind();
            }
        }
        public bool isAdmin;
        protected void login_Click(object sender, EventArgs e)
        {
            if (this.isFilled())
            {
                TMS.Common.User user1 = new TMS.Common.User();
                user1.Name = this.ddUserName.SelectedValue;
                user1.Password = this.u_pass.Text;
                TMS.BLL.UserBLL user = new TMS.BLL.UserBLL();
                try
                {
                   
                    if (user.checkLogin(user1) == "Operator")
                    {
                        isAdmin = false;
                        Session["isAdmin"] = isAdmin;
                        Session["isLogin"] = true;
                        Response.Redirect("DashBoardOperators.aspx");
                    }
                    else if (user.checkLogin(user1) == "Admin")
                    {
                        isAdmin = true;
                        Session["isLogin"] = true;
                        Session["isAdmin"] = isAdmin;
                        Response.Redirect("dashBoardAdmin.aspx");
                    }
                    else if (user.checkLogin(user1) == "Incorrect")
                    {
                        Response.Write("<script> alert('Unsuccessful login'); </script>");
                        Session["isLogin"] = false;
                    }
                    this.u_pass.Text = "";
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
        public bool isFilled()
        {
            if (this.ddUserName.Text == "")
            {
                Response.Write("<script> alert('Please select the user'); </script>");
                return false;
            }
            if (this.u_pass.Text == "")
            {
                Response.Write("<script> alert('Please enter the password'); </script>");
                return false;
            }
            return true;
        }

        protected void u_pass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
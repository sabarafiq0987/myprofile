using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Exir1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLogin;
            if (Session["isLogin"] != null)
            {
                isLogin = (bool)Session["isLogin"];
                if (!isLogin)
                    Response.Redirect("~/loginForm.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                Response.Redirect("loginForm.aspx");
        }
    }
}
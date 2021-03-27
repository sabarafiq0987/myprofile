using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;
using TMS.BLL;
using System.Data.SqlClient;
using System.Data;
namespace WebApplication3
{
    public partial class searchWorkAssignment : System.Web.UI.Page
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
            this.GridView1.DataSource = new TMS.BLL.AssignWork1BLL().getAllWorkAssignmentInListF();
            this.GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           string Wname = Convert.ToString(GridView1.DataKeys[e.RowIndex].Value);
            string T = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString();
            string C = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString();
            string P = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString();
            string to = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString();
            string Cust= ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text.ToString();
            string Price = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
            string IsD = ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text.ToString();
            string R = ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text.ToString();
            string IsC = ((TextBox)GridView1.Rows[e.RowIndex].Cells[9].Controls[0]).Text.ToString();
            DateTime Due= Convert.ToDateTime(((TextBox)GridView1.Rows[e.RowIndex].Cells[10].Controls[0]).Text);
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "UPDATE  Assign SET Task=@b,Comp=@c,pend=@d,total=@e,C=@g,P=@h,due=@i,R=@j,isCompleted=@k,Isdue=@l WHERE Name=@f";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@b", T);
                cmd.Parameters.AddWithValue("@c", C);
                cmd.Parameters.AddWithValue("@d", P);
                cmd.Parameters.AddWithValue("@e", to);
                cmd.Parameters.AddWithValue("@g", Cust);
                cmd.Parameters.AddWithValue("@h", Price);
                cmd.Parameters.AddWithValue("@i", IsD);
                cmd.Parameters.AddWithValue("@j", R);
                cmd.Parameters.AddWithValue("@k", IsC);
                cmd.Parameters.AddWithValue("@l", Due);
                cmd.Parameters.AddWithValue("@f", Wname);
             
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
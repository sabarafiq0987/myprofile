using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;
namespace WebApplication3
{
    public partial class addMeasurements : System.Web.UI.Page
    {
        public string name;
        public string val;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLogin;
            if (Session["isLogin"] != null)
            {
                isLogin = (bool)Session["isLogin"];
                if (!isLogin)
                    Response.Redirect("~/loginForm.aspx");
            }
            if (!IsPostBack)
            {
                string[] files = Directory.GetFiles(@"C:\Users\Saba Rafique\Documents\Visual Studio 2013\Projects\TMS\TMS\TMS.WinUI\bin\Debug\Measurements");
                foreach (string file in files)
                {
                    msr.Items.Add(Path.GetFileName(file));
                }
                msr.Text = this.msr.SelectedItem.Text.ToString();
                GridView1.DataSource = new TMS.BLL.MeasurementBLL().getAllMeasurmentsFromFile(msr.Text);
                GridView1.DataBind();
            }
        }

        protected void measurmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            msr.Text = this.msr.SelectedItem.Text.ToString();
            GridView1.DataSource = new TMS.BLL.MeasurementBLL().getAllMeasurmentsFromFile(msr.Text);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void close_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCustomer.aspx");
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
             name = Convert.ToString(GridView1.DataKeys[e.RowIndex].Value);
             val = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString();
             Global.ImportantData = this.msr.SelectedItem.Text+ name + val;
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "UPDATE  Measurement SET Value=@val1 WHERE Name=@n1 and FileN=@f";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@val1",val);
                cmd.Parameters.AddWithValue("@n1", name);
                cmd.Parameters.AddWithValue("@f", this.msr.SelectedItem.Text.ToString());
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
            GridView1.DataSource = new TMS.BLL.MeasurementBLL().getM();
            GridView1.DataBind();
        }
        protected void add_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCustomer.aspx");
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = new TMS.BLL.MeasurementBLL().getM();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;
using TMS.Common;

namespace WebApplication3
{
    public partial class assignWork : System.Web.UI.Page
    {
        public int i=0;
        public bool c = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLogin;
            if (Session["isLogin"] != null)
            {
                isLogin = (bool)Session["isLogin"];
                if (!isLogin)
                    Response.Redirect("~/loginForm.aspx");
            }
            if(!IsPostBack)
            {
                this.selectCustomer.DataSource = new TMS.BLL.CustomerBLL().GetAllUsersInTable();
                this.selectCustomer.DataTextField = "FullName";
                this.selectCustomer.DataValueField = "FullName";
                this.selectCustomer.DataBind();
                string m2= new TMS.BLL.CustomerBLL().getM(this.selectCustomer.Text);
                this.TextBox1.Text = m2;
                this.GridView1.DataSource = new TMS.BLL.AssignWork1BLL().getAllWorkAssignmentInList();
                this.GridView1.DataBind();
                this.selectWorker.DataSource = new TMS.BLL.WorkerBLL().GetAllWorkersInTable();
                this.selectWorker.DataTextField = "FullName";
                this.selectWorker.DataValueField = "FullName";
                this.selectWorker.DataBind();
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            Response.Redirect("searchWorkAssignment.aspx");
        }

        protected void measurment_TextChanged(object sender, EventArgs e)
        {

        }

        protected void remarks_TextChanged(object sender, EventArgs e)
        {

        }

        protected void price_TextChanged(object sender, EventArgs e)
        {

        }

        protected void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void selectCoustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void add_Click(object sender, EventArgs e)
        {
           
            if(this.TextBox1.Text==""||this.price.Text==""||this.dueDate.Text==""||this.remarks.Text=="")
            {
                Response.Write("<script> alert('Fill the required all fields'); </script> ");
            }
            else
            {
                i=i+1;
                AssignWork1 obj = new AssignWork1();
                obj.Name = this.selectWorker.Text;
                obj.Task = i;
                obj.P = Convert.ToInt16(this.price.Text);
                obj.due = Convert.ToDateTime(this.dueDate.Text);
                obj.C = this.selectCustomer.Text;
                obj.R = this.remarks.Text;
                obj.isCompleted = false;
                obj.Isdue = false;
                AssignWork1BLL wbll = new AssignWork1BLL();
                try
                {
                    if (wbll.insertW(obj))
                    {
                        Response.Write("<script>alert('Successfully Added!!!!!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to Add!!!!!');</script>");
                    }
                    this.TextBox1.Text = "";
                    this.price.Text = "";
                    this.remarks.Text = "";
                    this.dueDate.Text = "";
                    this.GridView1.DataSource = new TMS.BLL.AssignWork1BLL().getAllWorkAssignmentInList();
                    this.GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void markAsCompleted_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('marked As Completed');</script>");
        }

        protected void selectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string m2 = new TMS.BLL.CustomerBLL().getM(this.selectCustomer.Text);
            this.TextBox1.Text = m2;
        }

        protected void selectWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectWorker.DataSource = new TMS.BLL.WorkerBLL().GetAllWorkersInTable();
            this.selectWorker.DataTextField = "FullName";
            this.selectWorker.DataValueField = "FullName";
            this.selectWorker.DataBind();
        }

        protected void dueDate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashBoardAdmin.aspx");
        }
    }
}
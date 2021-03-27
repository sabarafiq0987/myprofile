using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;
using TMS.BLL;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication3
{
    public partial class addWorkers : System.Web.UI.Page
    {
         Worker worker1=new Worker();
        public string name3;
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

        protected void Add_Click(object sender, EventArgs e)
        {
            if (this.add.Text == "Update")
            {
                if (this.name.Text != "")
                {
                    worker1.FullName = this.name.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
                if (this.CNIC.Text != "")
                {
                    worker1.CNIC = this.CNIC.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields Except UserName'); </script> ");
                }
                if (this.address.Text != "")
                {
                    worker1.Address= this.address.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
                if (this.mobileNo.Text != "")
                {
                    worker1.MobileNo= this.mobileNo.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
                if (this.emg.Text != "")
                {
                    worker1.EmgContact = this.emg.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
                if (this.date.Text != "")
                {
                    worker1.JoinDate = Convert.ToDateTime(this.date.Text);
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
              
                WorkerBLL wbll = new WorkerBLL();
                try
                {
                    if (wbll.updateWorker(worker1, name3))
                    {
                        Response.Write("<script> alert('Updated Successfully'); </script> ");
                        this.add.Text = "Add";
                    }
                    else
                    {
                        Response.Write("<script> alert('Updated Successfully'); </script> ");
                        this.add.Text = "Add";
                    }
                    this.clearForm();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(this.name.Text) || String.IsNullOrEmpty(this.CNIC.Text) || String.IsNullOrEmpty(this.address.Text) || String.IsNullOrEmpty(this.emg.Text) || String.IsNullOrEmpty(this.mobileNo.Text) || String.IsNullOrEmpty(this.date.Text))
                {
                    Response.Write("<script> alert('Fill the required all fields'); </script> ");
                }
                else
                {
                    Worker w = new Worker();
                    w.FullName = this.name.Text;
                    w.CNIC = this.CNIC.Text;
                    w.EmgContact = this.emg.Text;
                    w.IsActive = this.IsActive.Text;
                    w.JoinDate= Convert.ToDateTime(this.date.Text);
                    w.MobileNo = this.mobileNo.Text;
                    w.Address = this.address.Text;
                    WorkerBLL wbll = new WorkerBLL();
                    try
                    {
                        if (wbll.insertWorker(w))
                        {
                            Response.Write("<script> alert('Successfully saved'); </script> ");
                            this.clearForm();
                        }
                        else
                        {
                            Response.Write("<script> alert('Failed To Save'); </script> ");
                            this.clearForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        protected void Close_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/dashBoardAdmin.aspx");
        }

        protected void Search_Click(object sender, EventArgs e)
        {

            if (this.name.Text == "")
            {
                Response.Write("<script> alert('User Name is required for searching data'); </script>");
                this.clearForm();
            }
            else
            {
                worker1.FullName = this.name.Text;
                name3 = this.name.Text;
                string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
                SqlConnection con = new SqlConnection(conStr);
                try
                {
                    Worker worker = new Worker();
                    con.Open();
                    string query = "Select * from Worker where FullName='" +worker1.FullName+ "'";
                    if (query == "")
                    {
                        Response.Write("<script> alert('No Such User is in the records'); </script>");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            worker.FullName = Convert.ToString(reader["FullName"]);
                            worker.Address = Convert.ToString(reader["Address"]);
                            worker.CNIC = Convert.ToString(reader["CNIC"]);
                            worker.EmgContact = Convert.ToString(reader["EmgContact"]);
                            worker.IsActive = Convert.ToString(reader["IsActive"]);
                            worker.MobileNo = Convert.ToString(reader["Mobile No"]);
                            worker.JoinDate = Convert.ToDateTime(reader["JoinDate"]);
                        }
                        reader.Close();
                    }
                    this.name.Text = worker.FullName;
                    this.address.Text = worker.Address;
                    this.mobileNo.Text = worker.MobileNo;
                    this.emg.Text = worker.EmgContact;
                    this.CNIC.Text = worker.CNIC;
                    this.date.Text= Convert.ToString(worker.JoinDate);
                    if (worker.IsActive != "")
                    {
                        this.IsActive.Checked= true;
                    }
                    else
                    {
                        this.IsActive.Checked = false;
                    }
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
                        this.add.Text = "Update";
                    }
                }
            }
        }
        public void clearForm()
        {
            this.name.Text = "";
            this.CNIC.Text = "";
            this.address.Text = "";
            this.mobileNo.Text = "";
            this.emg.Text = "";
            this.date.Text = "";
            this.IsActive.Checked = false;
        }
        protected void delete_Click(object sender, EventArgs e)
        {
            if (this.name.Text == "")
            {
                Response.Write("<script> alert('Full Name is required for deletion'); </script>");
                this.clearForm();
            }
            else
            {

                Worker worker = new Worker();
                worker.FullName = Convert.ToString(this.name.Text);
                WorkerBLL workers = new WorkerBLL();
                if (workers.delWorker(worker) == true)
                {
                    Response.Write("<script> alert('User Deleted'); </script>");
                    this.clearForm();
                }
                else
                {
                    Response.Write("<script> alert('Deletion failed'); </script>");
                    this.clearForm();
                }
            }
        }

        protected void male_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;
using TMS.Common;
namespace WebApplication3
{   
    
    public partial class createUser : System.Web.UI.Page
    {
        User user1 = new User();
        public string name;
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
        protected void add_Click1(object sender, EventArgs e)
        {
            if(this.add.Text=="Update")
            {
                if (this.textBox1.Text != "")
                { 
                    user1.FullName = this.textBox1.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields Except UserName'); </script> ");
                }
                if (this.textBox2.Text != "")
                {
                    user1.Name = this.textBox1.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields Except UserName'); </script> ");
                }
                if(this.textBox3.Text!="")
                {
                   user1.Password = this.textBox3.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
                if(this.combo1.Text!="")
                {
                  user1.Type = this.combo1.Text;
                }
                else
                {
                    Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                }
                user1.IsActive = this.isActive.Text;
                UserBLL ubll = new UserBLL();
                try
                {
                    if (ubll.updateUser(user1,name))
                    {
                        Response.Write("<script> alert('Updated Successfully'); </script> ");
                    }
                    else
                    {
                        Response.Write("<script> alert('Failed To Update'); </script> ");
                    }
                    this.add.Text = "Add";
                    this.clearForm();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text) || String.IsNullOrEmpty(this.textBox3.Text) || String.IsNullOrEmpty(this.combo1.Text))
                {
                    Response.Write("<script> alert('Fill the required all fields'); </script> ");
                }
                else
                {
                    User user = new User();
                    user.FullName = this.textBox1.Text;
                    user.Name = this.textBox2.Text;
                    user.Password = this.textBox3.Text;
                    user.Type = this.combo1.Text;
                    user.IsActive = this.isActive.Text;
                    UserBLL ubll = new UserBLL();
                    try
                    {
                        if (ubll.insertUser(user))
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
        public void clearForm()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.combo1.Text = "";
            this.isActive.Checked = false;
        }
        protected void delete_Click1(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                Response.Write("<script> alert('User Name is required for deletion'); </script>");
                this.clearForm();
            }
            else
            {

                TMS.Common.User user = new TMS.Common.User();
                user.Name = Convert.ToString(this.textBox2.Text);
                TMS.BLL.UserBLL users = new TMS.BLL.UserBLL();
                if (users.delUser(user) == true)
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
        protected void Close_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/dashBoardAdmin.aspx");
        }

        protected void id_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Search_Click1(object sender, EventArgs e)
        {

            if (this.textBox2.Text == "")
            {
                Response.Write("<script> alert('User Name is required for searching data'); </script>");
                this.clearForm();
            }
            else
            {
                user1.Name = this.textBox2.Text;
                name = this.textBox2.Text;
                string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
                SqlConnection con = new SqlConnection(conStr);
                try
                {
                    User worker = new User();
                    con.Open();
                    string query = "Select * from Users where UserName='"+this.textBox2.Text+"'";
                    if (query=="")
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
                            worker.Type = Convert.ToString(reader["Type"]);
                            worker.IsActive = Convert.ToString(reader["IsActive"]);
                            worker.Name = Convert.ToString(reader["UserName"]);
                            worker.Password = Convert.ToString(reader["Password"]);
                        }
                        reader.Close();
                    }
                    this.textBox1.Text = worker.FullName;
                    this.textBox2.Text = worker.Name;
                    this.textBox3.Text = worker.Password;
                    if(worker.IsActive!="")
                    {
                        this.combo1.Enabled=true;
                    }
                    else
                    {
                        this.combo1.Enabled = false;
                    }
                    this.add.Text = "Update";
                }
                catch(SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    if(con.State==ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}

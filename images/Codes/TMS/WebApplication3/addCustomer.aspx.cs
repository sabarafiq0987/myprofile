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
    
    public partial class addCustomer : System.Web.UI.Page
    {
        Customer cust=new Customer();
        public string name2;
       public string important1 = Global.ImportantData;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLogin;
            if (Session["isLogin"] != null)
            {
                isLogin = (bool)Session["isLogin"];
                if (!isLogin)
                    Response.Redirect("~/loginForm.aspx");
            }
            if(important1==null)
            {
                this.measurements.Text=" ";
            }
            else
            {
                this.measurements.Text = important1;
            }
   }
       protected void closeMeasurments_Click(object sender, EventArgs e)
        {
            this.measurements.Text = "";
        }

        protected void addMeasurments_Click(object sender, EventArgs e)
        {
            Response.Redirect("addMeasurements.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            if (this.name.Text == "")
            {
                Response.Write("<script> alert('Name is required for deletion'); </script>");
                this.clearForm();
            }
            else
            {

                TMS.Common.Customer cust = new TMS.Common.Customer();
                cust.FullName = Convert.ToString(this.name.Text);
                TMS.BLL.CustomerBLL customers = new TMS.BLL.CustomerBLL();
                if (customers.delCustomer(cust) == true)
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
            Response.Redirect("dashBoardAdmin.aspx");
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            if (this.name.Text == "")
            {
                Response.Write("<script> alert('FullName is required for searching data'); </script>");
                this.clearForm();
            }
            else
            {
                cust.FullName = this.name.Text;
                name2= this.name.Text;
                string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
                SqlConnection con = new SqlConnection(conStr);
                try
                {
                    Customer cust2 = new Customer();
                    con.Open();
                    string query = "Select * from Customer where FullName='"+this.name.Text+"'";
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
                            cust2.FullName = Convert.ToString(reader["FullName"]);
                            cust2.CNIC = Convert.ToString(reader["CNIC"]);
                            cust2.Address= Convert.ToString(reader["Address"]);
                            cust2.Measurements = Convert.ToString(reader["Measurements"]);
                            cust2.Remarks = Convert.ToString(reader["Remarks"]);
                            cust2.MobileNo = Convert.ToString(reader["Mobile No"]);
                        }
                        reader.Close();
                    }
                    this.name.Text = cust2.FullName;
                    this.CNIC.Text = cust2.CNIC;
                    this.address.Text = cust2.Address;
                    this.measurements.Text = cust2.Measurements;
                    this.remarks.Text = cust2.Remarks;
                    this.mobileNo.Text = cust2.MobileNo;
                    this.Add.Text = "Update";
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
        protected void Add_Click(object sender, EventArgs e)
        {
                if (this.Add.Text == "Update")
                {
                    if (this.name.Text != "")
                    {
                        cust.FullName = this.name.Text;
                    }
                    else
                    {
                        Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                    }
                    if (this.CNIC.Text != "")
                    {
                        cust.CNIC = this.CNIC.Text;
                    }
                    else
                    {
                        Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                    }
                    if (this.address.Text != "")
                    {
                        cust.Address = this.address.Text;
                    }
                    else
                    {
                        Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                    }
                    if (this.remarks.Text != "")
                    {
                        cust.Remarks = this.remarks.Text;
                    }
                    else
                    {
                        Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                    }
                    if (this.mobileNo.Text != "")
                    {
                        cust.MobileNo = this.mobileNo.Text;
                    }
                    else
                    {
                        Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                    }
                    if (this.measurements.Text != "")
                    {
                        cust.Measurements = this.measurements.Text;
                    }
                    else
                    {
                        Response.Write("<script> alert('Empty Field is not allow fill all fields'); </script> ");
                    }
                    CustomerBLL cbll = new CustomerBLL();
                    try
                    {
                        if (cbll.updateCust(cust, name2))
                        {
                            Response.Write("<script> alert('Updated Successfully'); </script> ");
                        }
                        else
                        {
                            Response.Write("<script> alert('Updated Successfully'); </script> ");
                        }
                        this.Add.Text = "Add";
                        this.clearForm();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(this.name.Text) || String.IsNullOrEmpty(this.remarks.Text) || String.IsNullOrEmpty(this.CNIC.Text) || String.IsNullOrEmpty(this.address.Text) || String.IsNullOrEmpty(this.mobileNo.Text) || String.IsNullOrEmpty(this.measurements.Text))
                    {
                        Response.Write("<script> alert('Fill the required all fields'); </script> ");
                    }
                    else
                    {
                        Customer cust2 = new Customer();
                        cust2.FullName = this.name.Text;
                        cust2.CNIC = this.CNIC.Text;
                        cust2.Address = this.address.Text;
                        cust2.Measurements = this.measurements.Text;
                        cust2.Remarks = this.remarks.Text;
                        cust2.MobileNo = this.mobileNo.Text;
                        CustomerBLL cbll = new CustomerBLL();
                        try
                        {
                            if (cbll.insertCustomer(cust2))
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
        protected void remarks_TextChanged(object sender, EventArgs e)
        {

        }

        protected void address_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CNIC_TextChanged(object sender, EventArgs e)
        {

        }

        protected void name_TextChanged(object sender, EventArgs e)
        {

        }

        protected void measurments_TextChanged(object sender, EventArgs e)
        {

        }
        public void clearForm()
        {
            this.name.Text = "";
            this.CNIC.Text = "";
            this.measurements.Text = "";
            this.mobileNo.Text = "";
            this.remarks.Text = "";
            this.address.Text = "";
        }

        protected void mobileNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
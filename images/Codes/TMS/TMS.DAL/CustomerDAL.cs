using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TMS.Common;

namespace TMS.DAL
{
   public class CustomerDAL
    {
       public string ms;
        public bool insertCustomer(Customer customer)
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "INSERT INTO Customer(FullName,[CNIC],[Address],[Mobile No],[Remarks],Measurements)VALUES ('"+customer.FullName+"', '"+customer.CNIC+"', '"+customer.Address+"', '"+customer.MobileNo+"','"+customer.Remarks+"','"+customer.Measurements+"');";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return true;
        }

        public bool delCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FullName))
           {
               return false;
           }
           else
           {
               string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
               SqlConnection con = new SqlConnection(conStr);
               try
               {
                   con.Open();
                   string query = "Delete from Customer where FullName='" + customer.FullName + "'";
                   SqlCommand cmd = new SqlCommand(query, con);
                   cmd.ExecuteNonQuery();
               }
               catch (SqlException ex)
               {
                   return false;
                   throw ex;
               }
               finally
               {
                   if (con.State == ConnectionState.Open)
                   {
                       con.Close();
                   }
               }
               return true;
           }
        }

        public DataTable GetAllInUsers()
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "Select * from Customer";
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataTable obj = new DataTable();
                ad.Fill(obj);
                return obj;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public string getM(string m)
        {
           string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
           SqlConnection con = new SqlConnection(conStr);
           try
            {
                con.Open();
                string query = "select Measurements from Customer where FullName='"+m+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ms = Convert.ToString(reader["Measurements"]);
                }
                reader.Close();
                return ms;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }



        public bool updateCust(Customer cust, string name)
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "UPDATE  Customer SET FullName=@F,Mobile No=@N,CNIC=@T ,Remarks=@P,Address=@ac1,Measurements=@m WHERE FullName=@n1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@F", cust.FullName);
                cmd.Parameters.AddWithValue("@N", cust.MobileNo);
                cmd.Parameters.AddWithValue("@T", cust.CNIC);
                cmd.Parameters.AddWithValue("@P", cust.Remarks);
                cmd.Parameters.AddWithValue("@ac1", cust.Address);
                cmd.Parameters.AddWithValue("@m", cust.Measurements);
                cmd.Parameters.AddWithValue("@n1", name);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return true;
        }
    }
}

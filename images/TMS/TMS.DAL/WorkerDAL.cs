using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TMS.Common;

namespace TMS.DAL
{
   public class WorkerDAL
    {
        public bool insertWorker(Worker w)
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "INSERT INTO Worker(FullName,CNIC,Address,[Mobile No],EmgContact,JoinDate,IsActive)VALUES('" + w.FullName + "','" + w.CNIC + "','" + w.Address + "','" + w.MobileNo+ "','" + w.EmgContact + "','" + w.JoinDate+ "','" + w.IsActive + "');";
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

        public DataTable GetAllInWorker()
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "Select * from Worker";
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

        public bool delWorker(Worker w)
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "Delete from Worker where FullName='" + w.FullName + "';";
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

        public bool updateWorker(Worker worker1, string name3)
        {
            char ac;
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                if (worker1.IsActive != "")
                {
                    ac = '1';
                }
                else
                {
                    ac = '0';
                }
                con.Open();
                string query = "UPDATE  Worker SET FullName=@F, CNIC=@N,Address=@P,Mobile No=@T,EmgContact=@d3,JoinDate=@d,IsActive=@ac1 WHERE FullName=@n1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@F", worker1.FullName);
                cmd.Parameters.AddWithValue("@N", worker1.CNIC);
                cmd.Parameters.AddWithValue("@P", worker1.Address);
                cmd.Parameters.AddWithValue("@T", worker1.MobileNo);
                cmd.Parameters.AddWithValue("@d3", worker1.EmgContact);
                cmd.Parameters.AddWithValue("@d", Convert.ToDateTime(worker1.JoinDate));
                cmd.Parameters.AddWithValue("@ac1", ac); 
                cmd.Parameters.AddWithValue("@n1", name3);
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

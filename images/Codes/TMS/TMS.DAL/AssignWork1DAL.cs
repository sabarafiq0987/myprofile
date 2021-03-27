using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TMS.Common;
namespace TMS.DAL
{
   public  class  AssignWork1DAL
    {
       
       //public bool isOverDueDate(AssignWork1 work)
       //{
       //    DateTime date = DateTime.Now;
       //    string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
       //    SqlConnection con = new SqlConnection(conStr);
       //    try
       //    {
       //        con.Open();
       //        string query = "select DueDate from workAssignment1TMS where Id=" + work.W;
       //        SqlCommand cmd = new SqlCommand(query, con);
       //        SqlDataReader reader = cmd.ExecuteReader();
       //        if (reader.Read())
       //        {
       //            if (DateTime.Compare(date, (Convert.ToDateTime(reader["DueDate"]))) > 0)
       //            {
       //                return true;
       //            }
       //            else
       //            {
       //                return false;
       //            }
       //        }
       //        else
       //        {
       //            return false;
       //        }
       //        reader.Close();
       //    }
       //    catch (SqlException ex)
       //    {
       //        throw ex;
       //    }
       //    finally
       //    {
       //        if (con.State == System.Data.ConnectionState.Open)
       //        {
       //            con.Close();
       //        }
       //    }
       //}
       //public int inCompleteTask(AssignWork1 work)
       //{
       //    string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
       //    SqlConnection con = new SqlConnection(conStr);
       //    try
       //    {
       //        con.Open();
       //        string query = "update workAssignment1TMS set Completed = '0',overDueDate='0' where Id =" + work.W;
       //        SqlCommand cmd = new SqlCommand(query, con);
       //        var result = cmd.ExecuteNonQuery();
       //        cmd.Dispose();
       //        con.Dispose();
       //        con.Close();
       //        return result;
       //    }
       //    catch (Exception ex)
       //    {
       //        throw ex;
       //    }
       //}
       //public int completeTask(AssignWork1 work)
       //{
       //    int i = 0;
       //    if (isOverDueDate(work))
       //    {
       //        i = 1;
       //    }
       //    string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
       //    SqlConnection con = new SqlConnection(conStr);
       //    try
       //    {
       //        con.Open();
       //        string query = "update workAssignment1TMS set Completed = '1',OverDueDate=" + i + " where Id =" + work.W;
       //        SqlCommand cmd = new SqlCommand(query, con);
       //        var result = cmd.ExecuteNonQuery();
       //        cmd.Dispose();
       //        con.Dispose();
       //        con.Close();
       //        return result;
       //    }
       //    catch (Exception ex)
       //    {
       //        throw ex;
       //    }
       //}
        public List<AssignWork1> getAllWorkAssignmentINList()
        {
           
             string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
           SqlConnection con = new SqlConnection(conStr);
           try
            {
                con.Open();
                string query = "select * from Assign";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<AssignWork1> list = new List<AssignWork1>();
                while (reader.Read())
                {
                    AssignWork1 worker = new AssignWork1();
                  
                    worker.Name = Convert.ToString(reader["Name"]);
                    worker.Task = Convert.ToInt32(reader["Task"]);
                    worker.Comp = Convert.ToInt32(reader["Comp"]);
                    worker.pend = Convert.ToInt32(reader["pend"]);
                    worker.total = Convert.ToString(reader["total"]);
                   
                    list.Add(worker);
                }
                reader.Close();
                return list;
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
        public List<AssignWork1> getAllWorkAssignmentINListF()
        {

            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "select * from Assign";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<AssignWork1> list = new List<AssignWork1>();
                while (reader.Read())
                {
                    AssignWork1 worker = new AssignWork1();

                    worker.Name = Convert.ToString(reader["Name"]);
                    worker.Task = Convert.ToInt32(reader["Task"]);
                    worker.Comp = Convert.ToInt32(reader["Comp"]);
                    worker.pend = Convert.ToInt32(reader["pend"]);
                    worker.total = Convert.ToString(reader["total"]);
                    worker.C = Convert.ToString(reader["C"]);
                    worker.P = Convert.ToInt16(reader["P"]);
                    worker.R = Convert.ToString(reader["R"]);
                    list.Add(worker);
                }
                reader.Close();
                return list;
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

        public bool insertW(AssignWork1 obj)
        {
            string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string query = "INSERT INTO Assign(Name,Task,Comp,pend,total,C,P,due,R,isCompleted,Isdue)VALUES ('" + obj.Name + "', '" + obj.Task + "', '" + 0 + "', '" + 1 + "','" +0+ "','" + obj.C + "','"+obj.P+"','"+obj.due+"','"+obj.R+"','"+obj.isCompleted+"','"+obj.Isdue+"');";
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;
using System.Data;
using System.Data.SqlClient;
namespace TMS.DAL
{
   public class UserDAL
    {
       public bool insertUser(User user)
       {

           string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
           SqlConnection con = new SqlConnection(conStr);
           try
           {
                   con.Open();
                   string query = "INSERT INTO Users (FullName,Type, IsActive,UserName,Password)VALUES ('" + user.FullName + "', '" + user.Type + "','1', '" +user.Name+ "', '" + user.Password + "');";
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
               if(con.State==ConnectionState.Open)
               {
                   con.Close();
               }
           }
           return true;
       }
       public string checkLogin(User user)
       {
           string alert1 = "Incorrect";
           string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
           SqlConnection con = new SqlConnection(conStr);
           try
           {
               con.Open();
               string query = "select type from Users where UserName='" + user.Name + "' and Password='" + user.Password + "'";
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataReader reader = cmd.ExecuteReader();
               if (reader.Read())
               {
                   if(user.Password=="123")
                   {
                       alert1 = "Admin";
                   }
                   else
                   {
                       alert1="Operator";
                   }
                   reader.Close();
               }
               return alert1;
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
       public DataTable GetAllInUsers()
       {
           string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
           SqlConnection con = new SqlConnection(conStr);
           try
           {
               con.Open();
               string query="Select * from Users";
               SqlDataAdapter ad = new SqlDataAdapter(query, con);
               DataTable obj=new DataTable() ;
               ad.Fill(obj);
               return obj;
           }
           catch(SqlException ex)
           {
               throw ex;
           }
           finally
           {
               if (con.State == ConnectionState.Open)
                   con.Close();
           }
       }
       public bool updateUser(User user,string name)
       {
           string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
           SqlConnection con = new SqlConnection(conStr);
           try
           {
               con.Open();
               string query = "UPDATE  Users SET FullName='"+user.FullName+"', UserName='"+user.Name+"',Type='"+user.Type+"',Password='"+user.Password+"',IsActive='"+0+"' WHERE UserName='"+name+"'";
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
       public bool delUser(User user)
       {

               string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
               SqlConnection con = new SqlConnection(conStr);
               try
               {
                   con.Open();
                   string query = "Delete from Users where  UserName='" + user.Name+ "'";
                   SqlCommand cmd = new SqlCommand(query, con);
                   var res = cmd.ExecuteNonQuery();
                   if(res==0)
                   {
                       return false;
                   }
                   else
                   {
                       return true;
                   }
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
           }
       }
    }

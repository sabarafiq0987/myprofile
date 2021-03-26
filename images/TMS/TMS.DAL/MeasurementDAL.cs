using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using TMS.Common;
using System.Data.SqlClient;
namespace TMS.DAL
{
    public class MeasurementDAL
    {
        public DataTable getAllMeasurmentsFromFile(string path)
        {
            string[] line1 = null;
            string[] val;
            int l;
            line1 = File.ReadAllLines(@"C:\Users\Saba Rafique\Documents\Visual Studio 2013\Projects\TMS\TMS\TMS.WinUI\bin\Debug\Measurements" + "\\" + Convert.ToString(path));
            l = line1.Length;
            if (path == "Shirt.txt")
              {
                  l = l - 1; ;
                 
              }
            for (int i = 0; i < l; i++)
            {
                Measurement msr2 = new Measurement();
                val = line1[i].Split(',');
                for (int j = 0; j < val.Length; j++)
                {
                        msr2.Name = val[j];
                        msr2.Value = "";
                        msr2.FileN = Convert.ToString(path);
                    string conStr = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
                    SqlConnection con = new SqlConnection(conStr);
                    try
                    {
                        con.Open();
                        string query = "INSERT INTO Measurement (Name,Value,FileN)VALUES ('" + msr2.Name + "','" + msr2.Value + "','" + msr2.FileN + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
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
            }
            string conS = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con2 = new SqlConnection(conS);
            try
            {
                con2.Open();
                string query = "Select * from Measurement";
                SqlDataAdapter ad = new SqlDataAdapter(query, con2);
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
                if (con2.State == ConnectionState.Open)
                    con2.Close();
            }
        }
        public DataTable getM()
        {
            string conS = "server=DESKTOP-RO7ULCV;database=SQLdb;Integrated Security=SSPI;";
            SqlConnection con2 = new SqlConnection(conS);
            try
            {
                con2.Open();
                string query = "Select * from Measurement";
                SqlDataAdapter ad = new SqlDataAdapter(query, con2);
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
                if (con2.State == ConnectionState.Open)
                    con2.Close();
            }
        }
    }

}    


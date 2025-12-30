using System.Data;
using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using DocumentFormat.OpenXml.EMMA;
//using Grpc.Core;
using NPOI.SS.Formula.Functions;
using CHO_Saathi.Models;
using System.Configuration;

namespace CHO_Saathi
{
    public class DBClass : IDisposable
    {
        //private readonly string ConpwdbCS;
        private SqlConnection con;
        private SqlCommand cmd;

      //  private readonly string ConpwdbCS;

        // Constructor to fetch connection string from appsettings.json using ConfigurationBuilder
        //public DBClass()
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())  // Set the base path for appsettings.json
        //        .AddJsonFile("appsettings.json")  // Add appsettings.json as a configuration source
        //        .Build();

        //    // Get the connection string from appsettings.json
        //    ConpwdbCS = configuration.GetConnectionString("DefaultConnection");
        //}


         
         private readonly string ConpwdbCS = "Server=10.44.242.40;Database=Prasav;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=JHAY565Iq2aej;MultipleActiveResultSets=True;";

        //private readonly string ConpwdbCS = "Server=MICROWARE-VM1;Database=Prasav;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=JHAY565Iq2aej;MultipleActiveResultSets=True;";

      
        public DBClass(string spname, CommandType cmdtype)
        {         
            con = new SqlConnection(ConpwdbCS);

            cmd = new SqlCommand(spname);
            cmd.CommandType = cmdtype;
            cmd.Connection = con;

            if (con.State == ConnectionState.Closed)
                con.Open();
        }





        //public DBClass()
        //{
        //}
        //public DBClass(string spname, CommandType cmdtype)
        //{
            
        //    con = new SqlConnection(ConpwdbCS);

        //    cmd = new SqlCommand(spname);
        //    cmd.CommandType = cmdtype;
        //    cmd.Connection = con;

        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
        //}

        public void AddParameters(string pname, string pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.NVarChar).Value = pvalue;
        }
        public void AddParameters(string pname, bool pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.Bit).Value = pvalue;
        }
        public void AddParameters(string pname, System.DBNull pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.NVarChar).Value = pvalue;
        }
        public void AddParameters(string pname, Int64 pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.BigInt).Value = pvalue;
        }
        public void AddParameters(string pname, int pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.Int).Value = pvalue;
        }
        public void AddParameters(string pname, float pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.Float).Value = pvalue;
        }
        public void AddParameters(string pname, DateTime pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.DateTime).Value = pvalue;
        }
        public void AddParameters(string pname, Decimal pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.Decimal).Value = pvalue;
        }
        public void AddParameters(string pname, Double pvalue)
        {
            cmd.Parameters.Add(pname, SqlDbType.Decimal).Value = pvalue;
        }
        public void AddParameters(string pname, DataTable pvalue)
        {
            cmd.Parameters.AddWithValue(pname, pvalue);
        }
        //add new in db class
        public void AddParameters(string pname, byte[] pvalue)
        {
            cmd.Parameters.AddWithValue(pname, pvalue);
        }

        public DataTable ReturnDataTable()
        {
            using (DataTable dt = new DataTable())
            {
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public DataSet ReturnDataSet()
        {
            using (DataSet ds = new DataSet())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                }
                return ds;
            }
        }

        public void TimeOut(int time)
        {
            cmd.CommandTimeout = time;
        }

        public string ReturnString()
        {
            return Convert.ToString(cmd.ExecuteScalar());
        }

        public void ExecuteNonQuery()
        {
            cmd.ExecuteNonQuery();
        }

        public int ExecuteNonQueryWithReturn()
        {
            return Convert.ToInt16(cmd.ExecuteNonQuery());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (con != null)
            {
                if (disposing)
                {
                    // get rid of managed resources
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            // get rid of unmanaged resources
        }

        public class PCTSData
        {

        }

    }
}

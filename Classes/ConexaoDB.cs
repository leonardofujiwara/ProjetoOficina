using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Programa_Oficina.Classes
{
    public class SQLServerClass
    {
        public string stringConn;
        public SqlConnection ConnDB;

        public SQLServerClass()
        {
            try
            {
                stringConn = ConfigurationManager.ConnectionStrings["ProgramaOficina"].ConnectionString;
                ConnDB = new SqlConnection(stringConn);
                ConnDB.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SqlQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var MyCommand = new SqlCommand(SQL, ConnDB);
                MyCommand.CommandTimeout = 0;
                var MyReader = MyCommand.ExecuteReader();
                dt.Load(MyReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var MyCommand = new SqlCommand(SQL, ConnDB);
                MyCommand.CommandTimeout = 0;
                MyCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            ConnDB.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PV.BusinessReport.DAL
{
    public class DataBaseProcess
    {
        public static string constr = "server=;port=;User Id=;password=;Database=";
        public MySqlConnection GetConn()
        {
            MySqlConnection myconn = new MySqlConnection(constr);
            try
            {
                myconn.Open();
            }
            catch (MySqlException mse) { }
            return myconn;
        }
        public DataTable SelectMySql(string sqlstr)
        {
            MySqlConnection conn = GetConn();
            DataTable dt;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlstr, conn);
                dt = new DataTable();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using log4net;
using MySql.Data.MySqlClient;

namespace PV.BusinessReport.DAL
{
    public class DataBaseProcess:IDisposable
    {
        private ILog _log = LogManager.GetLogger(typeof (DataBaseProcess));
        public static string constr = "server=localhost;port=3306;User Id=root;password=;Database=BusinessReport;charset='utf8'";
        private MySqlConnection _connection;
        public MySqlConnection GetConn()
        {
            _connection = new MySqlConnection(constr);
            try
            {
                _connection.Open();
            }
            catch (MySqlException mse)
            {
                _log.Error(mse);
            }
            return _connection;
        }
        public DataTable Query(string sqlstr)
        {
            _connection = GetConn();
            DataTable dt;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlstr, _connection);
                dt = new DataTable();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return dt;
        }

        public Int32 Exec(String sql)
        {
            Int32 cnt = 0;
            _connection = GetConn();
            try
            {
                MySqlCommand command=new MySqlCommand(sql);
                command.Connection = _connection;
                cnt= command.ExecuteNonQuery();
                return cnt;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
            return cnt;
        }

        public Boolean Update(DataTable sourceData,String cmdSql)
        {
            _connection = GetConn();
            MySqlDataAdapter adapter=new MySqlDataAdapter(cmdSql,_connection);
            adapter.SelectCommand=new MySqlCommand(cmdSql,_connection);
            MySqlCommandBuilder builder=new MySqlCommandBuilder(adapter);
            //adapter.UpdateCommand = builder.GetUpdateCommand();
            Int32 result = adapter.Update(sourceData);
            return result > 0;
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State != ConnectionState.Closed)
                {
                    //TODO  
                }
                _connection.Dispose();
            }
        }
    }
}

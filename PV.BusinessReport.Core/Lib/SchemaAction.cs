using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using log4net;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class SchemaAction
    {
        #region Veriable
        private ILog _log = LogManager.GetLogger(typeof(SchemaAction));
        #endregion

        #region Structure
        public SchemaAction()
        {
        }
        #endregion

        #region Function
        public DataTable GetSchema(String schemaName)
        {
            String sql = String.Format("SELECT * FROM {0} WHERE 1=2", schemaName);
            DataTable dt = null;
            using (DataBaseProcess process = new DataBaseProcess())
            {
                dt = process.Query(sql);
                dt.TableName = schemaName;
            }
            return dt;
        }

        public DataSet GetSchema(List<String> schemaNameList)
        {
            String sql = "SELECT * FROM {0} WHERE 1=2";
            DataSet ds = new DataSet();
            String schsql = "";
            using (DataBaseProcess process = new DataBaseProcess())
            {
                foreach (var schema in schemaNameList)
                {
                    schsql = String.Format(sql, schema);
                    DataTable dt = process.Query(sql);
                    if (dt != null)
                    {
                        dt.TableName = schema;
                        ds.Tables.Add(dt);
                    }
                }
            }
            return ds;
        }

        #endregion

    }
}

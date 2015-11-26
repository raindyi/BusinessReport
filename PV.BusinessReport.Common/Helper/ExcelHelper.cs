/************************************************************/
//Lynn 2015.11.20 09:48
//ExcelHelper
/************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace PV.BusinessReport.Common.Helper
{
    /// <summary>
    /// ExcelHelper
    /// </summary>
    public class ExcelHelper
    {
        #region Veriable

        #endregion

        #region Function

        #region Public
        public static DataSet ExcelToData(String filePath)
        {
            return Excel2Data(filePath, null);
        }

        public static DataSet ExcelToDataUseFilter(String filePath, String filter)
        {
            return Excel2Data(filePath, filter);
        }

        public static DataTable CsvToData(String filePath)
        {
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            try
            {
                String strLine = "";
                String[] aryLine;
                int columnCount = 0;
                bool IsFirst = true;
                while ((strLine = sr.ReadLine()) != null)
                {
                    aryLine = strLine.Split(',');
                    if (IsFirst == true)
                    {
                        IsFirst = false;
                        columnCount = aryLine.Length;
                        for (int i = 0; i < columnCount; i++)
                        {
                            try
                            {
                                DataColumn dc = new DataColumn(aryLine[i]);
                                dt.Columns.Add(dc);
                            }
                            catch (Exception)
                            {
                                DataColumn dc = new DataColumn(aryLine[i] + "(1)");
                                dt.Columns.Add(dc);
                            }
                        }
                    }
                    else
                    {
                        DataRow dr = dt.NewRow(); 
                        for (int j = 0; j < columnCount; j++)
                        {
                            dr[j] = aryLine[j];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
            return dt;
        }

        #endregion

        #region Private
        private static DataSet Excel2Data(String filePath, String filter)
        {
            OleDbConnection oledbConn = null;
            try
            {
                String path = System.IO.Path.GetFullPath(filePath);
                String connectionString = null;

                if (Path.GetExtension(path) == ".xls")
                {
                    connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
                }
                else if (Path.GetExtension(path) == ".xlsx")
                {
                    connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + path + "; Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";
                }
                using (oledbConn = new OleDbConnection(connectionString))
                {
                    OleDbCommand cmd = new OleDbCommand(); ;
                    OleDbDataAdapter oleda = new OleDbDataAdapter();
                    DataSet ds = new DataSet();
                    cmd.Connection = oledbConn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = String.IsNullOrEmpty(filter)?"":filter;
                    oleda = new OleDbDataAdapter(cmd);
                    oleda.Fill(ds);
                    return ds;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                oledbConn.Close();
            }
        }
        #endregion

        #endregion
    }
}

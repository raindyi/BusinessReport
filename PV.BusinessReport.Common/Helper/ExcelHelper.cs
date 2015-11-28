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
        private OleDbConnection conn;
        private string connString;
        private string fileName;
        private string filePath;
        private FileType fileType = FileType.noset;
        private DataTable readDataTable;
        private const int EXCEL03_MaxRow = 65535;
        public ExcelHelper()
        {

        }

        public void DataToCsv(string filepath, DataTable dt)
        {
            var sb = new StringBuilder();
            //Add Header Header
            for (var x = 0; x < dt.Columns.Count; x++)
            {
                if (x != 0) sb.Append(",");
                sb.Append(dt.Columns[x].ColumnName);
            }
            sb.AppendLine();
            //Add Rows
            foreach (DataRow row in dt.Rows)
            {
                for (var x = 0; x < dt.Columns.Count; x++)
                {
                    if (x != 0) sb.Append(",");
                    sb.Append(row[dt.Columns[x]]);
                }
                sb.AppendLine();
            }

            string content = sb.ToString();

            var sr = new StreamWriter(filepath, false, Encoding.GetEncoding("gb2312"));
            sr.Write(content);
            sr.Flush();
            sr.Close();
        }

        public DataTable Read(string path)
        {
            if (System.IO.File.Exists(path))
            {
                SetFileInfo(path);
                OleDbDataAdapter myCommand = null;
                DataSet ds = null;

                using (conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    string tableName = fileType == FileType.csv ? fileName : schemaTable.Rows[0][2].ToString().Trim();

                    string strExcel = string.Empty;

                    strExcel = "Select   *   From   [" + tableName + "]";
                    myCommand = new OleDbDataAdapter(strExcel, conn);

                    ds = new DataSet();

                    myCommand.Fill(ds, tableName);

                    readDataTable = ds.Tables[0];

                }
            }
            return readDataTable;
        }

        private void SetFileInfo(string path)
        {
            filePath = path.Replace("/", "\\");

            fileName = this.filePath.Remove(0, this.filePath.LastIndexOf("\\") + 1);
            switch (fileName.Split('.')[fileName.Split('.').Length - 1])
            {
                case "xls":
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    fileType = FileType.xls;
                    break;
                case "xlsx":
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                    fileType = FileType.xlsx;
                    break;
                case "csv":
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath.Remove(filePath.LastIndexOf("\\") + 1) + ";Extended Properties='Text;FMT=Delimited;HDR=YES;'";
                    fileType = FileType.csv;
                    break;
            }
        }

        private enum FileType
        {
            noset,
            xls,
            xlsx,
            csv
        }

        public DataTable ReadFormCsv(string path)
        {
            if (System.IO.File.Exists(path))
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                StreamReader s = new StreamReader(path, System.Text.Encoding.Default);
                //string ss = s.ReadLine();//skip the first line
                string delimiter = ",";
                string TableName = "csv";
                string[] columns = s.ReadLine().Split(delimiter.ToCharArray());
                ds.Tables.Add(TableName);
                foreach (string col in columns)
                {
                    bool added = false;
                    string next = "";
                    int i = 0;
                    while (!added)
                    {
                        string columnname = col + next;
                        columnname = columnname.Replace("#", "");
                        columnname = columnname.Replace("'", "");
                        columnname = columnname.Replace("&", "");

                        if (!ds.Tables[TableName].Columns.Contains(columnname))
                        {
                            ds.Tables[TableName].Columns.Add(columnname.ToUpper());
                            added = true;
                        }
                        else
                        {
                            i++;
                            next = "_" + i.ToString();
                        }
                    }
                }

                string AllData = s.ReadToEnd();
                string[] rows = AllData.Split("\n".ToCharArray());

                foreach (string r in rows)
                {
                    string[] items = r.Split(delimiter.ToCharArray());
                    ds.Tables[TableName].Rows.Add(items);
                }

                s.Close();

                dt = ds.Tables[0];

                return dt;
            }
            return readDataTable;
        }

        /// <summary>
        /// 将DataTable中数据写入到CSV文件中
        /// </summary>
        /// <param name="dt">提供保存数据的DataTable</param>
        /// <param name="fileName">CSV的文件路径</param>
        public void SaveCsv(DataTable dt, string fileName)
        {
            FileStream fs = new FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);

            string data = "";

            //写出列名称
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName;
                if (i < dt.Columns.Count - 1)
                {
                    data += ",";
                }
            }
            sw.WriteLine(data);

            //写出各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    data += dt.Rows[i][j].ToString();
                    if (j < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
            }

            sw.Close();
            fs.Close();
        }


        /// <summary>
        /// 读取csv文件为DataTable
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public DataTable ToDataTableByFilePath(string path)
        {
            if (File.Exists(path))
            {
                var reader = ReadAsLines(path);

                var data = new DataTable();

                //this assume the first record is filled with the column names
                var headers = reader.First().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var header in headers)
                {
                    data.Columns.Add(header);
                }

                var records = reader.Skip(1);
                foreach (var record in records)
                {
                    data.Rows.Add(record.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));
                }

                return data;
            }

            return null;
        }

        static IEnumerable<string> ReadAsLines(string filename)
        {
            using (StreamReader reader = new StreamReader(filename, Encoding.Default))
                while (!reader.EndOfStream)
                    yield return reader.ReadLine();
        }
    }
}

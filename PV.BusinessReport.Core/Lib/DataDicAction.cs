using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;
using PV.BusinessReport.PL.Context;

namespace PV.BusinessReport.Core.Lib
{
    public class DataDicAction
    {
        public DataDicAction()
        {
        }

        public DataTable GetDicList()
        {
            String sql = "SELECT ID, CODE FROM BPSYS_DATADIC";
            DataTable dt = null;
            using (DataBaseProcess process = new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            return dt;
        }

        public DataTable GetList(String sourceName)
        {
            String sql =String.Format("SELECT T.ID, T.CODE FROM BPSYS_DATADICDETAIL T INNER JOIN BPSYS_DATADIC D ON T.SOURCE=D.ID AND D.CODE='{0}'",sourceName);
            DataTable dt = null;
            using (DataBaseProcess process = new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            return dt;
        }

        public DataTable GetList()
        {
            String sql =
                "SELECT T.CODE, T.ID, D.CODE AS DCODE FROM BPSYS_DATADIC D INNER JOIN BPSYS_DATADICDETAIL T ON D.ID = T.SOURCE";
            DataTable dt = null;
            using (DataBaseProcess process = new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            return dt;
        }

        public HandlingResult Add(DataDicDetailModel model)
        {
            HandlingResult result=new HandlingResult();
            result.Successed = false;
            if (model != null)
            {
                String sql =
                    String.Format(
                        "INSERT INTO BPSYS_DATADICDETAIL(ID, CODE, SOURCE, CREATOR, CREATORID, CREATEDTIME) VALUES ('{0}', '{1}','{2}' , '{3}','{4}','{5}')",
                        model.Id, model.Code, model.Source, UserInformationContext.LoginName, UserInformationContext.ID,
                        DateTime.Now.ToString(ConfigImformationContext.TIME_FORMAT_FULL));
                using (DataBaseProcess process = new DataBaseProcess())
                {
                    result.MsgNumber = process.Exec(sql);
                }
            }
            result.Successed = result.MsgNumber > 0;
            result.Message = result.Successed ? "新增成功" : "新增失败";
            return result;
        }
    }
}

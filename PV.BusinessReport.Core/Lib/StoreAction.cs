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
    public class StoreAction
    {
        private const String TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public StoreAction()
        {
        }

        public DataTable Query()
        {
            String sql = "SELECT ID, NAME FROM BPSYS_STORE";
            DataTable dt=new DataTable();
            using (DataBaseProcess process=new DataBaseProcess())
            {
                dt= process.Query(sql);
            }
            return dt;
        }

        public HandlingResult Add(StoreModel model)
        {
            HandlingResult result=new HandlingResult();
            String sql =
                "INSERT INTO BPSYS_STORE(ID, NAME, PHONE, CREATOR, CREATORID, CREATEDTIME) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
            sql = String.Format(sql, model.Id, model.Name, model.Phone, UserInformationContext.LoginName,
                UserInformationContext.ID, DateTime.Now.ToString(ConfigImformationContext.TIME_FORMAT_FULL));
            using (DataBaseProcess process=new DataBaseProcess())
            {
                result.MsgNumber= process.Exec(sql);
            }
            result.Successed = result.MsgNumber > 0;
            result.Message = result.Successed ? "新增成功" : "新增失败";
            return result;
        }
    }
}

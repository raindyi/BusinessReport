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
     public class SNAction
    {
         public SNAction()
         {
         }

        public DataTable QueryByStore(Guid storeId)
        {
            String sql =String.Format("SELECT ID,CODE,NAME FROM BPSYS_STORESN WHERE STOREID='{0}'",storeId);
            DataTable dt = null;
            using (DataBaseProcess process=new DataBaseProcess())
            {
                dt = process.Query(sql);
            }
            return dt;
        }

         public HandlingResult Add(SnModel model)
         {
             HandlingResult result = new HandlingResult();
             String querysql = String.Format("SELECT COUNT(1) AS CNT FROM BPSYS_STORESN WHERE CODE='{0}'", model.Code);
             String sql =
                 "INSERT INTO BPSYS_STORESN(ID, STOREID, NAME, CODE, STATUS, CREATOR, CREATORID, CREATEDTIME) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}')";
             sql = String.Format(sql, model.Id, model.StoreId, model.Name, model.Code, 1,
                 UserInformationContext.LoginName,
                 UserInformationContext.ID, DateTime.Now.ToString(ConfigImformationContext.TIME_FORMAT_FULL));
             using (DataBaseProcess process = new DataBaseProcess())
             {
                 DataTable dt = process.Query(querysql);
                 if (dt != null && dt.Rows.Count > 0)
                 {
                     result.MsgNumber = Int32.Parse(dt.Rows[0]["CNT"].ToString());
                     if (result.MsgNumber == 0)
                     {
                         result.MsgNumber = process.Exec(sql);
                     }
                     else
                     {
                         result.MsgNumber = 0;
                         result.Message = String.Format("SN[{0}]已经存在", model.Code);
                     }
                 }
             }
             result.Successed = result.MsgNumber > 0;
             result.Message = result.Successed ? "新增成功" : "新增失败";
             return result;
         }

         public HandlingResult Update(SnModel model)
         {
             HandlingResult result = new HandlingResult();
             String sql = String.Format("UPDATE BPSYS_STORESN SET NAME='{0}',CODE='{1}' WHERE ID='{2}'", model.Name,
                 model.Code, model.Id);
             String querysql = String.Format("SELECT ID FROM BPSYS_STORESN WHERE CODE='{0}'", model.Code);

             using (DataBaseProcess process = new DataBaseProcess())
             {
                 DataTable dt = process.Query(querysql);
                 if (dt != null && dt.Rows.Count > 0)
                 {
                     Guid id = Guid.Parse(dt.Rows[0]["ID"].ToString());
                     if (id != model.Id)
                     {

                         result.MsgNumber = 0;
                         result.Message = String.Format("SN[{0}]已经存在", model.Code);
                     }
                     else
                     {
                         result.MsgNumber = process.Exec(sql);
                     }
                 }
             }
             result.Successed = result.MsgNumber > 0;
             result.Message = result.Message.Length > 0 ? result.Message : result.Successed ? "更新成功" : "更新失败";
             return result;
         }
    }
}

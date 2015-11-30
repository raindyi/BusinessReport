using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using NPV.BusinessReport.Common.Helper;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;
using PV.BusinessReport.PL.Context;

namespace PV.BusinessReport.Core.Lib
{
    public class UserAction
    {
        public UserAction()
        {

        }

        public void ChangePassword(Guid userId,String password)
        {
            String secpw = Md5Helper.GetMD5String(password);
            String sql = String.Format("update bpsys_user set password='{0}' where id='{1}'", secpw, userId);
            using (DataBaseProcess process = new DataBaseProcess())
            {
                process.Exec(sql);
            }
        }

        public DataTable GetList(UserQueryModel model)
        {
            DataTable dt = null;
            if (model != null)
            {
                String sql = "SELECT U.ID, U.LOGINNAME, U.NAME, U.PHONE, U.STATUS,CASE U.STATUS WHEN 1 THEN '有效' ELSE '无效' END AS STA, S.NAME AS SNAME FROM BPSYS_USER U INNER JOIN BPSYS_STORE S ON U.STOREID = S.ID";
                sql += " WHERE 1=1";
                //where u.[Name] like '%%' or u.Phone ='' or s.[Name] like '%%'
                if (!String.IsNullOrEmpty(model.Name))
                {
                    sql += String.Format(" AND U.NAME LIKE '%{0}%'", model.Name);
                }
                if (!String.IsNullOrEmpty(model.Name))
                {
                    sql += String.Format(" AND U.PHONE ='{0}'", model.Phone);
                }
                if (model.Store != null && model.Store != Guid.Empty)
                {
                    sql += String.Format(" AND S.ID='{0}'", model.Store.ToString());
                }
                using (DataBaseProcess process=new DataBaseProcess())
                {
                    dt = process.Query(sql);
                }
            }
            return dt;
        }

        public HandlingResult Add(UserModel model)
        {
            HandlingResult result=new HandlingResult();
            result.Successed = false;
            if (model != null)
            {
                String sql =
                    String.Format(
                        "INSERT INTO BPSYS_USER(ID, LOGINNAME, NAME, PASSWORD, PHONE, STOREID, STATUS, CREATOR, CREATORID, CREATEDTIME) VALUES ({0}, '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', {8}, '{9}')",
                        model.Id, model.LoginName, model.Name, model.Password, model.Phone, model.StoreId, 1,
                        UserInformationContext.LoginName, UserInformationContext.ID,
                        DateTime.Now.ToString(ConfigImformationContext.TIME_FORMAT_FULL));
                using (DataBaseProcess process=new DataBaseProcess())
                {
                    result.MsgNumber= process.Exec(sql);
                }
            }
            result.Successed = result.MsgNumber > 0;
            result.Message = result.Successed ? "新增成功" : "新增失败";
            return result;
        }

        public HandlingResult Modify(UserModel model)
        {
            HandlingResult result = new HandlingResult();
            result.Successed = false;
            if (model != null)
            {
                String sql =
                    String.Format(
                        "UPDATE BPSYS_USER SET LOGINNAME='{0}', NAME='{1}', PHONE='{2}', STOREID='{3}' WHERE ID='{4}'",
                        model.LoginName,model.Name,model.Phone,model.StoreId,model.Id );
                using (DataBaseProcess process = new DataBaseProcess())
                {
                    result.MsgNumber = process.Exec(sql);
                }
            }
            result.Successed = result.MsgNumber > 0;
            result.Message = result.Successed ? "修改成功" : "修改失败";
            return result;
        }

        public HandlingResult Delete(Guid userId)
        {
            HandlingResult result = new HandlingResult();
            String sql = string.Format("UPDATE BPSYS_USER SET STATUS=2' WHERE ID='{0}'", userId);
            using (DataBaseProcess process = new DataBaseProcess())
            {
                result.MsgNumber = process.Exec(sql);
            }
            result.Successed = result.MsgNumber > 0;
            result.Message = result.Successed ? "修改成功" : "修改失败";
            return result;
        }
    }
}

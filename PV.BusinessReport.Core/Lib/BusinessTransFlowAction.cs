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
    public class BusinessTransFlowAction
    {
        public BusinessTransFlowAction()
        {
        }

        public HandlingResult Import(DataTable source)
        {
            //机器SN号	交易时间	交易流水号	交易来源	实付金额	应付金额	手续费	状态	银行流水单
            HandlingResult result = new HandlingResult();
            SchemaAction action = new SchemaAction();
            DataTable dt = action.GetSchema("BUSINESS_TRANSFLOWCP");
            Guid id = Guid.NewGuid();
            DateTime t = DateTime.Now;
            foreach (DataRow sdr in source.Rows)
            {
                try
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = Guid.NewGuid();
                    dr["SN"] = sdr["机器SN号"];
                    dr["RunningNo"] = sdr["交易流水号"];
                    dr["ExcTime"] = sdr["交易时间"];
                    dr["ExcSource"] = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(sdr["交易来源"].ToString()));
                    dr["NetPay"] = sdr["实付金额"];
                    dr["Payable"] = sdr["应付金额"];
                    dr["Handling"] = sdr["手续费"];
                    dr["Statue"] = sdr["状态"];
                    dr["BankRunningNo"] = sdr["银行流水单"];
                    dr["BID"] = id;
                    dr["Creator"] = UserInformationContext.LoginName;
                    dr["CreatorID"] = UserInformationContext.ID;
                    dr["CreatedTime"] = t;
                    dt.Rows.Add(dr);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            String sql = "SELECT * FROM BUSINESS_TRANSFLOWCP WHERE 1=2";
           
            String insertsql = String.Format(
                "INSERT INTO  BUSINESS_TRANSFLOW  " +
                "SELECT C.ID,C.SN,C.RUNNINGNO,C.EXCTIME,C.EXCSOURCE,C.NETPAY,C.PAYABLE,C.HANDLING, " +
                "C.STATUE,C.BANKRUNNINGNO,C.CREATOR, C.CREATORID, C.CREATEDTIME " +
                "FROM   BUSINESS_TRANSFLOWCP C LEFT OUTER JOIN BUSINESS_TRANSFLOW S ON C.RUNNINGNO = S.RUNNINGNO " +
                "WHERE  C.BID='{0}' AND S.RUNNINGNO IS NULL", id);
            String delsql = String.Format("delete from business_transflowcp where bid='{0}'", id);
            using (DataBaseProcess process =new DataBaseProcess())
            {
                try
                {
                    Boolean upresult = process.Update(dt, sql);
                    if (upresult)
                    {
                        process.Exec(insertsql);
                        process.Exec(delsql);
                        result.Message = "导入成功";
                    }
                }
                catch (Exception ex)
                {
                    result.Successed = false;
                    result.Message = "数据存储异常";
                }

            }
            return result;
        }
    }
}

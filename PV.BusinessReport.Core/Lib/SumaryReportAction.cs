﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PV.BusinessReport.Common.Model;
using PV.BusinessReport.DAL;

namespace PV.BusinessReport.Core.Lib
{
    public class SumaryReportAction
    {
        private const String TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
        public SumaryReportAction()
        {
        }

        public DataTable Query(SummaryReportQueryModel queryModel)
        {
            //SELECT SUM(NETPAY)AS NETPAY, SUM(PAYABLE) AS NETPAY, SUM(HANDLING) AS NETPAY, EXCSOURCE
            //FROM   BUSINESS_TRANSFLOW
            //WHERE  SN = '' AND EXCTIME BETWEEN '' AND ''
            //GROUP  BY EXCSOURCE

            //SELECT EXCSOURCE, NETPAY, PAYABLE, HANDLING
            //FROM   BUSINESS_TRANSFLOW
            //WHERE  SN = '' AND EXCTIME BETWEEN '' AND ''

            //SELECT SUM(NETPAY) AS NETPAY, SUM(PAYABLE) AS NETPAY, SUM(HANDLING) AS NETPAY, EXCSOURCE, SN
            //FROM   BUSINESS_TRANSFLOW
            //WHERE  EXCTIME BETWEEN '' AND ''
            //GROUP  BY SN, EXCSOURCE
            StringBuilder sqlbulider=new StringBuilder();
            if (queryModel.ReportType == 1)
            {
                //明细
                sqlbulider.Append("SELECT SN,STATUE,BANKRUNNINGNO,EXCTIME,EXCSOURCE, NETPAY, PAYABLE, HANDLING FROM   BUSINESS_TRANSFLOW ");
                sqlbulider.Append(" WHERE 1=1");
                if (!String.IsNullOrEmpty(queryModel.SN))
                {
                    sqlbulider.AppendFormat(" AND SN='{0}'", queryModel.SN);
                }
                if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
                {
                    sqlbulider.AppendFormat(" AND EXCTIME BETWEEN '{0}' AND '{1}'",
                        queryModel.StartTime.Value.ToString(TIME_FORMAT),
                        queryModel.FinishTime.Value.ToString(TIME_FORMAT));
                }
            }
            else
            {
                //汇总
                if (String.IsNullOrEmpty(queryModel.SN))
                {
                    //所有SN汇总
                    sqlbulider.Append("SELECT SUM(NETPAY) AS NETPAY, SUM(PAYABLE) AS PAYABLE, SUM(HANDLING) AS HANDLING, EXCSOURCE, SN FROM   BUSINESS_TRANSFLOW ");
                    sqlbulider.Append(" WHERE 1=1");
                    if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
                    {
                        sqlbulider.AppendFormat(" AND EXCTIME BETWEEN '{0}' AND '{1}'",
                            queryModel.StartTime.Value.ToString(TIME_FORMAT),
                            queryModel.FinishTime.Value.ToString(TIME_FORMAT));
                    }
                    sqlbulider.Append(" GROUP  BY SN, EXCSOURCE");
                }
                else
                {
                    //单独SN汇总
                    sqlbulider.Append("SELECT SUM(NETPAY) AS NETPAY, SUM(PAYABLE) AS PAYABLE, SUM(HANDLING) AS HANDLING, EXCSOURCE FROM   BUSINESS_TRANSFLOW ");
                    sqlbulider.Append(" WHERE 1=1");
                    if (queryModel.StartTime.HasValue && queryModel.FinishTime.HasValue)
                    {
                        sqlbulider.AppendFormat(" AND EXCTIME BETWEEN '{0}' AND '{1}'",
                            queryModel.StartTime.Value.ToString(TIME_FORMAT),
                            queryModel.FinishTime.Value.ToString(TIME_FORMAT));
                    }
                    sqlbulider.AppendFormat(" AND SN='{0}'", queryModel.SN);
                    sqlbulider.Append(" GROUP  BY EXCSOURCE");
                }
            }
            DataTable dt = null;
            using (DataBaseProcess process = new DataBaseProcess())
            {
                dt = process.Query(sqlbulider.ToString());
            }
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PV.BusinessReport.UI.Model;

namespace PV.BusinessReport.UI.Config
{
    public static class DataViewGridColumnsConfig
    {
        public static readonly Dictionary<String, GridColumnModel> DeatilReportSettings = new Dictionary
            <String, GridColumnModel>()
        {
            //机器SN号	交易时间	交易流水号	交易来源	实付金额
            //应付金额	手续费	状态	银行流水单

            {
                "ID", new GridColumnModel()
                {
                    Name = "ID",
                    HeadName = "ID",
                    Visible = false
                }
            },
            {
                "SN", new GridColumnModel()
                {
                    Name = "SN",
                    HeadName = "机器SN号",
                    Width = 120
                }
            },
            {
                "RUNNINGNO", new GridColumnModel()
                {
                    Name = "RUNNINGNO",
                    HeadName = "交易流水号",
                    Width = 120
                }
            },
            {
                "EXCTIME", new GridColumnModel()
                {
                    Name = "EXCTIME",
                    HeadName = "交易时间",
                    Width = 120
                }
            },
            {
                "EXCSOURCE", new GridColumnModel()
                {
                    Name = "EXCSOURCE",
                    HeadName = "交易来源",
                    Width = 100

                }
            },
            {
                "NETPAY", new GridColumnModel()
                {
                    Name = "NETPAY",
                    HeadName = "实付金额",
                    Width = 125
                }
            },
            {
                "PAYABLE", new GridColumnModel()
                {
                    Name = "PAYABLE",
                    HeadName = "应付金额",
                    Width = 125
                }
            },
            {
                "HANDLING", new GridColumnModel()
                {
                    Name = "HANDLING",
                    HeadName = "手续费",
                    Width = 125
                }
            },
            {
                "STATUE", new GridColumnModel()
                {
                    Name = "STATUE",
                    HeadName = "状态",
                    Width = 125
                }
            },
            {
                "BANKRUNNINGNO", new GridColumnModel()
                {
                    Name = "BANKRUNNINGNO",
                    HeadName = "银行流水单",
                    Width = 200
                }
            }

        };
    }
}

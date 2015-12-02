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

        public static readonly Dictionary<String, GridColumnModel> UserSettings = new Dictionary
            <String, GridColumnModel>()
        {
            //ID, LOGINNAME, [NAME], PASSWORD, PHONE, STOREID, STATUS
            {
                "ID", new GridColumnModel()
                {
                    Name = "ID",
                    HeadName = "ID",
                    Visible = false
                }
            },
            {
                "LOGINNAME", new GridColumnModel()
                {
                    Name = "LOGINNAME",
                    HeadName = "登录名",
                    Width = 175
                }
            },
            {
                "NAME", new GridColumnModel()
                {
                    Name = "NAME",
                    HeadName = "姓名",
                    Width = 175
                }
            },
            {
                "PHONE", new GridColumnModel()
                {
                    Name = "PHONE",
                    HeadName = "电话",
                    Width = 120
                }
            },
            {
                "SNAME", new GridColumnModel()
                {
                    Name = "SNAME",
                    HeadName = "门店",
                    Width = 200
                }
            },
            {
                "STATUS", new GridColumnModel()
                {
                    Name = "STATUS",
                    HeadName = "STATUS",
                    Visible = false
                }
            },
            {
                "STA", new GridColumnModel()
                {
                    Name = "STA",
                    HeadName = "状态",
                    Width = 80
                }
            },
            {
                "PASSWORD", new GridColumnModel()
                {
                    Name = "PASSWORD",
                    HeadName = "PW",
                    Width = 80,
                    Visible = false
                }
            },
            {
                "STOREID", new GridColumnModel()
                {
                    Name = "STOREID",
                    HeadName = "门店ID",
                    Width = 80,
                    Visible = false
                }
            }
        };

        public static readonly Dictionary<String, GridColumnModel> DataDicSettings = new Dictionary
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
                "CODE", new GridColumnModel()
                {
                    Name = "CODE",
                    HeadName = "明细",
                    Width = 300
                }
            },
            {
                "DCODE", new GridColumnModel()
                {
                    Name = "DCODE",
                    HeadName = "主项",
                    Width = 200
                }
            }
        };

        public static readonly Dictionary<String, GridColumnModel> StoreSettings = new Dictionary
            <String, GridColumnModel>()
        {
            {
                "ID", new GridColumnModel()
                {
                    Name = "ID",
                    HeadName = "ID",
                    Visible = false
                }
            },
            {
                "NAME", new GridColumnModel()
                {
                    Name = "NAME",
                    HeadName = "名称",
                    Width = 300
                }
            },
            {
                "PHONE", new GridColumnModel()
                {
                    Name = "PHONE",
                    HeadName = "电话",
                    Width = 120
                }
            }
        };
        public static readonly Dictionary<String, GridColumnModel> SNSettings = new Dictionary
           <String, GridColumnModel>()
        {
            {
                "ID", new GridColumnModel()
                {
                    Name = "ID",
                    HeadName = "ID",
                    Visible = false
                }
            },
            {
                "NAME", new GridColumnModel()
                {
                    Name = "NAME",
                    HeadName = "别名",
                    Width = 265
                }
            },
            {
                "CODE", new GridColumnModel()
                {
                    Name = "CODE",
                    HeadName = "SN编号",
                    Width = 120
                }
            }
        };

        public static readonly Dictionary<String, GridColumnModel> SNDetailReportSettings = new Dictionary
           <String, GridColumnModel>()
        {
            {
                "SN", new GridColumnModel()
                {
                    Name = "SN",
                    HeadName = "机器SN号",
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
        public static readonly Dictionary<String, GridColumnModel> SNSummaryReport_SNSettings = new Dictionary
          <String, GridColumnModel>()
        {
            {
                "SN", new GridColumnModel()
                {
                    Name = "SN",
                    HeadName = "机器SN号",
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
            }
        };
        public static readonly Dictionary<String, GridColumnModel> SNSummaryReport_NOSNSettings = new Dictionary
          <String, GridColumnModel>()
        {
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
            }
        };
    }
}

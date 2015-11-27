using System;
using System.Collections.Generic;
using System.Management;

namespace PV.BusinessReport.Common.Helper
{
    public class InforHelper
    {
        private static InforHelper _helper;
        private static object _lockobj=new object();
        public InforHelper()
        {

        }

        public static InforHelper Instance()
        {
            lock (_lockobj)
            {
                if (_helper == null)
                {
                    _helper=new InforHelper();
                }
            }
            return _helper;
        }

        public List<String> GetMacAddress()
        {
            List<String> macs = new List<string>();
            try
            {
                string mac = "";
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"])
                    {
                        mac = mo["MacAddress"].ToString();
                        macs.Add(mac);
                    }
                }
                moc = null;
                mc = null;
            }
            catch(Exception ex)
            {
                //_log.Error("MacAddress get error",ex);
            }
            return macs;
        }
    }
}

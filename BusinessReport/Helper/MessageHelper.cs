using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PV.BusinessReport.UI.Forms;

namespace PV.BusinessReport.UI.Helper
{
    public static class MessageHelper
    {
        private static String _captionInformation = "信息提示";
        private static String _captionWarning = "操作注意";
        private static String _captionError = "错误";
        private static String _captionYesOrNo = "请选择";

        public static void ShowInformationNotify(Form OperationForm, String Message)
        {
            ShowNotify(OperationForm, _captionInformation, Message, ToolTipIcon.Info);
        }

        public static void ShowInformationNotify(Form OperationForm, String NotifyTitle, String Message)
        {
            ShowNotify(OperationForm, NotifyTitle, Message, ToolTipIcon.Info);
        }

        public static void ShowWarningNotify(Form OperationForm, String Message)
        {
            ShowNotify(OperationForm, _captionWarning, Message, ToolTipIcon.Warning);
        }

        public static void ShowWarningNotify(Form OperationForm, String NotifyTitle, String Message)
        {
            ShowNotify(OperationForm, NotifyTitle, Message, ToolTipIcon.Warning);
        }

        public static void ShowErrorNotify(Form OperationForm, String Message)
        {
            ShowNotify(OperationForm, _captionError, Message, ToolTipIcon.Error);
        }

        public static void ShowErrorNotify(Form OperationForm, String NotifyTitle, String Message)
        {
            ShowNotify(OperationForm, NotifyTitle, Message, ToolTipIcon.Error);
        }

        public static void ShowNormalNotify(Form OperationForm, String Message)
        {
            ShowNotify(OperationForm, "", Message, ToolTipIcon.None);
        }

        public static void ShowNormalNotify(Form OperationForm, String NotifyTitle, String Message)
        {
            ShowNotify(OperationForm, NotifyTitle, Message, ToolTipIcon.None);
        }

        public static void ShowNotify(Form OperationForm, String NotifyTitle, String Message, ToolTipIcon TipIcon)
        {
            Form frm = GetNotifyContainsForm(OperationForm);
            if (frm != null)
            {
                if (frm.Tag != null)
                {
                    object obj = frm.Tag;
                    if (obj.GetType().Equals(typeof(NotifyIcon)))
                    {
                        NotifyIcon notify = (NotifyIcon)frm.Tag;
                        ShowNotifyTip(notify, NotifyTitle, Message, TipIcon);
                    }
                }
            }
        }

        public static void ShowNotifyTip(NotifyIcon notifyIcon, String NotifyTitle, String Message, ToolTipIcon TipIcon)
        {
            if (String.IsNullOrEmpty(Message))
            {
                Message = " ";
            }
            notifyIcon.ShowBalloonTip(300, NotifyTitle, Message, TipIcon);
        }

        private static Form GetNotifyContainsForm(Form operationForm)
        {
            if (operationForm != null)
            {
                if (operationForm.Parent != null)
                {
                    Form parentfrm = operationForm.Parent.FindForm();
                    if (parentfrm != null)
                    {
                        return parentfrm;
                    }
                }
                else
                {
                    Form parentfrm = operationForm.Owner;
                    if (parentfrm != null)
                    {
                        return parentfrm;
                    }
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using log4net;
using PV.BusinessReport.PL.Context;
using PV.BusinessReport.UI.Config;
using PV.BusinessReport.UI.Model;

namespace PV.BusinessReport.UI.Forms
{
    public partial class MainForm : BaseForm
    {
        private Dictionary<String, Int32> pageDictionary = new Dictionary<string, Int32>();
        private Assembly _assembly;
        private ILog _log = LogManager.GetLogger(typeof(MainForm));
        private const Int32 CLOSE_SIZE = 15;
        public MainForm()
        {
            InitializeComponent();
        }
        #region Function

        private void Init()
        {
            _assembly = Assembly.Load("PV.BusinessReport.UI");
            Activator.CreateInstance(_assembly.GetType("PV.BusinessReport.UI.Forms.AboutForm"), true);
            tabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            linkLabelUser.Text = UserInformationContext.Name;
            Tag = notifyIconMessage;
        }

        private void AddForm(String name)
        {
            if (pageDictionary.Keys.Contains(name))
            {
                tabControlMain.TabPages[pageDictionary[name]].Select();
            }
            else
            {
                if (MenuConfig.MenuConfigSettings.Keys.Contains(name))
                {
                    MenuConfigModel model = MenuConfig.MenuConfigSettings[name];
                    try
                    {
                        Type t = _assembly.GetType(model.OperateFormFullName);
                        object obj = Activator.CreateInstance(t);
                        Form frm = (Form)obj;
                        if (model.DialogModel)
                        {
                            frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.ShowDialog(this);
                        }
                        else
                        {
                            TabPage page = new TabPage();
                            frm.TopLevel = false;
                            frm.WindowState = FormWindowState.Maximized;
                            frm.Dock = DockStyle.Fill;
                            page.Text = frm.Text + "      ";
                            page.Controls.Add(frm);
                            page.Tag = name;
                            tabControlMain.TabPages.Add(page);
                            pageDictionary.Add(name, tabControlMain.TabCount - 1);
                            page.Show();
                            tabControlMain.SelectTab(page);
                            frm.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.Error(String.Format("主窗体加载子窗体出现错误::配置名[{0}]\r\n", name), ex);
                    }
                }
            }
        }

        private void ClearTabForm()
        {
            foreach (TabPage tp in tabControlMain.TabPages)
            {
                try
                {
                    ((Form)tp.Controls[0]).Close();
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            tabControlMain.TabPages.Clear();
        }
        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle myTabRect = tabControlMain.GetTabRect(e.Index);

                //先添加TabPage属性   
                e.Graphics.DrawString(tabControlMain.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText,
                    myTabRect.X + 2, myTabRect.Y + 2);

                //再画一个矩形框
                using (Pen p = new Pen(Color.White))
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                    myTabRect.Width = CLOSE_SIZE;
                    myTabRect.Height = CLOSE_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                //填充矩形框
                Color recColor = e.State == DrawItemState.Selected ? Color.LightGray : tabControlMain.BackColor;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }

                //画关闭符号
                using (Pen objpen = new Pen(Color.Black))
                {
                    //=============================================
                    //自己画X
                    //"\"线
                    Point p1 = new Point(myTabRect.X + 3, myTabRect.Y + 3);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + myTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);
                    //"/"线
                    Point p3 = new Point(myTabRect.X + 3, myTabRect.Y + myTabRect.Height - 3);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);

                    ////=============================================
                    //使用图片
                    //Bitmap bt = new Bitmap(image);
                    Point p5 = new Point(myTabRect.X, 4);
                    //e.Graphics.DrawImage(bt, p5);
                    //e.Graphics.DrawString(this.MainTabControl.TabPages[e.Index].Text, this.Font, objpen.Brush, p5);
                }
                e.Graphics.Dispose();
            }
            catch (Exception ex)
            {
                _log.Error("FormMain_TabControl_DrawItemEvent_Error", ex);
            }
        }

        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //计算关闭区域   
                Rectangle myTabRect = tabControlMain.GetTabRect(tabControlMain.SelectedIndex);

                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;

                //如果鼠标在区域内就关闭选项卡   
                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if (isClose == true)
                {
                    Form frm = tabControlMain.SelectedTab.Controls[0] as Form;
                    //if (frm.BusyState)
                    //{
                    //    MessageBox.Show("正在处理业务,暂时无法关闭,请等待业务处理完成或手动终止业务", "警告", MessageBoxButtons.OK,
                    //        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    //}
                    //else
                    //{
                    //    frm.Close();
                    //    pageDictionary.Remove(tabControlMain.SelectedTab.Tag.ToString());
                    //    tabControlMain.TabPages.Remove(tabControlMain.SelectedTab);
                    //}
                    frm.Close();
                    pageDictionary.Remove(tabControlMain.SelectedTab.Tag.ToString());
                    tabControlMain.TabPages.Remove(tabControlMain.SelectedTab);
                }
            }
        }
        #endregion
        private void tsMenuItemTransFlowImport_Click(object sender, EventArgs e)
        {
            AddForm("TRANSFLOWIMPORT");
        }

        private void tsMenuItemUserManagement_Click(object sender, EventArgs e)
        {
            AddForm("USERLIST");
        }

        private void tsMenuItemStore_Click(object sender, EventArgs e)
        {
            AddForm("STORE");
        }

        private void tsMenuItemAbout_Click(object sender, EventArgs e)
        {
            AddForm("ABOUT");
        }

        private void tsMenuItemDataDic_Click(object sender, EventArgs e)
        {
            AddForm("DATADICLIST"); 
        }


        private void tsMenuItemBTFReport_Click(object sender, EventArgs e)
        {
            AddForm("DETAILREPORT");
        }

        private void tsMenuItemClear_Click(object sender, EventArgs e)
        {
            AddForm("TRANSFORREPORTDATA");
        }

        private void tsMenuItemBTFSumReport_Click(object sender, EventArgs e)
        {
            AddForm("SUMMARYREPORT");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                ClearTabForm();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void linkLabelUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PwChangeForm pwChange=new PwChangeForm();
            pwChange.StartPosition=FormStartPosition.CenterScreen;
            pwChange.ShowDialog(this);
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PV.BusinessReport.UI.Forms
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            splitContainerBottom.Panel1.Height = 1;
        }

        private void LoadData()
        {

        }

        #region ControlEvent
        private void UserListForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void dataGridViewList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxQStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

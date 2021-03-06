﻿namespace PV.BusinessReport.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripOprMain = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemTransFlowImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBTFReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBTFSumReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemStore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemDataDic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.linkLabelUser = new System.Windows.Forms.LinkLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.notifyIconMessage = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripOprMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripOprMain
            // 
            this.menuStripOprMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemData,
            this.tsMenuItemReport,
            this.tsMenuItemSystem});
            this.menuStripOprMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripOprMain.Name = "menuStripOprMain";
            this.menuStripOprMain.Size = new System.Drawing.Size(672, 24);
            this.menuStripOprMain.TabIndex = 0;
            // 
            // tsMenuItemData
            // 
            this.tsMenuItemData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemTransFlowImport});
            this.tsMenuItemData.Name = "tsMenuItemData";
            this.tsMenuItemData.Size = new System.Drawing.Size(83, 20);
            this.tsMenuItemData.Text = "数据业务(&D)";
            // 
            // tsMenuItemTransFlowImport
            // 
            this.tsMenuItemTransFlowImport.Name = "tsMenuItemTransFlowImport";
            this.tsMenuItemTransFlowImport.Size = new System.Drawing.Size(152, 22);
            this.tsMenuItemTransFlowImport.Text = "交易流水导入";
            this.tsMenuItemTransFlowImport.Click += new System.EventHandler(this.tsMenuItemTransFlowImport_Click);
            // 
            // tsMenuItemReport
            // 
            this.tsMenuItemReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemBTFReport,
            this.tsMenuItemBTFSumReport,
            this.toolStripSeparator1,
            this.tsMenuItemClear});
            this.tsMenuItemReport.Name = "tsMenuItemReport";
            this.tsMenuItemReport.Size = new System.Drawing.Size(82, 20);
            this.tsMenuItemReport.Text = "报表业务(&R)";
            // 
            // tsMenuItemBTFReport
            // 
            this.tsMenuItemBTFReport.Name = "tsMenuItemBTFReport";
            this.tsMenuItemBTFReport.Size = new System.Drawing.Size(146, 22);
            this.tsMenuItemBTFReport.Text = "交易流水查询";
            this.tsMenuItemBTFReport.Click += new System.EventHandler(this.tsMenuItemBTFReport_Click);
            // 
            // tsMenuItemBTFSumReport
            // 
            this.tsMenuItemBTFSumReport.Name = "tsMenuItemBTFSumReport";
            this.tsMenuItemBTFSumReport.Size = new System.Drawing.Size(146, 22);
            this.tsMenuItemBTFSumReport.Text = "交易分析报表";
            this.tsMenuItemBTFSumReport.Click += new System.EventHandler(this.tsMenuItemBTFSumReport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // tsMenuItemClear
            // 
            this.tsMenuItemClear.Name = "tsMenuItemClear";
            this.tsMenuItemClear.Size = new System.Drawing.Size(146, 22);
            this.tsMenuItemClear.Text = "报表数据清理";
            this.tsMenuItemClear.Click += new System.EventHandler(this.tsMenuItemClear_Click);
            // 
            // tsMenuItemSystem
            // 
            this.tsMenuItemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemUserManagement,
            this.tsMenuItemStore,
            this.tsMenuItemDataDic,
            this.toolStripSeparator2,
            this.tsMenuItemAbout});
            this.tsMenuItemSystem.Name = "tsMenuItemSystem";
            this.tsMenuItemSystem.Size = new System.Drawing.Size(82, 20);
            this.tsMenuItemSystem.Text = "系统管理(&T)";
            // 
            // tsMenuItemUserManagement
            // 
            this.tsMenuItemUserManagement.Name = "tsMenuItemUserManagement";
            this.tsMenuItemUserManagement.Size = new System.Drawing.Size(122, 22);
            this.tsMenuItemUserManagement.Text = "用户管理";
            this.tsMenuItemUserManagement.Click += new System.EventHandler(this.tsMenuItemUserManagement_Click);
            // 
            // tsMenuItemStore
            // 
            this.tsMenuItemStore.Name = "tsMenuItemStore";
            this.tsMenuItemStore.Size = new System.Drawing.Size(122, 22);
            this.tsMenuItemStore.Text = "门店管理";
            this.tsMenuItemStore.Click += new System.EventHandler(this.tsMenuItemStore_Click);
            // 
            // tsMenuItemDataDic
            // 
            this.tsMenuItemDataDic.Name = "tsMenuItemDataDic";
            this.tsMenuItemDataDic.Size = new System.Drawing.Size(122, 22);
            this.tsMenuItemDataDic.Text = "数据字典";
            this.tsMenuItemDataDic.Click += new System.EventHandler(this.tsMenuItemDataDic_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // tsMenuItemAbout
            // 
            this.tsMenuItemAbout.Name = "tsMenuItemAbout";
            this.tsMenuItemAbout.Size = new System.Drawing.Size(122, 22);
            this.tsMenuItemAbout.Text = "关于";
            this.tsMenuItemAbout.Click += new System.EventHandler(this.tsMenuItemAbout_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainerMain.Panel1.Controls.Add(this.labelWelcome);
            this.splitContainerMain.Panel1.Controls.Add(this.linkLabelUser);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.splitContainerMain.Size = new System.Drawing.Size(672, 392);
            this.splitContainerMain.SplitterDistance = 25;
            this.splitContainerMain.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(457, 5);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "欢迎您:";
            // 
            // linkLabelUser
            // 
            this.linkLabelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelUser.Location = new System.Drawing.Point(517, 5);
            this.linkLabelUser.Name = "linkLabelUser";
            this.linkLabelUser.Size = new System.Drawing.Size(150, 15);
            this.linkLabelUser.TabIndex = 0;
            this.linkLabelUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUser_LinkClicked);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(666, 358);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            this.tabControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseDown);
            // 
            // notifyIconMessage
            // 
            this.notifyIconMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMessage.Icon")));
            this.notifyIconMessage.Text = "交易流水数据管理系统";
            this.notifyIconMessage.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 416);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStripOprMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOprMain;
            this.Name = "MainForm";
            this.Text = "交易流水数据管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripOprMain.ResumeLayout(false);
            this.menuStripOprMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOprMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.LinkLabel linkLabelUser;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemData;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemTransFlowImport;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemReport;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSystem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemUserManagement;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemStore;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemDataDic;
        private System.Windows.Forms.NotifyIcon notifyIconMessage;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBTFReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBTFSumReport;
    }
}


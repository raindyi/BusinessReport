namespace PV.BusinessReport.UI.Forms
{
    partial class UserListForm
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxQPhone = new System.Windows.Forms.TextBox();
            this.labelQPhone = new System.Windows.Forms.Label();
            this.textBoxQName = new System.Windows.Forms.TextBox();
            this.labelQName = new System.Windows.Forms.Label();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.labelQStore = new System.Windows.Forms.Label();
            this.comboBoxQStore = new System.Windows.Forms.ComboBox();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.labelStore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.comboBoxQStore);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainerMain.Panel1.Controls.Add(this.labelQStore);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxQPhone);
            this.splitContainerMain.Panel1.Controls.Add(this.labelQPhone);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxQName);
            this.splitContainerMain.Panel1.Controls.Add(this.labelQName);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBottom);
            this.splitContainerMain.Size = new System.Drawing.Size(750, 456);
            this.splitContainerMain.SplitterDistance = 30;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(562, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "查找";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxQPhone
            // 
            this.textBoxQPhone.Location = new System.Drawing.Point(242, 6);
            this.textBoxQPhone.Name = "textBoxQPhone";
            this.textBoxQPhone.Size = new System.Drawing.Size(135, 20);
            this.textBoxQPhone.TabIndex = 3;
            // 
            // labelQPhone
            // 
            this.labelQPhone.AutoSize = true;
            this.labelQPhone.Location = new System.Drawing.Point(193, 9);
            this.labelQPhone.Name = "labelQPhone";
            this.labelQPhone.Size = new System.Drawing.Size(31, 13);
            this.labelQPhone.TabIndex = 2;
            this.labelQPhone.Text = "手机";
            // 
            // textBoxQName
            // 
            this.textBoxQName.Location = new System.Drawing.Point(52, 6);
            this.textBoxQName.Name = "textBoxQName";
            this.textBoxQName.Size = new System.Drawing.Size(135, 20);
            this.textBoxQName.TabIndex = 1;
            // 
            // labelQName
            // 
            this.labelQName.AutoSize = true;
            this.labelQName.Location = new System.Drawing.Point(3, 9);
            this.labelQName.Name = "labelQName";
            this.labelQName.Size = new System.Drawing.Size(43, 13);
            this.labelQName.TabIndex = 0;
            this.labelQName.Text = "用户名";
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerBottom.IsSplitterFixed = true;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.comboBoxStore);
            this.splitContainerBottom.Panel1.Controls.Add(this.textBoxPhone);
            this.splitContainerBottom.Panel1.Controls.Add(this.labelStore);
            this.splitContainerBottom.Panel1.Controls.Add(this.labelPhone);
            this.splitContainerBottom.Panel1.Controls.Add(this.textBoxName);
            this.splitContainerBottom.Panel1.Controls.Add(this.labelName);
            this.splitContainerBottom.Panel1.Controls.Add(this.textBoxLoginName);
            this.splitContainerBottom.Panel1.Controls.Add(this.labelLoginName);
            this.splitContainerBottom.Panel1MinSize = 30;
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainerBottom.Size = new System.Drawing.Size(750, 422);
            this.splitContainerBottom.SplitterDistance = 30;
            this.splitContainerBottom.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(420, 6);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(135, 20);
            this.textBoxPhone.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(383, 9);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(31, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "手机";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(242, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(135, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(193, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "用户名";
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(52, 6);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(135, 20);
            this.textBoxLoginName.TabIndex = 1;
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(3, 9);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(43, 13);
            this.labelLoginName.TabIndex = 0;
            this.labelLoginName.Text = "登录名";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(750, 388);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseClick);
            // 
            // labelQStore
            // 
            this.labelQStore.AutoSize = true;
            this.labelQStore.Location = new System.Drawing.Point(383, 9);
            this.labelQStore.Name = "labelQStore";
            this.labelQStore.Size = new System.Drawing.Size(31, 13);
            this.labelQStore.TabIndex = 6;
            this.labelQStore.Text = "门店";
            // 
            // comboBoxQStore
            // 
            this.comboBoxQStore.FormattingEnabled = true;
            this.comboBoxQStore.Location = new System.Drawing.Point(420, 5);
            this.comboBoxQStore.Name = "comboBoxQStore";
            this.comboBoxQStore.Size = new System.Drawing.Size(135, 21);
            this.comboBoxQStore.TabIndex = 7;
            this.comboBoxQStore.SelectedIndexChanged += new System.EventHandler(this.comboBoxQStore_SelectedIndexChanged);
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(598, 5);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(135, 21);
            this.comboBoxStore.TabIndex = 9;
            this.comboBoxStore.SelectedIndexChanged += new System.EventHandler(this.comboBoxStore_SelectedIndexChanged);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(561, 9);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(31, 13);
            this.labelStore.TabIndex = 8;
            this.labelStore.Text = "门店";
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 456);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel1.PerformLayout();
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label labelQName;
        private System.Windows.Forms.TextBox textBoxQName;
        private System.Windows.Forms.TextBox textBoxQPhone;
        private System.Windows.Forms.Label labelQPhone;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Label labelQStore;
        private System.Windows.Forms.ComboBox comboBoxQStore;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.Label labelStore;
    }
}
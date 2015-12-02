namespace PV.BusinessReport.UI.Forms
{
    partial class StoreListForm
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
            this.textBoxStoreName = new System.Windows.Forms.TextBox();
            this.labelStore = new System.Windows.Forms.Label();
            this.textBoxSnCode = new System.Windows.Forms.TextBox();
            this.labelSnCode = new System.Windows.Forms.Label();
            this.textBoxSnName = new System.Windows.Forms.TextBox();
            this.labelSnName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddSN = new System.Windows.Forms.Button();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
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
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxStoreName);
            this.splitContainerMain.Panel1.Controls.Add(this.labelStore);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSnCode);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSnCode);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSnName);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSnName);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxPhone);
            this.splitContainerMain.Panel1.Controls.Add(this.labelPhone);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxName);
            this.splitContainerMain.Panel1.Controls.Add(this.labelName);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonRefresh);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonAddSN);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonAddStore);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerMain.Size = new System.Drawing.Size(750, 471);
            this.splitContainerMain.SplitterDistance = 100;
            this.splitContainerMain.TabIndex = 0;
            // 
            // textBoxStoreName
            // 
            this.textBoxStoreName.Location = new System.Drawing.Point(434, 43);
            this.textBoxStoreName.Name = "textBoxStoreName";
            this.textBoxStoreName.Size = new System.Drawing.Size(150, 20);
            this.textBoxStoreName.TabIndex = 12;
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(397, 46);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(31, 13);
            this.labelStore.TabIndex = 11;
            this.labelStore.Text = "门店";
            // 
            // textBoxSnCode
            // 
            this.textBoxSnCode.Location = new System.Drawing.Point(241, 43);
            this.textBoxSnCode.Name = "textBoxSnCode";
            this.textBoxSnCode.Size = new System.Drawing.Size(150, 20);
            this.textBoxSnCode.TabIndex = 10;
            // 
            // labelSnCode
            // 
            this.labelSnCode.AutoSize = true;
            this.labelSnCode.Location = new System.Drawing.Point(204, 46);
            this.labelSnCode.Name = "labelSnCode";
            this.labelSnCode.Size = new System.Drawing.Size(22, 13);
            this.labelSnCode.TabIndex = 9;
            this.labelSnCode.Text = "SN";
            // 
            // textBoxSnName
            // 
            this.textBoxSnName.Location = new System.Drawing.Point(48, 43);
            this.textBoxSnName.Name = "textBoxSnName";
            this.textBoxSnName.Size = new System.Drawing.Size(150, 20);
            this.textBoxSnName.TabIndex = 8;
            // 
            // labelSnName
            // 
            this.labelSnName.AutoSize = true;
            this.labelSnName.Location = new System.Drawing.Point(11, 46);
            this.labelSnName.Name = "labelSnName";
            this.labelSnName.Size = new System.Drawing.Size(31, 13);
            this.labelSnName.TabIndex = 7;
            this.labelSnName.Text = "别名";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(338, 12);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhone.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(301, 15);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(31, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "电话";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(48, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "名称";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(590, 71);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(110, 25);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "刷新(&R)";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddSN
            // 
            this.buttonAddSN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAddSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSN.Location = new System.Drawing.Point(590, 40);
            this.buttonAddSN.Name = "buttonAddSN";
            this.buttonAddSN.Size = new System.Drawing.Size(110, 25);
            this.buttonAddSN.TabIndex = 1;
            this.buttonAddSN.Text = "新增SN(&N)";
            this.buttonAddSN.UseVisualStyleBackColor = true;
            this.buttonAddSN.Click += new System.EventHandler(this.buttonAddSN_Click);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStore.Location = new System.Drawing.Point(590, 9);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(110, 25);
            this.buttonAddStore.TabIndex = 0;
            this.buttonAddStore.Text = "新增门店(&M)";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(744, 361);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseClick);
            this.dataGridViewList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseDoubleClick);
            // 
            // StoreListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 471);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreListForm";
            this.Text = "门店管理";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.Button buttonAddSN;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxSnCode;
        private System.Windows.Forms.Label labelSnCode;
        private System.Windows.Forms.TextBox textBoxSnName;
        private System.Windows.Forms.Label labelSnName;
        private System.Windows.Forms.TextBox textBoxStoreName;
        private System.Windows.Forms.Label labelStore;
    }
}
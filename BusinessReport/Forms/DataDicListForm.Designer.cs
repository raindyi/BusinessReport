namespace PV.BusinessReport.UI.Forms
{
    partial class DataDicListForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSubName = new System.Windows.Forms.TextBox();
            this.labelSubName = new System.Windows.Forms.Label();
            this.comboBoxMainType = new System.Windows.Forms.ComboBox();
            this.labelMainType = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
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
            this.splitContainerMain.Panel1.Controls.Add(this.buttonRefresh);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSubName);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSubName);
            this.splitContainerMain.Panel1.Controls.Add(this.comboBoxMainType);
            this.splitContainerMain.Panel1.Controls.Add(this.labelMainType);
            this.splitContainerMain.Panel1MinSize = 40;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerMain.Size = new System.Drawing.Size(600, 350);
            this.splitContainerMain.SplitterDistance = 40;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(398, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "新增(&X)";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSubName
            // 
            this.textBoxSubName.Location = new System.Drawing.Point(242, 12);
            this.textBoxSubName.Name = "textBoxSubName";
            this.textBoxSubName.Size = new System.Drawing.Size(150, 20);
            this.textBoxSubName.TabIndex = 3;
            // 
            // labelSubName
            // 
            this.labelSubName.AutoSize = true;
            this.labelSubName.Location = new System.Drawing.Point(205, 15);
            this.labelSubName.Name = "labelSubName";
            this.labelSubName.Size = new System.Drawing.Size(31, 13);
            this.labelSubName.TabIndex = 2;
            this.labelSubName.Text = "名称";
            // 
            // comboBoxMainType
            // 
            this.comboBoxMainType.FormattingEnabled = true;
            this.comboBoxMainType.Location = new System.Drawing.Point(49, 12);
            this.comboBoxMainType.Name = "comboBoxMainType";
            this.comboBoxMainType.Size = new System.Drawing.Size(150, 21);
            this.comboBoxMainType.TabIndex = 1;
            this.comboBoxMainType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainType_SelectedIndexChanged);
            // 
            // labelMainType
            // 
            this.labelMainType.AutoSize = true;
            this.labelMainType.Location = new System.Drawing.Point(12, 15);
            this.labelMainType.Name = "labelMainType";
            this.labelMainType.Size = new System.Drawing.Size(31, 13);
            this.labelMainType.TabIndex = 0;
            this.labelMainType.Text = "类别";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(594, 300);
            this.dataGridViewList.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(479, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 25);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "刷新(&R)";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // DataDicListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataDicListForm";
            this.Text = "数据字典管理";
            this.Load += new System.EventHandler(this.DataDicListForm_Load);
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
        private System.Windows.Forms.Label labelMainType;
        private System.Windows.Forms.ComboBox comboBoxMainType;
        private System.Windows.Forms.Label labelSubName;
        private System.Windows.Forms.TextBox textBoxSubName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
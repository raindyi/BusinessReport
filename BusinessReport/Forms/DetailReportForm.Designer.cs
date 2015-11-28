namespace PV.BusinessReport.UI.Forms
{
    partial class DetailReportForm
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
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.labelStore = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.labelSN = new System.Windows.Forms.Label();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelFinish = new System.Windows.Forms.Label();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
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
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.dateTimePickerFinish);
            this.splitContainerMain.Panel1.Controls.Add(this.labelFinish);
            this.splitContainerMain.Panel1.Controls.Add(this.dateTimePickerStart);
            this.splitContainerMain.Panel1.Controls.Add(this.labelStartTime);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonQuery);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSN);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSN);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSource);
            this.splitContainerMain.Panel1.Controls.Add(this.comboBoxSource);
            this.splitContainerMain.Panel1.Controls.Add(this.labelStore);
            this.splitContainerMain.Panel1.Controls.Add(this.comboBoxStore);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerMain.Size = new System.Drawing.Size(755, 490);
            this.splitContainerMain.SplitterDistance = 75;
            this.splitContainerMain.TabIndex = 0;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(749, 405);
            this.dataGridViewList.TabIndex = 0;
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(56, 33);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(125, 24);
            this.comboBoxStore.TabIndex = 0;
            this.comboBoxStore.SelectedIndexChanged += new System.EventHandler(this.comboBoxStore_SelectedIndexChanged);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.Location = new System.Drawing.Point(12, 37);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(38, 16);
            this.labelStore.TabIndex = 1;
            this.labelStore.Text = "门店";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(187, 37);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(68, 16);
            this.labelSource.TabIndex = 3;
            this.labelSource.Text = "交易来源";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(261, 33);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(125, 24);
            this.comboBoxSource.TabIndex = 2;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSN.Location = new System.Drawing.Point(392, 37);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(42, 16);
            this.labelSN.TabIndex = 4;
            this.labelSN.Text = "SN号";
            // 
            // textBoxSN
            // 
            this.textBoxSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSN.Location = new System.Drawing.Point(440, 34);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(200, 22);
            this.textBoxSN.TabIndex = 5;
            // 
            // buttonQuery
            // 
            this.buttonQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuery.Location = new System.Drawing.Point(565, 5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 25);
            this.buttonQuery.TabIndex = 6;
            this.buttonQuery.Text = "查询(&C)";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(12, 9);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(38, 16);
            this.labelStartTime.TabIndex = 7;
            this.labelStartTime.Text = "起始";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(56, 7);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 8;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(262, 9);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(23, 16);
            this.labelFinish.TabIndex = 9;
            this.labelFinish.Text = "至";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(291, 7);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinish.TabIndex = 10;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePickerFinish_ValueChanged);
            // 
            // DetailReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 490);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailReportForm";
            this.Text = "交易明细报表";
            this.Load += new System.EventHandler(this.DetailReportForm_Load);
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
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
    }
}
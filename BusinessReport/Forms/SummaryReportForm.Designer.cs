namespace PV.BusinessReport.UI.Forms
{
    partial class SummaryReportForm
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
            this.groupBoxTimeCondition = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.radioButtonDefine = new System.Windows.Forms.RadioButton();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.labelFinish = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.labelSN = new System.Windows.Forms.Label();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.checkBoxReportType = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxTimeCondition.SuspendLayout();
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
            this.splitContainerMain.Panel1.Controls.Add(this.checkBoxReportType);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonQuery);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSN);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSN);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxTimeCondition);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerMain.Size = new System.Drawing.Size(753, 500);
            this.splitContainerMain.SplitterDistance = 125;
            this.splitContainerMain.TabIndex = 0;
            // 
            // groupBoxTimeCondition
            // 
            this.groupBoxTimeCondition.Controls.Add(this.comboBoxTime);
            this.groupBoxTimeCondition.Controls.Add(this.dateTimePickerFinish);
            this.groupBoxTimeCondition.Controls.Add(this.labelFinish);
            this.groupBoxTimeCondition.Controls.Add(this.dateTimePickerStart);
            this.groupBoxTimeCondition.Controls.Add(this.radioButtonDefine);
            this.groupBoxTimeCondition.Controls.Add(this.radioButtonCustomer);
            this.groupBoxTimeCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTimeCondition.Name = "groupBoxTimeCondition";
            this.groupBoxTimeCondition.Size = new System.Drawing.Size(528, 76);
            this.groupBoxTimeCondition.TabIndex = 0;
            this.groupBoxTimeCondition.TabStop = false;
            this.groupBoxTimeCondition.Text = "时间设置";
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustomer.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(71, 20);
            this.radioButtonCustomer.TabIndex = 0;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "自定义";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefine
            // 
            this.radioButtonDefine.AutoSize = true;
            this.radioButtonDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDefine.Location = new System.Drawing.Point(7, 46);
            this.radioButtonDefine.Name = "radioButtonDefine";
            this.radioButtonDefine.Size = new System.Drawing.Size(56, 20);
            this.radioButtonDefine.TabIndex = 1;
            this.radioButtonDefine.TabStop = true;
            this.radioButtonDefine.Text = "固定";
            this.radioButtonDefine.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(319, 20);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinish.TabIndex = 14;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(290, 22);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(23, 16);
            this.labelFinish.TabIndex = 13;
            this.labelFinish.Text = "至";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(84, 20);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 12;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(84, 46);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTime.TabIndex = 15;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(747, 365);
            this.dataGridViewList.TabIndex = 0;
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSN.Location = new System.Drawing.Point(63, 97);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(27, 16);
            this.labelSN.TabIndex = 1;
            this.labelSN.Text = "SN";
            // 
            // textBoxSN
            // 
            this.textBoxSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSN.Location = new System.Drawing.Point(96, 94);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(200, 22);
            this.textBoxSN.TabIndex = 2;
            // 
            // buttonQuery
            // 
            this.buttonQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuery.Location = new System.Drawing.Point(465, 93);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 25);
            this.buttonQuery.TabIndex = 3;
            this.buttonQuery.Text = "查询(&C)";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // checkBoxReportType
            // 
            this.checkBoxReportType.AutoSize = true;
            this.checkBoxReportType.Location = new System.Drawing.Point(305, 97);
            this.checkBoxReportType.Name = "checkBoxReportType";
            this.checkBoxReportType.Size = new System.Drawing.Size(62, 17);
            this.checkBoxReportType.TabIndex = 4;
            this.checkBoxReportType.Text = "汇总表";
            this.checkBoxReportType.UseVisualStyleBackColor = true;
            // 
            // SummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 500);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SummaryReportForm";
            this.Text = "交付分析报表";
            this.Load += new System.EventHandler(this.SummaryReportForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxTimeCondition.ResumeLayout(false);
            this.groupBoxTimeCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupBoxTimeCondition;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.RadioButton radioButtonDefine;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.CheckBox checkBoxReportType;
    }
}
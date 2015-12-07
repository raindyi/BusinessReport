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
            this.labelSummaryTitle = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.groupBoxTimeCondition = new System.Windows.Forms.GroupBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.checkBoxReportType = new System.Windows.Forms.CheckBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelSN = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.radioButtonDefine = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
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
            this.splitContainerMain.Panel1.Controls.Add(this.labelSummaryTitle);
            this.splitContainerMain.Panel1.Controls.Add(this.labelSummary);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxTimeCondition);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewList);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerMain.Size = new System.Drawing.Size(850, 500);
            this.splitContainerMain.SplitterDistance = 125;
            this.splitContainerMain.TabIndex = 0;
            // 
            // labelSummaryTitle
            // 
            this.labelSummaryTitle.AutoSize = true;
            this.labelSummaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummaryTitle.Location = new System.Drawing.Point(12, 94);
            this.labelSummaryTitle.Name = "labelSummaryTitle";
            this.labelSummaryTitle.Size = new System.Drawing.Size(38, 16);
            this.labelSummaryTitle.TabIndex = 16;
            this.labelSummaryTitle.Text = "汇总";
            // 
            // labelSummary
            // 
            this.labelSummary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(56, 90);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(686, 23);
            this.labelSummary.TabIndex = 1;
            this.labelSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxTimeCondition
            // 
            this.groupBoxTimeCondition.Controls.Add(this.buttonQuery);
            this.groupBoxTimeCondition.Controls.Add(this.checkBoxReportType);
            this.groupBoxTimeCondition.Controls.Add(this.comboBoxTime);
            this.groupBoxTimeCondition.Controls.Add(this.dateTimePickerFinish);
            this.groupBoxTimeCondition.Controls.Add(this.textBoxSN);
            this.groupBoxTimeCondition.Controls.Add(this.labelFinish);
            this.groupBoxTimeCondition.Controls.Add(this.labelSN);
            this.groupBoxTimeCondition.Controls.Add(this.dateTimePickerStart);
            this.groupBoxTimeCondition.Controls.Add(this.radioButtonDefine);
            this.groupBoxTimeCondition.Controls.Add(this.radioButtonCustomer);
            this.groupBoxTimeCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTimeCondition.Name = "groupBoxTimeCondition";
            this.groupBoxTimeCondition.Size = new System.Drawing.Size(730, 75);
            this.groupBoxTimeCondition.TabIndex = 0;
            this.groupBoxTimeCondition.TabStop = false;
            this.groupBoxTimeCondition.Text = "设置";
            // 
            // buttonQuery
            // 
            this.buttonQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuery.Location = new System.Drawing.Point(641, 42);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 25);
            this.buttonQuery.TabIndex = 7;
            this.buttonQuery.Text = "查询(&C)";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // checkBoxReportType
            // 
            this.checkBoxReportType.AutoSize = true;
            this.checkBoxReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReportType.Location = new System.Drawing.Point(545, 45);
            this.checkBoxReportType.Name = "checkBoxReportType";
            this.checkBoxReportType.Size = new System.Drawing.Size(90, 20);
            this.checkBoxReportType.TabIndex = 6;
            this.checkBoxReportType.Text = "汇总表(&H)";
            this.checkBoxReportType.UseVisualStyleBackColor = true;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(100, 46);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTime.TabIndex = 4;
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(339, 20);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinish.TabIndex = 2;
            // 
            // textBoxSN
            // 
            this.textBoxSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSN.Location = new System.Drawing.Point(339, 45);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(200, 22);
            this.textBoxSN.TabIndex = 5;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(310, 22);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(23, 16);
            this.labelFinish.TabIndex = 13;
            this.labelFinish.Text = "至";
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSN.Location = new System.Drawing.Point(306, 48);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(27, 16);
            this.labelSN.TabIndex = 1;
            this.labelSN.Text = "SN";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(100, 20);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // radioButtonDefine
            // 
            this.radioButtonDefine.AutoSize = true;
            this.radioButtonDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDefine.Location = new System.Drawing.Point(7, 46);
            this.radioButtonDefine.Name = "radioButtonDefine";
            this.radioButtonDefine.Size = new System.Drawing.Size(74, 20);
            this.radioButtonDefine.TabIndex = 3;
            this.radioButtonDefine.TabStop = true;
            this.radioButtonDefine.Text = "固定(&G)";
            this.radioButtonDefine.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustomer.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(87, 20);
            this.radioButtonCustomer.TabIndex = 0;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "自定义(&Z)";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(844, 365);
            this.dataGridViewList.TabIndex = 0;
            // 
            // SummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
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
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelSummaryTitle;
    }
}
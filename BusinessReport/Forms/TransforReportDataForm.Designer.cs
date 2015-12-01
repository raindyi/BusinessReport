namespace PV.BusinessReport.UI.Forms
{
    partial class TransforReportDataForm
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
            this.groupBoxConditions = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.labelFinish = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelStore = new System.Windows.Forms.Label();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.labelSN = new System.Windows.Forms.Label();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxSNName = new System.Windows.Forms.TextBox();
            this.labelSnNickName = new System.Windows.Forms.Label();
            this.groupBoxConditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConditions
            // 
            this.groupBoxConditions.Controls.Add(this.textBoxSNName);
            this.groupBoxConditions.Controls.Add(this.labelSnNickName);
            this.groupBoxConditions.Controls.Add(this.comboBoxSource);
            this.groupBoxConditions.Controls.Add(this.labelSource);
            this.groupBoxConditions.Controls.Add(this.textBoxSN);
            this.groupBoxConditions.Controls.Add(this.labelSN);
            this.groupBoxConditions.Controls.Add(this.comboBoxStore);
            this.groupBoxConditions.Controls.Add(this.labelStore);
            this.groupBoxConditions.Controls.Add(this.dateTimePickerFinish);
            this.groupBoxConditions.Controls.Add(this.labelFinish);
            this.groupBoxConditions.Controls.Add(this.dateTimePickerStart);
            this.groupBoxConditions.Controls.Add(this.labelStartTime);
            this.groupBoxConditions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConditions.Name = "groupBoxConditions";
            this.groupBoxConditions.Size = new System.Drawing.Size(532, 107);
            this.groupBoxConditions.TabIndex = 0;
            this.groupBoxConditions.TabStop = false;
            this.groupBoxConditions.Text = "条件";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(319, 19);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinish.TabIndex = 14;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePickerFinish_ValueChanged);
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(290, 23);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(23, 16);
            this.labelFinish.TabIndex = 13;
            this.labelFinish.Text = "至";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(50, 19);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 12;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(6, 23);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(38, 16);
            this.labelStartTime.TabIndex = 11;
            this.labelStartTime.Text = "开始";
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.Location = new System.Drawing.Point(6, 46);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(38, 16);
            this.labelStore.TabIndex = 15;
            this.labelStore.Text = "门店";
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(50, 45);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStore.TabIndex = 16;
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSN.Location = new System.Drawing.Point(286, 46);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(27, 16);
            this.labelSN.TabIndex = 17;
            this.labelSN.Text = "SN";
            // 
            // textBoxSN
            // 
            this.textBoxSN.Location = new System.Drawing.Point(319, 45);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(200, 20);
            this.textBoxSN.TabIndex = 18;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(6, 73);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(38, 16);
            this.labelSource.TabIndex = 19;
            this.labelSource.Text = "来源";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(50, 72);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSource.TabIndex = 20;
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(469, 125);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 25);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "清理(&Q)";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(12, 156);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(532, 150);
            this.richTextBoxMessage.TabIndex = 2;
            this.richTextBoxMessage.Text = "";
            // 
            // textBoxSNName
            // 
            this.textBoxSNName.Location = new System.Drawing.Point(319, 72);
            this.textBoxSNName.Name = "textBoxSNName";
            this.textBoxSNName.Size = new System.Drawing.Size(200, 20);
            this.textBoxSNName.TabIndex = 22;
            // 
            // labelSnNickName
            // 
            this.labelSnNickName.AutoSize = true;
            this.labelSnNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSnNickName.Location = new System.Drawing.Point(256, 73);
            this.labelSnNickName.Name = "labelSnNickName";
            this.labelSnNickName.Size = new System.Drawing.Size(57, 16);
            this.labelSnNickName.TabIndex = 21;
            this.labelSnNickName.Text = "SN别名";
            // 
            // TransforReportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 318);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxConditions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransforReportDataForm";
            this.Text = "数据清理";
            this.Load += new System.EventHandler(this.TransforReportDataForm_Load);
            this.groupBoxConditions.ResumeLayout(false);
            this.groupBoxConditions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditions;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.TextBox textBoxSNName;
        private System.Windows.Forms.Label labelSnNickName;
    }
}
namespace PV.BusinessReport.UI.Forms
{
    partial class TransFlowImportForm
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
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(12, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(560, 23);
            this.labelFileName.TabIndex = 0;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.Location = new System.Drawing.Point(12, 35);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(95, 30);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "选择文件(&X)";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Location = new System.Drawing.Point(113, 35);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(95, 30);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "导入(&D)";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.Teal;
            this.richTextBoxMessage.Location = new System.Drawing.Point(13, 72);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(559, 132);
            this.richTextBoxMessage.TabIndex = 3;
            this.richTextBoxMessage.Text = "";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialog1";
            // 
            // TransFlowImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 216);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.labelFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransFlowImportForm";
            this.Text = "商户交易流水信息导入";
            this.Load += new System.EventHandler(this.TransFlowImportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
    }
}
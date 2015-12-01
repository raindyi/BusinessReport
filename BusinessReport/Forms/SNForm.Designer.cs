namespace PV.BusinessReport.UI.Forms
{
    partial class SNForm
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
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(434, 216);
            this.dataGridViewList.TabIndex = 0;
            // 
            // SNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 216);
            this.Controls.Add(this.dataGridViewList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SNForm";
            this.Text = "SN信息";
            this.Load += new System.EventHandler(this.SNForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewList;
    }
}
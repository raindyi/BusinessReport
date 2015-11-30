namespace PV.BusinessReport.UI.Forms
{
    partial class StoreForm
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
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.buttonAddSN = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.splitContainerMain.Panel1.Controls.Add(this.textBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.textBox2);
            this.splitContainerMain.Panel1.Controls.Add(this.label2);
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
            this.splitContainerMain.Size = new System.Drawing.Size(712, 471);
            this.splitContainerMain.SplitterDistance = 100;
            this.splitContainerMain.TabIndex = 0;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(706, 361);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewList_MouseDoubleClick);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStore.Location = new System.Drawing.Point(499, 38);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(110, 25);
            this.buttonAddStore.TabIndex = 0;
            this.buttonAddStore.Text = "新增门店(&M)";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // buttonAddSN
            // 
            this.buttonAddSN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAddSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSN.Location = new System.Drawing.Point(499, 69);
            this.buttonAddSN.Name = "buttonAddSN";
            this.buttonAddSN.Size = new System.Drawing.Size(110, 25);
            this.buttonAddSN.TabIndex = 1;
            this.buttonAddSN.Text = "新增SN(&N)";
            this.buttonAddSN.UseVisualStyleBackColor = true;
            this.buttonAddSN.Click += new System.EventHandler(this.buttonAddSN_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(244, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(110, 25);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "刷新(&R)";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "名称";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(50, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(256, 44);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(31, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "电话";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(293, 41);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhone.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "电话";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "名称";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 471);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreForm";
            this.Text = "StoreForm";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
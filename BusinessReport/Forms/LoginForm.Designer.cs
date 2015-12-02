namespace PV.BusinessReport.UI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(122, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "用户名:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPassWord
            // 
            this.labelPassWord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassWord.Location = new System.Drawing.Point(122, 83);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(75, 23);
            this.labelPassWord.TabIndex = 1;
            this.labelPassWord.Text = "密码:";
            this.labelPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(203, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassWord.Location = new System.Drawing.Point(203, 82);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(155, 25);
            this.textBoxPassWord.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(283, 135);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 35);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(196, 83);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 16);
            this.labelMessage.TabIndex = 7;
            // 
            // buttonLogin
            // 
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.Location = new System.Drawing.Point(202, 135);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 35);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(346, 23);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "交易流水管理系统V1.0";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.ControlBox = false;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelTitle;
    }
}
namespace PV.BusinessReport.UI.Forms
{
    partial class PwChangeForm
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
            this.labelPw1 = new System.Windows.Forms.Label();
            this.labelPw2 = new System.Windows.Forms.Label();
            this.textBoxPw2 = new System.Windows.Forms.TextBox();
            this.textBoxPw1 = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPw1
            // 
            this.labelPw1.AutoSize = true;
            this.labelPw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPw1.Location = new System.Drawing.Point(12, 13);
            this.labelPw1.Name = "labelPw1";
            this.labelPw1.Size = new System.Drawing.Size(38, 16);
            this.labelPw1.TabIndex = 0;
            this.labelPw1.Text = "密码";
            // 
            // labelPw2
            // 
            this.labelPw2.AutoSize = true;
            this.labelPw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPw2.Location = new System.Drawing.Point(12, 39);
            this.labelPw2.Name = "labelPw2";
            this.labelPw2.Size = new System.Drawing.Size(68, 16);
            this.labelPw2.TabIndex = 0;
            this.labelPw2.Text = "确认密码";
            // 
            // textBoxPw2
            // 
            this.textBoxPw2.Location = new System.Drawing.Point(86, 38);
            this.textBoxPw2.Name = "textBoxPw2";
            this.textBoxPw2.PasswordChar = '*';
            this.textBoxPw2.Size = new System.Drawing.Size(186, 20);
            this.textBoxPw2.TabIndex = 2;
            // 
            // textBoxPw1
            // 
            this.textBoxPw1.Location = new System.Drawing.Point(86, 12);
            this.textBoxPw1.Name = "textBoxPw1";
            this.textBoxPw1.PasswordChar = '*';
            this.textBoxPw1.Size = new System.Drawing.Size(186, 20);
            this.textBoxPw1.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(116, 80);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 25);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "确认(&Q)";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(197, 80);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "取消(&C)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(86, 61);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(186, 16);
            this.labelMessage.TabIndex = 6;
            // 
            // PwChangeForm
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxPw1);
            this.Controls.Add(this.textBoxPw2);
            this.Controls.Add(this.labelPw2);
            this.Controls.Add(this.labelPw1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PwChangeForm";
            this.Text = "PwChangeForm";
            this.Load += new System.EventHandler(this.PwChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPw1;
        private System.Windows.Forms.Label labelPw2;
        private System.Windows.Forms.TextBox textBoxPw2;
        private System.Windows.Forms.TextBox textBoxPw1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMessage;
    }
}
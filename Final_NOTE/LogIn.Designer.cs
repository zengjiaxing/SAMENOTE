namespace NOTE
{
    partial class LogIn
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
            this.UserNameLb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.UserNameTbx = new System.Windows.Forms.TextBox();
            this.PasswordTbx = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.ForgetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Location = new System.Drawing.Point(143, 76);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(71, 15);
            this.UserNameLb.TabIndex = 0;
            this.UserNameLb.Text = "UserName";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(143, 122);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(71, 15);
            this.PasswordLb.TabIndex = 1;
            this.PasswordLb.Text = "password";
            // 
            // UserNameTbx
            // 
            this.UserNameTbx.Location = new System.Drawing.Point(231, 73);
            this.UserNameTbx.Name = "UserNameTbx";
            this.UserNameTbx.Size = new System.Drawing.Size(284, 25);
            this.UserNameTbx.TabIndex = 2;
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(231, 119);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.Size = new System.Drawing.Size(284, 25);
            this.PasswordTbx.TabIndex = 3;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(444, 179);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(71, 28);
            this.ConfirmBtn.TabIndex = 4;
            this.ConfirmBtn.Text = "登入";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // ForgetBtn
            // 
            this.ForgetBtn.Location = new System.Drawing.Point(344, 179);
            this.ForgetBtn.Name = "ForgetBtn";
            this.ForgetBtn.Size = new System.Drawing.Size(77, 28);
            this.ForgetBtn.TabIndex = 5;
            this.ForgetBtn.Text = "忘记密码";
            this.ForgetBtn.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 292);
            this.Controls.Add(this.ForgetBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.UserNameLb);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLb;
        private System.Windows.Forms.Label PasswordLb;
        private System.Windows.Forms.TextBox UserNameTbx;
        private System.Windows.Forms.TextBox PasswordTbx;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button ForgetBtn;
    }
}
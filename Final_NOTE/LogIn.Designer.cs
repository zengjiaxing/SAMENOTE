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
            this.button1 = new System.Windows.Forms.Button();
            this.TELBox = new System.Windows.Forms.TextBox();
            this.TelLabel = new System.Windows.Forms.Label();
            this.Tishi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Location = new System.Drawing.Point(103, 32);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(71, 15);
            this.UserNameLb.TabIndex = 0;
            this.UserNameLb.Text = "UserName";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(103, 76);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(71, 15);
            this.PasswordLb.TabIndex = 1;
            this.PasswordLb.Text = "password";
            // 
            // UserNameTbx
            // 
            this.UserNameTbx.Location = new System.Drawing.Point(191, 29);
            this.UserNameTbx.Name = "UserNameTbx";
            this.UserNameTbx.Size = new System.Drawing.Size(284, 25);
            this.UserNameTbx.TabIndex = 2;
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(191, 73);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.Size = new System.Drawing.Size(284, 25);
            this.PasswordTbx.TabIndex = 3;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(301, 176);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(71, 28);
            this.ConfirmBtn.TabIndex = 4;
            this.ConfirmBtn.Text = "登入";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // ForgetBtn
            // 
            this.ForgetBtn.Location = new System.Drawing.Point(436, 176);
            this.ForgetBtn.Name = "ForgetBtn";
            this.ForgetBtn.Size = new System.Drawing.Size(113, 28);
            this.ForgetBtn.TabIndex = 5;
            this.ForgetBtn.Text = "忘记密码";
            this.ForgetBtn.UseVisualStyleBackColor = true;
            this.ForgetBtn.Click += new System.EventHandler(this.ForgetBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TELBox
            // 
            this.TELBox.Location = new System.Drawing.Point(191, 117);
            this.TELBox.Name = "TELBox";
            this.TELBox.Size = new System.Drawing.Size(284, 25);
            this.TELBox.TabIndex = 7;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(103, 120);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(31, 15);
            this.TelLabel.TabIndex = 8;
            this.TelLabel.Text = "TEL";
            // 
            // Tishi
            // 
            this.Tishi.AutoSize = true;
            this.Tishi.ForeColor = System.Drawing.Color.Red;
            this.Tishi.Location = new System.Drawing.Point(71, 228);
            this.Tishi.Name = "Tishi";
            this.Tishi.Size = new System.Drawing.Size(382, 15);
            this.Tishi.TabIndex = 9;
            this.Tishi.Text = "如果忘记密码，请输入用户名和电话号码再点击忘记密码";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 292);
            this.Controls.Add(this.Tishi);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.TELBox);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TELBox;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label Tishi;
    }
}
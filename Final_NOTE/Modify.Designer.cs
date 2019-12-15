namespace NOTE
{
    partial class Modify
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
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.PasswordTbx = new System.Windows.Forms.TextBox();
            this.UserNameTbx = new System.Windows.Forms.TextBox();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.UserNameLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(401, 181);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(71, 28);
            this.ConfirmBtn.TabIndex = 10;
            this.ConfirmBtn.Text = "确认";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(188, 121);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.Size = new System.Drawing.Size(284, 25);
            this.PasswordTbx.TabIndex = 9;
            // 
            // UserNameTbx
            // 
            this.UserNameTbx.Location = new System.Drawing.Point(188, 75);
            this.UserNameTbx.Name = "UserNameTbx";
            this.UserNameTbx.Size = new System.Drawing.Size(284, 25);
            this.UserNameTbx.TabIndex = 8;
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(100, 124);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(71, 15);
            this.PasswordLb.TabIndex = 7;
            this.PasswordLb.Text = "password";
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Location = new System.Drawing.Point(100, 78);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(71, 15);
            this.UserNameLb.TabIndex = 6;
            this.UserNameLb.Text = "UserName";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 311);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.UserNameLb);
            this.Name = "Modify";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TextBox PasswordTbx;
        private System.Windows.Forms.TextBox UserNameTbx;
        private System.Windows.Forms.Label PasswordLb;
        private System.Windows.Forms.Label UserNameLb;
    }
}
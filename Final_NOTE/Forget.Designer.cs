namespace NOTE
{
    partial class Forget
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
            this.IdLb = new System.Windows.Forms.Label();
            this.UserNameLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(392, 175);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(71, 28);
            this.ConfirmBtn.TabIndex = 15;
            this.ConfirmBtn.Text = "确认";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(179, 115);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.Size = new System.Drawing.Size(284, 25);
            this.PasswordTbx.TabIndex = 14;
            // 
            // UserNameTbx
            // 
            this.UserNameTbx.Location = new System.Drawing.Point(179, 69);
            this.UserNameTbx.Name = "UserNameTbx";
            this.UserNameTbx.Size = new System.Drawing.Size(284, 25);
            this.UserNameTbx.TabIndex = 13;
            // 
            // IdLb
            // 
            this.IdLb.AutoSize = true;
            this.IdLb.Location = new System.Drawing.Point(91, 118);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(79, 15);
            this.IdLb.TabIndex = 12;
            this.IdLb.Text = "IDnumbers";
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Location = new System.Drawing.Point(91, 72);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(71, 15);
            this.UserNameLb.TabIndex = 11;
            this.UserNameLb.Text = "UserName";
            // 
            // Forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 326);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.UserNameLb);
            this.Name = "Forget";
            this.Text = "Forget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TextBox PasswordTbx;
        private System.Windows.Forms.TextBox UserNameTbx;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.Label UserNameLb;
    }
}
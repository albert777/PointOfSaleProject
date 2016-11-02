namespace pointOfSales
{
    partial class logging_form
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
            this.user_name_label = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.user_name_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_label.Location = new System.Drawing.Point(12, 14);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(74, 19);
            this.user_name_label.TabIndex = 0;
            this.user_name_label.Text = "User name";
            this.user_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(12, 51);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 19);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // user_name_input
            // 
            this.user_name_input.Location = new System.Drawing.Point(101, 13);
            this.user_name_input.Name = "user_name_input";
            this.user_name_input.Size = new System.Drawing.Size(204, 20);
            this.user_name_input.TabIndex = 2;
            this.user_name_input.Text = "User Name";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(101, 50);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(204, 20);
            this.password_input.TabIndex = 3;
            this.password_input.Text = "Password";
            // 
            // logging_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 85);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.user_name_input);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.user_name_label);
            this.Name = "logging_form";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.logging_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox user_name_input;
        private System.Windows.Forms.TextBox password_input;
    }
}
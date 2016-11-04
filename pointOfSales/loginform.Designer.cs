namespace pointOfSales
{
    partial class loginform
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
            this.Logon_Button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Logon_Button
            // 
            this.Logon_Button.Location = new System.Drawing.Point(136, 102);
            this.Logon_Button.Name = "Logon_Button";
            this.Logon_Button.Size = new System.Drawing.Size(100, 23);
            this.Logon_Button.TabIndex = 0;
            this.Logon_Button.Text = "Logon";
            this.Logon_Button.UseVisualStyleBackColor = true;
            this.Logon_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(10, 64);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(10, 20);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(86, 64);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(150, 20);
            this.password_input.TabIndex = 3;
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(86, 17);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(150, 20);
            this.username_input.TabIndex = 4;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 132);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.Logon_Button);
            this.Name = "loginform";
            this.Text = "loginform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logon_Button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox username_input;
    }
}
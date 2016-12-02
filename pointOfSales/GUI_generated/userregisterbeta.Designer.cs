namespace pointOfSales
{
    partial class userregisterbeta
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
            this.Register_user = new System.Windows.Forms.Button();
            this.username_form = new System.Windows.Forms.TextBox();
            this.user_name_label = new System.Windows.Forms.Label();
            this.first_name_label = new System.Windows.Forms.Label();
            this.first_name_form = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.Label();
            this.last_name_form = new System.Windows.Forms.TextBox();
            this.admin_level_form = new System.Windows.Forms.ComboBox();
            this.admin_level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_user
            // 
            this.Register_user.Location = new System.Drawing.Point(135, 117);
            this.Register_user.Name = "Register_user";
            this.Register_user.Size = new System.Drawing.Size(75, 23);
            this.Register_user.TabIndex = 0;
            this.Register_user.Text = "Register";
            this.Register_user.UseVisualStyleBackColor = true;
            this.Register_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_form
            // 
            this.username_form.Location = new System.Drawing.Point(110, 12);
            this.username_form.Name = "username_form";
            this.username_form.Size = new System.Drawing.Size(100, 20);
            this.username_form.TabIndex = 1;
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Location = new System.Drawing.Point(12, 15);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(55, 13);
            this.user_name_label.TabIndex = 2;
            this.user_name_label.Text = "Username";
            this.user_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(12, 41);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(57, 13);
            this.first_name_label.TabIndex = 4;
            this.first_name_label.Text = "First Name";
            // 
            // first_name_form
            // 
            this.first_name_form.Location = new System.Drawing.Point(110, 38);
            this.first_name_form.Name = "first_name_form";
            this.first_name_form.Size = new System.Drawing.Size(100, 20);
            this.first_name_form.TabIndex = 3;
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(12, 71);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(58, 13);
            this.last_name.TabIndex = 6;
            this.last_name.Text = "Last Name";
            this.last_name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // last_name_form
            // 
            this.last_name_form.Location = new System.Drawing.Point(110, 64);
            this.last_name_form.Name = "last_name_form";
            this.last_name_form.Size = new System.Drawing.Size(100, 20);
            this.last_name_form.TabIndex = 5;
            this.last_name_form.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // admin_level_form
            // 
            this.admin_level_form.AllowDrop = true;
            this.admin_level_form.FormattingEnabled = true;
            this.admin_level_form.Items.AddRange(new object[] {
            "Dymmylist",
            "Dymmylist",
            "Dymmylist",
            "Dymmylist",
            "Dymmylist",
            "Dymmylist"});
            this.admin_level_form.Location = new System.Drawing.Point(110, 90);
            this.admin_level_form.Name = "admin_level_form";
            this.admin_level_form.Size = new System.Drawing.Size(100, 21);
            this.admin_level_form.TabIndex = 7;
            // 
            // admin_level
            // 
            this.admin_level.AutoSize = true;
            this.admin_level.Location = new System.Drawing.Point(12, 98);
            this.admin_level.Name = "admin_level";
            this.admin_level.Size = new System.Drawing.Size(64, 13);
            this.admin_level.TabIndex = 8;
            this.admin_level.Text = "Profile_level";
            // 
            // userregisterbeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 148);
            this.Controls.Add(this.admin_level);
            this.Controls.Add(this.admin_level_form);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.last_name_form);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.first_name_form);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.username_form);
            this.Controls.Add(this.Register_user);
            this.Name = "userregisterbeta";
            this.Text = "userregisterbeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register_user;
        private System.Windows.Forms.TextBox username_form;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.TextBox first_name_form;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.TextBox last_name_form;
        private System.Windows.Forms.ComboBox admin_level_form;
        private System.Windows.Forms.Label admin_level;
    }
}
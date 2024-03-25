namespace forms
{
    partial class mainScreen
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
            job_label = new Label();
            txtbox_job = new TextBox();
            send_button = new Button();
            txtbox_user = new TextBox();
            txtbox_password = new TextBox();
            user_label = new Label();
            title_label = new Label();
            checkbox_write_credentials_in_file = new CheckBox();
            password_label = new Label();
            SuspendLayout();
            // 
            // job_label
            // 
            job_label.AutoSize = true;
            job_label.Location = new Point(21, 217);
            job_label.Name = "job_label";
            job_label.Size = new Size(131, 15);
            job_label.TabIndex = 0;
            job_label.Text = "Cargo ou competência:";
            // 
            // txtbox_job
            // 
            txtbox_job.Location = new Point(21, 235);
            txtbox_job.Name = "txtbox_job";
            txtbox_job.Size = new Size(153, 23);
            txtbox_job.TabIndex = 1;
            // 
            // send_button
            // 
            send_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            send_button.Location = new Point(137, 382);
            send_button.Name = "send_button";
            send_button.Size = new Size(92, 36);
            send_button.TabIndex = 2;
            send_button.Text = "Enviar";
            send_button.UseVisualStyleBackColor = true;
            send_button.Click += sendButton_Click;
            // 
            // txtbox_user
            // 
            txtbox_user.Location = new Point(21, 68);
            txtbox_user.Name = "txtbox_user";
            txtbox_user.Size = new Size(153, 23);
            txtbox_user.TabIndex = 3;
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new Point(21, 123);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(153, 23);
            txtbox_password.TabIndex = 4;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(21, 50);
            user_label.Name = "user_label";
            user_label.Size = new Size(98, 15);
            user_label.TabIndex = 5;
            user_label.Text = "Email ou usuário:";
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.FlatStyle = FlatStyle.Flat;
            title_label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            title_label.ForeColor = SystemColors.ActiveCaptionText;
            title_label.Location = new Point(12, 9);
            title_label.Name = "title_label";
            title_label.Size = new Size(217, 25);
            title_label.TabIndex = 7;
            title_label.Text = "LINKEDIN AUTOMATION";
            title_label.Visible = false;
            // 
            // checkbox_write_credentials_in_file
            // 
            checkbox_write_credentials_in_file.AutoSize = true;
            checkbox_write_credentials_in_file.Location = new Point(21, 161);
            checkbox_write_credentials_in_file.Name = "checkbox_write_credentials_in_file";
            checkbox_write_credentials_in_file.Size = new Size(182, 19);
            checkbox_write_credentials_in_file.TabIndex = 8;
            checkbox_write_credentials_in_file.Text = "Adicionar ao arquivo de texto";
            checkbox_write_credentials_in_file.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(21, 105);
            password_label.Name = "password_label";
            password_label.Size = new Size(42, 15);
            password_label.TabIndex = 9;
            password_label.Text = "Senha:";
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(356, 444);
            Controls.Add(password_label);
            Controls.Add(checkbox_write_credentials_in_file);
            Controls.Add(title_label);
            Controls.Add(user_label);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_user);
            Controls.Add(send_button);
            Controls.Add(txtbox_job);
            Controls.Add(job_label);
            Name = "mainScreen";
            Text = "mainScreen";
            Load += mainScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label job_label;
        private TextBox txtbox_job;
        private Button send;
        private Button send_button;
        private TextBox txtbox_user;
        private TextBox txtbox_password;
        private Label user_label;
        private Label password_Label;
        private Label title_label;
        private CheckBox checkbox_write_credentials_in_file;
        private Label password_label;
    }
}
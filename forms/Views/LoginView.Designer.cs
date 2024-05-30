namespace forms.Forms
{
    partial class LoginView
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
            groupBox_login = new GroupBox();
            loginButton = new Button();
            txtbox_user = new TextBox();
            txtbox_password = new TextBox();
            user_label = new Label();
            checkbox_write_credentials_in_file = new CheckBox();
            password_label = new Label();
            label1 = new Label();
            groupBox_login.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_login
            // 
            groupBox_login.Controls.Add(loginButton);
            groupBox_login.Controls.Add(txtbox_user);
            groupBox_login.Controls.Add(txtbox_password);
            groupBox_login.Controls.Add(user_label);
            groupBox_login.Controls.Add(checkbox_write_credentials_in_file);
            groupBox_login.Controls.Add(password_label);
            groupBox_login.Location = new Point(27, 61);
            groupBox_login.Name = "groupBox_login";
            groupBox_login.Size = new Size(263, 342);
            groupBox_login.TabIndex = 34;
            groupBox_login.TabStop = false;
            groupBox_login.Text = "Login Linkedin";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(75, 204);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(85, 29);
            loginButton.TabIndex = 10;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // txtbox_user
            // 
            txtbox_user.Location = new Point(17, 61);
            txtbox_user.Name = "txtbox_user";
            txtbox_user.Size = new Size(200, 23);
            txtbox_user.TabIndex = 3;
            // 
            // txtbox_password
            // 
            txtbox_password.Location = new Point(17, 115);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.PasswordChar = '*';
            txtbox_password.Size = new Size(200, 23);
            txtbox_password.TabIndex = 4;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(17, 43);
            user_label.Name = "user_label";
            user_label.Size = new Size(98, 15);
            user_label.TabIndex = 5;
            user_label.Text = "Email ou usuário:";
            // 
            // checkbox_write_credentials_in_file
            // 
            checkbox_write_credentials_in_file.AutoSize = true;
            checkbox_write_credentials_in_file.Location = new Point(17, 144);
            checkbox_write_credentials_in_file.Name = "checkbox_write_credentials_in_file";
            checkbox_write_credentials_in_file.Size = new Size(114, 19);
            checkbox_write_credentials_in_file.TabIndex = 8;
            checkbox_write_credentials_in_file.Text = "Lembrar de mim";
            checkbox_write_credentials_in_file.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(17, 97);
            password_label.Name = "password_label";
            password_label.Size = new Size(42, 15);
            password_label.TabIndex = 9;
            password_label.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 35;
            label1.Text = "Linkedin Automation";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 438);
            Controls.Add(label1);
            Controls.Add(groupBox_login);
            Name = "LoginScreen";
            Text = "LoginScreen";
            groupBox_login.ResumeLayout(false);
            groupBox_login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_login;
        private Button loginButton;
        private TextBox txtbox_user;
        private TextBox txtbox_password;
        private Label user_label;
        private CheckBox checkbox_write_credentials_in_file;
        private Label password_label;
        private Label label1;
    }
}
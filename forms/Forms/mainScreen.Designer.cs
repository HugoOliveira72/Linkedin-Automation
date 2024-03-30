﻿namespace forms
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
            label1 = new Label();
            amount_jobs = new TextBox();
            amout_jobs_label = new Label();
            annoncement_date_label = new Label();
            location_label = new Label();
            job_type_label = new Label();
            comboBox_annoucement_date = new ComboBox();
            experience_level_label = new Label();
            this.checkedListBox_experience_level = new CheckedListBox();
            checkedListBox_type_job = new CheckedListBox();
            checkedListBox_remote = new CheckedListBox();
            groupBox_login = new GroupBox();
            groupBox_job = new GroupBox();
            groupBox_filters = new GroupBox();
            groupBox_login.SuspendLayout();
            groupBox_job.SuspendLayout();
            groupBox_filters.SuspendLayout();
            SuspendLayout();
            // 
            // job_label
            // 
            job_label.AutoSize = true;
            job_label.Location = new Point(24, 49);
            job_label.Name = "job_label";
            job_label.Size = new Size(131, 15);
            job_label.TabIndex = 0;
            job_label.Text = "Cargo ou competência:";
            // 
            // txtbox_job
            // 
            txtbox_job.Location = new Point(24, 67);
            txtbox_job.Name = "txtbox_job";
            txtbox_job.Size = new Size(200, 23);
            txtbox_job.TabIndex = 1;
            // 
            // send_button
            // 
            send_button.Font = new Font("Segoe UI", 12F);
            send_button.Location = new Point(297, 675);
            send_button.Name = "send_button";
            send_button.Size = new Size(102, 44);
            send_button.TabIndex = 2;
            send_button.Text = "Aplicar";
            send_button.UseVisualStyleBackColor = true;
            send_button.Click += sendButton_Click;
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
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.FlatStyle = FlatStyle.Flat;
            title_label.Font = new Font("Segoe UI", 14F);
            title_label.ForeColor = SystemColors.ActiveCaptionText;
            title_label.Location = new Point(240, 42);
            title_label.Name = "title_label";
            title_label.Size = new Size(217, 25);
            title_label.TabIndex = 7;
            title_label.Text = "LINKEDIN AUTOMATION";
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
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // amount_jobs
            // 
            amount_jobs.Location = new Point(24, 120);
            amount_jobs.Name = "amount_jobs";
            amount_jobs.Size = new Size(44, 23);
            amount_jobs.TabIndex = 10;
            // 
            // amout_jobs_label
            // 
            amout_jobs_label.AutoSize = true;
            amout_jobs_label.Location = new Point(24, 102);
            amout_jobs_label.Name = "amout_jobs_label";
            amout_jobs_label.Size = new Size(73, 15);
            amout_jobs_label.TabIndex = 11;
            amout_jobs_label.Text = "N° de vagas:";
            // 
            // annoncement_date_label
            // 
            annoncement_date_label.AutoSize = true;
            annoncement_date_label.Location = new Point(17, 28);
            annoncement_date_label.Name = "annoncement_date_label";
            annoncement_date_label.Size = new Size(94, 15);
            annoncement_date_label.TabIndex = 26;
            annoncement_date_label.Text = "Data do anúncio";
            // 
            // location_label
            // 
            location_label.AutoSize = true;
            location_label.Location = new Point(13, 418);
            location_label.Name = "location_label";
            location_label.Size = new Size(52, 15);
            location_label.TabIndex = 25;
            location_label.Text = "Remoto:";
            // 
            // job_type_label
            // 
            job_type_label.AutoSize = true;
            job_type_label.Location = new Point(15, 239);
            job_type_label.Name = "job_type_label";
            job_type_label.Size = new Size(77, 15);
            job_type_label.TabIndex = 24;
            job_type_label.Text = "Tipo de vaga:";
            // 
            // comboBox_annoucement_date
            // 
            comboBox_annoucement_date.FormattingEnabled = true;
            comboBox_annoucement_date.Items.AddRange(new object[] { "Mais recentes", "Mais relevantes" });
            comboBox_annoucement_date.Location = new Point(17, 46);
            comboBox_annoucement_date.Name = "comboBox_annoucement_date";
            comboBox_annoucement_date.Size = new Size(121, 23);
            comboBox_annoucement_date.TabIndex = 23;
            // 
            // experience_level_label
            // 
            experience_level_label.AutoSize = true;
            experience_level_label.Location = new Point(16, 97);
            experience_level_label.Name = "experience_level_label";
            experience_level_label.Size = new Size(113, 15);
            experience_level_label.TabIndex = 19;
            experience_level_label.Text = "Nível de experiência";
            // 
            // checkedListBox_experience_level
            // 
            this.checkedListBox_experience_level.FormattingEnabled = true;
            this.checkedListBox_experience_level.Items.AddRange(new object[] { "Estágio", "Júnior", "Assistente", "Pleno-sênior", "Diretor" });
            this.checkedListBox_experience_level.Location = new Point(16, 115);
            this.checkedListBox_experience_level.Name = "checkedListBox_experience_level";
            this.checkedListBox_experience_level.Size = new Size(155, 94);
            this.checkedListBox_experience_level.TabIndex = 27;
            // 
            // checkedListBox_type_job
            // 
            checkedListBox_type_job.FormattingEnabled = true;
            checkedListBox_type_job.Items.AddRange(new object[] { "Tempo integral", "Meio período", "Contrato", "Temporário", "Voluntário", "Estágio", "Outro" });
            checkedListBox_type_job.Location = new Point(16, 257);
            checkedListBox_type_job.Name = "checkedListBox_type_job";
            checkedListBox_type_job.Size = new Size(120, 130);
            checkedListBox_type_job.TabIndex = 28;
            // 
            // checkedListBox_remote
            // 
            checkedListBox_remote.FormattingEnabled = true;
            checkedListBox_remote.Items.AddRange(new object[] { "Remoto", "Híbrido", "Presencial" });
            checkedListBox_remote.Location = new Point(17, 436);
            checkedListBox_remote.Name = "checkedListBox_remote";
            checkedListBox_remote.Size = new Size(120, 58);
            checkedListBox_remote.TabIndex = 29;
            // 
            // groupBox_login
            // 
            groupBox_login.Controls.Add(txtbox_user);
            groupBox_login.Controls.Add(txtbox_password);
            groupBox_login.Controls.Add(user_label);
            groupBox_login.Controls.Add(checkbox_write_credentials_in_file);
            groupBox_login.Controls.Add(password_label);
            groupBox_login.Location = new Point(39, 95);
            groupBox_login.Name = "groupBox_login";
            groupBox_login.Size = new Size(263, 199);
            groupBox_login.TabIndex = 33;
            groupBox_login.TabStop = false;
            groupBox_login.Text = "Login";
            // 
            // groupBox_job
            // 
            groupBox_job.Controls.Add(txtbox_job);
            groupBox_job.Controls.Add(amout_jobs_label);
            groupBox_job.Controls.Add(amount_jobs);
            groupBox_job.Controls.Add(job_label);
            groupBox_job.Location = new Point(39, 329);
            groupBox_job.Name = "groupBox_job";
            groupBox_job.Size = new Size(280, 164);
            groupBox_job.TabIndex = 34;
            groupBox_job.TabStop = false;
            groupBox_job.Text = "Vaga";
            // 
            // groupBox_filters
            // 
            groupBox_filters.Controls.Add(comboBox_annoucement_date);
            groupBox_filters.Controls.Add(annoncement_date_label);
            groupBox_filters.Controls.Add(this.checkedListBox_experience_level);
            groupBox_filters.Controls.Add(location_label);
            groupBox_filters.Controls.Add(checkedListBox_remote);
            groupBox_filters.Controls.Add(checkedListBox_type_job);
            groupBox_filters.Controls.Add(experience_level_label);
            groupBox_filters.Controls.Add(job_type_label);
            groupBox_filters.Location = new Point(388, 95);
            groupBox_filters.Name = "groupBox_filters";
            groupBox_filters.Size = new Size(227, 527);
            groupBox_filters.TabIndex = 35;
            groupBox_filters.TabStop = false;
            groupBox_filters.Text = "Filtros";
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(681, 731);
            Controls.Add(groupBox_filters);
            Controls.Add(groupBox_job);
            Controls.Add(groupBox_login);
            Controls.Add(label1);
            Controls.Add(title_label);
            Controls.Add(send_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainScreen";
            Text = "mainScreen";
            Load += mainScreen_Load;
            groupBox_login.ResumeLayout(false);
            groupBox_login.PerformLayout();
            groupBox_job.ResumeLayout(false);
            groupBox_job.PerformLayout();
            groupBox_filters.ResumeLayout(false);
            groupBox_filters.PerformLayout();
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
        private Label label1;
        private TextBox amount_jobs;
        private Label amout_jobs_label;
        private Label annoncement_date_label;
        private Label location_label;
        private Label job_type_label;
        private ComboBox comboBox_annoucement_date;
        private ComboBox comboBox_experience_level;
        private Label experience_level_label;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox_type_job;
        private CheckedListBox checkedListBox_remote;
        private GroupBox groupBox_login;
        private GroupBox groupBox_job;
        private GroupBox groupBox_filters;
    }
}
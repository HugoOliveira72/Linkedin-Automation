namespace forms.Forms
{
    partial class AutomationView
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
            richtxtBox = new RichTextBox();
            info_label = new Label();
            job_applied = new Label();
            txtBox_job = new TextBox();
            number_applied_jobs = new Label();
            txtBox_applied_Jobs = new TextBox();
            label4 = new Label();
            txtBox_saved_jobs = new TextBox();
            title_label = new Label();
            button_exit = new Button();
            SuspendLayout();
            // 
            // richtxtBox
            // 
            richtxtBox.Location = new Point(46, 47);
            richtxtBox.Name = "richtxtBox";
            richtxtBox.ReadOnly = true;
            richtxtBox.Size = new Size(702, 444);
            richtxtBox.TabIndex = 0;
            richtxtBox.Text = "";
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Location = new Point(46, 29);
            info_label.Name = "info_label";
            info_label.Size = new Size(28, 15);
            info_label.TabIndex = 1;
            info_label.Text = "Info";
            // 
            // job_applied
            // 
            job_applied.AutoSize = true;
            job_applied.Location = new Point(865, 64);
            job_applied.Name = "job_applied";
            job_applied.Size = new Size(35, 15);
            job_applied.TabIndex = 3;
            job_applied.Text = "Vaga:";
            // 
            // txtBox_job
            // 
            txtBox_job.Location = new Point(865, 82);
            txtBox_job.Name = "txtBox_job";
            txtBox_job.ReadOnly = true;
            txtBox_job.Size = new Size(161, 23);
            txtBox_job.TabIndex = 4;
            // 
            // number_applied_jobs
            // 
            number_applied_jobs.AutoSize = true;
            number_applied_jobs.Location = new Point(865, 137);
            number_applied_jobs.Name = "number_applied_jobs";
            number_applied_jobs.Size = new Size(89, 15);
            number_applied_jobs.TabIndex = 5;
            number_applied_jobs.Text = "Vagas aplicadas";
            // 
            // txtBox_applied_Jobs
            // 
            txtBox_applied_Jobs.Location = new Point(865, 155);
            txtBox_applied_Jobs.Name = "txtBox_applied_Jobs";
            txtBox_applied_Jobs.ReadOnly = true;
            txtBox_applied_Jobs.Size = new Size(89, 23);
            txtBox_applied_Jobs.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(865, 205);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Vagas salvas";
            // 
            // txtBox_saved_jobs
            // 
            txtBox_saved_jobs.Location = new Point(865, 223);
            txtBox_saved_jobs.Name = "txtBox_saved_jobs";
            txtBox_saved_jobs.ReadOnly = true;
            txtBox_saved_jobs.Size = new Size(89, 23);
            txtBox_saved_jobs.TabIndex = 8;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Segoe UI", 14F);
            title_label.Location = new Point(440, 9);
            title_label.Name = "title_label";
            title_label.Size = new Size(217, 25);
            title_label.TabIndex = 9;
            title_label.Text = "LINKEDIN AUTOMATION";
            // 
            // button_exit
            // 
            button_exit.Enabled = false;
            button_exit.Font = new Font("Segoe UI", 14F);
            button_exit.Location = new Point(440, 516);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(92, 40);
            button_exit.TabIndex = 10;
            button_exit.Text = "Sair";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += stopApplication_button_Click;
            // 
            // AutomationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 583);
            Controls.Add(button_exit);
            Controls.Add(title_label);
            Controls.Add(txtBox_saved_jobs);
            Controls.Add(label4);
            Controls.Add(txtBox_applied_Jobs);
            Controls.Add(number_applied_jobs);
            Controls.Add(txtBox_job);
            Controls.Add(job_applied);
            Controls.Add(richtxtBox);
            Controls.Add(info_label);
            Name = "AutomationView";
            Text = "Linkedin automation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richtxtBox;
        private Label info_label;
        private Label job_applied;
        private TextBox txtBox_job;
        private Label number_applied_jobs;
        private TextBox txtBox_applied_Jobs;
        private Label label4;
        private TextBox txtBox_saved_jobs;
        private Label title_label;
        private Button button_exit;
    }
}
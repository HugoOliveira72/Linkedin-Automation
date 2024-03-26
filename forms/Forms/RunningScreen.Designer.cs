namespace forms.Forms
{
    partial class RunningScreen
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
            richtxtBox_info = new RichTextBox();
            info_label = new Label();
            pause_button = new Button();
            job_applied = new Label();
            textBox1 = new TextBox();
            number_applied_jobs = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            saved_jobs = new TextBox();
            title_label = new Label();
            stopApplication_button = new Button();
            SuspendLayout();
            // 
            // richtxtBox_info
            // 
            richtxtBox_info.Location = new Point(46, 47);
            richtxtBox_info.Name = "richtxtBox_info";
            richtxtBox_info.Size = new Size(702, 444);
            richtxtBox_info.TabIndex = 0;
            richtxtBox_info.Text = "";
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
            // pause_button
            // 
            pause_button.Font = new Font("Segoe UI", 14F);
            pause_button.Location = new Point(391, 514);
            pause_button.Name = "pause_button";
            pause_button.Size = new Size(97, 40);
            pause_button.TabIndex = 2;
            pause_button.Text = "Pausar";
            pause_button.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(865, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
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
            // textBox2
            // 
            textBox2.Location = new Point(865, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
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
            // saved_jobs
            // 
            saved_jobs.Location = new Point(865, 223);
            saved_jobs.Name = "saved_jobs";
            saved_jobs.Size = new Size(100, 23);
            saved_jobs.TabIndex = 8;
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
            // stopApplication_button
            // 
            stopApplication_button.Font = new Font("Segoe UI", 14F);
            stopApplication_button.Location = new Point(535, 514);
            stopApplication_button.Name = "stopApplication_button";
            stopApplication_button.Size = new Size(92, 40);
            stopApplication_button.TabIndex = 10;
            stopApplication_button.Text = "Sair";
            stopApplication_button.UseVisualStyleBackColor = true;
            // 
            // RunningScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 583);
            Controls.Add(stopApplication_button);
            Controls.Add(title_label);
            Controls.Add(saved_jobs);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(number_applied_jobs);
            Controls.Add(textBox1);
            Controls.Add(job_applied);
            Controls.Add(pause_button);
            Controls.Add(richtxtBox_info);
            Controls.Add(info_label);
            Name = "RunningScreen";
            Text = "RunningScreen";
            Load += RunningScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richtxtBox_info;
        private Label info_label;
        private Button pause_button;
        private Label job_applied;
        private TextBox textBox1;
        private Label number_applied_jobs;
        private TextBox textBox2;
        private Label label4;
        private TextBox saved_jobs;
        private Label title_label;
        private Button stopApplication_button;
    }
}
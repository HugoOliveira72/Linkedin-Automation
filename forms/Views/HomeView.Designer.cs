namespace forms
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            label1 = new Label();
            panelContainer = new Panel();
            kryptonButtonHome = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            kryptonButtonSettings = new Krypton.Toolkit.KryptonButton();
            kryptonButtonFilter = new Krypton.Toolkit.KryptonButton();
            label4 = new Label();
            number_applied_jobs = new Label();
            job_applied = new Label();
            info_label = new Label();
            txtBox_applied_Jobs = new Krypton.Toolkit.KryptonTextBox();
            txtBox_saved_jobs = new Krypton.Toolkit.KryptonTextBox();
            richtxtBox = new Krypton.Toolkit.KryptonRichTextBox();
            groupBox_job = new GroupBox();
            amout_jobs_label = new Label();
            job_label = new Label();
            txtBox_job = new Krypton.Toolkit.KryptonTextBox();
            amount_jobs = new Krypton.Toolkit.KryptonTextBox();
            txtBoxCurrentJob = new Krypton.Toolkit.KryptonTextBox();
            playButton = new Krypton.Toolkit.KryptonButton();
            stopButton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox_job.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(379, 87);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(894, 150);
            panelContainer.TabIndex = 36;
            // 
            // kryptonButtonHome
            // 
            kryptonButtonHome.Location = new Point(58, 42);
            kryptonButtonHome.Name = "kryptonButtonHome";
            kryptonButtonHome.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240, 240);
            kryptonButtonHome.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240, 240);
            kryptonButtonHome.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButtonHome.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonHome.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonHome.Size = new Size(73, 31);
            kryptonButtonHome.StateCommon.Back.Color1 = Color.IndianRed;
            kryptonButtonHome.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButtonHome.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonHome.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButtonHome.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButtonHome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButtonHome.StateCommon.Border.Rounding = 20F;
            kryptonButtonHome.StateCommon.Border.Width = 1;
            kryptonButtonHome.StateCommon.Content.ShortText.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonHome.StateNormal.Back.Color1 = Color.FromArgb(33, 150, 243);
            kryptonButtonHome.StateNormal.Back.Color2 = Color.FromArgb(33, 150, 243);
            kryptonButtonHome.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonHome.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButtonHome.StatePressed.Back.Color1 = Color.White;
            kryptonButtonHome.StatePressed.Back.Color2 = Color.White;
            kryptonButtonHome.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButtonHome.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonHome.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            kryptonButtonHome.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonHome.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonHome.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonHome.TabIndex = 52;
            kryptonButtonHome.Values.Text = "Home";
            kryptonButtonHome.Click += kryptonButtonHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 150, 243);
            panel2.Controls.Add(kryptonButtonSettings);
            panel2.Controls.Add(kryptonButtonFilter);
            panel2.Controls.Add(kryptonButtonHome);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1273, 73);
            panel2.TabIndex = 50;
            // 
            // kryptonButtonSettings
            // 
            kryptonButtonSettings.Location = new Point(198, 42);
            kryptonButtonSettings.Name = "kryptonButtonSettings";
            kryptonButtonSettings.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240, 240);
            kryptonButtonSettings.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240, 240);
            kryptonButtonSettings.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButtonSettings.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonSettings.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonSettings.Size = new Size(129, 31);
            kryptonButtonSettings.StateCommon.Back.Color1 = Color.IndianRed;
            kryptonButtonSettings.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButtonSettings.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonSettings.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButtonSettings.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButtonSettings.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButtonSettings.StateCommon.Border.Rounding = 20F;
            kryptonButtonSettings.StateCommon.Border.Width = 1;
            kryptonButtonSettings.StateCommon.Content.ShortText.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonSettings.StateNormal.Back.Color1 = Color.FromArgb(33, 150, 243);
            kryptonButtonSettings.StateNormal.Back.Color2 = Color.FromArgb(33, 150, 243);
            kryptonButtonSettings.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonSettings.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButtonSettings.StatePressed.Back.Color1 = Color.White;
            kryptonButtonSettings.StatePressed.Back.Color2 = Color.White;
            kryptonButtonSettings.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButtonSettings.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonSettings.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            kryptonButtonSettings.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonSettings.TabIndex = 52;
            kryptonButtonSettings.UseMnemonic = false;
            kryptonButtonSettings.Values.Text = "Configurações";
            kryptonButtonSettings.Click += kryptonButtonSettings_Click;
            // 
            // kryptonButtonFilter
            // 
            kryptonButtonFilter.Location = new Point(128, 42);
            kryptonButtonFilter.Name = "kryptonButtonFilter";
            kryptonButtonFilter.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240, 240);
            kryptonButtonFilter.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240, 240);
            kryptonButtonFilter.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButtonFilter.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonFilter.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButtonFilter.Size = new Size(73, 31);
            kryptonButtonFilter.StateCommon.Back.Color1 = Color.IndianRed;
            kryptonButtonFilter.StateCommon.Back.Color2 = Color.IndianRed;
            kryptonButtonFilter.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonFilter.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButtonFilter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButtonFilter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButtonFilter.StateCommon.Border.Rounding = 20F;
            kryptonButtonFilter.StateCommon.Border.Width = 1;
            kryptonButtonFilter.StateCommon.Content.ShortText.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButtonFilter.StateNormal.Back.Color1 = Color.FromArgb(33, 150, 243);
            kryptonButtonFilter.StateNormal.Back.Color2 = Color.FromArgb(33, 150, 243);
            kryptonButtonFilter.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonFilter.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButtonFilter.StatePressed.Back.Color1 = Color.White;
            kryptonButtonFilter.StatePressed.Back.Color2 = Color.White;
            kryptonButtonFilter.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButtonFilter.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonFilter.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            kryptonButtonFilter.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonFilter.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonFilter.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButtonFilter.TabIndex = 52;
            kryptonButtonFilter.Values.Text = "Filtro";
            kryptonButtonFilter.Click += kryptonButtonFilter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(985, 380);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 57;
            label4.Text = "Vagas salvas";
            // 
            // number_applied_jobs
            // 
            number_applied_jobs.AutoSize = true;
            number_applied_jobs.Location = new Point(985, 312);
            number_applied_jobs.Name = "number_applied_jobs";
            number_applied_jobs.Size = new Size(89, 15);
            number_applied_jobs.TabIndex = 55;
            number_applied_jobs.Text = "Vagas aplicadas";
            // 
            // job_applied
            // 
            job_applied.AutoSize = true;
            job_applied.Location = new Point(985, 251);
            job_applied.Name = "job_applied";
            job_applied.Size = new Size(39, 15);
            job_applied.TabIndex = 53;
            job_applied.Text = "Cargo";
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Location = new Point(12, 237);
            info_label.Name = "info_label";
            info_label.Size = new Size(50, 15);
            info_label.TabIndex = 52;
            info_label.Text = "Console";
            // 
            // txtBox_applied_Jobs
            // 
            txtBox_applied_Jobs.Location = new Point(985, 330);
            txtBox_applied_Jobs.Name = "txtBox_applied_Jobs";
            txtBox_applied_Jobs.ReadOnly = true;
            txtBox_applied_Jobs.Size = new Size(71, 27);
            txtBox_applied_Jobs.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBox_applied_Jobs.StateCommon.Border.Rounding = 5F;
            txtBox_applied_Jobs.TabIndex = 67;
            // 
            // txtBox_saved_jobs
            // 
            txtBox_saved_jobs.Location = new Point(985, 398);
            txtBox_saved_jobs.Name = "txtBox_saved_jobs";
            txtBox_saved_jobs.ReadOnly = true;
            txtBox_saved_jobs.Size = new Size(71, 27);
            txtBox_saved_jobs.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBox_saved_jobs.StateCommon.Border.Rounding = 5F;
            txtBox_saved_jobs.TabIndex = 68;
            // 
            // richtxtBox
            // 
            richtxtBox.HideSelection = false;
            richtxtBox.Location = new Point(12, 264);
            richtxtBox.Name = "richtxtBox";
            richtxtBox.ReadOnly = true;
            richtxtBox.Size = new Size(946, 491);
            richtxtBox.TabIndex = 70;
            richtxtBox.Text = "";
            // 
            // groupBox_job
            // 
            groupBox_job.Controls.Add(amout_jobs_label);
            groupBox_job.Controls.Add(job_label);
            groupBox_job.Controls.Add(txtBox_job);
            groupBox_job.Controls.Add(amount_jobs);
            groupBox_job.Location = new Point(128, 79);
            groupBox_job.Name = "groupBox_job";
            groupBox_job.Size = new Size(245, 158);
            groupBox_job.TabIndex = 71;
            groupBox_job.TabStop = false;
            groupBox_job.Text = "Vaga";
            // 
            // amout_jobs_label
            // 
            amout_jobs_label.AutoSize = true;
            amout_jobs_label.Location = new Point(24, 82);
            amout_jobs_label.Name = "amout_jobs_label";
            amout_jobs_label.Size = new Size(73, 15);
            amout_jobs_label.TabIndex = 11;
            amout_jobs_label.Text = "N° de vagas:";
            // 
            // job_label
            // 
            job_label.AutoSize = true;
            job_label.Location = new Point(24, 22);
            job_label.Name = "job_label";
            job_label.Size = new Size(131, 15);
            job_label.TabIndex = 0;
            job_label.Text = "Cargo ou competência:";
            // 
            // txtBox_job
            // 
            txtBox_job.Location = new Point(24, 40);
            txtBox_job.Name = "txtBox_job";
            txtBox_job.Size = new Size(200, 27);
            txtBox_job.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBox_job.StateCommon.Border.Rounding = 5F;
            txtBox_job.TabIndex = 12;
            txtBox_job.Validating += TxtBox_job_Validating;
            // 
            // amount_jobs
            // 
            amount_jobs.Location = new Point(24, 101);
            amount_jobs.Name = "amount_jobs";
            amount_jobs.Size = new Size(44, 27);
            amount_jobs.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            amount_jobs.StateCommon.Border.Rounding = 5F;
            amount_jobs.TabIndex = 38;
            amount_jobs.Validating += Amount_jobs_Validating;
            // 
            // txtBoxCurrentJob
            // 
            txtBoxCurrentJob.Location = new Point(985, 269);
            txtBoxCurrentJob.Name = "txtBoxCurrentJob";
            txtBoxCurrentJob.ReadOnly = true;
            txtBoxCurrentJob.Size = new Size(217, 27);
            txtBoxCurrentJob.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBoxCurrentJob.StateCommon.Border.Rounding = 5F;
            txtBoxCurrentJob.TabIndex = 39;
            // 
            // playButton
            // 
            playButton.Cursor = Cursors.Hand;
            playButton.Location = new Point(20, 101);
            playButton.Name = "playButton";
            playButton.Size = new Size(80, 31);
            playButton.StateCommon.Back.Color1 = Color.FromArgb(35, 181, 125);
            playButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            playButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            playButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            playButton.StateCommon.Border.Rounding = 15F;
            playButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            playButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            playButton.StateCommon.Content.ShortText.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playButton.StateTracking.Back.Color1 = Color.FromArgb(38, 198, 138);
            playButton.StateTracking.Back.Color2 = Color.FromArgb(47, 215, 152);
            playButton.StateTracking.Back.ColorAngle = 50F;
            playButton.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            playButton.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            playButton.StateTracking.Border.Color1 = Color.FromArgb(100, 181, 125);
            playButton.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            playButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            playButton.StateTracking.Content.ShortText.Color1 = Color.FromArgb(32, 32, 32);
            playButton.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            playButton.TabIndex = 74;
            playButton.Values.Text = "PLAY";
            playButton.Click += playButton_Click;
            // 
            // stopButton
            // 
            stopButton.Cursor = Cursors.Hand;
            stopButton.Location = new Point(20, 159);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(80, 31);
            stopButton.StateCommon.Back.Color1 = Color.FromArgb(208, 55, 52);
            stopButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            stopButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            stopButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            stopButton.StateCommon.Border.Rounding = 15F;
            stopButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            stopButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            stopButton.StateCommon.Content.ShortText.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopButton.StateTracking.Back.Color1 = Color.FromArgb(214, 79, 75);
            stopButton.StateTracking.Back.Color2 = Color.FromArgb(217, 91, 95);
            stopButton.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            stopButton.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            stopButton.StateTracking.Border.Color1 = Color.FromArgb(212, 100, 100);
            stopButton.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            stopButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            stopButton.StateTracking.Content.ShortText.Color1 = Color.FromArgb(32, 32, 32);
            stopButton.TabIndex = 75;
            stopButton.Values.Text = "STOP";
            stopButton.Click += stopButton_Click;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1274, 767);
            Controls.Add(stopButton);
            Controls.Add(playButton);
            Controls.Add(txtBoxCurrentJob);
            Controls.Add(groupBox_job);
            Controls.Add(richtxtBox);
            Controls.Add(txtBox_saved_jobs);
            Controls.Add(txtBox_applied_Jobs);
            Controls.Add(label4);
            Controls.Add(number_applied_jobs);
            Controls.Add(job_applied);
            Controls.Add(info_label);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeView";
            Text = "Linkedin automation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox_job.ResumeLayout(false);
            groupBox_job.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button send;
        private Label password_Label;
        private Label label1;
        private ComboBox comboBox_experience_level;
        private Panel panelContainer;
        private Krypton.Toolkit.KryptonButton kryptonButtonHome;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton kryptonButtonSettings;
        private Krypton.Toolkit.KryptonButton kryptonButtonFilter;
        private Button button_exit;
        private Label label4;
        private Label number_applied_jobs;
        private Label job_applied;
        private Label info_label;
        private Krypton.Toolkit.KryptonButton kryptonLoginButton;
        private Krypton.Toolkit.KryptonTextBox txtBox_applied_Jobs;
        private Krypton.Toolkit.KryptonTextBox txtBox_saved_jobs;
        private Krypton.Toolkit.KryptonRichTextBox richtxtBox;
        private GroupBox groupBox_job;
        private Label amout_jobs_label;
        private Label job_label;
        private Krypton.Toolkit.KryptonTextBox txtBox_job;
        private Krypton.Toolkit.KryptonTextBox amount_jobs;
        private Krypton.Toolkit.KryptonTextBox txtBoxCurrentJob;
        private Krypton.Toolkit.KryptonButton stopButton;
        private Krypton.Toolkit.KryptonButton playButton;
    }
}
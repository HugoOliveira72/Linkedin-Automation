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
            pictureBoxStop = new PictureBox();
            labelStopButton = new Label();
            stopButton = new Button();
            pictureBoxPlay = new PictureBox();
            labelPlayButton = new Label();
            startButton = new Button();
            txtBox_applied_Jobs = new Krypton.Toolkit.KryptonTextBox();
            txtBox_saved_jobs = new Krypton.Toolkit.KryptonTextBox();
            richtxtBox = new Krypton.Toolkit.KryptonRichTextBox();
            groupBox_job = new GroupBox();
            amout_jobs_label = new Label();
            job_label = new Label();
            txtBox_job = new Krypton.Toolkit.KryptonTextBox();
            amount_jobs = new Krypton.Toolkit.KryptonTextBox();
            txtBoxCurrentJob = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlay).BeginInit();
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
            panelContainer.Location = new Point(473, 79);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 150);
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
            label4.Location = new Point(1005, 375);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 57;
            label4.Text = "Vagas salvas";
            // 
            // number_applied_jobs
            // 
            number_applied_jobs.AutoSize = true;
            number_applied_jobs.Location = new Point(1005, 307);
            number_applied_jobs.Name = "number_applied_jobs";
            number_applied_jobs.Size = new Size(89, 15);
            number_applied_jobs.TabIndex = 55;
            number_applied_jobs.Text = "Vagas aplicadas";
            // 
            // job_applied
            // 
            job_applied.AutoSize = true;
            job_applied.Location = new Point(1005, 246);
            job_applied.Name = "job_applied";
            job_applied.Size = new Size(35, 15);
            job_applied.TabIndex = 53;
            job_applied.Text = "Vaga:";
            // 
            // info_label
            // 
            info_label.AutoSize = true;
            info_label.Location = new Point(12, 237);
            info_label.Name = "info_label";
            info_label.Size = new Size(28, 15);
            info_label.TabIndex = 52;
            info_label.Text = "Info";
            // 
            // pictureBoxStop
            // 
            pictureBoxStop.BackColor = Color.Transparent;
            pictureBoxStop.Cursor = Cursors.Hand;
            pictureBoxStop.Image = Properties.Resources.stopButtonImage;
            pictureBoxStop.Location = new Point(141, 112);
            pictureBoxStop.Name = "pictureBoxStop";
            pictureBoxStop.Size = new Size(40, 40);
            pictureBoxStop.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStop.TabIndex = 65;
            pictureBoxStop.TabStop = false;
            // 
            // labelStopButton
            // 
            labelStopButton.AutoSize = true;
            labelStopButton.Location = new Point(147, 160);
            labelStopButton.Name = "labelStopButton";
            labelStopButton.Size = new Size(31, 15);
            labelStopButton.TabIndex = 64;
            labelStopButton.Text = "Stop";
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.Transparent;
            stopButton.BackgroundImageLayout = ImageLayout.Stretch;
            stopButton.Enabled = false;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Font = new Font("Segoe UI", 12F);
            stopButton.Location = new Point(121, 100);
            stopButton.Margin = new Padding(20, 3, 3, 3);
            stopButton.Name = "stopButton";
            stopButton.Padding = new Padding(80);
            stopButton.RightToLeft = RightToLeft.No;
            stopButton.Size = new Size(80, 80);
            stopButton.TabIndex = 63;
            stopButton.TextAlign = ContentAlignment.TopCenter;
            stopButton.TextImageRelation = TextImageRelation.ImageAboveText;
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // pictureBoxPlay
            // 
            pictureBoxPlay.BackColor = Color.Transparent;
            pictureBoxPlay.Cursor = Cursors.Hand;
            pictureBoxPlay.Image = Properties.Resources.playButton;
            pictureBoxPlay.Location = new Point(35, 110);
            pictureBoxPlay.Name = "pictureBoxPlay";
            pictureBoxPlay.Size = new Size(50, 50);
            pictureBoxPlay.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlay.TabIndex = 62;
            pictureBoxPlay.TabStop = false;
            pictureBoxPlay.Click += startButton_Click;
            // 
            // labelPlayButton
            // 
            labelPlayButton.AutoSize = true;
            labelPlayButton.Location = new Point(45, 163);
            labelPlayButton.Name = "labelPlayButton";
            labelPlayButton.Size = new Size(29, 15);
            labelPlayButton.TabIndex = 61;
            labelPlayButton.Text = "Play";
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.BackgroundImageLayout = ImageLayout.Stretch;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI", 12F);
            startButton.Location = new Point(20, 100);
            startButton.Name = "startButton";
            startButton.Padding = new Padding(80);
            startButton.RightToLeft = RightToLeft.No;
            startButton.Size = new Size(80, 80);
            startButton.TabIndex = 60;
            startButton.TextAlign = ContentAlignment.TopCenter;
            startButton.TextImageRelation = TextImageRelation.ImageAboveText;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // txtBox_applied_Jobs
            // 
            txtBox_applied_Jobs.Enabled = false;
            txtBox_applied_Jobs.Location = new Point(1005, 325);
            txtBox_applied_Jobs.Name = "txtBox_applied_Jobs";
            txtBox_applied_Jobs.Size = new Size(89, 23);
            txtBox_applied_Jobs.TabIndex = 67;
            // 
            // txtBox_saved_jobs
            // 
            txtBox_saved_jobs.Enabled = false;
            txtBox_saved_jobs.Location = new Point(1005, 393);
            txtBox_saved_jobs.Name = "txtBox_saved_jobs";
            txtBox_saved_jobs.Size = new Size(89, 23);
            txtBox_saved_jobs.TabIndex = 68;
            // 
            // richtxtBox
            // 
            richtxtBox.Location = new Point(12, 264);
            richtxtBox.Name = "richtxtBox";
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
            groupBox_job.Location = new Point(222, 78);
            groupBox_job.Name = "groupBox_job";
            groupBox_job.Size = new Size(245, 151);
            groupBox_job.TabIndex = 71;
            groupBox_job.TabStop = false;
            groupBox_job.Text = "Vaga";
            // 
            // amout_jobs_label
            // 
            amout_jobs_label.AutoSize = true;
            amout_jobs_label.Location = new Point(24, 74);
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
            txtBox_job.Size = new Size(200, 23);
            txtBox_job.TabIndex = 12;
            txtBox_job.Validating += TxtBox_job_Validating;
            // 
            // amount_jobs
            // 
            amount_jobs.Location = new Point(24, 92);
            amount_jobs.Name = "amount_jobs";
            amount_jobs.Size = new Size(44, 23);
            amount_jobs.TabIndex = 38;
            amount_jobs.Validating += Amount_jobs_Validating;
            // 
            // txtBoxCurrentJob
            // 
            txtBoxCurrentJob.Location = new Point(1005, 264);
            txtBoxCurrentJob.Name = "txtBoxCurrentJob";
            txtBoxCurrentJob.Size = new Size(200, 23);
            txtBoxCurrentJob.TabIndex = 39;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1274, 767);
            Controls.Add(txtBoxCurrentJob);
            Controls.Add(groupBox_job);
            Controls.Add(richtxtBox);
            Controls.Add(txtBox_saved_jobs);
            Controls.Add(txtBox_applied_Jobs);
            Controls.Add(pictureBoxPlay);
            Controls.Add(labelPlayButton);
            Controls.Add(startButton);
            Controls.Add(label4);
            Controls.Add(number_applied_jobs);
            Controls.Add(job_applied);
            Controls.Add(info_label);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBoxStop);
            Controls.Add(labelStopButton);
            Controls.Add(stopButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeView";
            Text = "Linkedin automation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlay).EndInit();
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
        private PictureBox pictureBoxStop;
        private Label labelStopButton;
        private Button stopButton;
        private PictureBox pictureBoxPlay;
        private Label labelPlayButton;
        private Button startButton;
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
    }
}
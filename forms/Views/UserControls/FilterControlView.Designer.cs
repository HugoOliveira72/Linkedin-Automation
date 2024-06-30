namespace forms.Views
{
    partial class FilterControlView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_filters = new GroupBox();
            checkedListBox_remote = new Krypton.Toolkit.KryptonCheckedListBox();
            label_annoucement_date = new Label();
            checkedListBox_type_job = new Krypton.Toolkit.KryptonCheckedListBox();
            label_choose_by = new Label();
            comboBox_annoucement_date = new Krypton.Toolkit.KryptonComboBox();
            checkedListBox_experience_level = new Krypton.Toolkit.KryptonCheckedListBox();
            location_label = new Label();
            experience_level_label = new Label();
            comboBox_choose_by = new Krypton.Toolkit.KryptonComboBox();
            job_type_label = new Label();
            groupBox_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBox_annoucement_date).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBox_choose_by).BeginInit();
            SuspendLayout();
            // 
            // groupBox_filters
            // 
            groupBox_filters.Controls.Add(checkedListBox_remote);
            groupBox_filters.Controls.Add(label_annoucement_date);
            groupBox_filters.Controls.Add(checkedListBox_type_job);
            groupBox_filters.Controls.Add(label_choose_by);
            groupBox_filters.Controls.Add(comboBox_annoucement_date);
            groupBox_filters.Controls.Add(checkedListBox_experience_level);
            groupBox_filters.Controls.Add(location_label);
            groupBox_filters.Controls.Add(experience_level_label);
            groupBox_filters.Controls.Add(comboBox_choose_by);
            groupBox_filters.Controls.Add(job_type_label);
            groupBox_filters.Location = new Point(3, 3);
            groupBox_filters.Name = "groupBox_filters";
            groupBox_filters.Size = new Size(761, 151);
            groupBox_filters.TabIndex = 37;
            groupBox_filters.TabStop = false;
            groupBox_filters.Text = "Filtros";
            // 
            // checkedListBox_remote
            // 
            checkedListBox_remote.Items.AddRange(new object[] { "Remoto", "Híbrido", "Presencial" });
            checkedListBox_remote.Location = new Point(538, 40);
            checkedListBox_remote.Name = "checkedListBox_remote";
            checkedListBox_remote.Size = new Size(182, 58);
            checkedListBox_remote.StateCheckedNormal.Item.Back.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_remote.StateCheckedNormal.Item.Back.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_remote.StateCheckedNormal.Item.Back.ColorAngle = 25F;
            checkedListBox_remote.StateCheckedNormal.Item.Border.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_remote.StateCheckedNormal.Item.Border.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_remote.StateCheckedNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_remote.StateCheckedTracking.Item.Back.Color1 = Color.FromArgb(116, 186, 245);
            checkedListBox_remote.StateCheckedTracking.Item.Back.Color2 = Color.FromArgb(175, 217, 250);
            checkedListBox_remote.StateCheckedTracking.Item.Border.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_remote.StateCheckedTracking.Item.Border.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_remote.StateCheckedTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_remote.StateTracking.Item.Back.Color1 = Color.FromArgb(187, 222, 251);
            checkedListBox_remote.StateTracking.Item.Back.Color2 = Color.FromArgb(200, 221, 238);
            checkedListBox_remote.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            checkedListBox_remote.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            checkedListBox_remote.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_remote.TabIndex = 43;
            checkedListBox_remote.MouseLeave += CheckedListBox_remote_MouseLeave;
            // 
            // label_annoucement_date
            // 
            label_annoucement_date.AutoSize = true;
            label_annoucement_date.Location = new Point(26, 74);
            label_annoucement_date.Name = "label_annoucement_date";
            label_annoucement_date.Size = new Size(97, 15);
            label_annoucement_date.TabIndex = 31;
            label_annoucement_date.Text = "Data do anúncio:";
            // 
            // checkedListBox_type_job
            // 
            checkedListBox_type_job.Items.AddRange(new object[] { "Tempo integral", "Meio período", "Contrato", "Temporário", "Voluntário", "Estágio", "Outro" });
            checkedListBox_type_job.Location = new Point(365, 40);
            checkedListBox_type_job.Name = "checkedListBox_type_job";
            checkedListBox_type_job.Size = new Size(128, 96);
            checkedListBox_type_job.StateCheckedNormal.Item.Back.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_type_job.StateCheckedNormal.Item.Back.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_type_job.StateCheckedNormal.Item.Back.ColorAngle = 25F;
            checkedListBox_type_job.StateCheckedNormal.Item.Border.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_type_job.StateCheckedNormal.Item.Border.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_type_job.StateCheckedNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_type_job.StateCheckedTracking.Item.Back.Color1 = Color.FromArgb(116, 186, 245);
            checkedListBox_type_job.StateCheckedTracking.Item.Back.Color2 = Color.FromArgb(175, 217, 250);
            checkedListBox_type_job.StateCheckedTracking.Item.Border.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_type_job.StateCheckedTracking.Item.Border.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_type_job.StateCheckedTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_type_job.StateTracking.Item.Back.Color1 = Color.FromArgb(187, 222, 251);
            checkedListBox_type_job.StateTracking.Item.Back.Color2 = Color.FromArgb(200, 221, 238);
            checkedListBox_type_job.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            checkedListBox_type_job.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            checkedListBox_type_job.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_type_job.TabIndex = 42;
            checkedListBox_type_job.MouseLeave += CheckedListBox_type_job_MouseLeave;
            // 
            // label_choose_by
            // 
            label_choose_by.AutoSize = true;
            label_choose_by.Location = new Point(26, 22);
            label_choose_by.Name = "label_choose_by";
            label_choose_by.Size = new Size(84, 15);
            label_choose_by.TabIndex = 26;
            label_choose_by.Text = "Classificar por:";
            // 
            // comboBox_annoucement_date
            // 
            comboBox_annoucement_date.AutoCompleteCustomSource.AddRange(new string[] { "1920x1080", "1366x768", "1280x720", "640x470" });
            comboBox_annoucement_date.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_annoucement_date.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_annoucement_date.CueHint.Color1 = Color.Gray;
            comboBox_annoucement_date.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            comboBox_annoucement_date.DropDownWidth = 142;
            comboBox_annoucement_date.IntegralHeight = false;
            comboBox_annoucement_date.Items.AddRange(new object[] { "A qualquer momento", "Último mês", "Última semana", "Últimas 24 horas" });
            comboBox_annoucement_date.ItemStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            comboBox_annoucement_date.Location = new Point(26, 94);
            comboBox_annoucement_date.Name = "comboBox_annoucement_date";
            comboBox_annoucement_date.Size = new Size(144, 21);
            comboBox_annoucement_date.StateCommon.ComboBox.Back.Color1 = Color.White;
            comboBox_annoucement_date.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBox_annoucement_date.StateCommon.DropBack.Color1 = Color.DodgerBlue;
            comboBox_annoucement_date.StateCommon.DropBack.Color2 = Color.DodgerBlue;
            comboBox_annoucement_date.StateCommon.Item.Back.Color1 = Color.White;
            comboBox_annoucement_date.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(255, 128, 0);
            comboBox_annoucement_date.StateNormal.ComboBox.Content.Color1 = Color.FromArgb(255, 192, 255);
            comboBox_annoucement_date.StateNormal.Item.Back.Color1 = SystemColors.ControlLightLight;
            comboBox_annoucement_date.StateNormal.Item.Back.Color2 = SystemColors.ControlLightLight;
            comboBox_annoucement_date.StateNormal.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            comboBox_annoucement_date.StateTracking.Item.Back.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_annoucement_date.StateTracking.Item.Back.Color2 = Color.FromArgb(187, 222, 251);
            comboBox_annoucement_date.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_annoucement_date.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            comboBox_annoucement_date.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBox_annoucement_date.TabIndex = 40;
            comboBox_annoucement_date.SelectedIndexChanged += ComboBox_annoucement_date_SelectedIndexChanged;
            // 
            // checkedListBox_experience_level
            // 
            checkedListBox_experience_level.Items.AddRange(new object[] { "Estágio", "Júnior", "Assistente", "Pleno-sênior", "Diretor", "Executivo" });
            checkedListBox_experience_level.Location = new Point(203, 40);
            checkedListBox_experience_level.Name = "checkedListBox_experience_level";
            checkedListBox_experience_level.Size = new Size(120, 96);
            checkedListBox_experience_level.StateCheckedNormal.Item.Back.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_experience_level.StateCheckedNormal.Item.Back.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_experience_level.StateCheckedNormal.Item.Back.ColorAngle = 25F;
            checkedListBox_experience_level.StateCheckedNormal.Item.Border.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_experience_level.StateCheckedNormal.Item.Border.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_experience_level.StateCheckedNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_experience_level.StateCheckedTracking.Item.Back.Color1 = Color.FromArgb(116, 186, 245);
            checkedListBox_experience_level.StateCheckedTracking.Item.Back.Color2 = Color.FromArgb(175, 217, 250);
            checkedListBox_experience_level.StateCheckedTracking.Item.Border.Color1 = Color.FromArgb(104, 182, 246);
            checkedListBox_experience_level.StateCheckedTracking.Item.Border.Color2 = Color.FromArgb(104, 182, 246);
            checkedListBox_experience_level.StateCheckedTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_experience_level.StateTracking.Item.Back.Color1 = Color.FromArgb(187, 222, 251);
            checkedListBox_experience_level.StateTracking.Item.Back.Color2 = Color.FromArgb(200, 221, 238);
            checkedListBox_experience_level.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            checkedListBox_experience_level.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            checkedListBox_experience_level.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            checkedListBox_experience_level.TabIndex = 41;
            checkedListBox_experience_level.MouseLeave += CheckedListBox_experience_level_MouseLeave;
            // 
            // location_label
            // 
            location_label.AutoSize = true;
            location_label.Location = new Point(538, 22);
            location_label.Name = "location_label";
            location_label.Size = new Size(52, 15);
            location_label.TabIndex = 25;
            location_label.Text = "Remoto:";
            // 
            // experience_level_label
            // 
            experience_level_label.AutoSize = true;
            experience_level_label.Location = new Point(210, 22);
            experience_level_label.Name = "experience_level_label";
            experience_level_label.Size = new Size(113, 15);
            experience_level_label.TabIndex = 19;
            experience_level_label.Text = "Nível de experiência";
            // 
            // comboBox_choose_by
            // 
            comboBox_choose_by.AutoCompleteCustomSource.AddRange(new string[] { "Mais recentes", "Mais relevantes"});
            comboBox_choose_by.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_choose_by.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_choose_by.CueHint.Color1 = Color.Red;
            comboBox_choose_by.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            comboBox_choose_by.DropDownWidth = 142;
            comboBox_choose_by.IntegralHeight = false;
            comboBox_choose_by.Items.AddRange(new object[] { "Mais recentes", "Mais relevantes" });
            comboBox_choose_by.ItemStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            comboBox_choose_by.Location = new Point(26, 40);
            comboBox_choose_by.Name = "comboBox_choose_by";
            comboBox_choose_by.Size = new Size(144, 21);
            comboBox_choose_by.StateCommon.ComboBox.Back.Color1 = Color.White;
            comboBox_choose_by.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBox_choose_by.StateCommon.DropBack.Color1 = Color.DodgerBlue;
            comboBox_choose_by.StateCommon.DropBack.Color2 = Color.DodgerBlue;
            comboBox_choose_by.StateCommon.Item.Back.Color1 = Color.White;
            comboBox_choose_by.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(255, 128, 0);
            comboBox_choose_by.StateNormal.ComboBox.Content.Color1 = Color.FromArgb(255, 192, 255);
            comboBox_choose_by.StateNormal.Item.Back.Color1 = SystemColors.ControlLightLight;
            comboBox_choose_by.StateNormal.Item.Back.Color2 = SystemColors.ControlLightLight;
            comboBox_choose_by.StateNormal.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            comboBox_choose_by.StateTracking.Item.Back.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_choose_by.StateTracking.Item.Back.Color2 = Color.FromArgb(187, 222, 251);
            comboBox_choose_by.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_choose_by.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            comboBox_choose_by.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBox_choose_by.TabIndex = 39;
            comboBox_choose_by.SelectedIndexChanged += ComboBox_choose_by_SelectedIndexChanged;
            // 
            // job_type_label
            // 
            job_type_label.AutoSize = true;
            job_type_label.Location = new Point(365, 19);
            job_type_label.Name = "job_type_label";
            job_type_label.Size = new Size(77, 15);
            job_type_label.TabIndex = 24;
            job_type_label.Text = "Tipo de vaga:";
            // 
            // FilterControlView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(groupBox_filters);
            Margin = new Padding(0);
            Name = "FilterControlView";
            Size = new Size(1087, 532);
            groupBox_filters.ResumeLayout(false);
            groupBox_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBox_annoucement_date).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBox_choose_by).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_filters;
        private Label label_annoucement_date;
        private Label label_choose_by;
        private Label location_label;
        private Label experience_level_label;
        private Label job_type_label;
        private Krypton.Toolkit.KryptonComboBox comboBox_choose_by;
        private Krypton.Toolkit.KryptonComboBox comboBox_annoucement_date;
        private Krypton.Toolkit.KryptonCheckedListBox checkedListBox_experience_level;
        private Krypton.Toolkit.KryptonCheckedListBox checkedListBox_type_job;
        private Krypton.Toolkit.KryptonCheckedListBox checkedListBox_remote;
    }
}

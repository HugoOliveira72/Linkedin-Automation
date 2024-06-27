namespace forms.Views.UserControls
{
    partial class ConfigControlView
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
            label2 = new Label();
            label_screen_type = new Label();
            comboBox_resolution = new Krypton.Toolkit.KryptonComboBox();
            comboBox_resolution_type = new Krypton.Toolkit.KryptonComboBox();
            groupBoxConfig = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)comboBox_resolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBox_resolution_type).BeginInit();
            groupBoxConfig.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 22);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Resolução";
            // 
            // label_screen_type
            // 
            label_screen_type.AutoSize = true;
            label_screen_type.Location = new Point(36, 22);
            label_screen_type.Name = "label_screen_type";
            label_screen_type.Size = new Size(39, 15);
            label_screen_type.TabIndex = 5;
            label_screen_type.Text = "Modo";
            // 
            // comboBox_resolution
            // 
            comboBox_resolution.AutoCompleteCustomSource.AddRange(new string[] { "1920x1080", "1366x768", "1280x720", "640x470" });
            comboBox_resolution.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_resolution.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_resolution.CueHint.Color1 = Color.Gray;
            comboBox_resolution.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            comboBox_resolution.DropDownWidth = 142;
            comboBox_resolution.IntegralHeight = false;
            comboBox_resolution.Items.AddRange(new object[] { "1920x1080", "1366x768", "1280x720", "640x470" });
            comboBox_resolution.ItemStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            comboBox_resolution.Location = new Point(211, 40);
            comboBox_resolution.Name = "comboBox_resolution";
            comboBox_resolution.Size = new Size(142, 21);
            comboBox_resolution.StateCommon.ComboBox.Back.Color1 = Color.White;
            comboBox_resolution.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBox_resolution.StateCommon.DropBack.Color1 = Color.DodgerBlue;
            comboBox_resolution.StateCommon.DropBack.Color2 = Color.DodgerBlue;
            comboBox_resolution.StateCommon.Item.Back.Color1 = Color.White;
            comboBox_resolution.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(255, 128, 0);
            comboBox_resolution.StateNormal.ComboBox.Content.Color1 = Color.FromArgb(255, 192, 255);
            comboBox_resolution.StateNormal.Item.Back.Color1 = SystemColors.ControlLightLight;
            comboBox_resolution.StateNormal.Item.Back.Color2 = SystemColors.ControlLightLight;
            comboBox_resolution.StateNormal.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            comboBox_resolution.StateTracking.Item.Back.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_resolution.StateTracking.Item.Back.Color2 = Color.FromArgb(187, 222, 251);
            comboBox_resolution.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_resolution.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            comboBox_resolution.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBox_resolution.SelectedIndexChanged += comboBox_resolution_SelectedIndexChanged;
            comboBox_resolution.TabIndex = 10;

            // 
            // comboBox_resolution_type
            // 
            comboBox_resolution_type.AutoCompleteCustomSource.AddRange(new string[] { "1920x1080", "1366x768", "1280x720", "640x470" });
            comboBox_resolution_type.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_resolution_type.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_resolution_type.CueHint.Color1 = Color.Gray;
            comboBox_resolution_type.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            comboBox_resolution_type.DropDownWidth = 142;
            comboBox_resolution_type.IntegralHeight = false;
            comboBox_resolution_type.Items.AddRange(new object[] { "Tela cheia", "Janela" });
            comboBox_resolution_type.ItemStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            comboBox_resolution_type.Location = new Point(36, 40);
            comboBox_resolution_type.Name = "comboBox_resolution_type";
            comboBox_resolution_type.Size = new Size(142, 21);
            comboBox_resolution_type.StateCommon.ComboBox.Back.Color1 = Color.White;
            comboBox_resolution_type.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBox_resolution_type.StateCommon.DropBack.Color1 = Color.DodgerBlue;
            comboBox_resolution_type.StateCommon.DropBack.Color2 = Color.DodgerBlue;
            comboBox_resolution_type.StateCommon.Item.Back.Color1 = Color.White;
            comboBox_resolution_type.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(255, 128, 0);
            comboBox_resolution_type.StateNormal.ComboBox.Content.Color1 = Color.FromArgb(255, 192, 255);
            comboBox_resolution_type.StateNormal.Item.Back.Color1 = SystemColors.ControlLightLight;
            comboBox_resolution_type.StateNormal.Item.Back.Color2 = SystemColors.ControlLightLight;
            comboBox_resolution_type.StateNormal.Item.Back.Draw = Krypton.Toolkit.InheritBool.True;
            comboBox_resolution_type.StateTracking.Item.Back.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_resolution_type.StateTracking.Item.Back.Color2 = Color.FromArgb(187, 222, 251);
            comboBox_resolution_type.StateTracking.Item.Border.Color1 = Color.FromArgb(200, 221, 238);
            comboBox_resolution_type.StateTracking.Item.Border.Color2 = Color.FromArgb(200, 221, 238);
            comboBox_resolution_type.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBox_resolution_type.SelectedIndexChanged += comboBox_resolution_type_SelectedIndexChanged;
            comboBox_resolution_type.TabIndex = 11;
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(comboBox_resolution_type);
            groupBoxConfig.Controls.Add(comboBox_resolution);
            groupBoxConfig.Controls.Add(label2);
            groupBoxConfig.Controls.Add(label_screen_type);
            groupBoxConfig.Location = new Point(3, 3);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(379, 80);
            groupBoxConfig.TabIndex = 15;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Resolução do navegador";
            // 
            // ConfigControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxConfig);
            Name = "ConfigControl";
            Size = new Size(1162, 86);
            ((System.ComponentModel.ISupportInitialize)comboBox_resolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBox_resolution_type).EndInit();
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label_screen_type;
        private Krypton.Toolkit.KryptonComboBox comboBox_resolution;
        private Krypton.Toolkit.KryptonComboBox comboBox_resolution_type;
        private GroupBox groupBoxConfig;
    }
}

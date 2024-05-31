namespace forms.Forms
{
    partial class ConfigView
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
            label_screen_type = new Label();
            comboBox_resolution_type = new ComboBox();
            comboBox_resolution = new ComboBox();
            label2 = new Label();
            button_save_configs = new Button();
            SuspendLayout();
            // 
            // label_screen_type
            // 
            label_screen_type.AutoSize = true;
            label_screen_type.Location = new Point(22, 35);
            label_screen_type.Name = "label_screen_type";
            label_screen_type.Size = new Size(39, 15);
            label_screen_type.TabIndex = 0;
            label_screen_type.Text = "Modo";
            // 
            // comboBox_resolution_type
            // 
            comboBox_resolution_type.FormattingEnabled = true;
            comboBox_resolution_type.IntegralHeight = false;
            comboBox_resolution_type.Items.AddRange(new object[] { "Tela cheia", "Janela" });
            comboBox_resolution_type.Location = new Point(22, 53);
            comboBox_resolution_type.Name = "comboBox_resolution_type";
            comboBox_resolution_type.Size = new Size(121, 23);
            comboBox_resolution_type.TabIndex = 1;
            comboBox_resolution_type.SelectedIndexChanged += comboBox_resolution_type_SelectedIndexChanged;
            // 
            // comboBox_resolution
            // 
            comboBox_resolution.FormattingEnabled = true;
            comboBox_resolution.Items.AddRange(new object[] { "1920x1080", "1366x768", "1280x720", "640x470" });
            comboBox_resolution.Location = new Point(22, 121);
            comboBox_resolution.Name = "comboBox_resolution";
            comboBox_resolution.Size = new Size(121, 23);
            comboBox_resolution.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Resolução";
            // 
            // button_save_configs
            // 
            button_save_configs.Location = new Point(92, 205);
            button_save_configs.Name = "button_save_configs";
            button_save_configs.Size = new Size(100, 30);
            button_save_configs.TabIndex = 4;
            button_save_configs.Text = "Salvar";
            button_save_configs.UseVisualStyleBackColor = true;
            // 
            // ConfigScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 295);
            Controls.Add(button_save_configs);
            Controls.Add(label2);
            Controls.Add(comboBox_resolution);
            Controls.Add(comboBox_resolution_type);
            Controls.Add(label_screen_type);
            Name = "ConfigScreen";
            Text = "Configurações";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_screen_type;
        private ComboBox comboBox_resolution_type;
        private ComboBox comboBox_resolution;
        private Label label2;
        private Button button_save_configs;
    }
}
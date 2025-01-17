﻿namespace forms.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            leftPanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelTitle = new Label();
            pictureBox3 = new PictureBox();
            passwordTxtBox = new Krypton.Toolkit.KryptonTextBox();
            userTxtBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLoginButton = new Krypton.Toolkit.KryptonButton();
            labelUser = new Label();
            labelPassword = new Label();
            loginTitleLabel = new Label();
            checkbox_rememberMe = new CheckBox();
            labelShortTextLogin = new Label();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(33, 150, 243);
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(pictureBox2);
            leftPanel.Controls.Add(pictureBox4);
            leftPanel.Controls.Add(labelTitle);
            leftPanel.Controls.Add(pictureBox3);
            leftPanel.ForeColor = SystemColors.InfoText;
            leftPanel.Location = new Point(-2, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(341, 515);
            leftPanel.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.umaA;
            pictureBox1.Location = new Point(234, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(128, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.letter_l;
            pictureBox4.Location = new Point(13, 132);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 110);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 53;
            pictureBox4.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AllowDrop = true;
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(33, 150, 243);
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(33, 33, 33);
            labelTitle.Location = new Point(2, 273);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(336, 45);
            labelTitle.TabIndex = 35;
            labelTitle.Text = "Linkedin Automation";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.backgouund_in;
            pictureBox3.Location = new Point(125, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(108, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(445, 224);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '●';
            passwordTxtBox.Size = new Size(263, 27);
            passwordTxtBox.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224, 224);
            passwordTxtBox.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224, 224);
            passwordTxtBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            passwordTxtBox.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            passwordTxtBox.StateCommon.Border.Rounding = 15F;
            passwordTxtBox.StateCommon.Border.Width = 1;
            passwordTxtBox.StateCommon.Content.Color1 = Color.Gray;
            passwordTxtBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxtBox.StateCommon.Content.Padding = new Padding(10, -1, 10, -1);
            passwordTxtBox.TabIndex = 41;
            passwordTxtBox.UseSystemPasswordChar = true;
            passwordTxtBox.Validating += PasswordTxtBox_Validating;
            // 
            // userTxtBox
            // 
            userTxtBox.Location = new Point(445, 148);
            userTxtBox.Name = "userTxtBox";
            userTxtBox.Size = new Size(263, 27);
            userTxtBox.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224, 224);
            userTxtBox.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224, 224);
            userTxtBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            userTxtBox.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            userTxtBox.StateCommon.Border.Rounding = 15F;
            userTxtBox.StateCommon.Border.Width = 1;
            userTxtBox.StateCommon.Content.Color1 = Color.Gray;
            userTxtBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTxtBox.StateCommon.Content.Padding = new Padding(10, -1, 10, -1);
            userTxtBox.TabIndex = 45;
            userTxtBox.Validating += UserTxtBox_Validating;
            // 
            // kryptonLoginButton
            // 
            kryptonLoginButton.BackColor = Color.White;
            kryptonLoginButton.Location = new Point(451, 340);
            kryptonLoginButton.Name = "kryptonLoginButton";
            kryptonLoginButton.Size = new Size(257, 47);
            kryptonLoginButton.StateCommon.Back.Color1 = Color.FromArgb(33, 150, 243);
            kryptonLoginButton.StateCommon.Back.Color2 = Color.FromArgb(25, 118, 210);
            kryptonLoginButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonLoginButton.StateCommon.Border.Rounding = 5F;
            kryptonLoginButton.StateCommon.Border.Width = 1;
            kryptonLoginButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonLoginButton.StateCommon.Content.ShortText.Color1 = Color.FromArgb(33, 33, 33);
            kryptonLoginButton.StateCommon.Content.ShortText.Color2 = Color.FromArgb(33, 33, 33);
            kryptonLoginButton.StateCommon.Content.ShortText.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLoginButton.StatePressed.Border.Color1 = Color.Transparent;
            kryptonLoginButton.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonLoginButton.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonLoginButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonLoginButton.StateTracking.Border.Color1 = Color.FromArgb(33, 150, 243);
            kryptonLoginButton.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonLoginButton.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonLoginButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonLoginButton.TabIndex = 47;
            kryptonLoginButton.Values.Text = "INICIAR";
            kryptonLoginButton.Click += kryptonLoginButton_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 10F);
            labelUser.ForeColor = Color.FromArgb(33, 33, 33);
            labelUser.Location = new Point(451, 126);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(110, 19);
            labelUser.TabIndex = 48;
            labelUser.Text = "Email ou usuário";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.ForeColor = Color.FromArgb(33, 33, 33);
            labelPassword.Location = new Point(451, 202);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(46, 19);
            labelPassword.TabIndex = 49;
            labelPassword.Text = "Senha";
            // 
            // loginTitleLabel
            // 
            loginTitleLabel.AutoSize = true;
            loginTitleLabel.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold);
            loginTitleLabel.ForeColor = Color.FromArgb(33, 33, 33);
            loginTitleLabel.Location = new Point(445, 23);
            loginTitleLabel.Name = "loginTitleLabel";
            loginTitleLabel.Size = new Size(125, 45);
            loginTitleLabel.TabIndex = 50;
            loginTitleLabel.Text = "LOG IN";
            // 
            // checkbox_rememberMe
            // 
            checkbox_rememberMe.AutoSize = true;
            checkbox_rememberMe.ForeColor = Color.FromArgb(33, 33, 33);
            checkbox_rememberMe.Location = new Point(451, 259);
            checkbox_rememberMe.Name = "checkbox_rememberMe";
            checkbox_rememberMe.Size = new Size(114, 19);
            checkbox_rememberMe.TabIndex = 51;
            checkbox_rememberMe.Text = "Lembrar de mim";
            checkbox_rememberMe.UseVisualStyleBackColor = true;
            // 
            // labelShortTextLogin
            // 
            labelShortTextLogin.AutoSize = true;
            labelShortTextLogin.Location = new Point(451, 68);
            labelShortTextLogin.Name = "labelShortTextLogin";
            labelShortTextLogin.Size = new Size(205, 15);
            labelShortTextLogin.TabIndex = 52;
            labelShortTextLogin.Text = "Insira as credencials da conta linkedin";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(789, 517);
            Controls.Add(labelShortTextLogin);
            Controls.Add(checkbox_rememberMe);
            Controls.Add(loginTitleLabel);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(kryptonLoginButton);
            Controls.Add(userTxtBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginView";
            Text = "LoginScreen";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginButton;
        private Label user_label;
        private Label password_label;
        private Label label1;
        private Panel leftPanel;
        private Label labelTitle;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxUserName;
        private Krypton.Toolkit.KryptonTextBox userTxtBox;
        private Krypton.Toolkit.KryptonTextBox passwordTxtBox;
        private Krypton.Toolkit.KryptonButton kryptonLoginButton;
        private Label labelUser;
        private Label labelPassword;
        private Label loginTitleLabel;
        private CheckBox checkbox_rememberMe;
        private Label labelShortTextLogin;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}
using System.Windows.Forms;

namespace forms.Views.UserControls
{
    partial class MainControlView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControlView));
            contextMenuStrip1 = new ContextMenuStrip(components);
            kryptonRichTextBoxWarningText = new Krypton.Toolkit.KryptonRichTextBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // kryptonRichTextBoxWarningText
            // 
            kryptonRichTextBoxWarningText.Location = new Point(0, 0);
            kryptonRichTextBoxWarningText.Name = "kryptonRichTextBoxWarningText";
            kryptonRichTextBoxWarningText.ReadOnly = true;
            kryptonRichTextBoxWarningText.Size = new Size(450, 150);
            kryptonRichTextBoxWarningText.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonRichTextBoxWarningText.StateCommon.Border.Rounding = 5F;
            kryptonRichTextBoxWarningText.TabIndex = 2;
            kryptonRichTextBoxWarningText.Text = resources.GetString("kryptonRichTextBoxWarningText.Text");
            // 
            // MainControlView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(kryptonRichTextBoxWarningText);
            Name = "MainControlView";
            Size = new Size(1180, 140);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxWarningText;
    }
}

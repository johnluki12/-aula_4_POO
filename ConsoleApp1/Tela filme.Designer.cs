namespace ConsoleApp1
{
    partial class Tela_filme
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
            this.SuspendLayout();
            // 
            // Tela_filme
            // 
            this.ClientSize = new System.Drawing.Size(734, 322);
            this.Name = "Tela_filme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
namespace RastreadorCaracterEspecial
{
    partial class FormMostrarConteudo
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
            this.txtBoxConteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxConteudo
            // 
            this.txtBoxConteudo.Location = new System.Drawing.Point(1, -1);
            this.txtBoxConteudo.Multiline = true;
            this.txtBoxConteudo.Name = "txtBoxConteudo";
            this.txtBoxConteudo.Size = new System.Drawing.Size(486, 429);
            this.txtBoxConteudo.TabIndex = 0;
            // 
            // FormMostrarConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 428);
            this.Controls.Add(this.txtBoxConteudo);
            this.MaximizeBox = false;
            this.Name = "FormMostrarConteudo";
            this.Text = "FormMostrarConteudo";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeComponent(string conteudo)
        {
            this.txtBoxConteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxConteudo
            // 
            this.txtBoxConteudo.Location = new System.Drawing.Point(1, -1);
            this.txtBoxConteudo.Multiline = true;
            this.txtBoxConteudo.Text = conteudo;
            this.txtBoxConteudo.Name = "txtBoxConteudo";
            this.txtBoxConteudo.Size = new System.Drawing.Size(486, 429);
            this.txtBoxConteudo.TabIndex = 0;
            this.txtBoxConteudo.TextChanged += new System.EventHandler(this.txtBoxConteudo_TextChanged);
            // 
            // FormMostrarConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 428);
            this.Controls.Add(this.txtBoxConteudo);
            this.MaximizeBox = false;
            this.Name = "FormMostrarConteudo";
            this.Text = "FormMostrarConteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private TextBox txtBoxConteudo;
        private VScrollBar vScrollBar1;
    }
}
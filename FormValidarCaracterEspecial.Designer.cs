namespace RastreadorCaracterEspecial
{
    partial class FormValidarCaracterEspecial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidarCaracterEspecial));
            this.btnImportarArquivo = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTelaMostrarConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportarArquivo
            // 
            this.btnImportarArquivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportarArquivo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImportarArquivo.Location = new System.Drawing.Point(99, 215);
            this.btnImportarArquivo.Name = "btnImportarArquivo";
            this.btnImportarArquivo.Size = new System.Drawing.Size(126, 32);
            this.btnImportarArquivo.TabIndex = 0;
            this.btnImportarArquivo.Text = "Anexar";
            this.btnImportarArquivo.UseVisualStyleBackColor = false;
            this.btnImportarArquivo.Click += new System.EventHandler(this.btnImportarArquivo_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 85);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(307, 70);
            this.lblResult.TabIndex = 1;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTelaMostrarConteudo
            // 
            this.btnTelaMostrarConteudo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTelaMostrarConteudo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTelaMostrarConteudo.Location = new System.Drawing.Point(99, 268);
            this.btnTelaMostrarConteudo.Name = "btnTelaMostrarConteudo";
            this.btnTelaMostrarConteudo.Size = new System.Drawing.Size(126, 32);
            this.btnTelaMostrarConteudo.TabIndex = 2;
            this.btnTelaMostrarConteudo.Text = "Mostrar";
            this.btnTelaMostrarConteudo.UseVisualStyleBackColor = false;
            this.btnTelaMostrarConteudo.Visible = false;
            this.btnTelaMostrarConteudo.Click += new System.EventHandler(this.btnTelaMostrarConteudo_Click);
            // 
            // FormValidarCaracterEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 405);
            this.Controls.Add(this.btnTelaMostrarConteudo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnImportarArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormValidarCaracterEspecial";
            this.Text = "Verificador de Caracter Especial";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnImportarArquivo;
        private Label lblResult;
        private Button btnTelaMostrarConteudo;
    }
}
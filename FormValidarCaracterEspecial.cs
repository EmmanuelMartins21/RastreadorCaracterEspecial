using System.Text.RegularExpressions;

namespace RastreadorCaracterEspecial
{
    public partial class FormValidarCaracterEspecial : Form
    {
        string? caminhoArquivo;
        string? conteudoArquivo;
        public FormValidarCaracterEspecial()
        {
            InitializeComponent();
        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            caminhoArquivo = null;
            conteudoArquivo = null;
            fileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";

            fileDialog.Title = "Selecione um arquivo de texto para importar";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                lblResult.Text = "";
                caminhoArquivo = fileDialog.FileName;
                conteudoArquivo = File.ReadAllText(caminhoArquivo);

                if(ValidarConteudo(conteudoArquivo))
                {
                    lblResult.ForeColor = Color.IndianRed;
                    lblResult.Text = "Arquivo incorreto";
                    btnTelaMostrarConteudo.Visible = true;
                }
                else
                {
                    lblResult.ForeColor = Color.DarkSeaGreen;
                    lblResult.Text = "Arquivo correto";
                }
            }
        } 
        public bool ValidarConteudo (string conteudo)
        {
            string rgxConteudo = @"[^\w\s]";
            return string.IsNullOrEmpty(conteudo) ? false : Regex.IsMatch(conteudo, rgxConteudo, RegexOptions.IgnoreCase);
        }

        private void btnTelaMostrarConteudo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(conteudoArquivo))
            {
                MessageBox.Show("Arquivo sem conteudo", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormMostrarConteudo form = new FormMostrarConteudo(conteudoArquivo);
                form.Show();
            }            
        }
    }
}
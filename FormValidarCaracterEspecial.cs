using System.Text.RegularExpressions;

namespace RastreadorCaracterEspecial
{
    public partial class FormValidarCaracterEspecial : Form
    {
        string caminhoArquivo;
        string conteudoArquivo;
        public FormValidarCaracterEspecial()
        {
            InitializeComponent();
        }

        private void btnImportarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

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
            string regexCPF = @"[^\w\s]";
            return Regex.IsMatch(conteudo, regexCPF, RegexOptions.IgnoreCase);
        }

        private void btnTelaMostrarConteudo_Click(object sender, EventArgs e)
        {
            FormMostrarConteudo form = new FormMostrarConteudo(conteudoArquivo);
            form.Show();
        }
    }
}
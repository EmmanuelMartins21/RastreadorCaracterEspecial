using System.Text.RegularExpressions;

namespace RastreadorCaracterEspecial
{
    public partial class FormValidarCaracterEspecial : Form
    {
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
                string caminhoArquivo = fileDialog.FileName;
                string conteudoArquivo = File.ReadAllText(caminhoArquivo);

                if(ValidarConteudo(conteudoArquivo))
                {
                    lblResult.ForeColor = Color.IndianRed;
                    lblResult.Text = "Arquivo incorreto";
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
    }
}
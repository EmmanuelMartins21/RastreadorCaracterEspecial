using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastreadorCaracterEspecial
{
    public partial class FormMostrarConteudo : Form
    {
        public FormMostrarConteudo()
        {
            InitializeComponent();
        }
        public FormMostrarConteudo(string conteudo)
        {
            InitializeComponent(conteudo);

        }

    }
}

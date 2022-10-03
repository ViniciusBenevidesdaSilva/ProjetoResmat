using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoResmat.Forms
{
    public partial class FormSelecionaGrid : Form
    {
        public bool Confirmou { get; private set; } = false;


        public FormSelecionaGrid()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DadosGrid.intervaloH = (double)txtIntervaloH.Value;
            DadosGrid.intervaloV = (double)txtIntervaloV.Value;
            DadosGrid.qtdH = (int)txtQtdH.Value;
            DadosGrid.qtdV = (int)txtQtdV.Value;

            Confirmou = true;

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

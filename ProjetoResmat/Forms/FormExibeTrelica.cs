using ProjetoResmat.Componentes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoResmat.Forms
{
    public partial class FormExibeTrelica : Form
    {
        public FormExibeTrelica()
        {
            InitializeComponent();
        }

        private void FormExibeTrelica_Load(object sender, EventArgs e)
        {
            gridTrelica1.GeraGrid();
        }

    }
}

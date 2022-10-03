using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoResmat.Forms;

namespace ProjetoResmat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;


            AlinhaComponentes();

        }


        private void AlinhaComponentes()
        {
            lblTitulo.Location = new Point((this.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y);

            //btnNova.Location = new Point(btnNova.Parent.Width / 4 - btnNova.Width / 2, btnNova.Location.Y);
            //btnImportar.Location = new Point(btnImportar.Parent.Width / 4 + btnImportar.Width / 2, btnImportar.Location.Y);

        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            FormSelecionaGrid tamanhoGrid = new FormSelecionaGrid();
            tamanhoGrid.ShowDialog();

            if (!tamanhoGrid.Confirmou)
                return;

            FormExibeTrelica trelica = new FormExibeTrelica();

            Hide();
            trelica.ShowDialog();
            Show();
        }
    }
}

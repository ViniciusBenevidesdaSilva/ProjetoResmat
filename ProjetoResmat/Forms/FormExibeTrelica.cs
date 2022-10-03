using ProjetoResmat.Componentes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoResmat.Forms
{
    public partial class FormExibeTrelica : Form
    {
        LinhaGrid linhaAux = null;


        public FormExibeTrelica()
        {
            InitializeComponent();

            //label1.Text = $"546; 411     Height: {gridTrelica1.Width} Width: {gridTrelica1.Height}";
        }

        private void FormExibeTrelica_Load(object sender, EventArgs e)
        {
            gridTrelica1.GeraGrid();


            //GeraGrid();
        }

        /*
        private void GeraGrid()
        {
            linhaAux = null;

            int espaco = grid.Width / (DadosGrid.qtdH + 2);
            int inicio = grid.Left;


            // Para cada reta que determina a horizontal (que são as retas verticais)
            for (int i = 0; i <= DadosGrid.qtdH; i++)
            {
                inicio += espaco;  // Aumento a posição que vou desenha-la

                linhaAux = new LinhaGrid(grid.Height, 1);
                linhaAux.Location = new Point(inicio - 181, grid.Top - 18);

                grid.Controls.Add(linhaAux);
            }


            espaco = grid.Height / (DadosGrid.qtdV + 2);
            inicio = grid.Top;

            for (int i = 0; i <= DadosGrid.qtdV; i++)
            {
                inicio += espaco;  // Aumento a posição que vou desenha-la

                linhaAux = new LinhaGrid(1, grid.Width);
                linhaAux.Location = new Point(grid.Left, inicio);

                grid.Controls.Add(linhaAux);
            }
            
        }
        */
       
    }
}

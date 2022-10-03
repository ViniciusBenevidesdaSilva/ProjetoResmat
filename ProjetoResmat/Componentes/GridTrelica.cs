using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoResmat.Componentes
{
    public partial class GridTrelica : UserControl
    {

        List<LinhaGrid> linhas = new List<LinhaGrid>();

        public GridTrelica()
        {
            InitializeComponent();
        }

        public void GeraGrid()
        {
            // eu vou criar (qtdH + 1) linhas horizontais por conta do 0 (mesma coisa qtdV + 1) 
            // x - 546
            // y | 411


            LinhaGrid linhaAux = null;

            int espaco = Width / (DadosGrid.qtdH + 2);
            int inicio = panel.Left;


            // Para cada reta que determina a horizontal (que são as retas verticais)
            for (int i = 0; i <= DadosGrid.qtdH; i++)
            {
                inicio += espaco;  // Aumento a posição que vou desenha-la

                linhaAux = new LinhaGrid(Height, 1);

                panel.Controls.Add(linhaAux);

                linhaAux.Location = new Point(inicio, panel.Top);

            }


            espaco = Height / (DadosGrid.qtdV + 2);
            inicio = panel.Top;

            for (int i = 0; i <= DadosGrid.qtdV; i++)
            {
                inicio += espaco;  // Aumento a posição que vou desenha-la

                linhaAux = new LinhaGrid(1, Width);

                panel.Controls.Add(linhaAux);

                linhaAux.Location = new Point(panel.Left, inicio);

            }
        }
    }
}

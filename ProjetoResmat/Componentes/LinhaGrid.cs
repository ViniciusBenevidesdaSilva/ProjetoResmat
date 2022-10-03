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
    public partial class LinhaGrid : UserControl
    {
        public LinhaGrid()
        {
            InitializeComponent();
        }

        public LinhaGrid(int altura, int comprimento)
        {
            InitializeComponent();

            Height = altura;
            Width = comprimento;

            Location = new Point(0, 0);
        }
    }
}

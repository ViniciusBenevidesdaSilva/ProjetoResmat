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
        public int valor { get; set; }
        
        public bool ehHorizontal { get; private set; }


        public LinhaGrid()
        {
            InitializeComponent();
        }

        public LinhaGrid(int altura, int comprimento, bool isHorizontal = false)
        {
            InitializeComponent();

            Height = altura;
            Width = comprimento;

            Location = new Point(0, 0);

            ehHorizontal = isHorizontal;
        }
    }
}

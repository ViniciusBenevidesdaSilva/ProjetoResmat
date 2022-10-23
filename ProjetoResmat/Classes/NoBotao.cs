using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoResmat.Classes
{
    public class NoBotao
    {
        public Point CentroGrid { get; set; }

        public Point CentroMatematico { get; set; }

        public Button Botao { get; set; }

        public bool Usado { get; set; } = false;

        public NoBotao(Button novoBotao, int x, int y)
        {
            Botao = novoBotao;
            CentroGrid = new Point(x, y);
            CentroMatematico = new Point(
                ((x / DadosGrid.passoH) - 1) * (int)DadosGrid.intervaloH, 
                ((y / DadosGrid.passoV) - 1) * (int)DadosGrid.intervaloV
            );
        }

        public NoBotao(int x, int y)
        {
            CentroGrid = new Point(x, y);
        }

    }
}

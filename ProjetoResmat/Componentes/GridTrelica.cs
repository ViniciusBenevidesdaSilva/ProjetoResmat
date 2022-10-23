using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoResmat.Classes;

namespace ProjetoResmat.Componentes
{
    public partial class GridTrelica : UserControl
    {

        List<LinhaGrid> linhasH = new List<LinhaGrid>();
        List<LinhaGrid> linhasV = new List<LinhaGrid>();


        Dictionary<Button, NoBotao> nosBotoes = new Dictionary<Button, NoBotao>();
        List<Barra> barras = new List<Barra>();

        Point inicioBarra = new Point(0, 0);  // Guarda o primeiro ponto após o clique
        Button inicioBotao = null;  // Guarda o primeiro botão pressionado para desenhar barra (mudar de cor)


        bool click = false;
        Color corBarraValida = Color.FromArgb(0, 128, 128);

        Pen blackPen = null;



        public GridTrelica()
        {
            InitializeComponent();

            blackPen = new Pen(corBarraValida, 5);
        }

        public int inicioWidth { get; set; }
        public int inicioHeight { get; set; }


        public void GeraGrid()
        {
            GeraLinhas();
            GeraBotoes();
        }


        public void GeraLinhas()
        {
            // eu vou criar (qtdH + 1) linhas horizontais por conta do 0 (mesma coisa qtdV + 1) 
            // x - 546
            // y | 411


            LinhaGrid linhaAux = null;

            DadosGrid.inicioH = panel.Left;
            DadosGrid.passoH = Width / (DadosGrid.qtdH + 2);

            int espaco = DadosGrid.passoH;
            int inicio = panel.Left;


            // Para cada reta que determina a horizontal (que são as retas verticais)
            for (int i = 0; i <= DadosGrid.qtdH; i++)
            {
                inicio += espaco;  // Aumento a posição que vou desenha-la

                linhaAux = new LinhaGrid(Height, 1, true);

                panel.Controls.Add(linhaAux);
                linhasH.Add(linhaAux);

                linhaAux.Location = new Point(inicio, panel.Top);
            }



            DadosGrid.inicioV = panel.Top;
            DadosGrid.passoV = Height / (DadosGrid.qtdV + 2);

            espaco = DadosGrid.passoV;
            inicio = panel.Top;

            for (int i = 0; i <= DadosGrid.qtdV; i++)
            {
                inicio += espaco;  // Aumento a posição que vou desenha-la

                linhaAux = new LinhaGrid(1, Width);

                panel.Controls.Add(linhaAux);
                linhasV.Add(linhaAux);

                linhaAux.Location = new Point(panel.Left, inicio);
            }
        }


        private void botaoAux_Click(object sender, EventArgs e)
        {

            Point ponto = new Point(nosBotoes[(sender as Button)].CentroGrid.X, nosBotoes[(sender as Button)].CentroGrid.Y);

            if (click)
            {
                Barra novaBarra = new Barra(inicioBarra, ponto, nosBotoes[inicioBotao], nosBotoes[(sender as Button)]);

                if (ValidaBarra(novaBarra))
                {
                    barras.Add(novaBarra);
                    novaBarra.NoInicio.Usado = true;
                    novaBarra.NoFinal.Usado = true;
                }

                timerDesenhaBarra.Stop();

                //(sender as Button).BackColor = corBarraValida;
                //inicioBotao.BackColor = corBarraValida;
            }
            else
            {
                inicioBarra = ponto;
                inicioBotao = (sender as Button);
                timerDesenhaBarra.Start();
            }


            click = !click;
            panel.Refresh();
        }


        public bool ValidaBarra(Barra novaBarra)
        {
            if (novaBarra.Inicio == novaBarra.Final)
                return false;

            foreach (Barra b in barras)
            {
                if (novaBarra.Inicio == b.Inicio && novaBarra.Final == b.Final ||
                    novaBarra.Final == b.Inicio && novaBarra.Inicio == b.Final)
                    return false;
            }

            return true;
        }


        public void GeraBotoes()
        {

            Button botaoAux = null;

            foreach (LinhaGrid cH in linhasH)
            {
                foreach (Control cV in linhasV)
                {

                    botaoAux = new Button();

                    botaoAux.Width = 10;
                    botaoAux.Height = 10;
                    botaoAux.Text = "";
                    botaoAux.BackColor = Color.Silver;

                    botaoAux.FlatAppearance.BorderSize = 0;
                    botaoAux.FlatStyle = FlatStyle.Flat;


                    botaoAux.Cursor = Cursors.Cross;
                    botaoAux.Click += botaoAux_Click;
                    panel.Controls.Add(botaoAux);
                    botaoAux.Location = new Point(cH.Left - botaoAux.Width / 2, cV.Top - botaoAux.Height / 2);
                    botaoAux.BringToFront();


                    nosBotoes.Add(botaoAux, new NoBotao(botaoAux, cH.Left, cV.Top));
                    DesenhaBotao(botaoAux);
                }

            }
        }

        public void DesenhaBotao(Button b)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, b.Width, b.Height);
            b.Region = new Region(forma);
        }



        private void panel_Paint(object sender, PaintEventArgs e)
        {
            blackPen.Color = corBarraValida;

            foreach (Barra b in barras)
            {
                e.Graphics.DrawLine(blackPen, b.Inicio, b.Final);
            }
            
            if (!click)
            {
                ReiniciaBotoes(e);
                return;
            }

            // Se o usuário esta desenhando uma reta, atualiza ela até o mouse

            blackPen.Color = Color.Black;

            Point atual = new Point(
                MousePosition.X - Parent.Location.X - Location.X - 8,
                MousePosition.Y - Parent.Location.Y - Location.Y - 32);

            e.Graphics.DrawLine(blackPen, inicioBarra, atual);

        }


        private void ReiniciaBotoes(PaintEventArgs e)
        {
            // Reinicio a cor dos botões
            foreach (Button b in nosBotoes.Keys)
            {
                b.BackColor = Color.Silver;
                b.Enabled = true;
            }



            foreach (Barra b in barras)
            {
                //e.Graphics.DrawLine(blackPen, b.Inicio, b.Final);

                // Atualiza os botões válidos
                b.NoInicio.Botao.BackColor = corBarraValida;
                b.NoFinal.Botao.BackColor = corBarraValida;

                // -> b.NoInicio.CentroMatematico
                // -> b.NoFinal.CentroMatematico

                // Eliminar todos que estão entre esses pontos

                // y = coeficiente * x + independente

                float coeficiente = (float)(b.NoFinal.CentroMatematico.Y - b.NoInicio.CentroMatematico.Y) / (b.NoFinal.CentroMatematico.X - b.NoInicio.CentroMatematico.X);
                int independente = (int)(b.NoInicio.CentroMatematico.Y - coeficiente * b.NoInicio.CentroMatematico.X);

                NoBotao menor = b.NoInicio.CentroGrid == b.Inicio ? b.NoInicio : b.NoFinal;
                NoBotao maior = menor == b.NoInicio ? b.NoFinal : b.NoInicio;


                foreach (KeyValuePair<Button, NoBotao> indice in nosBotoes)
                {
                    // indice.Key -> Botão que vai sumir
                    // indice.Value -> NoBotao que possui a posição em si (CentroMatematico)


                    if (!indice.Value.Usado &&

                        (indice.Value.CentroMatematico.Y == coeficiente * indice.Value.CentroMatematico.X + independente
                        && indice.Value.CentroMatematico.X > b.NoInicio.CentroMatematico.X
                        && indice.Value.CentroMatematico.X < b.NoFinal.CentroMatematico.X
                        && indice.Value.CentroMatematico.Y > b.NoInicio.CentroMatematico.Y
                        && indice.Value.CentroMatematico.Y < b.NoFinal.CentroMatematico.Y

                        ||


                        indice.Value.CentroMatematico.Y == coeficiente * indice.Value.CentroMatematico.X + independente
                        && indice.Value.CentroMatematico.X < b.NoFinal.CentroMatematico.X
                        && indice.Value.CentroMatematico.X > b.NoInicio.CentroMatematico.X
                        && indice.Value.CentroMatematico.Y > b.NoFinal.CentroMatematico.Y
                        && indice.Value.CentroMatematico.Y < b.NoInicio.CentroMatematico.Y

                        ||

                        indice.Value.CentroMatematico.X == b.NoFinal.CentroMatematico.X
                        && indice.Value.CentroMatematico.Y > b.NoFinal.CentroMatematico.Y
                        && indice.Value.CentroMatematico.Y < b.NoInicio.CentroMatematico.Y

                        ||

                        indice.Value.CentroMatematico.Y == b.NoFinal.CentroMatematico.Y
                        && indice.Value.CentroMatematico.X > b.NoFinal.CentroMatematico.X
                        && indice.Value.CentroMatematico.X < b.NoInicio.CentroMatematico.X
                        ))

                    {
                        indice.Key.Enabled = false;
                        indice.Key.BackColor = Color.White;
                    }

                }

            }

        }

        private void timerDesenhaBarra_Tick(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}

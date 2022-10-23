using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetoResmat.Classes
{
    public class Barra
    {

        public Point Inicio { get; set; }

        public Point Final { get; set; }

        public float coeficienteReta {get; set;}


        public NoBotao NoInicio { get; set; }

        public NoBotao NoFinal { get; set; }


        public Barra(Point inicio, Point final)
        {
            ValidaMaiorMenor(inicio, final);

            coeficienteReta = (Final.Y - Inicio.Y) / (Final.X - Inicio.X);

        }


        public Barra(Point inicio, Point final, NoBotao noInicio, NoBotao noFinal)
        {
            ValidaMaiorMenor(inicio, final);

            coeficienteReta = (float)(Final.Y - Inicio.Y) / (float)(Final.X - Inicio.X);


            NoInicio = noInicio;
            NoFinal = noFinal;
        }


        private void ValidaMaiorMenor(Point inicio, Point final)
        {
            Inicio = inicio;
            Final = final;

            // Se o x final for maior ou x iguais e o y final maior troca
            if (inicio.X > final.X || inicio.X == final.X && inicio.Y > final.Y)
            {
                Inicio = final;
                Final = inicio;
            }

        }

    }
}

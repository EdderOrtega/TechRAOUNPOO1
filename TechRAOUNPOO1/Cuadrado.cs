using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRAOUNPOO1
{
    internal class Cuadrado: Figura
    {
        public Cuadrado(int xInicial, int yInicial, int ancho, int alto, int color, int relleno)
           : base(1, xInicial, yInicial, ancho, alto, color, relleno)
        {
            this.TipoFigura = 1; // Tipo figura 1 para cuadrado
            this.XInicial = xInicial;
            this.YInicial = yInicial;
            this.Ancho = ancho;
            this.Alto = alto;
            this.Color = color;
            this.Relleno = relleno;
        }
    }
}

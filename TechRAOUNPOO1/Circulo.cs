using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRAOUNPOO1
{
    internal class Circulo : Figura
    {
        public Circulo(int xInicial, int yInicial, int ancho, int alto, int color, int relleno)
        : base(1, xInicial, yInicial, ancho, alto, color, relleno)
        {
            this.TipoFigura = 3;
            this.XInicial = xInicial;
            this.YInicial = yInicial;
            this.Ancho = ancho;
            this.Alto = alto;
            this.Color = color;
            this.Relleno = relleno;
        }

    
    }
}

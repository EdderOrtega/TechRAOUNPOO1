using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRAOUNPOO1
{
    internal class Triangulo
    {
        public int TipoFigura { get; set; }
        public int XInicial { get; set; }
        public int YInicial { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Color { get; set; }
        public int Relleno { get; set; }
        public Triangulo(int xInicial, int yInicial, int ancho, int alto, int color, int relleno)
        {
            this.TipoFigura = 4; // Tipo figura 4 para triángulo
            this.XInicial = xInicial;
            this.YInicial = yInicial;
            this.Ancho = ancho;
            this.Alto = alto;
            this.Color = color;
            this.Relleno = relleno;
        }
    }
}

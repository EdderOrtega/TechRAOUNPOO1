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
            this.TipoFigura = 1;
            this.XInicial = xInicial;
            this.YInicial = yInicial;
            this.Ancho = ancho;
            this.Alto = alto;
            this.Color = color;
            this.Relleno = relleno;
        }

        public void Dibujar()
        {
            Graphics figuraCirculo = Graphics.FromImage(new Bitmap(100, 100));
            figuraCirculo.DrawEllipse(Pens.Black, XInicial, YInicial, Ancho, Alto);

            // Corregir el uso de Color.FromArgb
            SolidBrush miPincel = new SolidBrush(System.Drawing.Color.FromArgb(Color));
            if (Relleno == 1) // Si el relleno está activado
            {
                figuraCirculo.FillEllipse(miPincel, XInicial, YInicial, Ancho, Alto);
            }
            else
            {
                figuraCirculo.DrawEllipse(Pens.Black, XInicial, YInicial, Ancho, Alto);
            }
        }
    }
}

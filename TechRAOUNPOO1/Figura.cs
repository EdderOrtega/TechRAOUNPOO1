using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRAOUNPOO1
{
    internal class Figura
    {
        private int tipoFigura, xInicial, yInicial, ancho, alto, color, relleno;
        public Figura(int tipoFigura, int xInicial, int yInicial, int ancho, int alto, int color, int relleno)
        {
            this.tipoFigura = tipoFigura;
            this.xInicial = xInicial;
            this.yInicial = yInicial;
            this.ancho = ancho;
            this.alto = alto;
            this.color = color;
            this.relleno = relleno;
        }

        public void Dibujar(Graphics g)
        {
            Color selColor = System.Drawing.Color.FromArgb(this.color);

            if (relleno == 1)
            {
                SolidBrush miPincel = new SolidBrush(selColor);

                switch (tipoFigura)
                {
                    case 1:
                        g.FillRectangle(miPincel, xInicial, yInicial, ancho, alto);
                        break;
                    case 2:
                        g.FillEllipse(miPincel, xInicial, yInicial, ancho, alto);
                        break;
                    case 3:
                        g.FillEllipse(miPincel, xInicial, yInicial, ancho, alto);
                        break;
                    case 4:
                        g.FillRectangle(miPincel, xInicial, yInicial, ancho, alto);
                        break;
                    case 6: // Triángulo
                        Point[] puntosTri = {
                        new Point(xInicial + ancho / 2, yInicial),
                        new Point(xInicial, yInicial + alto),
                        new Point(xInicial + ancho, yInicial + alto)
                    };
                        g.FillPolygon(miPincel, puntosTri);
                        break;
                    case 7: // Pentágono
                        Point[] puntosPenta = {
                        new Point(xInicial + ancho / 2, yInicial),
                        new Point(xInicial + ancho, yInicial + alto / 3),
                        new Point(xInicial + (int)(ancho * 0.8), yInicial + alto),
                        new Point(xInicial + (int)(ancho * 0.2), yInicial + alto),
                        new Point(xInicial, yInicial + alto / 3)
                    };
                        g.FillPolygon(miPincel, puntosPenta);
                        break;
                    case 8: // Rombo
                        Point[] puntosRombo = {
                        new Point(xInicial + ancho / 2, yInicial),
                        new Point(xInicial + ancho, yInicial + alto / 2),
                        new Point(xInicial + ancho / 2, yInicial + alto),
                        new Point(xInicial, yInicial + alto / 2)
                    };
                        g.FillPolygon(miPincel, puntosRombo);
                        break;
                }
            }
            else
            {
                Pen lapiz = new Pen(selColor, 2);

                switch (tipoFigura)
                {
                    case 1: // Cuadrado
                        g.DrawRectangle(lapiz, xInicial, yInicial, ancho, ancho);
                        break;
                    case 2: // Círculo
                        g.DrawEllipse(lapiz, xInicial, yInicial, ancho, ancho);
                        break;
                    case 3: // Elipse
                        g.DrawEllipse(lapiz, xInicial, yInicial, ancho, alto);
                        break;
                    case 4: // Rectángulo
                        g.DrawRectangle(lapiz, xInicial, yInicial, ancho, alto);
                        break;
                    case 5: // Línea
                        g.DrawLine(lapiz, xInicial, yInicial, xInicial + ancho, yInicial + alto);
                        break;
                    case 6: // Triángulo
                        Point[] puntosTri = {
                        new Point(xInicial + ancho / 2, yInicial),
                        new Point(xInicial, yInicial + alto),
                        new Point(xInicial + ancho, yInicial + alto)
                    };
                        g.DrawPolygon(lapiz, puntosTri);
                        break;
                    case 7: // Pentágono
                        Point[] puntosPenta = {
                        new Point(xInicial + ancho / 2, yInicial),
                        new Point(xInicial + ancho, yInicial + alto / 3),
                        new Point(xInicial + (int)(ancho * 0.8), yInicial + alto),
                        new Point(xInicial + (int)(ancho * 0.2), yInicial + alto),
                        new Point(xInicial, yInicial + alto / 3)
                    };
                        g.DrawPolygon(lapiz, puntosPenta);
                        break;
                    case 8: // Rombo
                        Point[] puntosRombo = {
                        new Point(xInicial + ancho / 2, yInicial),
                        new Point(xInicial + ancho, yInicial + alto / 2),
                        new Point(xInicial + ancho / 2, yInicial + alto),
                        new Point(xInicial, yInicial + alto / 2)
                    };
                        g.DrawPolygon(lapiz, puntosRombo);
                        break;
                }
            }
        }


        public int TipoFigura
        {
            get { return tipoFigura; }
            set { tipoFigura = value; }
        }

        public int XInicial
        {
            get { return xInicial; }
            set { xInicial = value; }
        }
        public int YInicial
        {
            get { return yInicial; }
            set { yInicial = value; }
        }
        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public int Alto
        {
            get { return alto; }
            set { alto = value; }
        }
        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Relleno
        {
            get { return relleno; }
            set { relleno = value; }
        }
    }
}

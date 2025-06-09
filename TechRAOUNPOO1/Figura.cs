using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRAOUNPOO1
{
    internal class Figura
    {
        Graphics figura;
        Color colorFig;
        private int tipoFigura, xInicial, yInicial, ancho, alto, color, relleno;
        int[,] arrfiguras;
        int[] figuras = new int[7];


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
            figura = g;
            figura.DrawRectangle(Pens.Black, xInicial, yInicial, ancho, alto);
        }

        // Fixed property syntax  
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

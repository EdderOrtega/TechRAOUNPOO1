using System.Windows.Forms;
using System.Drawing;
namespace TechRAOUNPOO1
{

    public partial class Form1 : Form
    {
        List<Figura> listaFiguras = new List<Figura>();
        Figura figura = new Figura(-1, -1, -1, -1, -1, Color.Black.ToArgb(), 0);
        Figura contornoFig = new Figura(-1, -1, -1, -1, -1, Color.Gray.ToArgb(), 0);
        Graphics papel;
        PointF PuntoIni = new PointF();
        PointF PuntoFin = new PointF();
        int swrelleno = 0;
        int swseleccionar = 0;
        int swcont = 0;
        private Font currentFont = new Font("Microsoft Sans Serif", 8.25F);
        int indfiguras;
        private Color currentColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            papel = picPaint.CreateGraphics();
            figura.Color = Color.Black.ToArgb();
            figura.Relleno = 0;
        }

        private void RedibujarFiguras()
        {
            Graphics g = picPaint.CreateGraphics();
            picPaint.Refresh();

            foreach (Figura f in listaFiguras)
            {
                f.Dibujar(g);
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 2;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 5;
        }


        private void btnSelectorDeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = currentColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                btnSelectorDeColor.BackColor = currentColor;
                figura.Color = currentColor.ToArgb();
            }
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = currentFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFont = fontDialog1.Font;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picPaint.Refresh();
            picPaint.BackColor = Color.White;
        }

        private void btnRelleno_Click_1(object sender, EventArgs e)
        {
            // Cambia entre relleno activado (1) y desactivado (0)
            swrelleno = (swrelleno == 0) ? 1 : 0;

            // Actualiza en el objeto figura actual
            figura.Relleno = swrelleno;

            // Cambia el ícono para dar retroalimentación visual (si aplica)
            btnRelleno.BackColor = (swrelleno == 1) ? Color.LightGreen : SystemColors.Control;
        }

        private void btnMarcador_Click(object sender, EventArgs e)
        {

        }

        private void btnLupa_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {

        }
        //FIGURAS
        private void btnLapiz_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 0; // Tipo figura 0 para lápiz
        }
        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 1;
        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 7;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 6;

        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 4;
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {
            figura.TipoFigura = 8;
        }
        //COLORES
        private void btnColorNegro_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorBlanco_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorGris_Click(object sender, EventArgs e)
        {
            currentColor = Color.Gray;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorGrisClaro_Click(object sender, EventArgs e)
        {
            currentColor = Color.DarkGray;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorRojoOscuro_Click(object sender, EventArgs e)
        {
            currentColor = Color.DarkRed;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorCafe_Click_1(object sender, EventArgs e)
        {
            currentColor = Color.Peru;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorRojo_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorRosa_Click(object sender, EventArgs e)
        {
            currentColor = Color.Pink;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorNaranja_Click(object sender, EventArgs e)
        {
            currentColor = Color.DarkOrange;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorOro_Click(object sender, EventArgs e)
        {
            currentColor = Color.Goldenrod;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorAmarillo_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorBeige_Click(object sender, EventArgs e)
        {
            currentColor = Color.Bisque;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorVerde_Click(object sender, EventArgs e)
        {
            currentColor = Color.ForestGreen;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorVerdeClaro_Click(object sender, EventArgs e)
        {
            currentColor = Color.GreenYellow;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorCeleste_Click(object sender, EventArgs e)
        {
            currentColor = Color.DeepSkyBlue;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorCelesteClaro_Click(object sender, EventArgs e)
        {
            currentColor = Color.LightBlue;
            btnSelectorDeColor.BackColor = currentColor;

        }

        private void btnColorAzulMarino_Click(object sender, EventArgs e)
        {
            currentColor = Color.RoyalBlue;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorAzulClaro_Click(object sender, EventArgs e)
        {
            currentColor = Color.CornflowerBlue;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorMorado_Click(object sender, EventArgs e)
        {
            currentColor = Color.MediumOrchid;
            btnSelectorDeColor.BackColor = currentColor;
        }

        private void btnColorLila_Click(object sender, EventArgs e)
        {
            currentColor = Color.Thistle;
            btnSelectorDeColor.BackColor = currentColor;
        }
        //submenu de figuras
        private void btnSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {

        }

        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (swseleccionar == 0)
            {
                figura.XInicial = e.X;
                figura.YInicial = e.Y;

                PuntoIni.X = e.X;
                PuntoIni.Y = e.Y;

                swcont = 1;
            }
        }

        private void picPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (swcont == 1 && swseleccionar == 0)
            {
                int xini = (int)PuntoIni.X;
                int yini = (int)PuntoIni.Y;
                int ancho = Math.Abs(e.X - xini);
                int alto = Math.Abs(e.Y - yini);
                if (e.X < xini) xini = e.X;
                if (e.Y < yini) yini = e.Y;
                contornoFig.XInicial = xini;
                contornoFig.YInicial = yini;
                contornoFig.Ancho = ancho;
                contornoFig.Alto = (figura.TipoFigura == 1 || figura.TipoFigura == 2) ? ancho : alto;
                contornoFig.TipoFigura = figura.TipoFigura;
                contornoFig.Relleno = 0;
                contornoFig.Color = Color.Gray.ToArgb();
                RedibujarFiguras();
                contornoFig.Dibujar(picPaint.CreateGraphics());
            }
        }

        private void picPaint_MouseUp(object sender, MouseEventArgs e)
        {
            if (swseleccionar == 0)
            {
                swcont = 0;

                int xini = figura.XInicial;
                int yini = figura.YInicial;
                int xfin = e.X;
                int yfin = e.Y;

                if (xfin < xini) { int temp = xini; xini = xfin; xfin = temp; }
                if (yfin < yini) { int temp = yini; yini = yfin; yfin = temp; }

                int ancho = Math.Abs(xfin - xini);
                int alto = Math.Abs(yfin - yini);

                figura.XInicial = xini;
                figura.YInicial = yini;
                figura.Ancho = ancho;
                figura.Alto = (figura.TipoFigura == 1 || figura.TipoFigura == 2) ? ancho : alto;

                Figura nuevaFigura = new Figura(
                    figura.TipoFigura,
                    figura.XInicial,
                    figura.YInicial,
                    figura.Ancho,
                    figura.Alto,
                    figura.Color,
                    figura.Relleno
                );

                listaFiguras.Add(nuevaFigura);
                RedibujarFiguras();
            }
        }

     
    }
}

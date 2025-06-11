using System.Windows.Forms;
using System.Drawing;
namespace TechRAOUNPOO1
{

    public partial class Form1 : Form
    {
        private Color currentColor = Color.Black;
        private Font currentFont = new Font("Microsoft Sans Serif", 8.25F);

        public Form1()
        {

            InitializeComponent();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnColorCafe_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectorDeColor_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = currentColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                btnSelectorDeColor.BackColor = currentColor;
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
    }
}

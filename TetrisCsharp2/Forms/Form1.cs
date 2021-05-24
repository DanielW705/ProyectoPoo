using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisCsharp2.Models;

namespace TetrisCsharp2
{
    public partial class Form1 : Form
    {
        Juego main;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            main = new Juego(PanelJuego, MovPiesas);
            main.IniciarJuego();
            RELOJ.Start();
        }

        public Color GetColor()
        {
            Random r = new Random();
            Color color = new Color();
            color = Color.FromArgb(r.Next(10, 255), r.Next(10, 255), r.Next(100, 255));
            return color;
        }

        private void RELOJ_Tick(object sender, EventArgs e)
        {
            this.BackColor = GetColor();
        }

        private void MovPiesas_Tick(object sender, EventArgs e)
        {
            main.ActualizarTablero();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            main.ActualizarTablero(e.KeyCode);

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            main.VolverANormalidad(e.KeyCode);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}

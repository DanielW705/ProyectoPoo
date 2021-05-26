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
        #region variables globales
        Juego main;
        #endregion
        #region constructores
        // constructor del formulario
        public Form1()
        {
            InitializeComponent();

        }
        #endregion
        #region eventos
        // Envento de la construccion del form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Aqui creamos nuestro objeto que es el juego que controla el panel (donde salen los tetriminos)
            main = new Juego(PanelJuego, MovPiesas);
            // Inicia el metodo para iniciar el juego
            main.IniciarJuego();
            // inicia el reloj o timer para que pase el tiempo
            RELOJ.Start();
        }
        // Cada vez que pase un intervalo de 2000ms o 2S y actualiza el tablero
        private void MovPiesas_Tick(object sender, EventArgs e)
        {
            // actualiza el tablero
            main.ActualizarTablero();
        }

            // Si se presiona una tecla, va a mandar a llamar este evento
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // va a actualizar el tablero, y le va a mandar la tecla picada
            main.ActualizarTablero(e.KeyCode);
        }
        // cuando se levante esta tecla, va a llamar este evento
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // va a mandar la tecla levantada
            main.VolverANormalidad(e.KeyCode);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class Jugador
    {
        private static Guid id { get; set; }
        private static string nombreJugador { get; set; }
        private double puntosActuales { get; set; }
        private Label[] puntosAnteriores { get; set; }
        private double partidasJugadas { get; set; }
        private double puntosMaximos { get; set; }
        private static BaseDeDatos conexionBD;
        Jugador(string _nombre)
        {
            id = Guid.NewGuid();
            nombreJugador = _nombre;
            conexionBD = new BaseDeDatos();
        }
        ~Jugador()
        {

        }
        public void MensajeDeError()
        {
            if (!conexionBD.MensajesDeConexion.Conexion)
            {
                DialogResult resultado = MessageBox.Show($"No se a podido conectar a la base porque: {conexionBD.MensajesDeConexion.Mensaje}", "Error de Conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (resultado == DialogResult.Retry)
                {
                    conexionBD = new BaseDeDatos();
                    MensajeDeError();
                }
            }
            else
            {
                MessageBox.Show("Se subira a la nube todos sus datos", "Conexion con la nube lograda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool GuardarEnLaBDPuntiacionActual()
        {
            if (conexionBD.MensajesDeConexion.Conexion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CambiarAjustes()
        {

        }
    }
}

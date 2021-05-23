using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SQL
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class BaseDeDatos
    {
        private SqlCommand comando;
        private SqlDataReader lector;
        private SqlDataAdapter adaptador;
        private static SqlConnection conexion;
        private static Guid id;
        private static string nombreJugador;
        public (bool Conexion, string Mensaje) MensajesDeConexion = (Conexion: false, Mensaje: string.Empty);
        private (bool, string) intentarConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionDefault"].ToString();
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                conexion.Close();
                return (true, string.Empty);
            }
            catch (SqlException e)
            {
                return (false, e.Message);
            }

        }
        public BaseDeDatos()
        {
            MensajesDeConexion = intentarConexion();
        }
        public BaseDeDatos(Guid _id)
        {
            MensajesDeConexion = intentarConexion();
            id = _id;
        }
        public double CalcularMaximo()
        {
            double res = 0;
            if (this.MensajesDeConexion.Conexion)
            {
                conexion.Open();
                using (comando = new SqlCommand($"Select SUM(Points) as 'Maximo' from Juegos group by ID having ID = '{id}'", conexion))
                {
                    lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        res = double.Parse(lector["Maximo"].ToString());
                    }
                    conexion.Close();
                }
                return res;
            }
            else
            {
                return res;
            }
        }
        public void consultarPuntosAnteriores()//(string[] ganadores, double[] cont) 
        {
            if (this.MensajesDeConexion.Conexion)
            {
                conexion.Open();
                using (comando = new SqlCommand("Select Top 5 TablaJugadores.nombreJugador as 'Jugador', Juegos.Points as 'Puntos', Juegos.DiaDeJuego as 'Fecha Jugada' from Juegos inner join TablaJugadores on Juegos.ID = TablaJugadores.JugadorId order by Juegos.Points desc;", conexion))
                    lector = comando.ExecuteReader();
                while (lector.Read())
                {
                }
                
            }
            else
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TetrisCsharp2.Models
{
    class Juego
    {
        public enum StateTertimno
        {
            vacio = 0,
            bajando = 1,
            estatico = 2
        }
        // Este es el tablero en una matriz de 10 *16
        private StateTertimno[,] tablaDeJuego = new StateTertimno[10, 16];
        private int Volumen;
        // Este es el controlador del Tetrimino
        private Tetrimino TetriminoEnElCampo { get; set; }
        //Aqui esta el tetrimino que se va a guardar
        private Tetrimino TetriminoGuardado;
        // Este Controlaremos el panel, para mandar las cosas
        private Panel InterfazDeJuego;
        //private Timer cambioDeColor;
        private Timer movimientoDelTetrimino;
        // este solo devuelve el la matriz 
        public StateTertimno[,] _tablaDeJuego
        {
            get
            {
                return tablaDeJuego;
            }
        }
        // Este controla el tetrimino en el campo y veremos que hacer con el
        public Tetrimino _TETRIMINOENELCAMPO
        {
            set
            {
                if (_TETRIMINOENELCAMPO != null)
                {
                    TetriminoEnElCampo = _TETRIMINOENELCAMPO;
                }
            }
            get
            {
                return TetriminoEnElCampo;
            }
        }
        //Este es el constructor
        public Juego(Panel _InterfazDelJuego, Timer _movimientoDelTetrimino)
        {
            InterfazDeJuego = _InterfazDelJuego;
            movimientoDelTetrimino = _movimientoDelTetrimino;
        }
        // Este es el destructor
        ~Juego()
        {

        }
        // Aqui se inciara el juego lanzando un primer tetrimino
        public void IniciarJuego()
        {
            LanzarTetrimino();
        }
        // Reliza una comparacion
        public void DetenerTetrimino()
        {
            for (int i = 3; i > -1; i--)
            {
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.estatico;
            }
            this.TetriminoEnElCampo = null;
            movimientoDelTetrimino.Stop();
            LanzarTetrimino();
        }
        public void MoverTetriminoEjeY()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                this.TetriminoEnElCampo._posicion[i].y += 1;
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                int PosX = this.TetriminoEnElCampo._figura[i].Location.X;
                int PosY = this.TetriminoEnElCampo._figura[i].Location.Y;
                this.TetriminoEnElCampo._figura[i].Location = new Point(PosX, PosY + 50);
            }
        }
        public void MoverTetriminoEjeXDerecha()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                this.TetriminoEnElCampo._posicion[i].x += 1;
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                int PosX = this.TetriminoEnElCampo._figura[i].Location.X, PosY = this.TetriminoEnElCampo._figura[i].Location.Y;
                this.TetriminoEnElCampo._figura[i].Location = new Point(PosX + 50, PosY);
            }
        }
        public void MoverTetriminoEjeXIzquierda()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                this.TetriminoEnElCampo._posicion[i].x -= 1;
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                int PosX = this.TetriminoEnElCampo._figura[i].Location.X, PosY = this.TetriminoEnElCampo._figura[i].Location.Y;
                this.TetriminoEnElCampo._figura[i].Location = new Point(PosX - 50, PosY);
            }
        }
        public StateTertimno[] QueHayEnfrente()
        {
            StateTertimno[] estados = new StateTertimno[4];
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                estados[i] = tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y + 1];
            }
            return estados;
        }
        //Aqui realizara acto de aparicion el tetrimino
        public void LanzarTetrimino()
        {
            int rand = new Random().Next(1, 1);
            Tetrimino.TypesOfTetrimino types = (Tetrimino.TypesOfTetrimino)Enum.Parse(typeof(Models.Tetrimino.TypesOfTetrimino), rand.ToString());
            if (types == Tetrimino.TypesOfTetrimino.TetriminoI)
            {
                TetriminoI piezaJugada = new TetriminoI(types);
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoJ)
            {
                TetriminoJ piezaJugada = new TetriminoJ(types);
                this.TetriminoEnElCampo = piezaJugada;

            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoL)
            {
                TetriminoL piezaJugada = new TetriminoL(types);
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoO)
            {
                TetriminoO piezaJugada = new TetriminoO(types);
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoT)
            {
                TetriminoT piezaJugada = new TetriminoT(types);
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoZ)
            {
                TetriminoZ piezaJugada = new TetriminoZ(types);
                this.TetriminoEnElCampo = piezaJugada;
            }
            this.InterfazDeJuego.Controls.AddRange(this.TetriminoEnElCampo._figura);
            foreach ((int, int) tupla in TetriminoEnElCampo._posicion)
            {
                tablaDeJuego[tupla.Item1, tupla.Item2] = StateTertimno.bajando;
            }
            //movimientoDelTetrimino.Start();
        }
        // Aqui se debe actualizar el tablero
        public void ActualizarTablero(Keys tecla = Keys.NoName)
        {
            if (tecla == Keys.W || tecla == Keys.Up)
            {
                movimientoDelTetrimino.Interval = 1500;
            }
            else if (tecla == Keys.S || tecla == Keys.Down)
            {
                movimientoDelTetrimino.Interval = 200;
            }
            else if (tecla == Keys.A || tecla == Keys.Left)
            {
                int MinX = TetriminoEnElCampo._posicion.Select(tuple => tuple.x).ToArray().Min();
                if (MinX > 0)
                {
                    MoverTetriminoEjeXIzquierda();
                }
            }
            else if (tecla == Keys.D || tecla == Keys.Right)
            {
                int MaXx = TetriminoEnElCampo._posicion.Select(tuple => tuple.x).ToArray().Max();
                if (MaXx < 9)
                {
                    MoverTetriminoEjeXDerecha();
                }
            }
            else if (tecla == Keys.Space)
            {
                for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
                {
                    tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                }
                this.TetriminoEnElCampo.cambiarPos();
                for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
                {
                    tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                }
            }
            else
            {
                StateTertimno[] estadosActual = QueHayEnfrente();
                int Maxy = TetriminoEnElCampo._posicion.Select(tuple => tuple.y).ToArray().Max();

                if (Maxy < 14 &&
                    estadosActual[0] != StateTertimno.estatico && estadosActual[1] != StateTertimno.estatico && estadosActual[2] != StateTertimno.estatico && estadosActual[3] != StateTertimno.estatico)
                {
                    MoverTetriminoEjeY();
                }
                else if (Maxy < 14 &&
                    (estadosActual[0] == StateTertimno.estatico || estadosActual[1] == StateTertimno.estatico || estadosActual[2] == StateTertimno.estatico || estadosActual[3] == StateTertimno.estatico))
                {
                    DetenerTetrimino();
                }
                else if (Maxy == 14)
                {
                    MoverTetriminoEjeY();
                    DetenerTetrimino();
                }
            }
        }
        public void VolverANormalidad(Keys tecla = Keys.NoName)
        {
            if (tecla == Keys.W || tecla == Keys.Up)
            {
                movimientoDelTetrimino.Interval = 500;
            }
            else if (tecla == Keys.S || tecla == Keys.Down)
            {
                movimientoDelTetrimino.Interval = 500;
            }
        }
        // Aqui se guarda.... por desarrollar
        public void GuardarTetrimino()
        {

        }
    }

}




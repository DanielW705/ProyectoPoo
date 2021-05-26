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
        #region variable globales
        // este enumerable se usa para que en el mapa se detecta si se esta moviendo o no
        public enum StateTertimno
        {
            vacio = 0,
            bajando = 1,
            estatico = 2
        }
        #endregion
        #region attributos
        // Este es el tablero en una matriz de 10 *16
        private StateTertimno[,] tablaDeJuego = new StateTertimno[10, 16];
        private int Volumen;
        // Este atributo ya que es abstracto, solo quiero el tetrimino que esta jugando ahorita
        private Tetrimino TetriminoEnElCampo { get; set; }
        //Aqui esta el tetrimino que se va a guardar
        private Tetrimino TetriminoGuardado;
        // Este Controlaremos el panel, para mostrar y lanzar los tetrimino
        private Panel InterfazDeJuego;
        //Este reloj lo controla el movimiento de las piezas;
        private Timer movimientoDelTetrimino;
        #endregion
        #region constructor
        //Este es el constructor obtiene el panel y el reloj o Timer
        public Juego(Panel _InterfazDelJuego, Timer _movimientoDelTetrimino)
        {
            InterfazDeJuego = _InterfazDelJuego;
            movimientoDelTetrimino = _movimientoDelTetrimino;
        }
        // Este es el destructor
        ~Juego()
        {

        }
        #endregion
        #region metodos o funciones
        //Aqui Se toma aleatoriamente que tetrimino se va a usar y cual se va a lanzar
        public void LanzarTetrimino()
        {
            int rand = new Random().Next(2, 2);
            // Aqui se selecciona aleatoriamente el numero del tetrimino
            // En C++ es un "rand() % 6 + 1" para que de un aleatorio 
            //int rand = new Random().Next(1, 6);
            // Aqui se hace parceo de int al enumerable, no le hagan CASO
            Tetrimino.TypesOfTetrimino types = (Tetrimino.TypesOfTetrimino)Enum.Parse(typeof(Models.Tetrimino.TypesOfTetrimino), rand.ToString());
            // Envez de comparar enumerables, haganlo con numeros
            if (types == Tetrimino.TypesOfTetrimino.TetriminoI)
            {
                // Se crea el nuevo tetrimino
                TetriminoI piezaJugada = new TetriminoI(types);
                // Se guarda en la variable, diciendo que esta en el campo
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoJ)
            {
                // Se crea el nuevo tetrimino
                TetriminoJ piezaJugada = new TetriminoJ(types);
                // Se guarda en la variable, diciendo que esta en el campo
                this.TetriminoEnElCampo = piezaJugada;

            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoL)
            {
                // Se crea el nuevo tetrimino
                TetriminoL piezaJugada = new TetriminoL(types);
                // Se guarda en la variable, diciendo que esta en el campo
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoO)
            {
                // Se crea el nuevo tetrimino
                TetriminoO piezaJugada = new TetriminoO(types);
                // Se guarda en la variable, diciendo que esta en el campo
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoT)
            {
                // Se crea el nuevo tetrimino
                TetriminoT piezaJugada = new TetriminoT(types);
                // Se guarda en la variable, diciendo que esta en el campo
                this.TetriminoEnElCampo = piezaJugada;
            }
            else if (types == Tetrimino.TypesOfTetrimino.TetriminoZ)
            {
                // Se crea el nuevo tetrimino
                TetriminoZ piezaJugada = new TetriminoZ(types);
                // Se guarda en la variable, diciendo que esta en el campo
                this.TetriminoEnElCampo = piezaJugada;
            }
            // LLama al panel, y le agrega los label al panel
            this.InterfazDeJuego.Controls.AddRange(this.TetriminoEnElCampo._figura);
            //El for each dice que por cada objeto (en este caso una tupla), en este caso en el arreglo
            foreach ((int, int) tupla in TetriminoEnElCampo._posicion)
            {
                // En la matriz en la ubicacion de la creacion va a decir que 
                tablaDeJuego[tupla.Item1, tupla.Item2] = StateTertimno.bajando;
            }
            // Aqui inicia el conteo el reloj
            movimientoDelTetrimino.Start();
        }
        // Aqui se inciara el juego lanzando un primer tetrimino
        public void IniciarJuego()
        {
            LanzarTetrimino();
        }
        // En esta parte detiene el tetrimino
        public void DetenerTetrimino()
        {
            // El ciclo inicia de abajo hacia arriba
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                // En cada posicion le cambia el estado
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.estatico;
            }
            // Borra el tetrimino en el campo
            this.TetriminoEnElCampo = null;
            //Detiene el reloj
            movimientoDelTetrimino.Stop();
            // Vuelve a lanzar el tetrimino
            LanzarTetrimino();
        }
        // Con esta funcion mueve el tetrimino en eje Y
        public void MoverTetriminoEjeY()
        {
            // Otra vez va de abajo hacia arriba
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                // En la posicion anterior lo pone que esta vacio
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                // Mueve el tetrimino en el eje Y osea hacia abajo
                this.TetriminoEnElCampo._posicion[i].y += 1;
                // En la nueva posicion se cambia de vacio a bajando
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                // Se sacan de la estructura el atributo x y y
                int PosX = this.TetriminoEnElCampo._figura[i].Location.X;
                int PosY = this.TetriminoEnElCampo._figura[i].Location.Y;
                // Se crea una nueva estructura y mediante el constructor se pasa parametros
                this.TetriminoEnElCampo._figura[i].Location = new Point(PosX, PosY + 50);
            }
        }
        public void MoverTetriminoEjeXDerecha()
        {
            // Va de abajo hacia arriaba
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                // En la posicion anterior lo pone que esta vacio
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                // Mueve el tetrimino en el eje X osea hacia la derecha
                this.TetriminoEnElCampo._posicion[i].x += 1;
                // En la nueva posicion se cambia de vacio a bajando
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                // Se sacan de la estructura el atributo x y y
                int PosX = this.TetriminoEnElCampo._figura[i].Location.X, PosY = this.TetriminoEnElCampo._figura[i].Location.Y;
                // Se crea una nueva estructura y mediante el constructor se pasa parametros
                this.TetriminoEnElCampo._figura[i].Location = new Point(PosX + 50, PosY);
            }
        }
        public void MoverTetriminoEjeXIzquierda()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                // En la posicion anterior lo pone que esta vacio
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.vacio;
                // Mueve el tetrimino en el eje X osea hacia la izquierda
                this.TetriminoEnElCampo._posicion[i].x -= 1;
                // En la nueva posicion se cambia de vacio a bajando
                tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y] = StateTertimno.bajando;
                // Se sacan de la estructura el atributo x y y
                int PosX = this.TetriminoEnElCampo._figura[i].Location.X, PosY = this.TetriminoEnElCampo._figura[i].Location.Y;
                // Se crea una nueva estructura y mediante el constructor se pasa parametros
                this.TetriminoEnElCampo._figura[i].Location = new Point(PosX - 50, PosY);
            }
        }
        // Deberia de detectar si hay algo enfrente pero tiene errores
        public bool SePuedeBajar()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                if (tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x, this.TetriminoEnElCampo._posicion[i].y + 1] == StateTertimno.estatico)
                {
                    return true;
                }
            }
            return false;
        }
        public bool QueHayALaDerecha()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                if (tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x + 1, this.TetriminoEnElCampo._posicion[i].y] == StateTertimno.estatico)
                {
                    return true;
                }
            }
            return false;
        }
        public bool QueHayALaIzquierda()
        {
            for (int i = this.TetriminoEnElCampo._posicion.Length - 1; i > -1; i--)
            {
                if (tablaDeJuego[this.TetriminoEnElCampo._posicion[i].x - 1, this.TetriminoEnElCampo._posicion[i].y] == StateTertimno.estatico)
                {
                    return true;
                }
            }
            return false;
        }
        // En este metodo se va actualizando el tablero
        public void ActualizarTablero(Keys tecla = Keys.NoName)
        {
            //Si presiona la tecla W o flecha arriba, el intervalo va a ser mas largo
            if (tecla == Keys.W || tecla == Keys.Up)
            {
                //Se cambia el intervalo 
                movimientoDelTetrimino.Interval = 1500;
            }
            // Si es hacia abajo va a ser mas corto
            else if (tecla == Keys.S || tecla == Keys.Down)
            {
                // Se cambia el intervalo
                movimientoDelTetrimino.Interval = 10;
            }
            else if (tecla == Keys.A || tecla == Keys.Left)
            {
                // Se usa Linq pra sacar el minimo del arreglo y se selecciona algo
                // link para linq: https://www.codeproject.com/Articles/488177/cpplinq-LINQ-Query-Operators-for-Cplusplus-Sequenc
                int MinX = TetriminoEnElCampo._posicion.Select(tuple => tuple.x).ToArray().Min();
                //Si detecta uno a la izquierda ya no deja moverse
                if (MinX > 0 && !QueHayALaIzquierda())
                {
                    MoverTetriminoEjeXIzquierda();
                }
            }
            else if (tecla == Keys.D || tecla == Keys.Right)
            {
                // Se usa Linq pra sacar el minimo del arreglo y se selecciona algo
                // link para linq: https://www.codeproject.com/Articles/488177/cpplinq-LINQ-Query-Operators-for-Cplusplus-Sequenc
                int MaXx = TetriminoEnElCampo._posicion.Select(tuple => tuple.x).ToArray().Max();
                //Si detecta uno a la derecha ya no deja moverse
                if (MaXx < 9 && !QueHayALaDerecha())
                {
                    MoverTetriminoEjeXDerecha();
                }
            }
            else if (tecla == Keys.Space)
            {
                //Si teclea el espacio, rota y cambia todo
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
                //En esta parete baja
                int Maxy = TetriminoEnElCampo._posicion.Select(tuple => tuple.y).ToArray().Max();
                if (Maxy < 14 && !SePuedeBajar())
                {
                    MoverTetriminoEjeY();
                }
                else if (Maxy < 14 && SePuedeBajar())
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
        // Con este si se levanta, la tecla se baja
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
    #endregion
}




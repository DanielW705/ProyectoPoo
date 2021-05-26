using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    public class Tetrimino
    {
        #region variables globales
        // En este enumerable se usa para determinar la poscicion del tetrimino
        public enum Positions
        {
            Top = 1,
            rigth = 2,
            down = 3,
            left = 4
        }
        //En este enumerable se usa para determinar el tipo de tetrimino
        public enum TypesOfTetrimino
        {
            TetriminoI = 1,
            TetriminoJ = 2,
            TetriminoL = 3,
            TetriminoO = 4,
            TetriminoT = 5,
            TetriminoZ = 6
        }
        #endregion
        #region attributos
        // Se usa un label para que se pueda dibujar en el panel
        // Esto es C++ se hace con un puntero
        protected Label[] figura = new Label[4];
        // Se determina la posicion actual del tetrimino 
        protected Positions positions;
        // Se da el tipo de tetrimino
        protected TypesOfTetrimino tipos;
        // Se usa un arreglo de tuplas para las posiciones en X y Y
        // en C++ el objeto tupla es Tuple link: https://www.geeksforgeeks.org/tuples-in-c/
        // En c++ recomendo usar un puntero de variables 
        protected (int x, int y)[] posicion = new (int x, int y)[4];
        // Este es el getter y el setter
        // link:https://www.w3schools.com/cpp/cpp_encapsulation.asp
        public (int x, int y)[] _posicion
        {
            get
            {
                return posicion;
            }
            set
            {
                posicion = _posicion;
            }
        }
        // igual getter y setters
        public Label[] _figura
        {
            get
            {
                return figura;
            }
            set
            {
                figura = _figura;
            }
        }
        #endregion
        #region metodos o funciones
        // Esta funcion virtual, se debe inicializar si o si
        // En C++ puede ser void y que modifique el valor, sino que regrese un puntero de arreglos
        public virtual Label[] constuirTetrimino()
        {
            return null;
        }
        // Otra clase virtual
        public virtual void cambiarPos()
        {

        }
        // En esta funcion se obiene un color a lo loco 
        public Color GetColor()
        {
            // En C++ el objeto random necesita una libreria 
            //link : https://www.cplusplus.com/reference/cstdlib/rand/
            Random r = new Random();
            // para este random es "rand() % 255" para que vaya de un rango aleatorio de 0 a 255
            return Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
        #endregion
        #region constructores
        //Este es el constructor
        public Tetrimino(TypesOfTetrimino _tipos)
        {
            this.tipos = _tipos;
            this.positions = Positions.Top;
        }
        #endregion
    }
}

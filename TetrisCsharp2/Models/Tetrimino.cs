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
        public enum Positions
        {
            Top = 1,
            rigth = 2,
            down = 3,
            left = 4
        }
        public enum TypesOfTetrimino
        {
            TetriminoI = 1,
            TetriminoJ = 2,
            TetriminoL = 3,
            TetriminoO = 4,
            TetriminoT = 5,
            TetriminoZ = 6
        }
        protected Label[] figura = new Label[4];
        protected Positions positions;
        protected TypesOfTetrimino tipos;
        protected (int x, int y)[] posicion = new (int x, int y)[4];
        public virtual Label[] constuirTetrimino()
        {
            return null;
        }
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
        public virtual void cambiarPos()
        {

        }
        public Color GetColor()
        {
            Random r = new Random();
            return Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
        public Tetrimino(TypesOfTetrimino _tipos)
        {
            this.tipos = _tipos;
            this.positions = Positions.Top;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class TetriminoJ : Tetrimino
    {
        #region constructor
        public TetriminoJ(TypesOfTetrimino _tipos = TypesOfTetrimino.TetriminoJ) : base(_tipos)
        {
            this.figura = this.constuirTetrimino();
        }
        #endregion
        #region metodos o funciones
        // En esta parte se sobre escribe la funcion original y se construye el tetrimino dependiendo del tipo que es
        public override Label[] constuirTetrimino()
        {
            Label[] tetrimino = new Label[4];
            for (int i = 0; i < tetrimino.Length; i++)
            {
                Label pieza = new Label();
                pieza.Size = new Size(50, 50);
                pieza.Location = (i == 3 ? new Point(150, 0 + ((i - 1) * 50)) : new Point(200, 0 + (i * 50)));
                pieza.BackColor = GetColor();
                pieza.Enabled = false;
                this.posicion[i] = (i == 3 ? (3, 0 + ((i - 1) * 1)) : (4, 0 + (i * 1)));
                tetrimino[i] = pieza;
            }
            return tetrimino;
        }
        // En esta parte se vuelve a sobre escribir la funcion para que se cambie los valores y la posicion en x y y del tetrimino para que este rote
        public override void cambiarPos()
        {
            int MaxY = this.posicion.Select(tupla => tupla.y).ToArray().Max();
            int MinY = this.posicion.Select(tupla => tupla.y).ToArray().Min();
            int MaxX = this.posicion.Select(tupla => tupla.x).ToArray().Max();
            int MinX = this.posicion.Select(tupla => tupla.x).ToArray().Min();
            (int x, int y) puntosMedios = (x: ((MaxX + MinX) / 2), y: ((MaxY + MinY) / 2));
            if (this.positions == Positions.Top)
            {
                for (int i = 0; i < this.figura.Length; i++)
                {
                    this.posicion[i] = (i == 3 ? (MinX, (MaxY + 1 - i)) : ((MaxX + 1 - i), puntosMedios.y));
                    this.figura[i].Location = (i == 3 ? new Point(MinX * 50, (MaxY + 1 - i) * 50) : new Point((MaxX + 1 - i) * 50, puntosMedios.y * 50));
                }
                this.positions = Positions.rigth;
            }
            if (this.positions == Positions.rigth)
            {
                for (int i = 0; i < this.figura.Length; i++)
                {
                }
                this.positions = Positions.down;
            }
            else if (this.positions == Positions.down)
            {
                for (int i = 0; i < this.figura.Length; i++)
                {
                    this.posicion[i] = (i == 3 ? (MinX, (MaxY + 1 - i)) : ((MaxX + 1 - i), puntosMedios.y));
                    this.figura[i].Location = (i == 3 ? new Point(MinX * 50, (MaxY + 1 - i) * 50) : new Point((MaxX + 1 - i) * 50, puntosMedios.y * 50));
                }
                this.positions = Positions.left;
            }
        }
        #endregion
    }
}

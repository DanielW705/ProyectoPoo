using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class TetriminoO : Tetrimino
    {
        public TetriminoO(TypesOfTetrimino _tipos = TypesOfTetrimino.TetriminoO) : base(_tipos)
        {
            this.figura = constuirTetrimino();
        }
        public override Label[] constuirTetrimino()
        {
            Label[] tetrimino = new Label[4];
            for (int i = 0; i < tetrimino.Length; i++)
            {
                Label pieza = new Label();
                pieza.Size = new Size(50, 50);
                pieza.Location = (i < 2 ? new Point(200 + (i * 50), 0) : new Point(200 + ((i - 2) * 50), 50));
                pieza.BackColor = GetColor();
                pieza.Enabled = false;
                this.posicion[i] = (i < 2 ? (4 + (i * 1), 1) : (4 + ((i - 2) * 1), 0));
                tetrimino[i] = pieza;
            }
            return tetrimino;
        }
    }
}

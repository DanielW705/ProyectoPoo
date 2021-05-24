using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class TetriminoT : Tetrimino
    {
        public TetriminoT(TypesOfTetrimino _tipos = TypesOfTetrimino.TetriminoT) : base(_tipos)
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
                pieza.Location = (i < 3 ? new Point(150 + (i * 50), 50) : new Point(200, 0));
                pieza.BackColor = GetColor();
                pieza.Enabled = false;
                this.posicion[i] = (i < 3 ? (3 + (i * 1), 1) : (4, 0));
                tetrimino[i] = pieza;
            }
            return tetrimino;
        }
        public void CambiarPos()
        {

        }
    }
}

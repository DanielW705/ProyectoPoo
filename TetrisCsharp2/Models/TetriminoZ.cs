using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class TetriminoZ : Tetrimino
    {
        public TetriminoZ(TypesOfTetrimino _tipos = TypesOfTetrimino.TetriminoZ) : base(_tipos)
        {
            this.figura = this.constuirTetrimino();
        }
        // Este construye los tetriterminos debe "sobre escribir" la funcion base
        public override Label[] constuirTetrimino()
        {
            Label[] tetrimino = new Label[4];
            for (int i = 0; i < tetrimino.Length; i++)
            {
                Label pieza = new Label();
                pieza.Size = new Size(50, 50);
                pieza.Location = (i < 2 ? new Point(150 + (i * 50), 0) : new Point(150 + ((i - 1) * 50), 50));
                pieza.BackColor = GetColor();
                pieza.Enabled = false;
                this.posicion[i] = (i < 2 ? (3 + (i * 1), 0) : (3 + ((i - 1) * 1), 1));
                tetrimino[i] = pieza;
            }
            return tetrimino;
        }
    }
}

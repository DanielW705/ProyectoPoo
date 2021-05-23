using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCsharp2.Models
{
    class TetriminoI : Tetrimino
    {
        public TetriminoI(TypesOfTetrimino _tipos = TypesOfTetrimino.TetriminoI) : base(_tipos)
        {
            this.figura = constuirTetrimino();
        }
        public override Label[] constuirTetrimino()
        {
            Label[] tetrimino = new Label[4];
            for (int i = tetrimino.Length - 1; i > -1; i--)
            {
                Label pieza = new Label();
                pieza.Size = new Size(50, 50);
                pieza.Location = new Point(200, 0 + (i * 50));
                pieza.BackColor = GetColor();
                pieza.Enabled = false;
                this.posicion[i] = (4, 0 + (i * 1));
                tetrimino[i] = pieza;
            }
            return tetrimino;
        }
        public override void cambiarPos()
        {
            int MaxY = this.posicion.Select(tupla => tupla.y).ToArray().Max();
            int MinY = this.posicion.Select(tupla => tupla.y).ToArray().Min();
            int MaxX = this.posicion.Select(tupla => tupla.x).ToArray().Max();
            int MinX = this.posicion.Select(tupla => tupla.x).ToArray().Min();
            if (this.positions == Positions.Top)
            {
                if (MaxX == 9 && MinX == 9)
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = ((MinX - i), MinY);
                        this.figura[i].Location = new Point((MinX - i) * 50, MinY * 50);
                    }
                }
                else if (MaxX >= 7 && MinX >= 7 && MaxX <= 8 && MinX <= 8)
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = (i == 1 ? (MinX, MinY + 1) : (MinX + i - 1, MinY + 1));
                        this.figura[i].Location = (i == 1 ? new Point(MinX * 50, (MinY + 1) * 50) : new Point((MinX + i - 1) * 50, (MinY + 1) * 50));
                    }
                }
                else
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = ((MinX + i), MinY);
                        this.figura[i].Location = new Point((MinX + i) * 50, MinY * 50);
                    }
                }
                this.positions = Positions.rigth;
            }
            else if (this.positions == Positions.rigth)
            {
                if (MaxX == 9)
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = (MaxX, (MinY + i));
                        this.figura[i].Location = new Point(MaxX * 50, (MinY + i) * 50);
                    }
                }
                else
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = (MinX, (MinY + i));
                        this.figura[i].Location = new Point(MinX * 50, (MinY + i) * 50);
                    }
                }
                this.positions = Positions.down;
            }
            else if (this.positions == Positions.down)
            {
                if (MaxX == 9)
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = ((MinX - i), MinY);
                        this.figura[i].Location = new Point((MinX - i) * 50, MinY * 50);
                    }
                }
                else if (MaxX >= 7 && MinX >= 7 && MaxX <= 8 && MinX <= 8)
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = (i == 1 ? (MinX, MinY + 1) : (MinX + i - 1, MinY + 1));
                        this.figura[i].Location = (i == 1 ? new Point(MinX * 50, (MinY + 1) * 50) : new Point((MinX + i - 1) * 50, (MinY + 1) * 50));
                    }
                }
                else
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = ((MinX + i), MinY);
                        this.figura[i].Location = new Point((MinX + i) * 50, MinY * 50);
                    }
                }
                this.positions = Positions.left;
            }
            else if (this.positions == Positions.left)
            {
                if (MaxX == 9)
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = (MaxX, (MinY + i));
                        this.figura[i].Location = new Point(MaxX * 50, (MinY + i) * 50);
                    }
                }
                else
                {
                    for (int i = 0; i < this.figura.Length; i++)
                    {
                        this.posicion[i] = (MinX, (MinY + i));
                        this.figura[i].Location = new Point(MinX * 50, (MinY + i) * 50);
                    }
                }
                this.positions = Positions.Top;
            }
        }
    }
}

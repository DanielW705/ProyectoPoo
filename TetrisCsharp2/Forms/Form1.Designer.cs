
namespace TetrisCsharp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RELOJ = new System.Windows.Forms.Timer(this.components);
            this.MovPiesas = new System.Windows.Forms.Timer(this.components);
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.lvly9 = new System.Windows.Forms.Label();
            this.lvly8 = new System.Windows.Forms.Label();
            this.lvly7 = new System.Windows.Forms.Label();
            this.lvly6 = new System.Windows.Forms.Label();
            this.lvly5 = new System.Windows.Forms.Label();
            this.lvly4 = new System.Windows.Forms.Label();
            this.lvly3 = new System.Windows.Forms.Label();
            this.lvly2 = new System.Windows.Forms.Label();
            this.tlvly1 = new System.Windows.Forms.Label();
            this.RIGTH = new System.Windows.Forms.Label();
            this.LEFT = new System.Windows.Forms.Label();
            this.BUTTOM = new System.Windows.Forms.Label();
            this.lblx15 = new System.Windows.Forms.Label();
            this.lvlx14 = new System.Windows.Forms.Label();
            this.lblx13 = new System.Windows.Forms.Label();
            this.lblx12 = new System.Windows.Forms.Label();
            this.lblx11 = new System.Windows.Forms.Label();
            this.lblx10 = new System.Windows.Forms.Label();
            this.lbkx9 = new System.Windows.Forms.Label();
            this.lvlx8 = new System.Windows.Forms.Label();
            this.lvlx7 = new System.Windows.Forms.Label();
            this.lvlx6 = new System.Windows.Forms.Label();
            this.lvlx5 = new System.Windows.Forms.Label();
            this.lvlx4 = new System.Windows.Forms.Label();
            this.lvlx3 = new System.Windows.Forms.Label();
            this.lvlx2 = new System.Windows.Forms.Label();
            this.lvlx1 = new System.Windows.Forms.Label();
            this.TOP = new System.Windows.Forms.Label();
            this.mostrarPuntuaciones = new System.Windows.Forms.Panel();
            this.TiTulo = new System.Windows.Forms.Panel();
            this.panelDepuntuacion = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelJuego.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RELOJ
            // 
            this.RELOJ.Tick += new System.EventHandler(this.RELOJ_Tick);
            // 
            // MovPiesas
            // 
            this.MovPiesas.Interval = 2000;
            this.MovPiesas.Tick += new System.EventHandler(this.MovPiesas_Tick);
            // 
            // PanelJuego
            // 
            this.PanelJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelJuego.BackgroundImage = global::TetrisCsharp2.Properties.Resources.p_1;
            this.PanelJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelJuego.Controls.Add(this.lvly9);
            this.PanelJuego.Controls.Add(this.lvly8);
            this.PanelJuego.Controls.Add(this.lvly7);
            this.PanelJuego.Controls.Add(this.lvly6);
            this.PanelJuego.Controls.Add(this.lvly5);
            this.PanelJuego.Controls.Add(this.lvly4);
            this.PanelJuego.Controls.Add(this.lvly3);
            this.PanelJuego.Controls.Add(this.lvly2);
            this.PanelJuego.Controls.Add(this.tlvly1);
            this.PanelJuego.Controls.Add(this.RIGTH);
            this.PanelJuego.Controls.Add(this.LEFT);
            this.PanelJuego.Controls.Add(this.BUTTOM);
            this.PanelJuego.Controls.Add(this.lblx15);
            this.PanelJuego.Controls.Add(this.lvlx14);
            this.PanelJuego.Controls.Add(this.lblx13);
            this.PanelJuego.Controls.Add(this.lblx12);
            this.PanelJuego.Controls.Add(this.lblx11);
            this.PanelJuego.Controls.Add(this.lblx10);
            this.PanelJuego.Controls.Add(this.lbkx9);
            this.PanelJuego.Controls.Add(this.lvlx8);
            this.PanelJuego.Controls.Add(this.lvlx7);
            this.PanelJuego.Controls.Add(this.lvlx6);
            this.PanelJuego.Controls.Add(this.lvlx5);
            this.PanelJuego.Controls.Add(this.lvlx4);
            this.PanelJuego.Controls.Add(this.lvlx3);
            this.PanelJuego.Controls.Add(this.lvlx2);
            this.PanelJuego.Controls.Add(this.lvlx1);
            this.PanelJuego.Controls.Add(this.TOP);
            this.PanelJuego.Location = new System.Drawing.Point(224, 15);
            this.PanelJuego.MaximumSize = new System.Drawing.Size(502, 802);
            this.PanelJuego.MinimumSize = new System.Drawing.Size(502, 802);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(502, 802);
            this.PanelJuego.TabIndex = 1;
            // 
            // lvly9
            // 
            this.lvly9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly9.Enabled = false;
            this.lvly9.Location = new System.Drawing.Point(450, 0);
            this.lvly9.Name = "lvly9";
            this.lvly9.Size = new System.Drawing.Size(2, 1060);
            this.lvly9.TabIndex = 39;
            // 
            // lvly8
            // 
            this.lvly8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly8.Enabled = false;
            this.lvly8.Location = new System.Drawing.Point(400, 0);
            this.lvly8.Name = "lvly8";
            this.lvly8.Size = new System.Drawing.Size(2, 1060);
            this.lvly8.TabIndex = 38;
            // 
            // lvly7
            // 
            this.lvly7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly7.Enabled = false;
            this.lvly7.Location = new System.Drawing.Point(350, 0);
            this.lvly7.Name = "lvly7";
            this.lvly7.Size = new System.Drawing.Size(2, 1060);
            this.lvly7.TabIndex = 37;
            // 
            // lvly6
            // 
            this.lvly6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly6.Enabled = false;
            this.lvly6.Location = new System.Drawing.Point(300, 0);
            this.lvly6.Name = "lvly6";
            this.lvly6.Size = new System.Drawing.Size(2, 1060);
            this.lvly6.TabIndex = 36;
            // 
            // lvly5
            // 
            this.lvly5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly5.Enabled = false;
            this.lvly5.Location = new System.Drawing.Point(250, 0);
            this.lvly5.Name = "lvly5";
            this.lvly5.Size = new System.Drawing.Size(2, 1060);
            this.lvly5.TabIndex = 35;
            // 
            // lvly4
            // 
            this.lvly4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly4.Enabled = false;
            this.lvly4.Location = new System.Drawing.Point(200, 0);
            this.lvly4.Name = "lvly4";
            this.lvly4.Size = new System.Drawing.Size(2, 1060);
            this.lvly4.TabIndex = 34;
            // 
            // lvly3
            // 
            this.lvly3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly3.Enabled = false;
            this.lvly3.Location = new System.Drawing.Point(150, 0);
            this.lvly3.Name = "lvly3";
            this.lvly3.Size = new System.Drawing.Size(2, 1060);
            this.lvly3.TabIndex = 33;
            // 
            // lvly2
            // 
            this.lvly2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvly2.Enabled = false;
            this.lvly2.Location = new System.Drawing.Point(100, 0);
            this.lvly2.Name = "lvly2";
            this.lvly2.Size = new System.Drawing.Size(2, 1060);
            this.lvly2.TabIndex = 32;
            // 
            // tlvly1
            // 
            this.tlvly1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlvly1.Enabled = false;
            this.tlvly1.Location = new System.Drawing.Point(50, 0);
            this.tlvly1.Name = "tlvly1";
            this.tlvly1.Size = new System.Drawing.Size(2, 1060);
            this.tlvly1.TabIndex = 31;
            // 
            // RIGTH
            // 
            this.RIGTH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RIGTH.Enabled = false;
            this.RIGTH.Location = new System.Drawing.Point(500, 0);
            this.RIGTH.Name = "RIGTH";
            this.RIGTH.Size = new System.Drawing.Size(2, 1060);
            this.RIGTH.TabIndex = 30;
            // 
            // LEFT
            // 
            this.LEFT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LEFT.Enabled = false;
            this.LEFT.Location = new System.Drawing.Point(0, 0);
            this.LEFT.Name = "LEFT";
            this.LEFT.Size = new System.Drawing.Size(2, 1060);
            this.LEFT.TabIndex = 29;
            // 
            // BUTTOM
            // 
            this.BUTTOM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BUTTOM.Enabled = false;
            this.BUTTOM.Location = new System.Drawing.Point(0, 800);
            this.BUTTOM.Name = "BUTTOM";
            this.BUTTOM.Size = new System.Drawing.Size(820, 2);
            this.BUTTOM.TabIndex = 28;
            // 
            // lblx15
            // 
            this.lblx15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx15.Enabled = false;
            this.lblx15.Location = new System.Drawing.Point(0, 750);
            this.lblx15.Name = "lblx15";
            this.lblx15.Size = new System.Drawing.Size(820, 2);
            this.lblx15.TabIndex = 27;
            // 
            // lvlx14
            // 
            this.lvlx14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx14.Enabled = false;
            this.lvlx14.Location = new System.Drawing.Point(0, 700);
            this.lvlx14.Name = "lvlx14";
            this.lvlx14.Size = new System.Drawing.Size(820, 2);
            this.lvlx14.TabIndex = 26;
            // 
            // lblx13
            // 
            this.lblx13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx13.Enabled = false;
            this.lblx13.Location = new System.Drawing.Point(0, 650);
            this.lblx13.Name = "lblx13";
            this.lblx13.Size = new System.Drawing.Size(820, 2);
            this.lblx13.TabIndex = 25;
            // 
            // lblx12
            // 
            this.lblx12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx12.Enabled = false;
            this.lblx12.Location = new System.Drawing.Point(0, 600);
            this.lblx12.Name = "lblx12";
            this.lblx12.Size = new System.Drawing.Size(820, 2);
            this.lblx12.TabIndex = 24;
            // 
            // lblx11
            // 
            this.lblx11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx11.Enabled = false;
            this.lblx11.Location = new System.Drawing.Point(0, 550);
            this.lblx11.Name = "lblx11";
            this.lblx11.Size = new System.Drawing.Size(820, 2);
            this.lblx11.TabIndex = 23;
            // 
            // lblx10
            // 
            this.lblx10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblx10.Enabled = false;
            this.lblx10.Location = new System.Drawing.Point(0, 500);
            this.lblx10.Name = "lblx10";
            this.lblx10.Size = new System.Drawing.Size(820, 2);
            this.lblx10.TabIndex = 22;
            // 
            // lbkx9
            // 
            this.lbkx9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbkx9.Enabled = false;
            this.lbkx9.Location = new System.Drawing.Point(0, 450);
            this.lbkx9.Name = "lbkx9";
            this.lbkx9.Size = new System.Drawing.Size(820, 2);
            this.lbkx9.TabIndex = 21;
            // 
            // lvlx8
            // 
            this.lvlx8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx8.Enabled = false;
            this.lvlx8.Location = new System.Drawing.Point(0, 400);
            this.lvlx8.Name = "lvlx8";
            this.lvlx8.Size = new System.Drawing.Size(820, 2);
            this.lvlx8.TabIndex = 20;
            // 
            // lvlx7
            // 
            this.lvlx7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx7.Enabled = false;
            this.lvlx7.Location = new System.Drawing.Point(0, 350);
            this.lvlx7.Name = "lvlx7";
            this.lvlx7.Size = new System.Drawing.Size(820, 2);
            this.lvlx7.TabIndex = 19;
            // 
            // lvlx6
            // 
            this.lvlx6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx6.Enabled = false;
            this.lvlx6.Location = new System.Drawing.Point(0, 300);
            this.lvlx6.Name = "lvlx6";
            this.lvlx6.Size = new System.Drawing.Size(820, 2);
            this.lvlx6.TabIndex = 18;
            // 
            // lvlx5
            // 
            this.lvlx5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx5.Enabled = false;
            this.lvlx5.Location = new System.Drawing.Point(0, 250);
            this.lvlx5.Name = "lvlx5";
            this.lvlx5.Size = new System.Drawing.Size(820, 2);
            this.lvlx5.TabIndex = 17;
            // 
            // lvlx4
            // 
            this.lvlx4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx4.Enabled = false;
            this.lvlx4.Location = new System.Drawing.Point(0, 200);
            this.lvlx4.Name = "lvlx4";
            this.lvlx4.Size = new System.Drawing.Size(820, 2);
            this.lvlx4.TabIndex = 16;
            // 
            // lvlx3
            // 
            this.lvlx3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx3.Enabled = false;
            this.lvlx3.Location = new System.Drawing.Point(0, 150);
            this.lvlx3.Name = "lvlx3";
            this.lvlx3.Size = new System.Drawing.Size(820, 2);
            this.lvlx3.TabIndex = 15;
            // 
            // lvlx2
            // 
            this.lvlx2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx2.Enabled = false;
            this.lvlx2.Location = new System.Drawing.Point(0, 100);
            this.lvlx2.Name = "lvlx2";
            this.lvlx2.Size = new System.Drawing.Size(820, 2);
            this.lvlx2.TabIndex = 14;
            // 
            // lvlx1
            // 
            this.lvlx1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlx1.Enabled = false;
            this.lvlx1.Location = new System.Drawing.Point(0, 50);
            this.lvlx1.Name = "lvlx1";
            this.lvlx1.Size = new System.Drawing.Size(820, 2);
            this.lvlx1.TabIndex = 13;
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TOP.Enabled = false;
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(820, 2);
            this.TOP.TabIndex = 12;
            // 
            // mostrarPuntuaciones
            // 
            this.mostrarPuntuaciones.BackColor = System.Drawing.Color.DimGray;
            this.mostrarPuntuaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.mostrarPuntuaciones.Enabled = false;
            this.mostrarPuntuaciones.Location = new System.Drawing.Point(0, 100);
            this.mostrarPuntuaciones.Name = "mostrarPuntuaciones";
            this.mostrarPuntuaciones.Size = new System.Drawing.Size(180, 838);
            this.mostrarPuntuaciones.TabIndex = 0;
            // 
            // TiTulo
            // 
            this.TiTulo.BackColor = System.Drawing.Color.Gray;
            this.TiTulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TiTulo.Location = new System.Drawing.Point(0, 0);
            this.TiTulo.Name = "TiTulo";
            this.TiTulo.Size = new System.Drawing.Size(1256, 100);
            this.TiTulo.TabIndex = 3;
            // 
            // panelDepuntuacion
            // 
            this.panelDepuntuacion.BackColor = System.Drawing.Color.DimGray;
            this.panelDepuntuacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDepuntuacion.Enabled = false;
            this.panelDepuntuacion.Location = new System.Drawing.Point(1076, 100);
            this.panelDepuntuacion.Name = "panelDepuntuacion";
            this.panelDepuntuacion.Size = new System.Drawing.Size(180, 838);
            this.panelDepuntuacion.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.PanelJuego);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(180, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 838);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1256, 938);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDepuntuacion);
            this.Controls.Add(this.mostrarPuntuaciones);
            this.Controls.Add(this.TiTulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 841);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TETETRIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PanelJuego.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer RELOJ;
        private System.Windows.Forms.Timer MovPiesas;
        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Label LEFT;
        private System.Windows.Forms.Label BUTTOM;
        private System.Windows.Forms.Label lblx15;
        private System.Windows.Forms.Label lvlx14;
        private System.Windows.Forms.Label lblx13;
        private System.Windows.Forms.Label lblx12;
        private System.Windows.Forms.Label lblx11;
        private System.Windows.Forms.Label lblx10;
        private System.Windows.Forms.Label lbkx9;
        private System.Windows.Forms.Label lvlx8;
        private System.Windows.Forms.Label lvlx7;
        private System.Windows.Forms.Label lvlx6;
        private System.Windows.Forms.Label lvlx5;
        private System.Windows.Forms.Label lvlx4;
        private System.Windows.Forms.Label lvlx3;
        private System.Windows.Forms.Label lvlx2;
        private System.Windows.Forms.Label lvlx1;
        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.Label lvly9;
        private System.Windows.Forms.Label lvly8;
        private System.Windows.Forms.Label lvly7;
        private System.Windows.Forms.Label lvly6;
        private System.Windows.Forms.Label lvly5;
        private System.Windows.Forms.Label lvly4;
        private System.Windows.Forms.Label lvly3;
        private System.Windows.Forms.Label lvly2;
        private System.Windows.Forms.Label tlvly1;
        private System.Windows.Forms.Label RIGTH;
        private System.Windows.Forms.Panel mostrarPuntuaciones;
        private System.Windows.Forms.Panel TiTulo;
        private System.Windows.Forms.Panel panelDepuntuacion;
        private System.Windows.Forms.Panel panel1;
    }
}


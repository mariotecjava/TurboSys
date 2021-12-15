namespace TurboSys
{
    partial class TurboInicio
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurarPantalla = new System.Windows.Forms.PictureBox();
            this.btnMinimizarPantalla = new System.Windows.Forms.PictureBox();
            this.btnPantallaChica = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarPantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarPantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPantallaChica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurarPantalla);
            this.BarraTitulo.Controls.Add(this.btnMinimizarPantalla);
            this.BarraTitulo.Controls.Add(this.btnPantallaChica);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestaurarPantalla
            // 
            this.btnRestaurarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarPantalla.Image = global::TurboSys.Properties.Resources.pantalla_completa;
            this.btnRestaurarPantalla.Location = new System.Drawing.Point(1239, 7);
            this.btnRestaurarPantalla.Name = "btnRestaurarPantalla";
            this.btnRestaurarPantalla.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurarPantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurarPantalla.TabIndex = 3;
            this.btnRestaurarPantalla.TabStop = false;
            this.btnRestaurarPantalla.Click += new System.EventHandler(this.btnRestaurarPantalla_Click);
            // 
            // btnMinimizarPantalla
            // 
            this.btnMinimizarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPantalla.Image = global::TurboSys.Properties.Resources.minimizar;
            this.btnMinimizarPantalla.Location = new System.Drawing.Point(1208, 7);
            this.btnMinimizarPantalla.Name = "btnMinimizarPantalla";
            this.btnMinimizarPantalla.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizarPantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarPantalla.TabIndex = 2;
            this.btnMinimizarPantalla.TabStop = false;
            this.btnMinimizarPantalla.Click += new System.EventHandler(this.btnMinimizarPantalla_Click);
            // 
            // btnPantallaChica
            // 
            this.btnPantallaChica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPantallaChica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPantallaChica.Image = global::TurboSys.Properties.Resources.minimizar__1_;
            this.btnPantallaChica.Location = new System.Drawing.Point(1239, 7);
            this.btnPantallaChica.Name = "btnPantallaChica";
            this.btnPantallaChica.Size = new System.Drawing.Size(25, 25);
            this.btnPantallaChica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPantallaChica.TabIndex = 1;
            this.btnPantallaChica.TabStop = false;
            this.btnPantallaChica.Click += new System.EventHandler(this.btnPantallaChica_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::TurboSys.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1270, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnAlmacen);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 612);
            this.MenuVertical.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 39);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAlmacen.Image = global::TurboSys.Properties.Resources.google_docs__3_;
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(8, 106);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(210, 39);
            this.btnAlmacen.TabIndex = 1;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(220, 38);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1080, 612);
            this.PanelContenido.TabIndex = 2;
            // 
            // TurboInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TurboInicio";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarPantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarPantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPantallaChica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.PictureBox btnPantallaChica;
        private System.Windows.Forms.PictureBox btnMinimizarPantalla;
        private System.Windows.Forms.PictureBox btnRestaurarPantalla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


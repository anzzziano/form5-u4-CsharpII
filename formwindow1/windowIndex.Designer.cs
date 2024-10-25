namespace formwindow1
{
    partial class windowIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verPrefilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            agregarCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { archivoToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(751, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { crearToolStripMenuItem });
            archivoToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            archivoToolStripMenuItem.Text = "archivo";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            crearToolStripMenuItem.Text = "Crear ";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { verPrefilToolStripMenuItem, agregarCuentasToolStripMenuItem });
            opcionesToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            opcionesToolStripMenuItem.Text = "opciones";
            // 
            // verPrefilToolStripMenuItem
            // 
            verPrefilToolStripMenuItem.Name = "verPrefilToolStripMenuItem";
            verPrefilToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            verPrefilToolStripMenuItem.Text = "Ver prefil";
            verPrefilToolStripMenuItem.Click += verPrefilToolStripMenuItem_Click;
            // 
            // agregarCuentasToolStripMenuItem
            // 
            agregarCuentasToolStripMenuItem.Name = "agregarCuentasToolStripMenuItem";
            agregarCuentasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            agregarCuentasToolStripMenuItem.Text = "agregar cuentas";
            // 
            // windowIndex
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(751, 404);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "windowIndex";
            Text = "windowIndex";
            TopMost = true;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPrefilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formwindow1
{
    public partial class windowIndex : Form
    {
        public windowIndex()
        {
            InitializeComponent();
        }

        private void verPrefilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            Form1 windowViewProfile = new Form1();
            windowViewProfile.MdiParent = this;
            windowViewProfile.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(windowCrearCuento))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            windowCrearCuento windowCrearCuento = new windowCrearCuento();
            windowCrearCuento.MdiParent = this;  
            windowCrearCuento.Show();
        }
    }
}

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
    public partial class windowCrearCuento : Form
    {
        public windowCrearCuento()
        {
            InitializeComponent();
        }

        private void buttonVerCuento_Click_1(object sender, EventArgs e)
        {
            string tituloCuento = textBoxTitleCuento.Text;
            string resumenCuento = richTextBoxREsumenCuento.Text;

            if (tituloCuento == "")
            {
                MessageBox.Show("debe tener titulo el cuento");
                return;
            }
            else if (resumenCuento == "")
            {
                MessageBox.Show("debe tener resumen el cuento");
                return;
            }

            MessageBox.Show("el titulo del cuento es : " + tituloCuento + " y su resumen " + resumenCuento);
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonMen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonViewProfile_Click(object sender, EventArgs e)
        {
            string saveName = textBoxName.Text;
            string saveApellido = textBoxApellido.Text;

            string genero;

            string checkGenero = radioButtonMen.Checked == true ? " masculino" : "femenino";

            if (saveName == "")
            {
                MessageBox.Show("debe tener un nombre");
                return;
            }
            else if (saveApellido == "")
            {
                MessageBox.Show("debe tener apellido");
                return;
            }

            if (radioButtonMen.Checked == false && radioButtonWomen.Checked == false)
            {
                MessageBox.Show("debe introducir un genero");
                return;
            }

            MessageBox.Show("su nombre es: " + saveName + " y su apellido: " + saveApellido + " y su genero: " + checkGenero);

        }

    }
}


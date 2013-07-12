using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndustriaJimenez.Interfaz
{
    public partial class FrmModificarFeriado : Form
    {
        public FrmModificarFeriado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos del día feriado han sido modificados en el sistema con éxito", "Información", MessageBoxButtons.OK);
            this.Hide();
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }

    }
}

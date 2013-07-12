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
    public partial class Frm_AgregarHorasDiaria : Form
    {
        public Frm_AgregarHorasDiaria()
        {
            InitializeComponent();
        }

        private void Frm_AgregarHorasDiaria_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            string fecha_actual = fecha.ToString("dd-MM-yyyy");

            Fecha_AgregarHoras.Text = fecha_actual;
            ampm1.SelectedIndex = 0;
            ampm2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double horasEntrada = Int16.Parse(numericUpDown3.Text);
            double horasSalida = Int16.Parse(numericUpDown4.Text);
            double minutosEntrada = Int16.Parse(numericUpDown1.Text);
            double minutosSalida = Int16.Parse(numericUpDown2.Text);

            minutosEntrada /= 60;
            minutosSalida /= 60;

            horasEntrada += minutosEntrada;
            horasSalida += minutosSalida;

            MessageBox.Show(horasEntrada.ToString());
            MessageBox.Show(horasSalida.ToString());
        }
    }
}

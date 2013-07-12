using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIndustriasJimenez
{
    public partial class Prueba : Form
    {
        Bienvenido dsd = new Bienvenido();
        public Prueba()
        {
            InitializeComponent();
            dsd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

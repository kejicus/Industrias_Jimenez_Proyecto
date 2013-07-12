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
    public partial class Bienvenido : Form
    {
        VerEmpleados verEmpleados = new VerEmpleados();
        public Bienvenido()
        {
            InitializeComponent();
            
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {

        }        
        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            Hide();
                       
        }
    }
}

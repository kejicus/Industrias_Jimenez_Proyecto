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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal vPrincipal = new FrmPrincipal();
            this.Hide();
            vPrincipal.ShowDialog();
            this.Dispose();
        }

    }
}

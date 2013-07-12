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
    public partial class FrmRegistrarHoras : Form
    {
        public FrmRegistrarHoras()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_AgregarHorasDiaria agregarHorasDiarias = new Frm_AgregarHorasDiaria();
            agregarHorasDiarias.ShowDialog();
        }

        private void FrmRegistrarHoras_Load(object sender, EventArgs e)
        {

        }
    }
}

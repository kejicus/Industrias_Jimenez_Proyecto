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
    public partial class FrmPrincipal : Form
    {


        #region Metodos 

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarFeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarFeriado agregarFeriado = new FrmAgregarFeriado();
            agregarFeriado.ShowDialog();
        }

        private void editarFeriadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmModificarFeriado modificarFeriado = new FrmModificarFeriado();
            modificarFeriado.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarPersonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgregarPersonas agregarPersonas = new FrmAgregarPersonas();
            agregarPersonas.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Editar Persona
        }

        #endregion

        private void registrarHorasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarHoras registrarHorasSemanales = new FrmRegistrarHoras();
            registrarHorasSemanales.ShowDialog();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarReportes generarComprobantePago = new FrmGenerarReportes();
            generarComprobantePago.ShowDialog();
        }

      

    }
}

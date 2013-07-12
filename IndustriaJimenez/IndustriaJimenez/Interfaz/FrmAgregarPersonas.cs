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
    public partial class FrmAgregarPersonas : Form
    {
        public FrmAgregarPersonas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox1.Image = new Bitmap(open.FileName);
                // mostrar el path de la imagen
                bttnExaminar.Text = open.FileName;
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos de la persona han sido guardados en el sistema con éxito", "Información", MessageBoxButtons.OK);
            this.Hide();
            this.Dispose();
        }


    }
}

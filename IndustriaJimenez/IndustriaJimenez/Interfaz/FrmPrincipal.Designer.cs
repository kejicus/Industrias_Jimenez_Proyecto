namespace IndustriaJimenez.Interfaz
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPersonasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHorasDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feriadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFeriadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFeriadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aguinaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPersonasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.feriadosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarPersonasToolStripMenuItem
            // 
            this.agregarPersonasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPersonasToolStripMenuItem1,
            this.eliminarPersonaToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.agregarPersonasToolStripMenuItem.Name = "agregarPersonasToolStripMenuItem";
            this.agregarPersonasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.agregarPersonasToolStripMenuItem.Text = "Personas";
            // 
            // agregarPersonasToolStripMenuItem1
            // 
            this.agregarPersonasToolStripMenuItem1.Name = "agregarPersonasToolStripMenuItem1";
            this.agregarPersonasToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.agregarPersonasToolStripMenuItem1.Text = "Agregar Personas";
            this.agregarPersonasToolStripMenuItem1.Click += new System.EventHandler(this.agregarPersonasToolStripMenuItem1_Click);
            // 
            // eliminarPersonaToolStripMenuItem
            // 
            this.eliminarPersonaToolStripMenuItem.Name = "eliminarPersonaToolStripMenuItem";
            this.eliminarPersonaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eliminarPersonaToolStripMenuItem.Text = "Eliminar Personas";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editarToolStripMenuItem.Text = "Editar Persona";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHorasDiariasToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registrarHorasDiariasToolStripMenuItem
            // 
            this.registrarHorasDiariasToolStripMenuItem.Name = "registrarHorasDiariasToolStripMenuItem";
            this.registrarHorasDiariasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.registrarHorasDiariasToolStripMenuItem.Text = "Registrar Horas Diarias";
            this.registrarHorasDiariasToolStripMenuItem.Click += new System.EventHandler(this.registrarHorasDiariasToolStripMenuItem_Click);
            // 
            // feriadosToolStripMenuItem
            // 
            this.feriadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFeriadoToolStripMenuItem,
            this.editarFeriadosToolStripMenuItem});
            this.feriadosToolStripMenuItem.Name = "feriadosToolStripMenuItem";
            this.feriadosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.feriadosToolStripMenuItem.Text = "Feriados";
            // 
            // agregarFeriadoToolStripMenuItem
            // 
            this.agregarFeriadoToolStripMenuItem.Name = "agregarFeriadoToolStripMenuItem";
            this.agregarFeriadoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarFeriadoToolStripMenuItem.Text = "Agregar Feriado";
            this.agregarFeriadoToolStripMenuItem.Click += new System.EventHandler(this.agregarFeriadoToolStripMenuItem_Click);
            // 
            // editarFeriadosToolStripMenuItem
            // 
            this.editarFeriadosToolStripMenuItem.Name = "editarFeriadosToolStripMenuItem";
            this.editarFeriadosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editarFeriadosToolStripMenuItem.Text = "Editar Feriados";
            this.editarFeriadosToolStripMenuItem.Click += new System.EventHandler(this.editarFeriadosToolStripMenuItem_Click_1);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoToolStripMenuItem,
            this.aguinaldoToolStripMenuItem,
            this.vacacionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagoToolStripMenuItem.Text = "Pago";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // aguinaldoToolStripMenuItem
            // 
            this.aguinaldoToolStripMenuItem.Name = "aguinaldoToolStripMenuItem";
            this.aguinaldoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aguinaldoToolStripMenuItem.Text = "Aguinaldo";
            // 
            // vacacionesToolStripMenuItem
            // 
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IndustriaJimenez.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Industria Jiménez";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feriadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFeriadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFeriadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aguinaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem agregarPersonasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHorasDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPersonaToolStripMenuItem;

    }
}
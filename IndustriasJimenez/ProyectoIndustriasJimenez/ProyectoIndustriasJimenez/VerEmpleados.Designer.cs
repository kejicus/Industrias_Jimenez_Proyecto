namespace ProyectoIndustriasJimenez
{
    partial class VerEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_Empleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // Grid_Empleados
            // 
            this.Grid_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Editar});
            this.Grid_Empleados.Location = new System.Drawing.Point(37, 85);
            this.Grid_Empleados.Name = "Grid_Empleados";
            this.Grid_Empleados.Size = new System.Drawing.Size(243, 315);
            this.Grid_Empleados.TabIndex = 2;
            this.Grid_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Empleados_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Editar";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            // 
            // VerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 447);
            this.Controls.Add(this.Grid_Empleados);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerEmpleados";
            this.Text = "Tiempos y Salarios";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}
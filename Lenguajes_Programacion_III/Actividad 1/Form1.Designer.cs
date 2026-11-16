namespace Actividad_1
{
    partial class frmExpediente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpediente));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHorarios = new System.Windows.Forms.GroupBox();
            this.rdbVespertino = new System.Windows.Forms.RadioButton();
            this.rdbMatutino = new System.Windows.Forms.RadioButton();
            this.lstEstados = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtFechaNacimiento);
            this.grpDatos.Controls.Add(this.txtNombreCompleto);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(516, 171);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Alumno";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(179, 119);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 26);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(179, 78);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(320, 26);
            this.txtFechaNacimiento.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(179, 37);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(320, 26);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo";
            // 
            // grpHorarios
            // 
            this.grpHorarios.Controls.Add(this.rdbVespertino);
            this.grpHorarios.Controls.Add(this.rdbMatutino);
            this.grpHorarios.Location = new System.Drawing.Point(364, 202);
            this.grpHorarios.Name = "grpHorarios";
            this.grpHorarios.Size = new System.Drawing.Size(164, 121);
            this.grpHorarios.TabIndex = 9;
            this.grpHorarios.TabStop = false;
            this.grpHorarios.Text = "Horarios";
            // 
            // rdbVespertino
            // 
            this.rdbVespertino.AutoSize = true;
            this.rdbVespertino.Location = new System.Drawing.Point(26, 79);
            this.rdbVespertino.Name = "rdbVespertino";
            this.rdbVespertino.Size = new System.Drawing.Size(107, 24);
            this.rdbVespertino.TabIndex = 1;
            this.rdbVespertino.TabStop = true;
            this.rdbVespertino.Text = "vespertino";
            this.rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            this.rdbMatutino.AutoSize = true;
            this.rdbMatutino.Location = new System.Drawing.Point(26, 34);
            this.rdbMatutino.Name = "rdbMatutino";
            this.rdbMatutino.Size = new System.Drawing.Size(96, 24);
            this.rdbMatutino.TabIndex = 0;
            this.rdbMatutino.TabStop = true;
            this.rdbMatutino.Text = "matutino";
            this.rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // lstEstados
            // 
            this.lstEstados.FormattingEnabled = true;
            this.lstEstados.ItemHeight = 20;
            this.lstEstados.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.lstEstados.Location = new System.Drawing.Point(12, 202);
            this.lstEstados.Name = "lstEstados";
            this.lstEstados.Size = new System.Drawing.Size(325, 184);
            this.lstEstados.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(364, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(164, 43);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // frmExpediente
            // 
            this.AccessibleDescription = "Expediente de alumno";
            this.AccessibleName = "frmExpediente";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 417);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstEstados);
            this.Controls.Add(this.grpHorarios);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExpediente";
            this.Text = "Expediente de alumno";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpHorarios.ResumeLayout(false);
            this.grpHorarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.GroupBox grpHorarios;
        private System.Windows.Forms.RadioButton rdbVespertino;
        private System.Windows.Forms.RadioButton rdbMatutino;
        private System.Windows.Forms.ListBox lstEstados;
        private System.Windows.Forms.Button btnGuardar;
    }
}


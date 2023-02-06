namespace UI.Windows.Forms
{
    partial class FormularioRepresentante
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
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.TxtSexo = new System.Windows.Forms.TextBox();
            this.TxtEstadoCivil = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.DgvRepresentante = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRepresentante)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(213, 69);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(237, 22);
            this.TxtNombres.TabIndex = 0;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(213, 109);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(237, 22);
            this.TxtApellidos.TabIndex = 1;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(213, 155);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(237, 22);
            this.TxtIdentificacion.TabIndex = 2;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(213, 196);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(237, 22);
            this.TxtTelefono.TabIndex = 3;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(213, 235);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(237, 22);
            this.DtpFechaNacimiento.TabIndex = 4;
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(653, 69);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(237, 22);
            this.TxtNacionalidad.TabIndex = 5;
            // 
            // TxtSexo
            // 
            this.TxtSexo.Location = new System.Drawing.Point(653, 110);
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(237, 22);
            this.TxtSexo.TabIndex = 6;
            // 
            // TxtEstadoCivil
            // 
            this.TxtEstadoCivil.Location = new System.Drawing.Point(653, 150);
            this.TxtEstadoCivil.Name = "TxtEstadoCivil";
            this.TxtEstadoCivil.Size = new System.Drawing.Size(237, 22);
            this.TxtEstadoCivil.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(653, 192);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(237, 22);
            this.TxtDireccion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombres: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Identificacion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha Nacimiento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nacionalidad: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sexo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado Civil: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dirección: ";
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(815, 294);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(115, 34);
            this.BtnInsertar.TabIndex = 18;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // DgvRepresentante
            // 
            this.DgvRepresentante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRepresentante.Location = new System.Drawing.Point(53, 294);
            this.DgvRepresentante.Name = "DgvRepresentante";
            this.DgvRepresentante.RowHeadersWidth = 51;
            this.DgvRepresentante.RowTemplate.Height = 24;
            this.DgvRepresentante.Size = new System.Drawing.Size(737, 214);
            this.DgvRepresentante.TabIndex = 19;
            this.DgvRepresentante.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRepresentante_CellMouseClick);
            this.DgvRepresentante.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRepresentante_CellMouseDoubleClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(213, 33);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(0, 22);
            this.TxtId.TabIndex = 20;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(815, 335);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 34);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(815, 373);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(115, 34);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FormularioRepresentante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 540);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DgvRepresentante);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtEstadoCivil);
            this.Controls.Add(this.TxtSexo);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioRepresentante";
            this.Text = "Formulario Representante";
            this.Load += new System.EventHandler(this.FormularioRepresentante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRepresentante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.TextBox TxtSexo;
        private System.Windows.Forms.TextBox TxtEstadoCivil;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.DataGridView DgvRepresentante;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}
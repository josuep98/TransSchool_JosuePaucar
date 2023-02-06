namespace UI.Windows.Forms
{
    partial class FormularioIncidencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRutaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.DgvIncidencia = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(287, 65);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(237, 22);
            this.TxtTipo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Titulo";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(287, 105);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(237, 22);
            this.TxtTitulo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mensaje";
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Location = new System.Drawing.Point(287, 150);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(237, 22);
            this.TxtMensaje.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "RutaId";
            // 
            // TxtRutaId
            // 
            this.TxtRutaId.Location = new System.Drawing.Point(287, 194);
            this.TxtRutaId.Name = "TxtRutaId";
            this.TxtRutaId.Size = new System.Drawing.Size(237, 22);
            this.TxtRutaId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(287, 237);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 22);
            this.DtpFecha.TabIndex = 20;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(634, 235);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(130, 35);
            this.BtnCerrar.TabIndex = 25;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(634, 197);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 35);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(634, 156);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(130, 35);
            this.BtnInsertar.TabIndex = 23;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // DgvIncidencia
            // 
            this.DgvIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIncidencia.Location = new System.Drawing.Point(87, 300);
            this.DgvIncidencia.Name = "DgvIncidencia";
            this.DgvIncidencia.RowHeadersWidth = 51;
            this.DgvIncidencia.RowTemplate.Height = 24;
            this.DgvIncidencia.Size = new System.Drawing.Size(688, 177);
            this.DgvIncidencia.TabIndex = 26;
            this.DgvIncidencia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvIncidencia_CellMouseClick);
            this.DgvIncidencia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvIncidencia_CellMouseDoubleClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(287, 27);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(0, 22);
            this.TxtId.TabIndex = 27;
            // 
            // FormularioIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 518);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DgvIncidencia);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRutaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioIncidencia";
            this.Text = "FormularioIncidencia";
            this.Load += new System.EventHandler(this.FormularioIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIncidencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRutaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.DataGridView DgvIncidencia;
        private System.Windows.Forms.TextBox TxtId;
    }
}
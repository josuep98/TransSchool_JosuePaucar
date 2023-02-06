namespace UI.Windows.Forms
{
    partial class FormularioContenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioContenedor));
            this.PnMenuVertical = new System.Windows.Forms.Panel();
            this.MnIncidencia = new System.Windows.Forms.Button();
            this.MnRepresentante = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnReducir = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuDesplegable = new System.Windows.Forms.PictureBox();
            this.PnContenedor = new System.Windows.Forms.Panel();
            this.PnMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegable)).BeginInit();
            this.SuspendLayout();
            // 
            // PnMenuVertical
            // 
            this.PnMenuVertical.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnMenuVertical.Controls.Add(this.MnIncidencia);
            this.PnMenuVertical.Controls.Add(this.MnRepresentante);
            this.PnMenuVertical.Controls.Add(this.pictureBox1);
            this.PnMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PnMenuVertical.Name = "PnMenuVertical";
            this.PnMenuVertical.Size = new System.Drawing.Size(250, 662);
            this.PnMenuVertical.TabIndex = 1;
            // 
            // MnIncidencia
            // 
            this.MnIncidencia.FlatAppearance.BorderSize = 0;
            this.MnIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MnIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MnIncidencia.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnIncidencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MnIncidencia.Image = ((System.Drawing.Image)(resources.GetObject("MnIncidencia.Image")));
            this.MnIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MnIncidencia.Location = new System.Drawing.Point(3, 163);
            this.MnIncidencia.Name = "MnIncidencia";
            this.MnIncidencia.Size = new System.Drawing.Size(244, 40);
            this.MnIncidencia.TabIndex = 2;
            this.MnIncidencia.Text = "Incidencia";
            this.MnIncidencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MnIncidencia.UseVisualStyleBackColor = true;
            this.MnIncidencia.Click += new System.EventHandler(this.MnIncidencia_Click);
            // 
            // MnRepresentante
            // 
            this.MnRepresentante.FlatAppearance.BorderSize = 0;
            this.MnRepresentante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MnRepresentante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MnRepresentante.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnRepresentante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MnRepresentante.Image = ((System.Drawing.Image)(resources.GetObject("MnRepresentante.Image")));
            this.MnRepresentante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MnRepresentante.Location = new System.Drawing.Point(0, 117);
            this.MnRepresentante.Name = "MnRepresentante";
            this.MnRepresentante.Size = new System.Drawing.Size(244, 40);
            this.MnRepresentante.TabIndex = 0;
            this.MnRepresentante.Text = "Representante";
            this.MnRepresentante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MnRepresentante.UseVisualStyleBackColor = true;
            this.MnRepresentante.Click += new System.EventHandler(this.MnRepresentante_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMaximizar);
            this.panel1.Controls.Add(this.BtnReducir);
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.MenuDesplegable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 50);
            this.panel1.TabIndex = 2;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(999, 9);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 4;
            this.BtnMaximizar.TabStop = false;
            // 
            // BtnReducir
            // 
            this.BtnReducir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReducir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnReducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReducir.Image = ((System.Drawing.Image)(resources.GetObject("BtnReducir.Image")));
            this.BtnReducir.Location = new System.Drawing.Point(999, 9);
            this.BtnReducir.Name = "BtnReducir";
            this.BtnReducir.Size = new System.Drawing.Size(25, 25);
            this.BtnReducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnReducir.TabIndex = 3;
            this.BtnReducir.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(968, 9);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1030, 9);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            // 
            // MenuDesplegable
            // 
            this.MenuDesplegable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuDesplegable.Image = ((System.Drawing.Image)(resources.GetObject("MenuDesplegable.Image")));
            this.MenuDesplegable.Location = new System.Drawing.Point(6, 9);
            this.MenuDesplegable.Name = "MenuDesplegable";
            this.MenuDesplegable.Size = new System.Drawing.Size(35, 35);
            this.MenuDesplegable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuDesplegable.TabIndex = 0;
            this.MenuDesplegable.TabStop = false;
            // 
            // PnContenedor
            // 
            this.PnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContenedor.Location = new System.Drawing.Point(250, 50);
            this.PnContenedor.Name = "PnContenedor";
            this.PnContenedor.Size = new System.Drawing.Size(1068, 612);
            this.PnContenedor.TabIndex = 3;
            // 
            // FormularioContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 662);
            this.Controls.Add(this.PnContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioContenedor";
            this.Text = "FormularioContenedor";
            this.PnMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnMenuVertical;
        private System.Windows.Forms.Button MnIncidencia;
        private System.Windows.Forms.Button MnRepresentante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnReducir;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox MenuDesplegable;
        private System.Windows.Forms.Panel PnContenedor;
    }
}
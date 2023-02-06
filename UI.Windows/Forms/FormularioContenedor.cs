using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Windows.Forms
{
    public partial class FormularioContenedor : Form
    {
        public FormularioContenedor()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.PnContenedor.Controls.Count > 0)
                this.PnContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnContenedor.Controls.Add(fh);
            this.PnContenedor.Tag = fh;
            fh.Show();
        }

        private void MnRepresentante_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormularioRepresentante());
        }

        private void MnIncidencia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormularioIncidencia());

        }
    }
}

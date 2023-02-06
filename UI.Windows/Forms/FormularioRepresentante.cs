using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;

namespace UI.Windows.Forms
{
    public partial class FormularioRepresentante : Form
    {
        private RepresentanteController representanteController;
        private RepresentanteViewModel representanteViewModel;
        public FormularioRepresentante()
        {
            InitializeComponent();
            representanteController = new RepresentanteController();
        }

        private void Insertar()
        {
            if (representanteController.InsertarRepresentante(representanteViewModel))
            {
                Listar();
                MessageBox.Show("Representante insertado correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar al representante");
        }

        private void Listar()
        {
            DgvRepresentante.DataSource = representanteController.ListarRepresentante();
        }

        private void Actualizar()
        {
            if (representanteController.ModificarRepresentante(representanteViewModel))
            {
                MessageBox.Show("Representante actualizado!");
                Listar();
            }
            else
                MessageBox.Show("ERROR! No se pudo actualizar el representante");
        }

        private void Eliminar()
        {
            int id = 0;
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                id = Convert.ToInt32(TxtId.Text);
                if (representanteController.Eliminar(id))
                {
                    MessageBox.Show("Representante eliminado correctamente!");
                    Listar();
                }
                else
                    MessageBox.Show("ERROR! No se pudo eliminar el representante");
            }
            else
                MessageBox.Show("ERROR! No se pudo eliminar, seleccione una fila");
        }

        private void FormularioRepresentante_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            representanteViewModel = new RepresentanteViewModel();
            representanteViewModel.Nombres = TxtNombres.Text;
            representanteViewModel.Apellidos = TxtApellidos.Text;
            representanteViewModel.Identificacion = TxtIdentificacion.Text;
            representanteViewModel.Telefono = TxtTelefono.Text;
            representanteViewModel.FechaNacimiento = DtpFechaNacimiento.Value;
            representanteViewModel.Nacionalidad = TxtNacionalidad.Text;
            representanteViewModel.Sexo = TxtSexo.Text;
            representanteViewModel.EstadoCivil = TxtEstadoCivil.Text;
            representanteViewModel.Dirección = TxtDireccion.Text;
            if (string.IsNullOrEmpty(TxtId.Text))
                Insertar();
            else
            {
                representanteViewModel.RepresentanteId = Convert.ToInt32(TxtId.Text);
                Actualizar();
            }
        }

        private void DgvRepresentante_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvRepresentante.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvRepresentante.CurrentRow.Cells[0].Value.ToString();
                TxtNombres.Text = DgvRepresentante.CurrentRow.Cells[1].Value.ToString();
                TxtApellidos.Text = DgvRepresentante.CurrentRow.Cells[2].Value.ToString();
                TxtIdentificacion.Text = DgvRepresentante.CurrentRow.Cells[3].Value.ToString();
                TxtTelefono.Text = DgvRepresentante.CurrentRow.Cells[4].Value.ToString();
                DtpFechaNacimiento.Value = Convert.ToDateTime(DgvRepresentante.CurrentRow.Cells[5].Value);
                TxtNacionalidad.Text = DgvRepresentante.CurrentRow.Cells[6].Value.ToString();
                TxtSexo.Text = DgvRepresentante.CurrentRow.Cells[7].Value.ToString();
                TxtEstadoCivil.Text = DgvRepresentante.CurrentRow.Cells[8].Value.ToString();
                TxtDireccion.Text = DgvRepresentante.CurrentRow.Cells[9].Value.ToString();
                BtnInsertar.Text = "Actualizar";
            }
        }

        private void DgvRepresentante_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvRepresentante.SelectedRows.Count > 0)
                TxtId.Text = DgvRepresentante.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}

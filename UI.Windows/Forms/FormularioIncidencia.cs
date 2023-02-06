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
    public partial class FormularioIncidencia : Form
    {
        private IncidenciaController incidenciaController;
        private IncidenciaViewModel incidenciaViewModel;
        public FormularioIncidencia()
        {
            InitializeComponent();
            incidenciaController = new IncidenciaController();
        }

        private void Insertar()
        {
            if (incidenciaController.Insertar(incidenciaViewModel))
            {
                Listar();
                MessageBox.Show("Incidencia insertada correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar la incidencia");
        }

        private void Listar()
        {
            DgvIncidencia.DataSource = incidenciaController.Listar();
        }

        private void Actualizar()
        {
            if (incidenciaController.Modificar(incidenciaViewModel))
            {
                MessageBox.Show("Incidencia actualizada!");
                Listar();
            }
            else
                MessageBox.Show("ERROR! No se pudo actualizar la incidencia");
        }

        private void Eliminar()
        {
            int id = 0;
            if (!string.IsNullOrEmpty(TxtId.Text))
            {
                id = Convert.ToInt32(TxtId.Text);
                if (incidenciaController.Eliminar(id))
                {
                    MessageBox.Show("Incidencia eliminado correctamente!");
                    Listar();
                }
                else
                    MessageBox.Show("ERROR! No se pudo eliminar la incidencia");
            }
            else
                MessageBox.Show("ERROR! No se pudo eliminar, seleccione una fila");
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            incidenciaViewModel = new IncidenciaViewModel();
            incidenciaViewModel.Fecha = DtpFecha.Value;
            incidenciaViewModel.Titulo = TxtTitulo.Text;
            incidenciaViewModel.Tipo = TxtTipo.Text;
            incidenciaViewModel.Mensaje = TxtMensaje.Text;
            incidenciaViewModel.RutaId = Convert.ToInt32(TxtRutaId.Text);

            if (string.IsNullOrEmpty(TxtId.Text))
                Insertar();
            else
            {
                incidenciaViewModel.IncidenciaId = Convert.ToInt32(TxtId.Text);
                Actualizar();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioIncidencia_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void DgvIncidencia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvIncidencia.SelectedRows.Count > 0)
            {
                TxtId.Text = DgvIncidencia.CurrentRow.Cells[0].Value.ToString();
                TxtTipo.Text = DgvIncidencia.CurrentRow.Cells[1].Value.ToString();
                TxtTitulo.Text = DgvIncidencia.CurrentRow.Cells[2].Value.ToString();
                TxtMensaje.Text = DgvIncidencia.CurrentRow.Cells[3].Value.ToString();
                TxtRutaId.Text = DgvIncidencia.CurrentRow.Cells[4].Value.ToString();
                DtpFecha.Value = Convert.ToDateTime(DgvIncidencia.CurrentRow.Cells[5].Value);
                BtnInsertar.Text = "Actualizar";
            }
        }

        private void DgvIncidencia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvIncidencia.SelectedRows.Count > 0)
                TxtId.Text = DgvIncidencia.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

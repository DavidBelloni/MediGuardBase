using BLL;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DOMAIN.Enums;

namespace UI
{
    public partial class Triage : Form
    {
        public Triage()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Triage_Load(object sender, EventArgs e)
        {
            // Instanciar la lógica de negocio para visita
            var visitaLogic = new VisitaLogic();

            // Obtener la lista de visitas con pacientes en estado "Esperando Triage"
            var visitas = visitaLogic.ObtenerVisitasPorEstado(EstadoVisita.EsperandoTriage);

            // Transformar las visitas y pacientes en el ViewModel
            var visitasViewModel = visitas.Select(v => new VisitaPacienteViewModel
            {
                idPaciente = v.idPaciente,
                nombre = v.Paciente.nombre,
                apellido = v.Paciente.apellido,
                numeroDocumento = v.Paciente.numeroDocumento.ToString(),
                sexo = v.Paciente.sexo,
                fechaNacimiento = v.Paciente.fechaNacimiento,
                grupoRiesgo = v.grupoRiesgo
            }).ToList();

            // Asignar la lista al DataGridView
            dgvVisitasTriage.DataSource = visitasViewModel;
        }

        private void dgvVisitasTriage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtener el objeto seleccionado del DataGridView
                var visitaSeleccionada = (VisitaPacienteViewModel)dgvVisitasTriage.Rows[e.RowIndex].DataBoundItem;

                // Autocompletar los campos de texto
                txtNombre.Text = visitaSeleccionada.nombre;
                txtApellido.Text = visitaSeleccionada.apellido;
                txtDocumento.Text = visitaSeleccionada.numeroDocumento;
                txtSexo.Text = visitaSeleccionada.sexo.ToString();
                txtEdad.Text = visitaSeleccionada.Edad.ToString();
                txtGrupoRiesgo.Text = visitaSeleccionada.grupoRiesgo.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

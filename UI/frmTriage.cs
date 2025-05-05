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
    public partial class frmTriage : Form
    {
        public frmTriage()
        {
            InitializeComponent();
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
                //idPaciente = v.idPaciente,
                nombre = v.Paciente.nombre,
                apellido = v.Paciente.apellido,
                numeroDocumento = v.Paciente.numeroDocumento.ToString(),
                sexo = v.Paciente.sexo,
                fechaNacimiento = v.Paciente.fechaNacimiento,
                grupoRiesgo = v.grupoRiesgo
            }).ToList();

            // Asignar la lista al DataGridView
            dgvVisitasTriage.DataSource = visitasViewModel;

            // PENDIENTE ORDENAR LA LISTA POR PRIORIDAD Y ORDEN DE LLEGADA
            // METER UN REFRESH EN LA DGV PARA 5 SEG
            // Convert.ToInt32(dgvVisitasTriage.CurrentRow.Cells["idVisita"].Value),
        }

        private void dgvVisitasTriage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtener el objeto seleccionado del DataGridView
                var dataBoundItem = dgvVisitasTriage.Rows[e.RowIndex].DataBoundItem;

                if (dataBoundItem == null)
                {
                    MessageBox.Show("No se encontró un objeto vinculado a la fila seleccionada.");
                    return;
                }

                // Verifica el tipo del objeto
                Console.WriteLine($"Tipo de DataBoundItem: {dataBoundItem.GetType().Name}");

                if (dataBoundItem is VisitaPacienteViewModel visitaSeleccionada)
                {
                    // Autocompletar los campos de texto
                    txtNombre.Text = visitaSeleccionada.nombre;
                    txtApellido.Text = visitaSeleccionada.apellido;
                    txtDocumento.Text = visitaSeleccionada.numeroDocumento;
                    txtSexo.Text = visitaSeleccionada.sexo.ToString();
                    txtEdad.Text = visitaSeleccionada.Edad.ToString();
                    txtGrupoRiesgo.Text = visitaSeleccionada.grupoRiesgo.ToString();
                }
                else
                {
                    MessageBox.Show("El objeto vinculado no es del tipo esperado (VisitaPacienteViewModel).");
                }
            }
        }

        private void btnRegistrarTriage_Click(object sender, EventArgs e)
        {
            //Capturar datos del Form
            var triageLogic = new TriageLogic();

            var triage = new Triage
            {
                motivoVisita = txtMotivoVisita.Text,
                nivelUrgencia = (NivelUrgencia)Enum.Parse(typeof(NivelUrgencia), cbNivelUrgencia.SelectedItem.ToString()),
                observaciones = txtObservaciones.Text,
                especialidad = (TipoEspecialidad)Enum.Parse(typeof(TipoEspecialidad), cbEspecialidad.SelectedItem.ToString()),
                temperatura = Convert.ToInt32(txtTemp.Text),
                frecuenciaCardiaca = Convert.ToInt32(txtFC.Text),
                presionArterial = txtPA.Text,
                saturacionOxigeno = Convert.ToInt32(txtO2.Text),
            };

            // Registrar Triage
            try
            {
                 triageLogic.RegistrarTriage(triage);
                 MessageBox.Show("Triage registrado exitosamente.");
            }
            
            catch (Exception ex)
            {
                 MessageBox.Show($"Error al registrar el triage: {ex.Message}");
            }

            // ACTUALIZAR VISITA (ESTO DEBERIA CAMBIAR EL ESTADO DE LA VISITA Y SACAR AL PACIENTE DE LA LISTA)

        }
    }
}

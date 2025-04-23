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

namespace UI
{
    public partial class Recepcion : Form
    {
        public Recepcion()
        {
            InitializeComponent();
        }

        private void Recepcion_Load(object sender, EventArgs e)
        {

        }

        // Método para buscar un paciente por DNI
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el DNI ingresado en el campo de texto  
                int dni;
                if (!int.TryParse(txtDocumento.Text, out dni))
                {
                    MessageBox.Show("Por favor, ingrese un Documento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Instanciar la lógica de negocio para pacientes  
                var pacienteLogic = new PacienteLogic();

                // Buscar el paciente por DNI  
                var pacientes = pacienteLogic.GetPacienteByDni(dni); // Asumiendo que devuelve una lista  

                if (pacientes != null && pacientes.Any())
                {
                    var paciente = pacientes.First(); // Obtener el primer paciente de la lista  

                    // Si el paciente existe, cargar los datos en el formulario  
                    txtNombre.Text = paciente.nombre;
                    txtApellido.Text = paciente.apellido;
                    txtEmail.Text = paciente.email;
                    txtCel.Text = paciente.celular;
                    cbSexo.SelectedItem = paciente.sexo;
                    cbTipoCobertura.SelectedItem = paciente.tipoCobertura;
                    txtCobertura.Text = paciente.coberturaMedica;
                    dtpFechaNacimiento.Value = paciente.fechaNacimiento;

                    MessageBox.Show("Paciente encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si el paciente no existe, limpiar el formulario y permitir el ingreso de datos  
                    LimpiarFormulario();
                    MessageBox.Show("El paciente no está registrado. Complete los datos para darlo de alta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores  
                MessageBox.Show($"Ocurrió un error al buscar el paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar el formulario
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtCel.Clear();
            cbSexo.SelectedIndex = -1;
            cbTipoCobertura.SelectedIndex = -1;
            txtCobertura.Clear();
            cbGrupoRiesgo.SelectedIndex = -1;
            txtFechaNacimiento.Clear();
        }

        // Método para registrar la visita
        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        // Método para registrar la visita
        private void btnRegistrarVisita_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los datos del formulario
                if (string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    cbGrupoRiesgo.SelectedIndex == -1) // Validar que el grupo de riesgo esté seleccionado
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios, incluido el grupo de riesgo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los datos del formulario
                int dni = int.Parse(txtDocumento.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text;
                string celular = txtCel.Text;
                string sexo = cbSexo.Text; // Texto seleccionado en el ComboBox
                string tipoCobertura = cbTipoCobertura.Text; // Texto seleccionado en el ComboBox
                string grupoRiesgo = cbGrupoRiesgo.Text; // Grupo de riesgo seleccionado
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;

                // Crear instancia de la lógica de negocio
                var pacienteLogic = new PacienteLogic();
                var visitaLogic = new VisitaLogic();

                // Buscar si el paciente ya existe
                var paciente = pacienteLogic.GetPacienteByDni(dni);

                if (paciente == null)
                {
                    // El paciente no existe, crear uno nuevo
                    paciente = new Paciente
                    {
                        numeroDocumento = dni,
                        tipoCobertura = (Enums.TipoCobertura)Enum.Parse(typeof(Enums.TipoCobertura), tipoCobertura),
                        nombre = nombre,
                        apellido = apellido,
                        email = email,
                        celular = celular,
                        sexo = (Enums.Sexo)Enum.Parse(typeof(Enums.Sexo), cbSexo.Text),
                        tipoCobertura = tipoCobertura,
                        fechaNacimiento = fechaNacimiento,
                    };

                    pacienteLogic.RegisterPaciente(paciente);
                }

                // Registrar la visita
                var visita = new Visita
                {
                    PacienteId = paciente.IdPaciente, // Asociar al ID del paciente
                    FechaHora = DateTime.Now,         // Fecha y hora de la visita
                    GrupoRiesgo = grupoRiesgo,       // Grupo de riesgo seleccionado
                    Motivo = txtMotivo.Text,         // Motivo de la visita
                    Observaciones = txtObservaciones.Text // Observaciones adicionales
                };

                visitaLogic.RegistrarVisita(visita);

                // Confirmar operación
                MessageBox.Show("La visita ha sido registrada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el formulario
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al registrar la visita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

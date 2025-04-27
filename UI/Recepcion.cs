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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                // Verificar si se seleccionó un tipo de documento
                if (cbTipoDocumento.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intentar convertir el texto del documento a un entero
                if (!int.TryParse(txtDocumento.Text, out int numeroDocumento) || numeroDocumento <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número de documento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Instanciar la lógica de negocio para pacientes  
                var pacienteLogic = new PacienteLogic();

                // Buscar el paciente por DNI  
                var paciente = pacienteLogic.GetPacienteByDni(numeroDocumento, (TipoDocumento?)cbTipoDocumento.SelectedItem);

                if (paciente != null)
                {
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
                    // Si el paciente no existe, limpiar el formulario
                    LimpiarFormulario();
                    MessageBox.Show("El paciente no está registrado. Complete los datos para darlo de alta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                // Mostrar mensaje de error específico desde la BLL
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
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
            dtpFechaNacimiento.Value = DateTime.Now;
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

                var paciente = new Paciente
                {
                    numeroDocumento = int.Parse(txtDocumento.Text),
                    tipoDocumento = (Enums.TipoDocumento)Enum.Parse(typeof(Enums.TipoDocumento), cbTipoDocumento.Text),
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    email = txtEmail.Text,
                    celular = txtCel.Text,
                    sexo = (Enums.Sexo)Enum.Parse(typeof(Enums.Sexo), cbSexo.Text),
                    tipoCobertura = (Enums.TipoCobertura)Enum.Parse(typeof(Enums.TipoCobertura), cbTipoCobertura.Text),
                    fechaNacimiento = dtpFechaNacimiento.Value,
                    coberturaMedica = txtCobertura.Text,
                };

                var grupoRiesgo = cbGrupoRiesgo.Text;

                // Registrar la visita mediante la lógica de negocio
                var visitaLogic = new VisitaLogic();
                visitaLogic.RegistrarVisita(paciente, grupoRiesgo);

                // Confirmar operación
                MessageBox.Show("La visita ha sido registrada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el formulario
                LimpiarFormulario();
            }

            catch (ArgumentException ex)
            {
                // Manejo de errores de validación
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                MessageBox.Show($"Ocurrió un error al registrar la visita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            //int numeroDocumento = int.Parse(txtDocumento.Text);
            //string tipoDocumento = cbTipoDocumento.Text;
            //string nombre = txtNombre.Text;
            //string apellido = txtApellido.Text;
            //string email = txtEmail.Text;
            //string celular = txtCel.Text;
            //string sexo = cbSexo.Text; // Texto seleccionado en el ComboBox
            //string tipoCobertura = cbTipoCobertura.Text; // Texto seleccionado en el ComboBox
            //string coberturaMedica = txtCobertura.Text;
            //string grupoRiesgo = cbGrupoRiesgo.Text; // Grupo de riesgo seleccionado
            //DateTime fechaNacimiento = dtpFechaNacimiento.Value;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

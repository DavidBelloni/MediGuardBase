using BLL.Services;
using BLL.Interfaces;
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
using System.Drawing.Text;
using Services.Facade;

namespace UI
{
    public partial class frmRecepcion : Form
    {
        public frmRecepcion()
        {
            InitializeComponent();

            // Suscribirse al evento de cambio de idioma
            IdiomaManager.IdiomaCambiado += OnIdiomaCambiado;
        }
        private void OnIdiomaCambiado()
        {
            // Actualizar las traducciones cuando el idioma cambie
            AplicarTraducciones();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Desuscribirse del evento para evitar problemas de memoria
            IdiomaManager.IdiomaCambiado -= OnIdiomaCambiado;
        }

        private void Recepcion_Load(object sender, EventArgs e)
        {
            AplicarTraducciones();
        }

        private void AplicarTraducciones()
        {
            // Usar el método Traducir para actualizar textos
            this.lblNombre.Text = "Nombre".Traducir();
            this.lblApellido.Text = "Apellido".Traducir();
            this.lblEmail.Text = "Email".Traducir();
            this.lblCelular.Text = "Celular".Traducir();
            this.lblSexo.Text = "Sexo".Traducir();
            this.lblFechaNacimiento.Text = "FechaNacimiento".Traducir();
            this.lblTipoCobertura.Text = "TipoCobertura".Traducir();
            this.lblCoberturaMedica.Text = "CoberturaMedica".Traducir();
            this.gbPrioridad.Text = "Prioridad".Traducir();
            this.lblGrupoRiesgo.Text = "GrupoDeRiesgo".Traducir();
            this.btnRegistrarVisita.Text = "RegistrarVisita".Traducir();
            this.btnBuscar.Text = "Buscar".Traducir();
            this.gbDatosPersonales.Text = "DatosPersonales".Traducir();
            this.gbPacientesEsperandoTriage.Text = "PacientesEsperandoTriage".Traducir();

        }

        // Método para buscar un paciente por DNI
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar la lógica de negocio para pacientes  
                var pacienteServices = new PacienteServices();

                // Buscar el paciente por DNI  
                var paciente = pacienteServices.GetPacienteByDni(Int32.Parse(txtDocumento.Text), (Enums.TipoDocumento)Enum.Parse(typeof(Enums.TipoDocumento), cbTipoDocumento.Text));

                if (paciente != null)
                {
                    // Si el paciente existe, cargar los datos en el formulario
                    txtNombre.Text = paciente.Nombre;
                    txtApellido.Text = paciente.Apellido;
                    txtEmail.Text = paciente.Email;
                    txtCel.Text = paciente.Celular;
                    cbSexo.SelectedIndex = (int)paciente.Sexo;
                    cbTipoCobertura.SelectedIndex = (int)paciente.TipoCobertura;
                    txtCobertura.Text = paciente.CoberturaMedica;
                    dtpFechaNacimiento.Value = paciente.FechaNacimiento;

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
            //cbTipoDocumento.SelectedIndex = -1;
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
                    NumeroDocumento = int.Parse(txtDocumento.Text),
                    TipoDocumento = (Enums.TipoDocumento)Enum.Parse(typeof(Enums.TipoDocumento), cbTipoDocumento.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Celular = txtCel.Text,
                    Sexo = (Enums.Sexo)Enum.Parse(typeof(Enums.Sexo), cbSexo.Text),
                    TipoCobertura = (Enums.TipoCobertura)Enum.Parse(typeof(Enums.TipoCobertura), cbTipoCobertura.Text),
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    CoberturaMedica = txtCobertura.Text,
                };

                var grupoRiesgo = cbGrupoRiesgo.Text;

                // Registrar la visita mediante la lógica de negocio
                var visitaServices = new VisitaServices();
                visitaServices.RegistrarVisita(paciente, grupoRiesgo);

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
    }
}

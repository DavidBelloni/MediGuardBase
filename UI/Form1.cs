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
    public partial class Form1: Form
    {
        private PatientLogic patientLogic;
        public Form1()
        {
            InitializeComponent();

            patientLogic = new PatientLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Obtener los datos del paciente desde los controles del formulario
            var patient = new Patient
            {
                idPatient = Guid.NewGuid(),
                dni = int.Parse(textBoxDni.Text),
                name = textBoxName.Text,
                lastName = textBoxLastName.Text,
                phone = textBoxPhone.Text,
                email = textBoxEmail.Text,
                riskGroup = comboBoxRiskGroup.SelectedItem.ToString(),
                ticketNumber = textBoxTicketNumber.Text
            };

            // Llamar al método RegisterPatient para registrar el paciente
            patientLogic.RegisterPatient(patient);

            // Mostrar un mensaje confirmando el registro
            MessageBox.Show("Paciente registrado exitosamente.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTicketNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

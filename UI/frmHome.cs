using BLL.Services;
using Services.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            // Asociar eventos de clic para las opciones de idioma
            españolToolStripMenuItem.Click += (sender, args) => CambiarIdioma("es-ES");
            inglesToolStripMenuItem.Click += (sender, args) => CambiarIdioma("en-US");
        }

        private void CambiarIdioma(string cultura)
        {
            // Cambiar la cultura de la aplicación y dispara el evento de cambio de idioma
            IdiomaManager.IdiomaActual = cultura; 

            // Aplicar traducciones al formulario
            AplicarTraducciones();
        }

        private void AplicarTraducciones()
        {
            // Usar el método Traducir para actualizar textos
            this.recepciónToolStripMenuItem.Text = "Recepcion".Traducir();
            this.triageToolStripMenuItem.Text = "Triage".Traducir();
            this.medicoToolStripMenuItem.Text = "Medico".Traducir();
            this.administradorToolStripMenuItem.Text = "Administrador".Traducir();
            this.españolToolStripMenuItem.Text = "Español".Traducir();
            this.inglesToolStripMenuItem.Text = "Ingles".Traducir();
        }

        private void recepciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario frmRecepcion
            frmRecepcion recepcion = new frmRecepcion();
            recepcion.MdiParent = this; // Establece el formulario actual como padre
            recepcion.Show(); // Muestra el formulario hijo
        }

        private void triageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Triage
            frmTriage triage = new frmTriage();
            triage.MdiParent = this; // Establece el formulario actual como padre
            triage.Show(); // Muestra el formulario hijo
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

    }
}

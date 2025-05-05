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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
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
    }
}

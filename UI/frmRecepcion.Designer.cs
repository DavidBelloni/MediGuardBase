namespace UI
{
    partial class frmRecepcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarVisita = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCoberturaMedica = new System.Windows.Forms.Label();
            this.lblTipoCobertura = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtCobertura = new System.Windows.Forms.TextBox();
            this.cbGrupoRiesgo = new System.Windows.Forms.ComboBox();
            this.lblGrupoRiesgo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbTipoCobertura = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.gbPrioridad = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEsperandoTriage = new System.Windows.Forms.DataGridView();
            this.gbPacientesEsperandoTriage = new System.Windows.Forms.GroupBox();
            this.gbDatosPersonales.SuspendLayout();
            this.gbPrioridad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsperandoTriage)).BeginInit();
            this.gbPacientesEsperandoTriage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarVisita
            // 
            this.btnRegistrarVisita.Location = new System.Drawing.Point(23, 566);
            this.btnRegistrarVisita.Name = "btnRegistrarVisita";
            this.btnRegistrarVisita.Size = new System.Drawing.Size(189, 37);
            this.btnRegistrarVisita.TabIndex = 0;
            this.btnRegistrarVisita.Text = "Registrar Visita";
            this.btnRegistrarVisita.UseVisualStyleBackColor = true;
            this.btnRegistrarVisita.Click += new System.EventHandler(this.btnRegistrarVisita_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(281, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 29);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 152);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(14, 191);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(257, 35);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblCoberturaMedica
            // 
            this.lblCoberturaMedica.AutoSize = true;
            this.lblCoberturaMedica.Location = new System.Drawing.Point(257, 113);
            this.lblCoberturaMedica.Name = "lblCoberturaMedica";
            this.lblCoberturaMedica.Size = new System.Drawing.Size(94, 13);
            this.lblCoberturaMedica.TabIndex = 9;
            this.lblCoberturaMedica.Text = "Cobertura Medica:";
            // 
            // lblTipoCobertura
            // 
            this.lblTipoCobertura.AutoSize = true;
            this.lblTipoCobertura.Location = new System.Drawing.Point(257, 74);
            this.lblTipoCobertura.Name = "lblTipoCobertura";
            this.lblTipoCobertura.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCobertura.TabIndex = 10;
            this.lblTipoCobertura.Text = "Tipo Cobertura:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(105, 41);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(145, 20);
            this.txtDocumento.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(16, 90);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(190, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(16, 168);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(190, 20);
            this.txtCel.TabIndex = 15;
            // 
            // txtCobertura
            // 
            this.txtCobertura.Location = new System.Drawing.Point(260, 129);
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.Size = new System.Drawing.Size(188, 20);
            this.txtCobertura.TabIndex = 19;
            // 
            // cbGrupoRiesgo
            // 
            this.cbGrupoRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoRiesgo.FormattingEnabled = true;
            this.cbGrupoRiesgo.Items.AddRange(new object[] {
            "Mayor80",
            "Inmunosuprimido",
            "LactanteMenor30Dias",
            "Embarazada",
            "NoPertenece"});
            this.cbGrupoRiesgo.Location = new System.Drawing.Point(260, 19);
            this.cbGrupoRiesgo.Name = "cbGrupoRiesgo";
            this.cbGrupoRiesgo.Size = new System.Drawing.Size(188, 21);
            this.cbGrupoRiesgo.TabIndex = 21;
            // 
            // lblGrupoRiesgo
            // 
            this.lblGrupoRiesgo.AutoSize = true;
            this.lblGrupoRiesgo.Location = new System.Drawing.Point(14, 22);
            this.lblGrupoRiesgo.Name = "lblGrupoRiesgo";
            this.lblGrupoRiesgo.Size = new System.Drawing.Size(90, 13);
            this.lblGrupoRiesgo.TabIndex = 22;
            this.lblGrupoRiesgo.Text = "Grupo de Riesgo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino\t",
            "Femenino",
            "Otro"});
            this.cbSexo.Location = new System.Drawing.Point(17, 207);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(189, 21);
            this.cbSexo.TabIndex = 23;
            // 
            // cbTipoCobertura
            // 
            this.cbTipoCobertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCobertura.FormattingEnabled = true;
            this.cbTipoCobertura.Items.AddRange(new object[] {
            "ObraSocial",
            "Prepaga",
            "Particular"});
            this.cbTipoCobertura.Location = new System.Drawing.Point(260, 90);
            this.cbTipoCobertura.Name = "cbTipoCobertura";
            this.cbTipoCobertura.Size = new System.Drawing.Size(188, 21);
            this.cbTipoCobertura.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tipo:";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Cedula"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(10, 41);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(89, 21);
            this.cbTipoDocumento.TabIndex = 26;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(260, 51);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(188, 20);
            this.dtpFechaNacimiento.TabIndex = 27;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.cbSexo);
            this.gbDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.lblApellido);
            this.gbDatosPersonales.Controls.Add(this.lblEmail);
            this.gbDatosPersonales.Controls.Add(this.cbTipoCobertura);
            this.gbDatosPersonales.Controls.Add(this.lblCelular);
            this.gbDatosPersonales.Controls.Add(this.lblSexo);
            this.gbDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblCoberturaMedica);
            this.gbDatosPersonales.Controls.Add(this.lblTipoCobertura);
            this.gbDatosPersonales.Controls.Add(this.txtCobertura);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.txtCel);
            this.gbDatosPersonales.Controls.Add(this.txtApellido);
            this.gbDatosPersonales.Controls.Add(this.txtEmail);
            this.gbDatosPersonales.Location = new System.Drawing.Point(23, 144);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(465, 251);
            this.gbDatosPersonales.TabIndex = 28;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales:";
            // 
            // gbPrioridad
            // 
            this.gbPrioridad.Controls.Add(this.cbGrupoRiesgo);
            this.gbPrioridad.Controls.Add(this.lblGrupoRiesgo);
            this.gbPrioridad.Location = new System.Drawing.Point(23, 401);
            this.gbPrioridad.Name = "gbPrioridad";
            this.gbPrioridad.Size = new System.Drawing.Size(465, 57);
            this.gbPrioridad.TabIndex = 29;
            this.gbPrioridad.TabStop = false;
            this.gbPrioridad.Text = "Prioridad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDocumento);
            this.groupBox3.Controls.Add(this.cbTipoDocumento);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(27, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 80);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda:";
            // 
            // dgvEsperandoTriage
            // 
            this.dgvEsperandoTriage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEsperandoTriage.Location = new System.Drawing.Point(6, 19);
            this.dgvEsperandoTriage.Name = "dgvEsperandoTriage";
            this.dgvEsperandoTriage.Size = new System.Drawing.Size(352, 375);
            this.dgvEsperandoTriage.TabIndex = 31;
            // 
            // gbPacientesEsperandoTriage
            // 
            this.gbPacientesEsperandoTriage.Controls.Add(this.dgvEsperandoTriage);
            this.gbPacientesEsperandoTriage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPacientesEsperandoTriage.Location = new System.Drawing.Point(494, 58);
            this.gbPacientesEsperandoTriage.Name = "gbPacientesEsperandoTriage";
            this.gbPacientesEsperandoTriage.Size = new System.Drawing.Size(364, 400);
            this.gbPacientesEsperandoTriage.TabIndex = 32;
            this.gbPacientesEsperandoTriage.TabStop = false;
            this.gbPacientesEsperandoTriage.Text = "Pacientes Esperando Triage:";
            // 
            // frmRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(871, 626);
            this.Controls.Add(this.gbPacientesEsperandoTriage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPrioridad);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.btnRegistrarVisita);
            this.Name = "frmRecepcion";
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.Recepcion_Load);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbPrioridad.ResumeLayout(false);
            this.gbPrioridad.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsperandoTriage)).EndInit();
            this.gbPacientesEsperandoTriage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarVisita;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCoberturaMedica;
        private System.Windows.Forms.Label lblTipoCobertura;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtCobertura;
        private System.Windows.Forms.ComboBox cbGrupoRiesgo;
        private System.Windows.Forms.Label lblGrupoRiesgo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbTipoCobertura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.GroupBox gbPrioridad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEsperandoTriage;
        private System.Windows.Forms.GroupBox gbPacientesEsperandoTriage;
    }
}
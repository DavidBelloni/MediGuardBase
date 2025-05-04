namespace UI
{
    partial class Triage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVisitasTriage = new System.Windows.Forms.DataGridView();
            this.visitaPacienteViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtGrupoRiesgo = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtO2 = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrioridad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnRegistrarTriage = new System.Windows.Forms.Button();
            this.btnAusente = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.btnAtencionInmediata = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitasTriage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitaPacienteViewModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVisitasTriage
            // 
            this.dgvVisitasTriage.AllowUserToAddRows = false;
            this.dgvVisitasTriage.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvVisitasTriage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVisitasTriage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisitasTriage.AutoGenerateColumns = false;
            this.dgvVisitasTriage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisitasTriage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitasTriage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVisitasTriage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitasTriage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.grupoRiesgo});
            this.dgvVisitasTriage.DataSource = this.visitaPacienteViewModelBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitasTriage.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVisitasTriage.EnableHeadersVisualStyles = false;
            this.dgvVisitasTriage.Location = new System.Drawing.Point(12, 43);
            this.dgvVisitasTriage.Name = "dgvVisitasTriage";
            this.dgvVisitasTriage.ReadOnly = true;
            this.dgvVisitasTriage.Size = new System.Drawing.Size(476, 531);
            this.dgvVisitasTriage.TabIndex = 0;
            this.dgvVisitasTriage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitasTriage_CellClick);
            // 
            // visitaPacienteViewModelBindingSource
            // 
            this.visitaPacienteViewModelBindingSource.DataSource = typeof(DOMAIN.VisitaPacienteViewModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtGrupoRiesgo);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(494, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(235, 43);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(53, 20);
            this.txtEdad.TabIndex = 35;
            // 
            // txtGrupoRiesgo
            // 
            this.txtGrupoRiesgo.Location = new System.Drawing.Point(235, 147);
            this.txtGrupoRiesgo.Name = "txtGrupoRiesgo";
            this.txtGrupoRiesgo.ReadOnly = true;
            this.txtGrupoRiesgo.Size = new System.Drawing.Size(189, 20);
            this.txtGrupoRiesgo.TabIndex = 34;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(18, 147);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(189, 20);
            this.txtSexo.TabIndex = 33;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(18, 43);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(130, 20);
            this.txtDocumento.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Documento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Grupo de Riesgo:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(235, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(190, 20);
            this.txtApellido.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.txtO2);
            this.groupBox2.Controls.Add(this.txtPA);
            this.groupBox2.Controls.Add(this.txtFC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTemp);
            this.groupBox2.Controls.Add(this.cbEspecialidad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrioridad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Location = new System.Drawing.Point(494, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 340);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(16, 109);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(407, 77);
            this.txtObservaciones.TabIndex = 16;
            // 
            // txtO2
            // 
            this.txtO2.Location = new System.Drawing.Point(342, 299);
            this.txtO2.Name = "txtO2";
            this.txtO2.Size = new System.Drawing.Size(81, 20);
            this.txtO2.TabIndex = 15;
            // 
            // txtPA
            // 
            this.txtPA.Location = new System.Drawing.Point(235, 299);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(81, 20);
            this.txtPA.TabIndex = 14;
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(126, 299);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(81, 20);
            this.txtFC.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "SpO2 (%):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(232, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "PA (s/d):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "FC (lpm): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Temperatura (Cº):";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(16, 299);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(81, 20);
            this.txtTemp.TabIndex = 8;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(16, 252);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(407, 21);
            this.cbEspecialidad.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Especialidad Requerida:";
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.FormattingEnabled = true;
            this.txtPrioridad.Location = new System.Drawing.Point(16, 205);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(407, 21);
            this.txtPrioridad.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Prioridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Motivo de Visita:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(16, 40);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(407, 50);
            this.txtMotivo.TabIndex = 1;
            // 
            // btnRegistrarTriage
            // 
            this.btnRegistrarTriage.Location = new System.Drawing.Point(836, 580);
            this.btnRegistrarTriage.Name = "btnRegistrarTriage";
            this.btnRegistrarTriage.Size = new System.Drawing.Size(104, 50);
            this.btnRegistrarTriage.TabIndex = 3;
            this.btnRegistrarTriage.Text = "Registrar Triage";
            this.btnRegistrarTriage.UseVisualStyleBackColor = true;
            // 
            // btnAusente
            // 
            this.btnAusente.Location = new System.Drawing.Point(12, 580);
            this.btnAusente.Name = "btnAusente";
            this.btnAusente.Size = new System.Drawing.Size(124, 50);
            this.btnAusente.TabIndex = 4;
            this.btnAusente.Text = "Marcar Ausente";
            this.btnAusente.UseVisualStyleBackColor = true;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Location = new System.Drawing.Point(146, 580);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(124, 50);
            this.btnReimprimir.TabIndex = 5;
            this.btnReimprimir.Text = "Reimprimir Ticket";
            this.btnReimprimir.UseVisualStyleBackColor = true;
            // 
            // btnAtencionInmediata
            // 
            this.btnAtencionInmediata.Location = new System.Drawing.Point(718, 580);
            this.btnAtencionInmediata.Name = "btnAtencionInmediata";
            this.btnAtencionInmediata.Size = new System.Drawing.Size(112, 50);
            this.btnAtencionInmediata.TabIndex = 6;
            this.btnAtencionInmediata.Text = "Atención Inmediata";
            this.btnAtencionInmediata.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(930, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "EVALUACIÓN DE TRIAGE";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 110;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 120;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "numeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDocumentoDataGridViewTextBoxColumn.Width = 70;
            // 
            // grupoRiesgo
            // 
            this.grupoRiesgo.DataPropertyName = "grupoRiesgo";
            this.grupoRiesgo.HeaderText = "Grupo de Riesgo";
            this.grupoRiesgo.Name = "grupoRiesgo";
            this.grupoRiesgo.ReadOnly = true;
            this.grupoRiesgo.Width = 135;
            // 
            // Triage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 641);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtencionInmediata);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnAusente);
            this.Controls.Add(this.btnRegistrarTriage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVisitasTriage);
            this.Name = "Triage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triage";
            this.Load += new System.EventHandler(this.Triage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitasTriage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitaPacienteViewModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitasTriage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtGrupoRiesgo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnRegistrarTriage;
        private System.Windows.Forms.Button btnAusente;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.Button btnAtencionInmediata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtPrioridad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.TextBox txtO2;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.BindingSource visitaPacienteViewModelBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoRiesgo;
    }
}
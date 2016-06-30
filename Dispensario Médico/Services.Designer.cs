namespace Dispensario_Médico
{
    partial class Services
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnFarmacos = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbServiciosTitle = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dispensarioDataSet = new Dispensario_Médico.DispensarioDataSet();
            this.dispensarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmacoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmacoTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.FarmacoTableAdapter();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.MarcaTableAdapter();
            this.marcaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.MedicamentoTableAdapter();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.PacienteTableAdapter();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.MedicoTableAdapter();
            this.registroVisitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registro_VisitaTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.Registro_VisitaTableAdapter();
            this.tipoPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_PacienteTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.Tipo_PacienteTableAdapter();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_UsuarioTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.Tipo_UsuarioTableAdapter();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.UbicacionTableAdapter();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Dispensario_Médico.DispensarioDataSetTableAdapters.UsuarioTableAdapter();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.medicamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmacoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroVisitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUsers);
            this.groupBox1.Controls.Add(this.btnVisitas);
            this.groupBox1.Controls.Add(this.btnUbicaciones);
            this.groupBox1.Controls.Add(this.btnPacientes);
            this.groupBox1.Controls.Add(this.btnMedicamentos);
            this.groupBox1.Controls.Add(this.btnMarcas);
            this.groupBox1.Controls.Add(this.btnFarmacos);
            this.groupBox1.Controls.Add(this.btnMedicos);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Lavender;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(1, 474);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(170, 80);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnVisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitas.Location = new System.Drawing.Point(1, 553);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Size = new System.Drawing.Size(170, 80);
            this.btnVisitas.TabIndex = 13;
            this.btnVisitas.Text = "Visitas";
            this.btnVisitas.UseVisualStyleBackColor = false;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.BackColor = System.Drawing.Color.Plum;
            this.btnUbicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicaciones.Location = new System.Drawing.Point(1, 395);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(170, 80);
            this.btnUbicaciones.TabIndex = 11;
            this.btnUbicaciones.Text = "Ubicaciones";
            this.btnUbicaciones.UseVisualStyleBackColor = false;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(1, 237);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(170, 80);
            this.btnPacientes.TabIndex = 9;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.Location = new System.Drawing.Point(1, 79);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(170, 80);
            this.btnMedicamentos.TabIndex = 7;
            this.btnMedicamentos.Text = "Medicamentos";
            this.btnMedicamentos.UseVisualStyleBackColor = false;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(1, 0);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(170, 80);
            this.btnMarcas.TabIndex = 6;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnFarmacos
            // 
            this.btnFarmacos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFarmacos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFarmacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmacos.Location = new System.Drawing.Point(1, 316);
            this.btnFarmacos.Name = "btnFarmacos";
            this.btnFarmacos.Size = new System.Drawing.Size(170, 80);
            this.btnFarmacos.TabIndex = 10;
            this.btnFarmacos.Text = "Tipos de Fármacos";
            this.btnFarmacos.UseVisualStyleBackColor = false;
            this.btnFarmacos.Click += new System.EventHandler(this.btnFarmacos_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.Location = new System.Drawing.Point(1, 158);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(170, 80);
            this.btnMedicos.TabIndex = 8;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnDisable);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(301, 521);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 83);
            this.groupBox2.TabIndex = 1000;
            this.groupBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(0, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 70);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisable.Location = new System.Drawing.Point(498, 9);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(80, 70);
            this.btnDisable.TabIndex = 5;
            this.btnDisable.Text = "Desactivar";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(387, 9);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 70);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(276, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 70);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(166, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 70);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbServiciosTitle
            // 
            this.lbServiciosTitle.AutoSize = true;
            this.lbServiciosTitle.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiciosTitle.Location = new System.Drawing.Point(456, 16);
            this.lbServiciosTitle.Name = "lbServiciosTitle";
            this.lbServiciosTitle.Size = new System.Drawing.Size(242, 85);
            this.lbServiciosTitle.TabIndex = 12;
            this.lbServiciosTitle.Text = "Servicios";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(204, 123);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServices.Size = new System.Drawing.Size(782, 369);
            this.dgvServices.TabIndex = 14;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            this.dgvServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellDoubleClick);
            // 
            // dispensarioDataSet
            // 
            this.dispensarioDataSet.DataSetName = "DispensarioDataSet";
            this.dispensarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispensarioDataSetBindingSource
            // 
            this.dispensarioDataSetBindingSource.DataSource = this.dispensarioDataSet;
            this.dispensarioDataSetBindingSource.Position = 0;
            // 
            // farmacoBindingSource
            // 
            this.farmacoBindingSource.DataMember = "Farmaco";
            this.farmacoBindingSource.DataSource = this.dispensarioDataSet;
            // 
            // farmacoTableAdapter
            // 
            this.farmacoTableAdapter.ClearBeforeFill = true;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // marcaBindingSource1
            // 
            this.marcaBindingSource1.DataMember = "Marca";
            this.marcaBindingSource1.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataMember = "Medicamento";
            this.medicamentoBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // medicamentoTableAdapter
            // 
            this.medicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // registroVisitaBindingSource
            // 
            this.registroVisitaBindingSource.DataMember = "Registro_Visita";
            this.registroVisitaBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // registro_VisitaTableAdapter
            // 
            this.registro_VisitaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoPacienteBindingSource
            // 
            this.tipoPacienteBindingSource.DataMember = "Tipo_Paciente";
            this.tipoPacienteBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // tipo_PacienteTableAdapter
            // 
            this.tipo_PacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "Tipo_Usuario";
            this.tipoUsuarioBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // tipo_UsuarioTableAdapter
            // 
            this.tipo_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataMember = "Ubicacion";
            this.ubicacionBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // ubicacionTableAdapter
            // 
            this.ubicacionTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(948, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(10, 10);
            this.pbImagen.TabIndex = 14;
            this.pbImagen.TabStop = false;
            this.pbImagen.Visible = false;
            // 
            // medicamentoBindingSource1
            // 
            this.medicamentoBindingSource1.DataMember = "Medicamento";
            this.medicamentoBindingSource1.DataSource = this.dispensarioDataSetBindingSource;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 633);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.lbServiciosTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1033, 672);
            this.MinimumSize = new System.Drawing.Size(1033, 672);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Services_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmacoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroVisitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbServiciosTitle;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.BindingSource dispensarioDataSetBindingSource;
        private DispensarioDataSet dispensarioDataSet;
        private System.Windows.Forms.BindingSource farmacoBindingSource;
        private DispensarioDataSetTableAdapters.FarmacoTableAdapter farmacoTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private DispensarioDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource1;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private DispensarioDataSetTableAdapters.MedicamentoTableAdapter medicamentoTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private DispensarioDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private DispensarioDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.BindingSource registroVisitaBindingSource;
        private DispensarioDataSetTableAdapters.Registro_VisitaTableAdapter registro_VisitaTableAdapter;
        private System.Windows.Forms.BindingSource tipoPacienteBindingSource;
        private DispensarioDataSetTableAdapters.Tipo_PacienteTableAdapter tipo_PacienteTableAdapter;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private DispensarioDataSetTableAdapters.Tipo_UsuarioTableAdapter tipo_UsuarioTableAdapter;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private DispensarioDataSetTableAdapters.UbicacionTableAdapter ubicacionTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DispensarioDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        public System.Windows.Forms.Button btnPacientes;
        public System.Windows.Forms.Button btnMarcas;
        public System.Windows.Forms.Button btnFarmacos;
        public System.Windows.Forms.Button btnMedicos;
        public System.Windows.Forms.Button btnMedicamentos;
        public System.Windows.Forms.Button btnUbicaciones;
        public System.Windows.Forms.Button btnVisitas;
        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.BindingSource medicamentoBindingSource1;
    }
}
namespace Dispensario_Médico
{
    partial class Consultas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBusquedaNormal = new System.Windows.Forms.Button();
            this.cbEntidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCriterioBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaMax = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaMin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 85);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnBusquedaNormal);
            this.groupBox1.Location = new System.Drawing.Point(57, 539);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 70);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBusquedaNormal
            // 
            this.btnBusquedaNormal.Enabled = false;
            this.btnBusquedaNormal.Location = new System.Drawing.Point(746, 0);
            this.btnBusquedaNormal.Name = "btnBusquedaNormal";
            this.btnBusquedaNormal.Size = new System.Drawing.Size(80, 70);
            this.btnBusquedaNormal.TabIndex = 6;
            this.btnBusquedaNormal.Text = "Buscar";
            this.btnBusquedaNormal.UseVisualStyleBackColor = true;
            this.btnBusquedaNormal.Click += new System.EventHandler(this.btnBusquedaNormal_Click);
            // 
            // cbEntidad
            // 
            this.cbEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntidad.FormattingEnabled = true;
            this.cbEntidad.Items.AddRange(new object[] {
            "Marcas",
            "Medicamentos",
            "Médicos",
            "Tipo de Fármacos",
            "Pacientes",
            "Visitas",
            "Tipos de Paciente",
            "Tipos de Usuario",
            "Ubicaciones",
            "Usuarios"});
            this.cbEntidad.Location = new System.Drawing.Point(58, 27);
            this.cbEntidad.Name = "cbEntidad";
            this.cbEntidad.Size = new System.Drawing.Size(175, 21);
            this.cbEntidad.TabIndex = 1;
            this.cbEntidad.SelectedIndexChanged += new System.EventHandler(this.cbEntidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Elemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Campo";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.Enabled = false;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Marcas",
            "Medicamentos",
            "Médicos",
            "Tipo de Fármacos",
            "Pacientes",
            "Visitas",
            "Tipos de Pacientes",
            "Tipos de Usuario",
            "Ubicaciones",
            "Usuarios"});
            this.cbCampo.Location = new System.Drawing.Point(309, 27);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(186, 21);
            this.cbCampo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Criterio de Búsqueda";
            // 
            // txtCriterioBusqueda
            // 
            this.txtCriterioBusqueda.Enabled = false;
            this.txtCriterioBusqueda.Location = new System.Drawing.Point(632, 28);
            this.txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            this.txtCriterioBusqueda.Size = new System.Drawing.Size(194, 20);
            this.txtCriterioBusqueda.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaMax);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpFechaMin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbEntidad);
            this.groupBox2.Controls.Add(this.txtCriterioBusqueda);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbCampo);
            this.groupBox2.Location = new System.Drawing.Point(57, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 111);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // dtpFechaMax
            // 
            this.dtpFechaMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaMax.CustomFormat = "dd MMM yyyy - hh:mm";
            this.dtpFechaMax.Enabled = false;
            this.dtpFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMax.Location = new System.Drawing.Point(484, 74);
            this.dtpFechaMax.Name = "dtpFechaMax";
            this.dtpFechaMax.Size = new System.Drawing.Size(214, 20);
            this.dtpFechaMax.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hasta";
            // 
            // dtpFechaMin
            // 
            this.dtpFechaMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaMin.CustomFormat = "dd MMM yyyy - hh:mm";
            this.dtpFechaMin.Enabled = false;
            this.dtpFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMin.Location = new System.Drawing.Point(152, 74);
            this.dtpFechaMin.Name = "dtpFechaMin";
            this.dtpFechaMin.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaMin.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Desde";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(13, 20);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 25;
            this.lbUsuario.Text = "label7";
            this.lbUsuario.Visible = false;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Location = new System.Drawing.Point(12, 52);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbTipoUsuario.TabIndex = 26;
            this.lbTipoUsuario.Text = "label8";
            this.lbTipoUsuario.Visible = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(13, 69);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(34, 21);
            this.pbFoto.TabIndex = 27;
            this.pbFoto.TabStop = false;
            this.pbFoto.Visible = false;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 621);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lbTipoUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(960, 660);
            this.MinimumSize = new System.Drawing.Size(960, 660);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBusquedaNormal;
        private System.Windows.Forms.ComboBox cbEntidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCriterioBusqueda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaMin;
        public System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.Label lbTipoUsuario;
        public System.Windows.Forms.PictureBox pbFoto;
    }
}
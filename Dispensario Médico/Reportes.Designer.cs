using System;

namespace Dispensario_Médico
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasMedicasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.lbTipoUsuario);
            this.groupBox1.Controls.Add(this.lbUsuario);
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 576);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(216, 80);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(22, 28);
            this.pbFoto.TabIndex = 4;
            this.pbFoto.TabStop = false;
            this.pbFoto.Visible = false;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Location = new System.Drawing.Point(213, 64);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbTipoUsuario.TabIndex = 3;
            this.lbTipoUsuario.Text = "label2";
            this.lbTipoUsuario.Visible = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(213, 51);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "label1";
            this.lbUsuario.Visible = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(792, 557);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exportarToolStripMenuItem.Text = "File";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEdicosToolStripMenuItem1,
            this.visitasMedicasToolStripMenuItem1,
            this.medicamentosToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportsToolStripMenuItem.Text = "Reportes";
            // 
            // mEdicosToolStripMenuItem1
            // 
            this.mEdicosToolStripMenuItem1.Name = "mEdicosToolStripMenuItem1";
            this.mEdicosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.mEdicosToolStripMenuItem1.Text = "Médicos";
            this.mEdicosToolStripMenuItem1.Click += new System.EventHandler(this.mEdicosToolStripMenuItem1_Click);
            // 
            // visitasMedicasToolStripMenuItem1
            // 
            this.visitasMedicasToolStripMenuItem1.Name = "visitasMedicasToolStripMenuItem1";
            this.visitasMedicasToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.visitasMedicasToolStripMenuItem1.Text = "Visitas Médicas";
            this.visitasMedicasToolStripMenuItem1.Click += new System.EventHandler(this.visitasMedicasToolStripMenuItem1_Click);
            // 
            // medicamentosToolStripMenuItem1
            // 
            this.medicamentosToolStripMenuItem1.Name = "medicamentosToolStripMenuItem1";
            this.medicamentosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.medicamentosToolStripMenuItem1.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem1.Click += new System.EventHandler(this.medicamentosToolStripMenuItem1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 576);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEdicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visitasMedicasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbFoto;
        public System.Windows.Forms.Label lbTipoUsuario;
        public System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
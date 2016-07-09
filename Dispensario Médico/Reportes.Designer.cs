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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasMedicasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 552);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(792, 533);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEdicosToolStripMenuItem1,
            this.visitasMedicasToolStripMenuItem1,
            this.medicamentosToolStripMenuItem1,
            this.pacientesToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // mEdicosToolStripMenuItem1
            // 
            this.mEdicosToolStripMenuItem1.Name = "mEdicosToolStripMenuItem1";
            this.mEdicosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.mEdicosToolStripMenuItem1.Text = "Medicos";
            this.mEdicosToolStripMenuItem1.Click += new System.EventHandler(this.mEdicosToolStripMenuItem1_Click);
            // 
            // visitasMedicasToolStripMenuItem1
            // 
            this.visitasMedicasToolStripMenuItem1.Name = "visitasMedicasToolStripMenuItem1";
            this.visitasMedicasToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.visitasMedicasToolStripMenuItem1.Text = "Visitas Medicas";
            this.visitasMedicasToolStripMenuItem1.Click += new System.EventHandler(this.visitasMedicasToolStripMenuItem1_Click);
            // 
            // medicamentosToolStripMenuItem1
            // 
            this.medicamentosToolStripMenuItem1.Name = "medicamentosToolStripMenuItem1";
            this.medicamentosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.medicamentosToolStripMenuItem1.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem1.Click += new System.EventHandler(this.medicamentosToolStripMenuItem1_Click);
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            this.pacientesToolStripMenuItem1.Click += new System.EventHandler(this.pacientesToolStripMenuItem1_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportarToolStripMenuItem.Text = "Aloha!";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar Nombre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
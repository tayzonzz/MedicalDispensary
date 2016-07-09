using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Dispensario_Médico
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        private void crearReporte(string direccion)
        {//Que es esto?
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load(direccion);

            crConnectionInfo.ServerName = "INNOVA\\SQLEXPRESS2";
            crConnectionInfo.DatabaseName = "Dispensario";
            crConnectionInfo.IntegratedSecurity = true;

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
        private void mEdicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crearReporte("C:/Users/Yasmín/Documents/Dispensario Médico/Dispensario Médico/crpMedicos.rpt");
        }

        private void visitasMedicasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crearReporte("C:/Users/Yasmín/Documents/Dispensario Médico/Dispensario Médico/crpVisitasMedicas.rpt");
        }

        private void medicamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crearReporte("C:/Users/Yasmín/Documents/Dispensario Médico/Dispensario Médico/crpMedicamentos.rpt");
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.lbUserName.Text = lbUsuario.Text;
            main.lbUserType.Text = lbTipoUsuario.Text;
            main.pbUser.Image = pbFoto.Image;
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:/Users/Manuel/Source/Repos/MedicalDispensary/Dispensario Médico/crpMedicamentos.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = textBox1.Text;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["NombreMed"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}

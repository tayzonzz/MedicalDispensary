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

        private void mEdicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {//Que es esto?
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load("C:/Users/Manuel/Source/Repos/MedicalDispensary/Dispensario Médico/crpMedicos.rpt");

            crConnectionInfo.ServerName = "Jose-Lap";
            crConnectionInfo.DatabaseName = "Dispensario";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "123456";

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

        private void visitasMedicasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load("C:/Users/Manuel/Source/Repos/MedicalDispensary/Dispensario Médico/crpVisitasMedicas.rpt");

            crConnectionInfo.ServerName = "Jose-Lap";
            crConnectionInfo.DatabaseName = "Dispensario";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "123456";

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

        private void medicamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load("C:/Users/Manuel/Source/Repos/MedicalDispensary/Dispensario Médico/crpMedicamentos.rpt");

            crConnectionInfo.ServerName = "Jose-Lap";
            crConnectionInfo.DatabaseName = "Dispensario";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "123456";

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

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load("C:/Users/Manuel/Source/Repos/MedicalDispensary/Dispensario Médico/crpInventario.rpt");

            crConnectionInfo.ServerName = "Jose-Lap";
            crConnectionInfo.DatabaseName = "Dispensario";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "123456";

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

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

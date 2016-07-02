using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensario_Médico
{
    public partial class Main : Form
    {
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();

        public Main()
        {
            InitializeComponent();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Services servicios = new Services();
            servicios.usuario = lbUserName.Text;
            servicios.tipoUsuario = lbUserType.Text;
            servicios.pbImagen.Image = pbUser.Image;
            servicios.Show();
            servicios.btnMarcas.PerformClick();
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            consulta.lbUsuario.Text = lbUserName.Text;
            consulta.lbTipoUsuario.Text = lbUserType.Text;
            consulta.pbFoto.Image = pbUser.Image;
            consulta.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            //reportes.lbUsuario.Text = lbUserName.Text;
            //reportes.lbTipoUsuario.Text = lbUserType.Text;
            //reportes.pbFoto.Image = pbUser.Image;
            reportes.Show();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (lbUserType.Text == "Cliente")
            {
                btnReportes.Enabled = false;
                btnServicios.Enabled = false;
            }
            else
            {
                btnReportes.Enabled = true;
                btnServicios.Enabled = true;
            }
            
            SqlCommand cmd = new SqlCommand("SELECT Foto FROM Usuario WHERE Nombre_Usuario = '" + lbUserName.Text + "' AND Foto IS NOT NULL", frmVI.conn);
            frmVI.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                byte[] data = (byte[])dr["Foto"];
                MemoryStream stream = new MemoryStream(data);
                Bitmap bitmap = new Bitmap(stream);

                pbUser.Image = bitmap;
            }

            frmVI.conn.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

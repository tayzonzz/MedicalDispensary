using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensario_Médico
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Services servicios = new Services();
            servicios.Show();
            servicios.usuario = lbUserName.Text;
            servicios.tipoUsuario = lbUserType.Text;
            servicios.pbImagen.Image = pbUser.Image;
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            consulta.main = this;
            consulta.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

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
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

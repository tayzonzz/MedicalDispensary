using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensario_Médico
{
    public partial class Consultas : Form
    {
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        SqlCommand cmd;

        public Consultas()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.lbUserName.Text = lbUsuario.Text;
            main.lbUserType.Text = lbTipoUsuario.Text;

            if (pbFoto != null)
            {
                main.pbUser.Image = pbFoto.Image;
            }

            main.Show();
            this.Close();
        }

        private void cbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCampo.Items.Clear();
            txtCriterioBusqueda.Enabled = true;
            dtpFechaMin.Enabled = true;
            dtpFechaMax.Enabled = true;
            btnBusquedaNormal.Enabled = true;

            if (cbEntidad.SelectedItem.ToString() == "Tipos de Fármacos")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Marcas")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Medicamentos")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Dosis");
                cbCampo.Items.Add("id_tipoFarmaco");
                cbCampo.Items.Add("id_ubicacion");
                cbCampo.Items.Add("id_marca");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Médicos")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Cedula");
                cbCampo.Items.Add("Tanda");
                cbCampo.Items.Add("Especialidad");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Pacientes")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Cedula");
                cbCampo.Items.Add("No_Carnet");
                cbCampo.Items.Add("Tipo_Paciente");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Visitas")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("id_Medico");
                cbCampo.Items.Add("Fecha_Visita");
                cbCampo.Items.Add("Hora_Visita");
                cbCampo.Items.Add("Sintomas");
                cbCampo.Items.Add("id_Medicamento");
                cbCampo.Items.Add("Recomendaciones");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("id_Paciente");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Tipos de Paciente")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Tipos de Usuario")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("FechaRegistro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Ubicaciones")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripcion");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Estante");
                cbCampo.Items.Add("Tramo");
                cbCampo.Items.Add("Celda");
                cbCampo.Items.Add("FechaRegistro");
            }
            else
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Nombre_Usuario");
                cbCampo.Items.Add("Contrasenia");
                cbCampo.Items.Add("Primer_nombre");
                cbCampo.Items.Add("Otros_Nombres");
                cbCampo.Items.Add("Primer_Apellido");
                cbCampo.Items.Add("Segundo_Apellido");
                cbCampo.Items.Add("Fecha_Nacimiento");
                cbCampo.Items.Add("Ocupacion");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Tipo_Usuario");
                cbCampo.Items.Add("FechaRegistro");
            }
            cbCampo.Enabled = true;
        }

        private void btnBusquedaNormal_Click(object sender, EventArgs e)
        {
            if(cbCampo.SelectedItem == null && txtCriterioBusqueda.Text == String.Empty)
            {
                if (cbEntidad.SelectedIndex == 0)
                {
                    cmd = new SqlCommand("sp_BuscarFarmaco", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 1)
                {
                    cmd = new SqlCommand("sp_BuscarMarca", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 2)
                {
                    cmd = new SqlCommand("sp_BuscarMedicamento", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 3)
                {
                    cmd = new SqlCommand("sp_BuscarMedico", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 4)
                {
                    cmd = new SqlCommand("sp_BuscarPaciente", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 5)
                {
                    cmd = new SqlCommand("sp_BuscarVisita", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 6)
                {
                    cmd = new SqlCommand("sp_BuscarTipoPaciente", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 7)
                {
                    cmd = new SqlCommand("sp_BuscarTipoUsuario", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 8)
                {
                    cmd = new SqlCommand("sp_BuscarUbicacion", frmVI.conn);
                }
                if (cbEntidad.SelectedIndex == 9)
                {
                    cmd = new SqlCommand("sp_BuscarUsuario", frmVI.conn);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr;
                try
                {
                    frmVI.conn.Open();
                    dr = cmd.ExecuteReader();
                    frmVI.conn.Close();
                }
                catch
                {

                }

            }
        }
    }
}

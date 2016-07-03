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
    public partial class Visitas : Form
    {
        SqlCommand cmd, cmd2, cmd3;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;

        public Visitas()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Registro_Visita");
            InicializarCbxFK();
        }

        private void InicializarCbxFK()
        {
            cmd = new SqlCommand("SELECT Nombre, Estado FROM Paciente", frmVI.conn);
            SqlDataReader dr;
            cmd2 = new SqlCommand("SELECT Descripcion, Estado FROM Medicamento", frmVI.conn);
            SqlDataReader dr2;
            cmd3 = new SqlCommand("SELECT Nombre,Estado FROM Medico", frmVI.conn);
            SqlDataReader dr3;

            frmVI.conn.Open();

            /*if (cmd.ExecuteNonQuery() > 1 || cmd2.ExecuteNonQuery() > 1 || cmd3.ExecuteNonQuery() > 1)
            {*/
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Estado"].ToString() == "Activado")
                    cbPaciente.Items.Add(dr["Nombre"].ToString());
            }

            dr.Close();

            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                if (dr2["Estado"].ToString() == "Activado")
                    cbMedicamentos.Items.Add(dr2["Descripcion"].ToString());
            }

            dr2.Close();

            dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                if (dr3["Estado"].ToString() == "Activado")
                    cbMedico.Items.Add(dr3["Nombre"].ToString());
            }

            /*
            }
            else
            {
                string mensaje = "No puede registrar visitas debido a que no existen ";

                if (cmd.ExecuteNonQuery() < 1) mensaje += "pacientes ";
                if (cmd2.ExecuteNonQuery() < 1) mensaje += ", medicamentos ";
                if (cmd3.ExecuteNonQuery() < 1) mensaje += ", medicos ";
                
                MessageBox.Show(mensaje + "registrados.");
                this.Close();
            }
            */
            frmVI.conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtRecomendaciones.Text = String.Empty;
            txtSintomas.Text = String.Empty;
            cbEstado.SelectedItem = null;
            cbMedicamentos.SelectedItem = null;
            cbMedico.SelectedItem = null;
            cbPaciente.SelectedItem = null;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmVI.conn.Open();
                if (cbEstado.SelectedItem != null && cbMedicamentos.SelectedItem != null && cbMedico.SelectedItem != null && cbPaciente.SelectedItem != null && txtRecomendaciones.Text != String.Empty && txtSintomas.Text != String.Empty)
                {
                    int idPaciente = frmVI.buscarId("Paciente", "Nombre", cbPaciente.SelectedItem.ToString());
                    int idMedicamento = frmVI.buscarId("Medicamento", "Descripcion", cbMedicamentos.SelectedItem.ToString());
                    int idMedico = frmVI.buscarId("Medico", "Nombre", cbMedico.SelectedItem.ToString());

                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Registro_Visita")))
                    {
                        cmd = new SqlCommand("sp_RegistrarVisita", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@FechaVisita", dtpFecha.Value);
                        cmd.Parameters.AddWithValue("@Sintomas", txtSintomas.Text);
                        cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);
                        cmd.Parameters.AddWithValue("@Recomendaciones", txtRecomendaciones.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha registrado satisfactoriamente.");
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_ActualizarVisita", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@FechaVisita", dtpFecha.Value);
                        cmd.Parameters.AddWithValue("@Sintomas", txtSintomas.Text);
                        cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);
                        cmd.Parameters.AddWithValue("@Recomendaciones", txtRecomendaciones.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");

                    }

                    frmVI.conn.Close();

                    service.btnVisitas.PerformClick();
                    this.Close();


                }

                else
                {
                    MessageBox.Show("Rellene los campos vacíos");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            frmVI.conn.Close();
        }

        private void Visitas_Load(object sender, EventArgs e)
        {
            
        }
    }
}

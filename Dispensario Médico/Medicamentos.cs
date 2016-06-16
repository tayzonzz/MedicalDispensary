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
    public partial class Medicamentos : Form
    {
        SqlCommand cmd, cmd2, cmd3;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;

        public Medicamentos()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Medicamento");
            InicializarCbxFK();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = String.Empty;
            cbDosis.SelectedItem = null;
            cbMarca.SelectedItem = null;
            cbTipoFarmaco.SelectedItem = null;
            cbUbicacion.SelectedItem = null;
            cbVeces.SelectedItem = null;
            cbEstado.SelectedItem = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmVI.conn.Open();
                if (cbEstado.SelectedItem != null && cbTipoFarmaco.SelectedItem != null && cbMarca.SelectedItem != null && cbDosis.SelectedItem != null && cbVeces.SelectedItem != null && cbUbicacion.SelectedItem != null && txtDescripcion.Text != String.Empty)
                {
                    string dosis = cbVeces.SelectedItem.ToString() + " veces por " + cbDosis.SelectedItem.ToString();

                    int idTipoFarmaco = frmVI.buscarId("Farmaco", "Descripcion", cbTipoFarmaco.SelectedItem.ToString());
                    int idUbicacion = frmVI.buscarId("Ubicacion", "Descripcion", cbUbicacion.SelectedItem.ToString());
                    int idMarca = frmVI.buscarId("Marca", "Descripcion", cbMarca.SelectedItem.ToString());

                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Medicamento")))
                    {
                        cmd = new SqlCommand("sp_RegistrarMedicamento", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Dosis", dosis);
                        cmd.Parameters.AddWithValue("@idTipoFarmaco", idTipoFarmaco);
                        cmd.Parameters.AddWithValue("@idUbicacion", idUbicacion);
                        cmd.Parameters.AddWithValue("@idMarca", idMarca);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha regitrado satisfactoriamente.");
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_ActualizarMedicamento", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Dosis", dosis);
                        cmd.Parameters.AddWithValue("@idTipoFarmaco", idTipoFarmaco);
                        cmd.Parameters.AddWithValue("@idUbicacion", idUbicacion);
                        cmd.Parameters.AddWithValue("@idMarca", idMarca);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");
                    }

                    frmVI.conn.Close();
                    service.btnMedicamentos.PerformClick();
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            
        }

        private void InicializarCbxFK()
        {
            cmd = new SqlCommand("SELECT Descripcion, Estado FROM Marca", frmVI.conn);
            SqlDataReader dr;
            cmd2 = new SqlCommand("SELECT Descripcion, Estado FROM Farmaco", frmVI.conn);
            SqlDataReader dr2;
            cmd3 = new SqlCommand("SELECT Descripcion, Estado FROM Ubicacion", frmVI.conn);
            SqlDataReader dr3;

            frmVI.conn.Open();

            /*if (cmd.ExecuteNonQuery() > 1 || cmd2.ExecuteNonQuery() > 1 || cmd3.ExecuteNonQuery() > 1)
            {*/
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["Estado"].ToString() == "Activado")
                        cbMarca.Items.Add(dr["Descripcion"].ToString());
                }
                dr.Close();

                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    if (dr2["Estado"].ToString() == "Activado")
                        cbTipoFarmaco.Items.Add(dr2["Descripcion"].ToString());
                }
                dr2.Close();

                dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    if (dr3["Estado"].ToString() == "Activado    ")
                        cbUbicacion.Items.Add(dr3["Descripcion"].ToString());
                }
                dr3.Close();
            }
            catch
            {

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
    }
}

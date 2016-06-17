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
    public partial class Ubicaciones : Form
    {
        SqlCommand cmd;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;

        public Ubicaciones()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Ubicacion");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmVI.conn.Open();
                if (cbEstado.SelectedItem != null && cbTramo.SelectedItem != null && cbCelda != null && cbEstante != null && txtDescripcion.Text != String.Empty)
                {
                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Ubicacion")))
                    {
                        cmd = new SqlCommand("sp_RegistrarUbicacion", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Estante", cbEstante.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Tramo", cbTramo.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Celda", cbCelda.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha registrado satisfactoriamente.");
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_ActualizarUbicacion", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Estante", cbEstante.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Tramo", cbTramo.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Celda", cbCelda.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");
                    }

                    frmVI.conn.Close();

                    service.btnUbicaciones.PerformClick();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = String.Empty;
            cbEstado.SelectedItem = null;
            cbCelda.SelectedItem = null;
            cbEstante.SelectedItem = null;
            cbTramo.SelectedItem = null;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

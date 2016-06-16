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
    public partial class Farmacos : Form
    {
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;

        public Farmacos()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Farmaco");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = String.Empty;
            cbEstado.SelectedItem = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmVI.conn.Open();
                if (cbEstado.SelectedItem != null && txtDescripcion.Text != String.Empty)
                {
                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Farmaco")))
                    {
                        SqlCommand cmd = new SqlCommand("sp_RegistrarFarmaco", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha registrado satisfactoriamente.");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("sp_ActualizarFarmaco", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");

                        frmVI.conn.Close();
                        this.Close();
                    }

                    frmVI.conn.Close();
                    this.Close();
                    service.btnFarmacos.PerformClick();
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
            service.btnFarmacos.PerformClick();
            this.Close();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }
    }
}

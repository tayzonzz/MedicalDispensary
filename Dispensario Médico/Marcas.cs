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
    public partial class Marcas : Form
    {
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;

        public Marcas()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Marca");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
                if (cbEstado.SelectedItem != null && txtDescripcion.Text != String.Empty)
                {
                    frmVI.conn.Open();

                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Marca")))
                    {
                        SqlCommand cmd = new SqlCommand("sp_RegistrarMarca", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha registrado satisfactoriamente.");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("sp_ActualizarMarca", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");
                    }
                    frmVI.conn.Close();

                    service.btnMarcas.PerformClick();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rellene los campos vacíos");
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
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }
    }
}

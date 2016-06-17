using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dispensario_Médico
{
    public partial class Medicos : Form
    {
        SqlConnection conn = new SqlConnection("Data Source='INNOVA\\SQLEXPRESS2';initial catalog=Dispensario;integrated security=True;");
        SqlCommand cmd;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;
        bool cedulachecked = false;

        public Medicos()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Medico");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (cedulachecked && cbEstado.SelectedItem != null && cbTanda.SelectedItem != null && txtEspecialidad.Text != String.Empty && txtCedula.Text != String.Empty && txtNombre.Text != String.Empty)
                {
                    if(Convert.ToInt32(frmVI.InicializarAdd("Medico")) <= Convert.ToInt32(txtIdentificador.Text))
                    {
                        cmd = new SqlCommand("sp_RegistrarMedico", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@Tanda", cbTanda.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Especialidad", txtEspecialidad.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha registrado satisfactoriamente.");
                    }
                    else{
                        cmd = new SqlCommand("sp_ActualizarMedico", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@Tanda", cbTanda.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Especialidad", txtEspecialidad.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");
                    }
                    conn.Close();

                    service.btnMedicos.PerformClick();
                    this.Close();
                }
                else if(cedulachecked == false)
                {
                    MessageBox.Show("Tiene campos inválidos.");
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

            conn.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNombre.Text = String.Empty;
            txtCedula.Text = String.Empty;
            txtNombre.Text = String.Empty;
            cbEstado.SelectedItem = null;
            cbTanda.SelectedItem = null;
        }

        private void txtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyDigits(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length != 11)
            {
                epCedula.Icon = Properties.Resources.error_converted;
                epCedula.SetError(txtCedula, "La cédula debe tener 11 dígitos.");
            }
            else
            {
                char[] Cedula = new char[13];
                Cedula = txtCedula.Text.ToCharArray();
                string pCedula = string.Empty;

                for (int i = 0; i < 11; i++)
                {
                    pCedula += Cedula[i];

                    if (i == 2)
                    {
                        pCedula += "-";
                    }

                    if (i == 9)
                    {
                        pCedula += "-";
                    }

                    if (frmVI.validaCedula(pCedula))
                    {
                        epCedula.Icon = Properties.Resources.check_converted;
                        epCedula.SetError(txtCedula, "La cédula es correcta.");
                        cedulachecked = true;
                    }
                    else
                    {
                        epCedula.Icon = Properties.Resources.error_converted;
                        epCedula.SetError(txtCedula, "La cédula es incorrecta.");
                        cedulachecked = false;
                    }
                }
            }

                cmd = new SqlCommand("sp_ExisteCedulaMedico", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);

                conn.Open();
                int existe = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

            if (existe != 0 || frmVI.buscarValorAtributo(Convert.ToInt32(txtIdentificador.Text), "Paciente", "Cedula") == txtCedula.Text)
            {
                epCedula.Icon = Properties.Resources.error_converted;
                epCedula.SetError(txtCedula, "La cédula " + txtCedula.Text + " ya existe.");
                cedulachecked = false;
            }
        }
    }
}

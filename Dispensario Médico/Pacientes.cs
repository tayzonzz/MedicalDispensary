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
    public partial class Pacientes : Form
    {
        SqlCommand cmd;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;
        public bool cedulachecked = false;

        public Pacientes()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Paciente");
            InicializarCbxFK();
        }

        private void InicializarCbxFK()
        {
            frmVI.conn.Open();
            cmd = new SqlCommand("SELECT Descripcion FROM Tipo_Paciente", frmVI.conn);
            SqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbTipoPaciente.Items.Add(dr["Descripcion"].ToString());
                }
            }
            catch
            {

            }

            frmVI.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmVI.conn.Open();
                if (cedulachecked && cbEstado.SelectedItem != null && cbTipoPaciente.SelectedItem != null && txtNumeroCarnet.Text != String.Empty && txtCedula.Text != String.Empty && txtNombre.Text != String.Empty)
                {
                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Paciente")))
                    {
                        int idTipoPaciente = frmVI.buscarId("Tipo_Paciente", "Descripcion", cbTipoPaciente.SelectedItem.ToString());

                        cmd = new SqlCommand("sp_RegistrarPaciente", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@No_Carnet", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@TipoPaciente", idTipoPaciente);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha regitrado satisfactoriamente.");
                    }
                    else
                    {
                        int idTipoPaciente = frmVI.buscarId("Tipo_Paciente", "Descripcion", cbTipoPaciente.SelectedItem.ToString());

                        cmd = new SqlCommand("sp_ActualizarPaciente", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@No_Carnet", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@TipoPaciente", idTipoPaciente);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha actualizado satisfactoriamente.");
                    }
                    frmVI.conn.Close();

                    service.btnPacientes.PerformClick();
                    this.Close();


                }

                else if (cedulachecked == false)
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

            frmVI.conn.Close();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNombre.Text = String.Empty;
            txtCedula.Text = String.Empty;
            txtNumeroCarnet.Text = String.Empty;
            cbEstado.SelectedItem = null;
            cbTipoPaciente.SelectedItem = null;
        }

        private void txtNumeroCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyDigits(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyDigits(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length != 11)
            {
                epCedula.Icon = Properties.Resources.error_converted;
                epCedula.SetError(txtCedula, "La cédula debe tener 11 dígitos.");
                cedulachecked = false;
            }
            else if(txtCedula.Text.Length == 11)
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
                cmd = new SqlCommand("sp_ExisteCedulaPaciente", frmVI.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);

                frmVI.conn.Open();
                int existe = Convert.ToInt32(cmd.ExecuteScalar());
                frmVI.conn.Close();

                if (existe != 0 || frmVI.buscarValorAtributo(Convert.ToInt32(txtIdentificador.Text), "Paciente", "Cedula") == txtCedula.Text)
                {
                    epCedula.Icon = Properties.Resources.error_converted;
                    epCedula.SetError(txtCedula, "La cédula " + txtCedula.Text + " ya existe.");
                    cedulachecked = false;
                }
            
        }
    }
}

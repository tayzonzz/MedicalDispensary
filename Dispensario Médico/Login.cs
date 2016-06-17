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
    public partial class Login : Form
    {
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            connectToDispensario();
        }
        private void connectToDispensario()
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(txtPassword.Text);
            result = Convert.ToBase64String(encryted);

            SqlCommand cmd = new SqlCommand("SELECT Identificador, Foto, Nombre_Usuario AS Username, Contrasenia AS Password, Tipo_Usuario AS Tipo, Estado AS Estado FROM Usuario WHERE Nombre_Usuario = '" + txtUser.Text + "' AND Contrasenia = '" + result + "'", frmVI.conn);
            SqlDataReader dr;

            try
            {
                frmVI.conn.Open();
                dr = cmd.ExecuteReader();

                try
                {
                    if (dr.Read())
                    {

                        if (dr["Username"].ToString().Equals(txtUser.Text) && dr["Password"].ToString().Equals(result) && dr["Estado"].ToString().Equals("Activado"))
                        {
                            Main frmMain = new Main();
                            frmMain.lbUserName.Text = dr["Username"].ToString();

                            int i = Convert.ToInt32(dr["Tipo"]);

                            frmMain.lbUserType.Text = frmVI.buscarValorAtributo(i, "Tipo_Usuario", "Descripcion");
                            frmMain.Show();
                            //frmMain.pbUser.Image = byteArrayToImage((byte[])dr["Foto"]);

                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos. Por favor, intente nuevamente.");
                    }
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                
            }
            catch
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }

            frmVI.conn.Close();
        }
        
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == String.Empty)
            {
                epUsuario.Icon = Properties.Resources.error_converted;
                epUsuario.SetError(txtUser, "Debe escribir un nombre de usuario.");
            }
            else
            {
                    SqlCommand cmd = new SqlCommand("sp_ExisteUsuario", frmVI.conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usuario", txtUser.Text);

                    frmVI.conn.Open();
                    int existe = Convert.ToInt32(cmd.ExecuteScalar());
                    frmVI.conn.Close();

                    if(existe == 0)
                    {
                        epUsuario.Icon = Properties.Resources.error_converted;
                        epUsuario.SetError(txtUser, "El usuario " + txtUser.Text + " es incorrecto.");
                    }
                    else
                    {
                        epUsuario.Icon = Properties.Resources.check_converted;
                        epUsuario.SetError(txtUser, "El usuario " + txtUser.Text + " existe.");
                    }
                    
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Click(sender, e);
            }
        }
    }
}

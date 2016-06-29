using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispensario_Médico
{
    public partial class Users : Form
    {
        SqlCommand cmd;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public Services service;
        public bool add = false;
        public string user = String.Empty;
        public bool check = false;
        public bool mismoUsuario = false;

        public Users()
        {
            InitializeComponent();
            txtIdentificador.Text = frmVI.InicializarAdd("Usuario");
            InicializarCbxFK();
        }

        private void InicializarCbxFK()
        {
            frmVI.conn.Open();
            cmd = new SqlCommand("SELECT Descripcion FROM Tipo_Usuario", frmVI.conn);
            SqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbTipoUsuario.Items.Add(dr["Descripcion"].ToString());
                }
            }
            catch
            {

            }

            frmVI.conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmVI.conn.Open();
            }
            catch
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }

            try {
                if (check && cbEstado.SelectedItem != null && cbTipoUsuario.SelectedItem != null && txtApellido.Text != String.Empty && txtOcupacion.Text != String.Empty && txtNombres.Text != String.Empty && txtUsuario.Text != String.Empty)
                {
                    string NombreCompleto, PrimerNombre, OtrosNombres, Apellidos, PrimerApellido, SegundoApellido;

                    NombreCompleto = txtNombres.Text;
                    int index = NombreCompleto.IndexOf(" ");
                    int indexFin = NombreCompleto.Length - 1 - index;

                    if (index != -1)
                    {
                        PrimerNombre = NombreCompleto.Substring(0, index);
                        OtrosNombres = NombreCompleto.Substring(index + 1, indexFin);
                    }
                    else
                    {
                        PrimerNombre = NombreCompleto;
                        OtrosNombres = String.Empty;
                    }

                    Apellidos = txtApellido.Text;
                    index = Apellidos.IndexOf(" ");
                    indexFin = Apellidos.Length - 1 - index;


                    if (index != -1 && Apellidos.Substring(indexFin, 1) != null)
                    {
                        PrimerApellido = Apellidos.Substring(0, index);
                        SegundoApellido = Apellidos.Substring(index + 1, indexFin);
                    }
                    else
                    {
                        PrimerApellido = Apellidos;
                        SegundoApellido = String.Empty;
                    }

                    int idTipoUsuario = frmVI.buscarId("Tipo_Usuario", "Descripcion", cbTipoUsuario.SelectedItem.ToString());
                    string result = string.Empty;
                    byte[] encryted = Encoding.Unicode.GetBytes(txtPassword.Text);
                    result = Convert.ToBase64String(encryted);

                    if (Convert.ToInt32(txtIdentificador.Text) >= Convert.ToInt32(frmVI.InicializarAdd("Usuario")))
                    {
                        cmd = new SqlCommand("sp_RegistrarUsuario", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", result);
                        cmd.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
                        cmd.Parameters.AddWithValue("@OtrosNombres", OtrosNombres);
                        cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Ocupacion", txtOcupacion.Text);
                        cmd.Parameters.AddWithValue("@TipoUsuario", idTipoUsuario);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@FotoPerfil", pbFotoPerfil.Image);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha registrado satisfactoriamente.");
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_ActualizarUsuarioConFoto", frmVI.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Identificador", txtIdentificador.Text);
                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", result);
                        cmd.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
                        cmd.Parameters.AddWithValue("@OtrosNombres", OtrosNombres);
                        cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Ocupacion", txtOcupacion.Text);
                        cmd.Parameters.AddWithValue("@TipoUsuario", idTipoUsuario);
                        cmd.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());

                        if (pbFotoPerfil != null)
                        {
                            // Stream usado como buffer
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            // Se guarda la imagen en el buffer
                            pbFotoPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            // Se extraen los bytes del buffer para asignarlos como valor para el 
                            // parámetro.
                            cmd.Parameters.AddWithValue("@Foto", ms.GetBuffer());
                            //cmd.Parameters.AddWithValue("@FotoPerfil", pbFotoPerfil.Image);

                            cmd.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Se ha actualizado satisfactoriamente.");
                        /*
                        if (mismoUsuario || result == frmVI.buscarValorAtributo(Convert.ToInt32(txtIdentificador.Text), "Usuario", "Contrasenia"))
                        {
                            MessageBox.Show("Debido a que ha cambiado datos del estado, usuario y/o contraseña, debe volver a loguearse.");

                            Login login = new Login();
                            login.Show();
                            service.Close();
                            this.Close();
                        }
                        */
                    }

                    service.btnUsers.PerformClick();
                    this.Close();
                }

                else if (check == false)
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

        private void Users_Load(object sender, EventArgs e)
        {
            if (txtUsuario.Text != String.Empty)
            {
                epNombreUsuario.Icon = Properties.Resources.check_converted;
                epNombreUsuario.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " está disponible");
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbFotoPerfil.Image = Image.FromFile(dialog.FileName);
                pbFotoPerfil.Visible = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNombres.Text = String.Empty;
            txtApellido.Text = String.Empty;
            pbFotoPerfil = null;
            pbFotoPerfil.Visible = false;
            txtOcupacion.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            cbEstado.SelectedItem = null;
            cbTipoUsuario.SelectedItem = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            int i = 0;
            frmVI.conn.Open();

            if (txtUsuario.Text != String.Empty)
            {
                cmd = new SqlCommand("sp_ExisteUsuario", frmVI.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                try
                {
                    i = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch
                {

                }

                if (add)
                {
                    if (i <= 0)
                    {
                        epNombreUsuario.Icon = Properties.Resources.check_converted;
                        epNombreUsuario.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " está disponible");
                        check = true;
                    }
                    else
                    {
                        epNombreUsuario.Icon = Properties.Resources.error_converted;
                        epNombreUsuario.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " ya existe");
                        check = false;
                    }
                }
                else
                {
                    if (i <= 0 || txtUsuario.Text == user)
                    {
                        epNombreUsuario.Icon = Properties.Resources.check_converted;
                        epNombreUsuario.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " está disponible");
                        check = true;
                    }
                    else
                    {
                        epNombreUsuario.Icon = Properties.Resources.error_converted;
                        epNombreUsuario.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " ya existe");
                        check = false;
                    }
                }
            }

            else
            {
                epNombreUsuario.Icon = Properties.Resources.error_converted;
                epNombreUsuario.SetError(txtUsuario, "Debe escribir un usuario");
                check = false;
            }
            frmVI.conn.Close();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text.Length < 5)
            {
                epPassword.Icon = Properties.Resources.error_converted;
                epPassword.SetError(txtPassword, "La contraseña debe tener mínimo 5 caracteres.");
                check = false;
            }
            else if (frmVI.validaClave(txtPassword.Text))
            {
                epPassword.Icon = Properties.Resources.check_converted;
                epPassword.SetError(txtPassword, "La contraseña está correcta.");
                check = true;
            }
            else
            {
                epPassword.Icon = Properties.Resources.error_converted;
                epPassword.SetError(txtPassword, "La contraseña debe tener mínimo 1 letra mayúscula, 1 minúscula y 1 número.");
                check = false;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmVI.OnlyLetters(e);
        }
    }
}

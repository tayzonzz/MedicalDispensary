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
    public partial class Services : Form
    {
        SqlDataAdapter dataadapter;
        SqlCommand cmd;
        SqlCommandBuilder comando;
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        public string usuario;
        public string tipoUsuario;

        public Services()
        {
            InitializeComponent();

            x = 0;
            dgvServices.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        public int x;
        public int id;
        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            x = 1;
            dataadapter = new SqlDataAdapter("SELECT * FROM Medicamento", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Medicamento");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Medicamento";
            lbServiciosTitle.Text = "Medicamento";
            desactivarControles();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            x = 0;
            dataadapter = new SqlDataAdapter("SELECT * FROM Marca", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Marca");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Marca";
            lbServiciosTitle.Text = "Marca";
            desactivarControles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFormServices(sender, e, false);
            dgvServices.Refresh();
        }

        private void OpenFormServices(object sender, EventArgs e, bool edit)
        {
            if (x == 0)
            {
                Marcas marca = new Marcas();
                marca.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    marca.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    marca.txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                    marca.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                }

                marca.ShowDialog();
            }
            else if (x == 1)
            {
                Medicamentos medicamento = new Medicamentos();
                medicamento.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    string vecesDias, dosis = selectedRow.Cells["Dosis"].Value.ToString();
                    int indexInit, indexInit2;

                    indexInit = dosis.IndexOf(" ");
                    indexInit2 = indexInit + 11;

                    vecesDias = dosis.Substring(0, indexInit);
                    dosis = dosis.Substring(indexInit2, dosis.Length - indexInit2);
                    
                    medicamento.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    medicamento.txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                    medicamento.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                    medicamento.cbTipoFarmaco.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["id_tipoFarmaco"].Value), "Farmaco", "Descripcion");
                    medicamento.cbUbicacion.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["id_ubicacion"].Value), "Ubicacion", "Descripcion");
                    medicamento.cbMarca.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["id_marca"].Value), "Marca", "Descripcion"); 
                    medicamento.cbVeces.SelectedItem = vecesDias;
                    medicamento.cbDosis.SelectedItem = dosis;
                }
                medicamento.ShowDialog();
            }
            else if (x == 2)
            {
                Medicos medico = new Medicos();
                medico.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    medico.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    medico.txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                    medico.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                    medico.txtCedula.Text = selectedRow.Cells["Cedula"].Value.ToString();
                    medico.txtEspecialidad.Text = selectedRow.Cells["Especialidad"].Value.ToString();
                    medico.cbTanda.SelectedItem = selectedRow.Cells["Tanda"].Value.ToString();
                }
                medico.ShowDialog();
            }
            else if (x == 3)
            {
                Pacientes paciente = new Pacientes();
                paciente.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    paciente.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    paciente.txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                    paciente.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                    paciente.txtCedula.Text = selectedRow.Cells["Cedula"].Value.ToString();
                    paciente.txtNumeroCarnet.Text = selectedRow.Cells["No_Carnet"].Value.ToString();
                    paciente.cbTipoPaciente.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["Tipo_Paciente"].Value), "Tipo_Paciente", "Descripcion");
                }
                paciente.ShowDialog();
            }
            else if (x == 4)
            {
                Farmacos tipoFarmaco = new Farmacos();
                tipoFarmaco.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    tipoFarmaco.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    tipoFarmaco.txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                    tipoFarmaco.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                }
                tipoFarmaco.ShowDialog();
            }
            else if (x == 5)
            {
                Ubicaciones ubicacion = new Ubicaciones();
                ubicacion.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    ubicacion.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    ubicacion.txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                    ubicacion.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                    ubicacion.cbEstante.SelectedItem = selectedRow.Cells["Estante"].Value.ToString();
                    ubicacion.cbTramo.SelectedItem = selectedRow.Cells["Tramo"].Value.ToString();
                    ubicacion.cbCelda.SelectedItem = selectedRow.Cells["Celda"].Value.ToString();
                }
                ubicacion.ShowDialog();
            }
            else if (x == 6)
            {
                Users usuario = new Users();
                usuario.service = this;

                if (edit)
                {
                    usuario.add = false;

                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    usuario.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    usuario.txtNombres.Text = selectedRow.Cells["Primer_nombre"].Value.ToString() + " " + selectedRow.Cells["Otros_Nombres"].Value.ToString();
                    usuario.txtApellido.Text = selectedRow.Cells["Primer_Apellido"].Value.ToString() + " " + selectedRow.Cells["Segundo_Apellido"].Value.ToString();
                    usuario.txtOcupacion.Text = selectedRow.Cells["Ocupacion"].Value.ToString();
                    usuario.txtUsuario.Text = selectedRow.Cells["Nombre_Usuario"].Value.ToString();
                    usuario.dtpFechaNacimiento.Text = selectedRow.Cells["Fecha_Nacimiento"].Value.ToString();
                    usuario.cbTipoUsuario.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["Tipo_Usuario"].Value), "Tipo_Usuario", "Descripcion");
                    usuario.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();

                    if (frmVI.buscarValorAtributo(Convert.ToInt32(usuario.txtIdentificador.Text), "Usuario", "Foto").ToString() != null)
                    {
                        frmVI.conn.Open();
                        cmd = new SqlCommand("SELECT Foto FROM Usuario where Identificador = "+usuario.txtIdentificador.Text, frmVI.conn);
                        SqlDataReader dr;

                        try
                        {
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                if(dr["Foto"] != null)
                                {
                                    byte[] data = (byte[])dr["Foto"];
                                    MemoryStream stream = new MemoryStream(data);
                                    Bitmap bitmap = new Bitmap(stream);

                                    usuario.pbFotoPerfil.Image = bitmap;
                                }
                            }

                        }
                        catch
                        {

                        }

                        frmVI.conn.Close();

                        
                    }

                    usuario.user = usuario.txtUsuario.Text;
                    
                    if(this.usuario == usuario.user)
                    {
                        usuario.mismoUsuario = true;
                    }
               }
                usuario.Show();
            }
            else if (x == 7)
            {
                Visitas visita = new Visitas();
                visita.service = this;

                if (edit)
                {
                    int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

                    visita.txtIdentificador.Text = selectedRow.Cells["Identificador"].Value.ToString();
                    visita.txtRecomendaciones.Text = selectedRow.Cells["Recomendaciones"].Value.ToString();
                    visita.txtSintomas.Text = selectedRow.Cells["Sintomas"].Value.ToString();
                    visita.cbMedicamentos.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["id_Medicamento"].Value), "Medicamento", "Descripcion");
                    visita.cbMedico.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["id_Medico"].Value), "Medico", "Nombre");
                    visita.cbPaciente.SelectedItem = frmVI.buscarValorAtributo(Convert.ToInt32(selectedRow.Cells["id_Paciente"].Value), "Paciente", "Nombre");


                    visita.cbEstado.SelectedItem = selectedRow.Cells["Estado"].Value.ToString();
                }

                visita.ShowDialog();
                DesactivarBotonesEmpleado();
            }
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            x = 2;
            dataadapter = new SqlDataAdapter("SELECT * FROM Medico", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Medico");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Medico";
            lbServiciosTitle.Text = "Médico";
            desactivarControles();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            x = 3;
            dataadapter = new SqlDataAdapter("SELECT * FROM Paciente", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Paciente");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Paciente";
            lbServiciosTitle.Text = "Paciente";
            desactivarControles();
        }

        private void btnFarmacos_Click(object sender, EventArgs e)
        {
            x = 4;
            dataadapter = new SqlDataAdapter("SELECT * FROM Farmaco", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Farmaco");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Farmaco";
            lbServiciosTitle.Text = "Fármaco";
            desactivarControles();
        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            x = 5;
            dataadapter = new SqlDataAdapter("SELECT * FROM Ubicacion", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Ubicacion");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Ubicacion";
            lbServiciosTitle.Text = "Ubicación";
            desactivarControles();

        }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            x = 7;
            dataadapter = new SqlDataAdapter("SELECT * FROM Registro_Visita", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Registro_Visita");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Registro_Visita";
            lbServiciosTitle.Text = "Visita";
            this.dgvServices.Columns[1].Visible = false;
            this.dgvServices.Columns[3].Visible = false;
            this.dgvServices.Columns[5].Visible = false;
            this.dgvServices.Columns[8].Visible = false;
            desactivarControles();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenFormServices(sender, e, true);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();

            if (dgvServices.CurrentRow == null)
                return;

            frmVI.service = this;
            this.Enabled = false;
            frmVI.ShowDialog();
            
            /*
            using (SqlConnection cnn = new SqlConnection("connection string"))
            {

                object query = "INSERT Tabla (campo) VALUES (@param)";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@param", id);

                cmd.ExecuteNonQuery();

            }


            
            dgvServices.Rows.Remove(dgvServices.CurrentRow);*/
        }
        
        public void eliminar()
        {
            id = Convert.ToInt32(dgvServices.CurrentRow.Cells["Identificador"].Value);
            frmVI.conn.Open();

            if (x == 0)
            {
                cmd = new SqlCommand("sp_EliminarFilaMarca", frmVI.conn);
            }

            else if (x == 1)
            {
                cmd = new SqlCommand("sp_EliminarFilaMedicamento", frmVI.conn);
            }

            else if (x == 2)
            {
                cmd = new SqlCommand("sp_EliminarFilaMedico", frmVI.conn);
            }

            else if (x == 3)
            {
                cmd = new SqlCommand("sp_EliminarFilaPaciente", frmVI.conn);
            }

            else if (x == 4)
            {
                cmd = new SqlCommand("sp_EliminarFilaFarmaco", frmVI.conn);
            }

            else if (x == 5)
            {
                cmd = new SqlCommand("sp_EliminarFilaUbicacion", frmVI.conn);
            }

            else if (x == 6)
            {
                cmd = new SqlCommand("sp_EliminarFilaUsuario", frmVI.conn);
            }

            else if (x == 7)
            {
                cmd = new SqlCommand("sp_EliminarFilaVisita", frmVI.conn);
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado satisfactoriamente.");
                actualizarDataGridView(x);

            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar debido a que ya existe una entidad con ese atributo");
            }

            frmVI.conn.Close();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow == null)
                return;
            
            id = Convert.ToInt32(dgvServices.CurrentRow.Cells["Identificador"].Value);
            frmVI.conn.Open();
            
            if (x == 0)
            {
                cmd = new SqlCommand("UPDATE Marca SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 1)
            {
                cmd = new SqlCommand("UPDATE Medicamento SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 2)
            {
                cmd = new SqlCommand("UPDATE Medico SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 3)
            {
                cmd = new SqlCommand("UPDATE Paciente SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 4)
            {
                cmd = new SqlCommand("UPDATE Farmaco SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 5)
            {
                cmd = new SqlCommand("UPDATE Ubicacion SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 6)
            {
                cmd = new SqlCommand("UPDATE Usuario SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            else if (x == 7)
            {
                cmd = new SqlCommand("UPDATE Registro_Visita SET Estado = 'Desactivado' WHERE Identificador = " + id, frmVI.conn);
            }

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha desactivado satisfactoriamente.");
                actualizarDataGridView(x);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            frmVI.conn.Close();
        }

        public void actualizarDataGridView(int entidad)
        {
            if (entidad == 0)
            {
                btnMarcas.PerformClick();
            }

            else if (entidad == 1)
            {
                btnMedicamentos.PerformClick();
            }

            else if (entidad == 2)
            {
                btnMedicos.PerformClick();
            }

            else if (entidad == 3)
            {
                btnPacientes.PerformClick();
            }

            else if (entidad == 4)
            {
                btnFarmacos.PerformClick();
            }

            else if (entidad == 5)
            {
                btnUbicaciones.PerformClick();
            }

            else if (entidad == 6)
            {
                btnUsers.PerformClick();
            }

            else if (entidad == 7)
            {
                btnVisitas.PerformClick();
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dispensarioDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dispensarioDataSet.Usuario);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Ubicacion' table. You can move, or remove it, as needed.
            this.ubicacionTableAdapter.Fill(this.dispensarioDataSet.Ubicacion);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Tipo_Usuario' table. You can move, or remove it, as needed.
            this.tipo_UsuarioTableAdapter.Fill(this.dispensarioDataSet.Tipo_Usuario);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Tipo_Paciente' table. You can move, or remove it, as needed.
            this.tipo_PacienteTableAdapter.Fill(this.dispensarioDataSet.Tipo_Paciente);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Registro_Visita' table. You can move, or remove it, as needed.
            this.registro_VisitaTableAdapter.Fill(this.dispensarioDataSet.Registro_Visita);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.dispensarioDataSet.Medico);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.dispensarioDataSet.Paciente);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Medicamento' table. You can move, or remove it, as needed.
            this.medicamentoTableAdapter.Fill(this.dispensarioDataSet.Medicamento);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.dispensarioDataSet.Marca);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Farmaco' table. You can move, or remove it, as needed.
            this.farmacoTableAdapter.Fill(this.dispensarioDataSet.Farmaco);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Farmaco' table. You can move, or remove it, as needed.
            this.farmacoTableAdapter.Fill(this.dispensarioDataSet.Farmaco);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.dispensarioDataSet.Marca);
            // TODO: This line of code loads data into the 'dispensarioDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dispensarioDataSet.Usuario);

            DesactivarBotonesEmpleado();

            if(tipoUsuario == "Médico")
            {
                btnUsers.Enabled = false;
                btnUsers.BackColor = Color.Gray;
            }
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            x = 6;

            dataadapter = new SqlDataAdapter("SELECT * FROM Usuario", frmVI.conn);
            comando = new SqlCommandBuilder(dataadapter);
            dispensarioDataSet.Clear();
            dataadapter.Fill(dispensarioDataSet, "Usuario");

            dgvServices.DataSource = null;
            dgvServices.DataSource = dispensarioDataSet;
            dgvServices.DataMember = "Usuario";
            lbServiciosTitle.Text = "Usuario";

            this.dgvServices.Columns[2].Visible = false;
            this.dgvServices.Columns[4].Visible = false;
            this.dgvServices.Columns[6].Visible = false;
            this.dgvServices.Columns[7].Visible = false;
            this.dgvServices.Columns[10].Visible = false;
            this.dgvServices.Columns[12].Visible = false;
            desactivarControles();
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];

            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            try
            {
                if (selectedRow.Cells["Estado"].Value.ToString() == "Activado" || selectedRow.Cells["Estado"].Value.ToString() == "Activado    ")
                {
                    btnDisable.Enabled = true;
                }
                else
                {
                    btnDisable.Enabled = false;
                }

                DesactivarBotonesEmpleado();

                if (btnUsers.Focus() == true) { 
                    if (selectedRow.Cells["Nombre_Usuario"].Value.ToString() == usuario)
                    {
                        btnDisable.Enabled = false;
                        btnRemove.Enabled = false;
                    }
                }
            }
            catch
            {

            }
            
        }

        private void desactivarControles()
        {
            btnEdit.Enabled = false;
            btnDisable.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.lbUserName.Text = usuario;
            main.lbUserType.Text = tipoUsuario;

            if (pbImagen != null)
            {
                main.pbUser.Image = pbImagen.Image;
            }

            main.Show();
            this.Close();

        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void DesactivarBotonesEmpleado()
        {
            if (tipoUsuario == "Empleado" || tipoUsuario == "Médico")
            {
                btnUsers.Enabled = false;
                btnUsers.BackColor = Color.Gray;
                btnEdit.Enabled = false;
                btnDisable.Enabled = false;
                btnRemove.Enabled = false;
            }
        }
    }
}

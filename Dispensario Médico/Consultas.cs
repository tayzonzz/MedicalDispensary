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
    public partial class Consultas : Form
    {
        ValidacionesInicializaciones frmVI = new ValidacionesInicializaciones();
        SqlCommand cmd;
        public Main main;
        int x = 0;
        bool ejecutarQuery = false; 

        public Consultas()
        {
            InitializeComponent();
            dgvConsulta.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void cbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCampo.Items.Clear();
            btnBusquedaNormal.Enabled = true;
            dtpFechaMin.Enabled = false;
            dtpFechaMax.Enabled = false;
            txtCriterioBusqueda.Clear();
            txtCriterioBusqueda.Enabled = false;

            if (cbEntidad.SelectedItem.ToString() == "Tipo de Fármacos")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripción");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Marcas")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripción");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Medicamentos")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripción");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Dósis");
                cbCampo.Items.Add("Tipo de Fármaco");
                cbCampo.Items.Add("Ubicación");
                cbCampo.Items.Add("Marca");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Médicos")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Cédula");
                cbCampo.Items.Add("Tanda");
                cbCampo.Items.Add("Especialidad");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Pacientes")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Nombre");
                cbCampo.Items.Add("Cédula");
                cbCampo.Items.Add("Número de Carnet");
                cbCampo.Items.Add("Tipo de Paciente");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Visitas")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Médico");
                cbCampo.Items.Add("Fecha de Visita");
                cbCampo.Items.Add("Hora de Visita");
                cbCampo.Items.Add("Síntomas");
                cbCampo.Items.Add("Medicamento");
                cbCampo.Items.Add("Recomendaciones");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Paciente");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Tipos de Paciente")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripción");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Tipos de Usuario")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripción");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else if (cbEntidad.SelectedItem.ToString() == "Ubicaciones")
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Descripción");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Estante");
                cbCampo.Items.Add("Tramo");
                cbCampo.Items.Add("Celda");
                cbCampo.Items.Add("Fecha de Registro");
            }
            else
            {
                cbCampo.Items.Add("Identificador");
                cbCampo.Items.Add("Nombre de Usuario");
                cbCampo.Items.Add("Primer Nombre");
                cbCampo.Items.Add("Otros Nombres");
                cbCampo.Items.Add("Primer Apellido");
                cbCampo.Items.Add("Segundo Apellido");
                cbCampo.Items.Add("Fecha de Nacimiento");
                cbCampo.Items.Add("Ocupacion");
                cbCampo.Items.Add("Estado");
                cbCampo.Items.Add("Tipo de Usuario");
                cbCampo.Items.Add("Fecha de Registro");
            }
            cbCampo.Enabled = true;

        }
        private void ejecutarConsultaBD(string pSQL)
        {
            SqlDataAdapter oDa = new SqlDataAdapter(pSQL, frmVI.conn);
            DataTable oTable = new DataTable();
            oDa.Fill(oTable);
            dgvConsulta.DataSource = oTable;
            dgvConsulta.Refresh();
            frmVI.conn.Close();

            if(oTable.Rows.Count > 0)
            {
                ejecutarQuery = true;
            }
            else
            {
                ejecutarQuery = false;
            }

            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBusquedaNormal_Click(object sender, EventArgs e)
        {
            if (cbEntidad.SelectedItem != null)
            {

                if (cbCampo.SelectedItem == null)
                {

                    if (cbEntidad.SelectedIndex == 0)
                    {
                        string sSQL = "SELECT Identificador, Estado, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM MARCA";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 1)
                    {
                        string sSQL = "SELECT Identificador, Estado, Descripcion AS Descripción, Dosis AS Dósis, id_tipoFarmaco AS [Tipo de Fármaco], id_ubicacion AS Ubicación, id_marca AS Marca, FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 2)
                    {
                        string sSQL = "SELECT Identificador, Estado, Nombre, Cedula AS Cédula, Tanda, Especialidad, FechaRegistro AS [Fecha de Registro] FROM MEDICO";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 3)
                    {
                        string sSQL = "SELECT Identificador, Estado, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM FARMACO";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 4)
                    {
                        string sSQL = "SELECT Identificador, Estado, Nombre, Cedula AS Cédula, No_Carnet AS [Número de Carnet], Tipo_Paciente AS [Tipo de Paciente], FechaRegistro AS [Fecha de Registro] FROM PACIENTE";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 5)
                    {
                        string sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 6)
                    {
                        string sSQL = "SELECT Identificador, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM TIPO_PACIENTE";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 7)
                    {
                        string sSQL = "SELECT Identificador, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM TIPO_USUARIO";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 8)
                    {
                        string sSQL = "SELECT Identificador, Estado, Estante, Tramo, Celda, FechaRegistro AS [Fecha de Registro] FROM UBICACION";
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 9)
                    {
                        string sSQL = "Select u.Identificador, u.Estado, u.Nombre_Usuario AS [Nombre de Usuario], u.Primer_nombre + ' ' + u.Otros_Nombres + ' ' + u.Primer_Apellido + ' ' + u.Segundo_Apellido AS [Nombre Completo], u.Fecha_Nacimiento AS [Fecha de Nacimiento], u.Ocupacion AS Ocupación, t.Descripcion AS [Tipo de Usuario], u.FechaRegistro AS [Fecha de Registro], Foto AS [Foto de Perfil] from Usuario u INNER JOIN Tipo_Usuario t ON u.Tipo_Usuario = t.Identificador";
                        ejecutarConsultaBD(sSQL);
                    }

                }


                else
                {
                    string campoSeleccionado = buscarCampoSeleccionado(cbCampo.SelectedItem.ToString());

                    if (cbEntidad.SelectedIndex == 0 && campoSeleccionado != "FechaRegistro")
                    {
                        string sSQL = "SELECT Identificador, Estado, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM MARCA ";
                        sSQL += " where " + campoSeleccionado;
                        sSQL += " like ";
                        if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                        else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                        sSQL += " order by " + campoSeleccionado;
                        ejecutarConsultaBD(sSQL);

                    }
                    else if (cbEntidad.SelectedIndex == 0 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT Identificador, Estado, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM MARCA where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }

                    if (cbEntidad.SelectedIndex == 1 && campoSeleccionado != "FechaRegistro")
                    {
                        //cmd = new SqlCommand("sp_BuscarMedicamento", frmVI.conn);
                        int i;
                        string sSQL;
                        string criterioBusqueda = txtCriterioBusqueda.Text;

                        if (campoSeleccionado == "id_tipoFarmaco" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where f.Descripcion";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by f.Descripcion";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_tipoFarmaco" && (int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where f.Identificador";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by f.Identificador";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_ubicacion" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where u.Descripcion";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by u.Descripcion";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_ubicacion" && (int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where u.Identificador";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by u.Identificador";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_marca" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where m.Descripcion";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by m.Descripcion";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_marca" && (int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where m.Identificador";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by m.Identificador";
                            ejecutarConsultaBD(sSQL);
                        }
                        else
                        {
                            sSQL = "SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador ";
                            sSQL += " where mm." + campoSeleccionado;
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by mm." + campoSeleccionado;
                            ejecutarConsultaBD(sSQL);
                        }
                    }
                    else if (cbEntidad.SelectedIndex == 1 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT mm.Identificador, mm.Estado, mm.Descripcion AS Descripción, mm.Dosis AS Dósis, f.Descripcion AS [Tipo de Fármaco], u.Descripcion AS Ubicación, m.Descripcion AS Marca, mm.FechaRegistro AS [Fecha de Registro] FROM MEDICAMENTO mm INNER JOIN Farmaco f ON mm.id_tipoFarmaco = f.Identificador INNER JOIN Ubicacion u ON mm.id_ubicacion = u.Identificador INNER JOIN Marca m ON mm.id_marca = m.Identificador where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }

                    if (cbEntidad.SelectedIndex == 2 && campoSeleccionado != "FechaRegistro")
                    {
                        //cmd = new SqlCommand("sp_BuscarMedico", frmVI.conn);
                        string sSQL = "SELECT Identificador, Estado, Nombre, Cedula AS Cédula, Tanda, Especialidad, FechaRegistro AS [Fecha de Registro] FROM MEDICO ";
                        sSQL += " where " + campoSeleccionado;
                        sSQL += " like ";
                        if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                        else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                        sSQL += " order by " + campoSeleccionado;

                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 2 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT Identificador, Estado, Nombre, Cedula AS Cédula, Tanda, Especialidad, FechaRegistro AS [Fecha de Registro] FROM MEDICO where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 3 && campoSeleccionado != "FechaRegistro")
                    {
                        //cmd = new SqlCommand("sp_BuscarFarmaco", frmVI.conn);
                        string sSQL = "SELECT Identificador, Estado, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM FARMACO ";
                        sSQL += " where " + campoSeleccionado;
                        sSQL += " like ";
                        if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                        else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                        sSQL += " order by " + campoSeleccionado;
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 3 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT Identificador, Estado, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM FARMACO where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 4 && campoSeleccionado != "FechaRegistro")
                    {
                        //cmd = new SqlCommand("sp_BuscarPaciente", frmVI.conn);
                        int i;
                        string criterioBusqueda = txtCriterioBusqueda.Text;
                        string sSQL;

                        if (campoSeleccionado == "Tipo_Paciente" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT p.Identificador, p.Estado, p.Nombre, p.Cedula AS Cédula, p.No_Carnet AS [Número de Carnet], t.Descripcion AS [Tipo de Paciente], p.FechaRegistro AS [Fecha de Registro] FROM PACIENTE p INNER JOIN Tipo_Paciente t ON p.Tipo_Paciente = t.Identificador";
                            sSQL += " where t.Descripcion";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by t.Descripcion";
                            ejecutarConsultaBD(sSQL);
                        }
                        else
                        {
                            sSQL = "SELECT p.Identificador, p.Estado, p.Nombre, p.Cedula AS Cédula, p.No_Carnet AS [Número de Carnet], t.Descripcion AS [Tipo de Paciente], p.FechaRegistro AS [Fecha de Registro] FROM PACIENTE p INNER JOIN Tipo_Paciente t ON p.Tipo_Paciente = t.Identificador";
                            sSQL += " where p." + campoSeleccionado;
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by p." + campoSeleccionado;
                            ejecutarConsultaBD(sSQL);
                        }
                    }
                    else if (cbEntidad.SelectedIndex == 4 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT p.Identificador, p.Estado, p.Nombre, p.Cedula AS Cédula, p.No_Carnet AS [Número de Carnet], t.Descripcion AS [Tipo de Paciente], p.FechaRegistro AS [Fecha de Registro] FROM PACIENTE p INNER JOIN Tipo_Paciente t ON p.Tipo_Paciente = t.Identificador where p.FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 5 && campoSeleccionado != "FechaRegistro")
                    {
                        // cmd = new SqlCommand("sp_BuscarVisita", frmVI.conn);
                        int i;
                        string sSQL;
                        string criterioBusqueda = txtCriterioBusqueda.Text;

                        if (campoSeleccionado == "id_Medico" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where m.nombre";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by m.nombre";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_Medico" && (int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where m.Identificador";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by m.Identificador";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_Medicamento" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where mm.Descripcion";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by mm.Descripcion";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_Medicamento" && (int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where mm.Identificador";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by mm.Identificador";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_Paciente" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where p.Nombre";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by p.Nombre";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if (campoSeleccionado == "id_Paciente" && (int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where p.Identificador";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by p.Identificador";
                            ejecutarConsultaBD(sSQL);
                        }
                        else
                        {
                            sSQL = "SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente";
                            sSQL += " where r." + campoSeleccionado;
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                            sSQL += " order by r." + campoSeleccionado;
                            ejecutarConsultaBD(sSQL);
                        }
                    }
                    else if (cbEntidad.SelectedIndex == 5 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT r.Identificador, r.Estado, r.Fecha_Visita AS [Fecha de Visita], r.Hora_Visita AS [Hora de Visita], r.Sintomas AS [Síntomas], r.Recomendaciones, m.Nombre AS Médico, mm.Descripcion AS Medicamento, p.Nombre AS Paciente, r.FechaRegistro AS [Fecha de Registro] FROM REGISTRO_VISITA r INNER JOIN Medico m ON r.id_Medico = m.Identificador INNER JOIN Medicamento mm ON r.id_Medicamento = mm.Identificador INNER JOIN Paciente p ON p.Identificador = r.id_Paciente where r.FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 6 && campoSeleccionado != "FechaRegistro")
                    {
                        // cmd = new SqlCommand("sp_BuscarTipoPaciente", frmVI.conn);
                        string sSQL = "SELECT Identificador, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM TIPO_PACIENTE ";
                        sSQL += " where " + campoSeleccionado;
                        sSQL += " like ";
                        if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                        else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                        sSQL += " order by " + campoSeleccionado;
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 6 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT Identificador, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM TIPO_PACIENTE where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 7 && campoSeleccionado != "FechaRegistro")
                    {
                        // cmd = new SqlCommand("sp_BuscarTipoUsuario", frmVI.conn);
                        string sSQL = "SELECT Identificador, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM TIPO_USUARIO ";
                        sSQL += " where " + campoSeleccionado;
                        sSQL += " like ";
                        if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                        else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                        sSQL += " order by " + campoSeleccionado;
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 7 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT Identificador, Descripcion AS Descripción, FechaRegistro AS [Fecha de Registro] FROM TIPO_USUARIO where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 8 && campoSeleccionado != "FechaRegistro")
                    {
                        // cmd = new SqlCommand("sp_BuscarUbicacion", frmVI.conn);
                        string sSQL = "SELECT Identificador, Estado, Estante, Tramo, Celda, FechaRegistro AS [Fecha de Registro] FROM UBICACION ";
                        sSQL += " where " + campoSeleccionado;
                        sSQL += " like ";
                        if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                        else sSQL += "'" + txtCriterioBusqueda.Text + "%'";
                        sSQL += " order by " + campoSeleccionado;
                        ejecutarConsultaBD(sSQL);
                    }
                    else if (cbEntidad.SelectedIndex == 8 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT Identificador, Estado, Estante, Tramo, Celda, FechaRegistro AS [Fecha de Registro] FROM UBICACION where FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                    if (cbEntidad.SelectedIndex == 9 && campoSeleccionado != "FechaRegistro")
                    {
                        //cmd = new SqlCommand("sp_BuscarUsuario", frmVI.conn);
                        int i;
                        string criterioBusqueda = txtCriterioBusqueda.Text;

                        if (campoSeleccionado == "Tipo_Usuario" && !(int.TryParse(txtCriterioBusqueda.Text, out i)))
                        {
                            string sSQL = "Select u.Identificador, u.Estado, u.Nombre_Usuario AS [Nombre de Usuario], u.Primer_nombre + ' ' + u.Otros_Nombres + ' ' + u.Primer_Apellido + ' ' + u.Segundo_Apellido AS [Nombre Completo], u.Fecha_Nacimiento AS [Fecha de Nacimiento], u.Ocupacion AS Ocupación, t.Descripcion AS [Tipo de Usuario], u.FechaRegistro AS [Fecha de Registro], Foto AS [Foto de Perfil] from Usuario u INNER JOIN Tipo_Usuario t ON u.Tipo_Usuario = t.Identificador";
                            sSQL += " where t.Descripcion";
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + criterioBusqueda + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by t.Descripcion";
                            ejecutarConsultaBD(sSQL);
                        }
                        else if(campoSeleccionado == "Fecha_Nacimiento")
                        {
                            SqlDataAdapter sdf = new SqlDataAdapter("SELECT u.Identificador, u.Estado, u.Nombre_Usuario AS [Nombre de Usuario], u.Primer_nombre + ' ' + u.Otros_Nombres + ' ' + u.Primer_Apellido + ' ' + u.Segundo_Apellido AS [Nombre Completo], u.Fecha_Nacimiento AS [Fecha de Nacimiento], u.Ocupacion AS Ocupación, t.Descripcion AS [Tipo de Usuario], u.FechaRegistro AS [Fecha de Registro], Foto AS [Foto de Perfil] from Usuario u INNER JOIN Tipo_Usuario t ON u.Tipo_Usuario = t.Identificador where u.Fecha_Nacimiento between '" + dtpFechaNacimiento.Value.ToString() + "' and '" + dtpFechaNacimiento.Value.ToString() + "'", frmVI.conn);
                            DataTable sd = new DataTable();
                            sdf.Fill(sd);
                            dgvConsulta.DataSource = sd;
                        }
                        else
                        {
                            string sSQL = "Select u.Identificador, u.Estado, u.Nombre_Usuario AS [Nombre de Usuario], u.Primer_nombre + ' ' + u.Otros_Nombres + ' ' + u.Primer_Apellido + ' ' + u.Segundo_Apellido AS [Nombre Completo], u.Fecha_Nacimiento AS [Fecha de Nacimiento], u.Ocupacion AS Ocupación, t.Descripcion AS [Tipo de Usuario], u.FechaRegistro AS [Fecha de Registro], Foto AS [Foto de Perfil] from Usuario u INNER JOIN Tipo_Usuario t ON u.Tipo_Usuario = t.Identificador";
                            sSQL += " where u." + campoSeleccionado;
                            sSQL += " like ";
                            if (x == 0) sSQL += "'%" + txtCriterioBusqueda.Text + "%'";
                            else sSQL += "'" + criterioBusqueda + "%'";
                            sSQL += " order by u." + campoSeleccionado;
                            ejecutarConsultaBD(sSQL);
                        }
                    }
                    else if (cbEntidad.SelectedIndex == 9 && campoSeleccionado == "FechaRegistro")
                    {
                        SqlDataAdapter sdf = new SqlDataAdapter("u.Identificador, u.Estado, u.Nombre_Usuario AS [Nombre de Usuario], u.Primer_nombre + ' ' + u.Otros_Nombres + ' ' + u.Primer_Apellido + ' ' + u.Segundo_Apellido AS [Nombre Completo], u.Fecha_Nacimiento AS [Fecha de Nacimiento], u.Ocupacion AS Ocupación, t.Descripcion AS [Tipo de Usuario], u.FechaRegistro AS [Fecha de Registro], Foto AS [Foto de Perfil] from Usuario u INNER JOIN Tipo_Usuario t ON u.Tipo_Usuario = t.Identificador where u.FechaRegistro between'" + dtpFechaMin.Value.ToString() + "'and'" + dtpFechaMax.Value.ToString() + "'", frmVI.conn);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        dgvConsulta.DataSource = sd;

                    }
                }

                if(ejecutarQuery == false)
                {
                    MessageBox.Show("No se encontraron datos.");
                }

            }
            else
            {
                MessageBox.Show("Favor de elegir una entidad");
            }

        }
        
        private void btnOpcionBusqueda_Click(object sender, EventArgs e)
        {
            if(x == 0)
            {
                lbOpcionBusqueda.Text = "Buscar los datos que contengan el Criterio de Búsqueda?";
                x = 1;
            }
            else
            {
                lbOpcionBusqueda.Text = "Buscar sólo los datos que empiecen por el Criterio de Búsqueda?";
                x = 0;
            }
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCampo.SelectedItem.ToString() == "Fecha de Registro")
            {
                txtCriterioBusqueda.Enabled = false;
                dtpFechaMax.Enabled = true;
                dtpFechaMin.Enabled = true;
                txtCriterioBusqueda.Text = "0";
                btnOpcionBusqueda.Enabled = false;
                
            }
            else
            {
                txtCriterioBusqueda.Enabled = true;
                dtpFechaMax.Enabled = false;
                dtpFechaMin.Enabled = false;
                btnOpcionBusqueda.Enabled = true;
                txtCriterioBusqueda.Clear();
            }
            if(cbCampo.SelectedItem.ToString() == null) txtCriterioBusqueda.Enabled = true;
            if (cbCampo.SelectedItem.ToString() == "Fecha de Nacimiento")
            {
                dtpFechaNacimiento.Visible = true;
                txtCriterioBusqueda.Visible = false;
                btnOpcionBusqueda.Enabled = false;
            }
            else
            {
                dtpFechaNacimiento.Visible = false;
                txtCriterioBusqueda.Visible = true;
                btnOpcionBusqueda.Enabled = true;
            }

        }
        private string buscarCampoSeleccionado(string campoSeleccionado)
        {
            if (cbCampo.SelectedItem.ToString() == "Identificador") campoSeleccionado = "Identificador";
            else if (cbCampo.SelectedItem.ToString() == "Descripción") campoSeleccionado = "Descripcion";
            else if (cbCampo.SelectedItem.ToString() == "Estado") campoSeleccionado = "Estado";
            else if (cbCampo.SelectedItem.ToString() == "Fecha de Registro") campoSeleccionado = "FechaRegistro";
            else if (cbCampo.SelectedItem.ToString() == "Dósis") campoSeleccionado = "Dosis";
            else if (cbCampo.SelectedItem.ToString() == "Tipo de Fármaco") campoSeleccionado = "Id_tipoFarmaco";
            else if (cbCampo.SelectedItem.ToString() == "Ubicación") campoSeleccionado = "Ubicacion";
            else if (cbCampo.SelectedItem.ToString() == "Nombre") campoSeleccionado = "Nombre";
            else if (cbCampo.SelectedItem.ToString() == "Cédula") campoSeleccionado = "cedula";
            else if (cbCampo.SelectedItem.ToString() == "Síntomas") campoSeleccionado = "sintomas";
            else if (cbCampo.SelectedItem.ToString() == "Tanda") campoSeleccionado = "tanda";
            else if (cbCampo.SelectedItem.ToString() == "Número de Carnet") campoSeleccionado = "No_Carnet";
            else if (cbCampo.SelectedItem.ToString() == "Tipo de Paciente") campoSeleccionado = "Tipo_Paciente";
            else if (cbCampo.SelectedItem.ToString() == "Tipo de Usuario") campoSeleccionado = "Tipo_Usuario";
            else if (cbCampo.SelectedItem.ToString() == "Médico") campoSeleccionado = "id_Medico";
            else if (cbCampo.SelectedItem.ToString() == "Fecha de Visita") campoSeleccionado = "Fecha_Visita";
            else if (cbCampo.SelectedItem.ToString() == "Hora de Visita") campoSeleccionado = "Hora_Visita";
            else if (cbCampo.SelectedItem.ToString() == "Medicamento") campoSeleccionado = "id_Medicamento";
            else if (cbCampo.SelectedItem.ToString() == "Recomendaciones") campoSeleccionado = "Recomendaciones";
            else if (cbCampo.SelectedItem.ToString() == "Paciente") campoSeleccionado = "Paciente";
            else if (cbCampo.SelectedItem.ToString() == "Estante") campoSeleccionado = "Estante";
            else if (cbCampo.SelectedItem.ToString() == "Tramo") campoSeleccionado = "Tramo";
            else if (cbCampo.SelectedItem.ToString() == "Celda") campoSeleccionado = "Celda";
            else if (cbCampo.SelectedItem.ToString() == "Contraseña") campoSeleccionado = "Contrasenia";
            else if (cbCampo.SelectedItem.ToString() == "Nombre de Usuario") campoSeleccionado = "Nombre_Usuario";
            else if (cbCampo.SelectedItem.ToString() == "Primer Nombre") campoSeleccionado = "Primer_Nombre";
            else if (cbCampo.SelectedItem.ToString() == "Otros Nombres") campoSeleccionado = "Otros_Nombres";
            else if (cbCampo.SelectedItem.ToString() == "Primer Apellido") campoSeleccionado = "Primer_Apellido";
            else if (cbCampo.SelectedItem.ToString() == "Segundo Apellido") campoSeleccionado = "Segundo_Apellido";
            else if (cbCampo.SelectedItem.ToString() == "Fecha de Nacimiento") campoSeleccionado = "Fecha_Nacimiento";
            else if (cbCampo.SelectedItem.ToString() == "Ocupacion") campoSeleccionado = "Ocupacion";

            return campoSeleccionado;
        }
    }
}



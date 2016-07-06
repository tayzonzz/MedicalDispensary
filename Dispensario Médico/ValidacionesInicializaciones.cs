using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dispensario_Médico
{
    public partial class ValidacionesInicializaciones : Form
    {
        public SqlConnection conn = new SqlConnection("Data Source='INNOVA\\SQLEXPRESS2';initial catalog=Dispensario;integrated security=True;");
        SqlConnection conn2 = new SqlConnection("Data Source='INNOVA\\SQLEXPRESS2';initial catalog=Dispensario;integrated security=True;");
        SqlCommand cmd;
        public Services service;
        public int x = 0;
        public int id;

        public ValidacionesInicializaciones()
        {
            InitializeComponent();
        }

        public string InicializarAdd(string entity)
        {
            int identifier = -1;

            try
            {
                conn2.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Identificador FROM " + entity + " ORDER BY Identificador DESC", conn2);
                if (Convert.ToInt32(cmd.ExecuteScalar()) < 1)
                {
                    identifier = 1;
                }
                else {
                    identifier = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }

            }
            catch
            {

            }
            conn2.Close();

            return identifier.ToString();
        }

        public int buscarId(string entidad, string nombre_atributo, string valor_atributo)
        {
            int id = -1;
            bool x = true;

            cmd = new SqlCommand("SELECT Identificador FROM " + entidad + " WHERE " + nombre_atributo + " = '" + valor_atributo + "'", conn2);
            SqlDataReader dr;

            conn2.Open();

            if (cmd.ExecuteNonQuery() < 1)
            {
                dr = cmd.ExecuteReader();
                while (dr.Read() && x)
                {
                    string result = dr["Identificador"].ToString();
                    id = Convert.ToInt32(result);
                    x = false;
                }
            }

            conn2.Close();

            return id;
        }

        public string buscarValorAtributo(int id, string entidad, string nombre_atributo)
        {
            string result = String.Empty;
            bool x = true;

            cmd = new SqlCommand("SELECT " + nombre_atributo + " FROM " + entidad + " WHERE Identificador = " + id + "", conn2);
            SqlDataReader dr;

            conn2.Open();

            if (cmd.ExecuteNonQuery() < 1)
            {
                dr = cmd.ExecuteReader();
                while (dr.Read() && x)
                {
                    result = dr[nombre_atributo].ToString();
                    x = false;
                }
            }

            conn2.Close();

            return result;
        }

        public void OnlyDigits(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar) || char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public void OnlyDigitsSpaceLetters(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar) || pE.KeyChar == Convert.ToChar(Keys.Space) || char.IsDigit(pE.KeyChar) || pE.KeyChar == Convert.ToChar(Keys.Back))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public void OnlyLetters(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar) || pE.KeyChar == Convert.ToChar(Keys.Space) || pE.KeyChar == Convert.ToChar(Keys.Back))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public string ColocarCaracteresExactos(string text)
        {
            string textResult = String.Empty;

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\"' || text[i] == '\\') textResult += '\\';
                else if (text[i] == '\'') textResult += '\'';
                textResult += text[i];
            }

            return textResult;
        }

        public void OnlyLettersNoSpace(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar) || pE.KeyChar == Convert.ToChar(Keys.Back))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public bool validaClave(string clave) //Método para validar que una contraseña acepte como mínimo 5 caracteres con 1 letra mayúscula, 1 minúscula y 1 número. 
        {
            clave = Convert.ToString(clave);
            string strRegex = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{5,20}$";

            Regex re = new Regex(strRegex);
            if (re.IsMatch(clave))
                return (true);
            else
                return (false);
        }

        public void ValidacionesInicializaciones_Load(object sender, EventArgs e)
        {

        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            service.eliminar();
            service.Enabled = true;
            service.actualizarDataGridView(service.x);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            service.Enabled = true;
            this.Close();
            service.Enabled = true;
        }
        public bool validaCedula(string pCedula) //Método para validar cédula. (©Copyright - Juan Pablo Valdez - Todos los derechos reservados). 
        {
            if (pCedula.Equals("000-0000000-0"))
            {
                return false;
            }

            else
            {
                int vnTotal = 0;
                string vcCedula = pCedula.Replace("-", "");
                int pLongCed = vcCedula.Trim().Length;
                int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

                if (pLongCed < 11 || pLongCed > 11)
                    return false;

                for (int vDig = 1; vDig <= pLongCed; vDig++)
                {
                    int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                    if (vCalculo < 10)
                        vnTotal += vCalculo;
                    else
                        vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
                }

                if (vnTotal % 10 == 0)
                    return true;
                else
                    return false;
            }
        }
    }
}

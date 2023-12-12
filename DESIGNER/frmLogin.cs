using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DESIGNER.Tools; // traemos nuestras herramientas

// Incluir librerías
using BOL;
using CryptSharp; // Claves encriptadas


namespace DESIGNER
{
    public partial class frmLogin : Form
    {
        // Instancia de la clase 
        Usuario usuario = new Usuario();
        DataTable dtRpta = new DataTable();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            if (txtEmail.Text.Trim() == String.Empty)
            {
                errorLogin.SetError(txtEmail, "Por favor ingrese su email");
                txtEmail.Focus();
            }
            else
            {
                errorLogin.Clear();
                if (txtClaveAcceso.Text.Trim() == String.Empty)
                {
                    errorLogin.SetError(txtClaveAcceso, "Escriba su contraseña");
                    txtClaveAcceso.Focus();
                }
                else
                {
                    errorLogin.Clear();

                    // Los datos fueron ingresados en sus respectivos campos.

                    dtRpta = usuario.iniciarSesion(txtEmail.Text);

                    if (dtRpta.Rows.Count > 0)
                    {
                        string claveEncriptada = dtRpta.Rows[0][4].ToString();
                        string apellidos = dtRpta.Rows[0][1].ToString();
                        string nombres = dtRpta.Rows[0][2].ToString();
                        

                        // Primer registro - Primer valor
                        //MessageBox.Show(dtRpta.Rows[0][1].ToString());
                        if (Crypter.CheckPassword(txtClaveAcceso.Text, claveEncriptada))
                        {

                            Aviso.Informar($"Bienvenido {apellidos} {nombres}");
                            frmMain formMain = new frmMain(); // Abre el formulario principal
                            formMain.Show();
                            this.Hide(); // Ocilata el formulario actual(login)
                        }
                        else
                        {
                            Aviso.Advertir("Error en la constraseña");
                        }

                    }
                    else
                    {
                        Aviso.Advertir("El usuario ingresado no existe");
                    }


                }
            }
        }

            private void btnIniciar_Click(object sender, EventArgs e)
            {
                Login();

            }

            private void txtClaveAcceso_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {

                    Login();

                }

            }
        }
  } 



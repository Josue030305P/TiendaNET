using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL; // Logica
using ENTITIES; // Estructura
using DESIGNER.Tools; // Herramientas
using CryptSharp;

namespace DESIGNER.Modulos
{
    public partial class frmUsuario : Form
    {


        //Objeto "usuario" contiene las funciones/ logica => Registrar,Listar,Eliminar.
        Usuario usuario = new Usuario();
        // Objeto 'entUsuario' contiene los datos => aoellidos,nombres,email.claveacceso,nivelacceso
        EUsuario entUsuario = new EUsuario();
        string nivelAcceso = "INV";
        DataView dv;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("¿Está seguro de guardar?") == DialogResult.Yes)
            {
                string claveEncriptada = Crypter.Blowfish.Crypt(txtClave.Text.Trim());
                
                entUsuario.apellidos = txtApellidos.Text;
                entUsuario.nombres = txtNombres.Text;
                entUsuario.email = txtEmail.Text;
                entUsuario.claveAcceso = claveEncriptada;
                entUsuario.nivelAcceso = nivelAcceso;

                if (usuario.Registrar(entUsuario) > 0)
                {
                    reiniciarInterfaz();
                    Aviso.Informar("Nuevo usuario registrado");
                    actualizarDatos();

                }
                else
                {
                    Aviso.Advertir("No hemos podido terminar el registro");
                }
             

            }
        }

        private void actualizarDatos()
        {
            dv = new DataView(usuario.Listar());
            gridUsuarios.DataSource = dv;
            gridUsuarios.Refresh();
            gridUsuarios.Columns[0].Visible = false;//id
            gridUsuarios.Columns[4].Visible = false;// clave
            gridUsuarios.Columns[1].Width = 200;// Apellidos
            gridUsuarios.Columns[2].Width = 200;// Nombtrs
            gridUsuarios.Columns[3].Width = 200;// Email
            gridUsuarios.Columns[5].Width = 230; // Nivel acceso
            // Filas cebreadas
            gridUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void reiniciarInterfaz()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            optInvitado.Checked = true;
            nivelAcceso = "INV";
            txtApellidos.Focus();
        }

        private void optAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "ADM";
        }

        private void optInvitado_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "INV";
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void gridUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridUsuarios.ClearSelection();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "apellidos LIKE '%" + txtBusqueda.Text + "%' OR nombres LIKE '%" + txtBusqueda + "%'";
        }
    }
}

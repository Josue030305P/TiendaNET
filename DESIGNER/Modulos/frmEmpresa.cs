using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using ENTITIES;
using DESIGNER.Tools;


namespace DESIGNER.Modulos
{
    public partial class frmEmpresa : Form
    {

        Empresa empresa = new Empresa();
        EEmpresa entEmpresa = new EEmpresa();
        DataView dv;

        

        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {

            if (txtRuc.Text != "" && txtRazonSocial.Text != "")
            {
                

                if (Aviso.Preguntar("¿Está seguro de agregar el resgitro?") == DialogResult.Yes)

                {
                    entEmpresa.razonSocial = txtRazonSocial.Text;
                    entEmpresa.ruc = txtRuc.Text;
                    entEmpresa.direccion = txtDireccion.Text;
                    entEmpresa.telefono = txtTelefono.Text;
                    entEmpresa.email = txtEmail.Text;
                    entEmpresa.webSite = txtSitioWeb.Text;


                    if (empresa.Registrar(entEmpresa) > 0)
                    {
                        ReiniciarInterfaz();
                        Aviso.Informar("Registro agregado exitosamente");
                        ActualizarDatos();
                    }
                    else
                    {
                        Aviso.Advertir("No se ha podido completar el registro");
                    }

                }

            }

            else
            {
                Aviso.Advertir("Complete el campo ruc y razon social");
            }

            









        }
        public void ActualizarDatos()
        {

            dv = new DataView(empresa.Listar());
            gridEmpresas.DataSource = dv;
            gridEmpresas.Refresh();
            gridEmpresas.Columns[0].Visible = false;
            gridEmpresas.Columns[7].Visible = false;
            gridEmpresas.Columns[8].Visible = false;
            gridEmpresas.Columns[9].Visible = false;

            gridEmpresas.Columns[1].Width = 150;
            gridEmpresas.Columns[2].Width = 150;
            gridEmpresas.Columns[3].Width = 150;
            gridEmpresas.Columns[5].Width = 210;
            
            gridEmpresas.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }



        public void ReiniciarInterfaz()
        {
            txtRazonSocial.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtSitioWeb.Clear();
            txtRazonSocial.Focus();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void txtBuisquedaEmpresa_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "ruc LIKE '%" + txtBusquedaEmpresa.Text + "%' OR direccion LIKE '%" + txtBusquedaEmpresa + "%'";

        }

        private void gridEmpresas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridEmpresas.ClearSelection();
        }
    }
}

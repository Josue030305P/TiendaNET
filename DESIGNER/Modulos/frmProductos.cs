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
using DESIGNER.Tools;
using ENTITIES;

namespace DESIGNER.Modulos
{
    public partial class frmProductos : Form
    {
        Producto producto = new Producto();
        Categoria categoria = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        Marca marca = new Marca();
        EProducto entProducto = new EProducto();


        // Bandera = Variable logica  que controla estados
        bool categoriasListas = false;


        public frmProductos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void actualizarMarcas()
        {
            cboMarca.DataSource = marca.listar();
            cboMarca.DisplayMember = "marca"; // Mostrar(el campo de la tabla marcas)
            cboMarca.ValueMember = "idmarca"; // Guarda (pk, id)
            cboMarca.Refresh();
            cboMarca.Text = "";
        }

        private void actualizarCategorias()
        {
            cboCategoria.DataSource = categoria.listar();
            cboCategoria.DisplayMember = "categoria"; 
            cboCategoria.ValueMember = "idcategoria"; 
            cboCategoria.Refresh();
            cboCategoria.Text = "";

        }
        private void actualizarProductos()
        {
            gridProductos.DataSource = producto.listar();
            gridProductos.Refresh();        }




        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarProductos();
            actualizarMarcas();
            actualizarCategorias();
            categoriasListas = true;

        }























































        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void reiniciarInterfaz()
        {
            cboCategoria.Text = "";
            cboMarca.Text = "";
            txtDescripcion.Text = "";
            txtGarantia.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            


        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriasListas)
            {
                int idcategoria = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
                // Invocar al método que carga las subcategorias
                cboSubcategoria.DataSource = subcategoria.listar(idcategoria);
                cboSubcategoria.DisplayMember = "subcategoria";
                cboSubcategoria.ValueMember = "idsubcategoria";
                cboSubcategoria.Refresh();
                cboSubcategoria.Text = "";

            }
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Esta seguro de guardar el registro?") == DialogResult.Yes)
            {

                entProducto.idmarca = Convert.ToInt32(cboMarca.SelectedValue.ToString());
                entProducto.idsubcategoria = Convert.ToInt32(cboSubcategoria.SelectedValue.ToString());
                entProducto.descripcion = txtDescripcion.Text;
                entProducto.garantia = Convert.ToInt32(txtGarantia.Text);
                entProducto.precio = Convert.ToInt32(txtPrecio.Text);
                entProducto.stock = Convert.ToInt32(txtStock.Text);

                if(producto.registrar(entProducto) > 0)
                {
                    reiniciarInterfaz();
                    actualizarProductos();

                }

               


            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // 1. Crear instanacia del reporte (CrystalReport)
                 Reportes.rptProductos reporte = new Reportes.rptProductos();

            // 2. Asignar los datos al objeto reporte(creado en el paso 1)
            reporte.SetDataSource(producto.listar());
            reporte.Refresh();

            // 3. Instanciar el formulario donde se mostraran los reportes
            Reportes.frmVisroReportes formulario = new Reportes.frmVisroReportes();

            // 4. Pasamos el reporte al visor
            formulario.visor.ReportSource = reporte;
            formulario.visor.Refresh();

            // 5. Mostramos el formulario conteniendo el reporte
            formulario.ShowDialog();
        
        }

        /// <summary>
        /// Genera un archivo fisico del reporte
        /// </summary>
        /// <param name="extension"> Utilice: XLS  O PDF </param>
        private void exportarDatos( string  extension)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Reporte de productos";
            sd.Filter = $"Archivos en formato {extension.ToUpper()}|*.{extension.ToLower()}";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                // Creamos una versión del reporte en formato PDF
                // 1. Instancia del objeto reporte (CrystalReport)
                Reportes.rptProductos reporte = new Reportes.rptProductos();
                // 2. Asignar los datos al objeto reporte(creado en el paso 1)
                reporte.SetDataSource(producto.listar());
                reporte.Refresh();

                //3. El reporte creado y en memoria se escribir'a en el storage
                if(extension.ToUpper() == "PDF")
                {
                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sd.FileName);

                }else if (extension.ToUpper() == "XLSX")

                {

                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelWorkbook ,sd.FileName);

                }


                // 4. Notificar al usuario la creación del archivo
                Aviso.Informar("Se ha creado el reporte correctamente");


            }

        }



        private void btnExportarXLS_Click(object sender, EventArgs e)
        {
            exportarDatos("XLSX");

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            exportarDatos("PDF");
        }
    }
}
  
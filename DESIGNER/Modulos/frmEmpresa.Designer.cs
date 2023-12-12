
namespace DESIGNER.Modulos
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaEmpresa = new System.Windows.Forms.TextBox();
            this.gridEmpresas = new System.Windows.Forms.DataGridView();
            this.gbFormulario = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSitioWeb = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresas)).BeginInit();
            this.gbFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar una empresa";
            // 
            // txtBusquedaEmpresa
            // 
            this.txtBusquedaEmpresa.Location = new System.Drawing.Point(12, 50);
            this.txtBusquedaEmpresa.Name = "txtBusquedaEmpresa";
            this.txtBusquedaEmpresa.Size = new System.Drawing.Size(873, 20);
            this.txtBusquedaEmpresa.TabIndex = 2;
            this.txtBusquedaEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuisquedaEmpresa_KeyUp);
            // 
            // gridEmpresas
            // 
            this.gridEmpresas.BackgroundColor = System.Drawing.Color.White;
            this.gridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpresas.Location = new System.Drawing.Point(12, 91);
            this.gridEmpresas.Name = "gridEmpresas";
            this.gridEmpresas.Size = new System.Drawing.Size(873, 260);
            this.gridEmpresas.TabIndex = 3;
            this.gridEmpresas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridEmpresas_DataBindingComplete);
            // 
            // gbFormulario
            // 
            this.gbFormulario.Controls.Add(this.btnCancelar);
            this.gbFormulario.Controls.Add(this.btnCerrar);
            this.gbFormulario.Controls.Add(this.btnAgregar);
            this.gbFormulario.Controls.Add(this.txtSitioWeb);
            this.gbFormulario.Controls.Add(this.txtEmail);
            this.gbFormulario.Controls.Add(this.label7);
            this.gbFormulario.Controls.Add(this.label6);
            this.gbFormulario.Controls.Add(this.txtTelefono);
            this.gbFormulario.Controls.Add(this.label5);
            this.gbFormulario.Controls.Add(this.label4);
            this.gbFormulario.Controls.Add(this.txtDireccion);
            this.gbFormulario.Controls.Add(this.txtRuc);
            this.gbFormulario.Controls.Add(this.label3);
            this.gbFormulario.Controls.Add(this.txtRazonSocial);
            this.gbFormulario.Controls.Add(this.label2);
            this.gbFormulario.Location = new System.Drawing.Point(27, 410);
            this.gbFormulario.Name = "gbFormulario";
            this.gbFormulario.Size = new System.Drawing.Size(858, 179);
            this.gbFormulario.TabIndex = 3;
            this.gbFormulario.TabStop = false;
            this.gbFormulario.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razón social:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(96, 27);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(328, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ruc:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(96, 63);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(328, 20);
            this.txtRuc.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(96, 98);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(328, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 135);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(328, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sitio web:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(501, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.Location = new System.Drawing.Point(501, 59);
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(203, 20);
            this.txtSitioWeb.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(723, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(723, 87);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(723, 58);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 621);
            this.Controls.Add(this.gbFormulario);
            this.Controls.Add(this.gridEmpresas);
            this.Controls.Add(this.txtBusquedaEmpresa);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpresas)).EndInit();
            this.gbFormulario.ResumeLayout(false);
            this.gbFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaEmpresa;
        private System.Windows.Forms.DataGridView gridEmpresas;
        private System.Windows.Forms.GroupBox gbFormulario;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtSitioWeb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
    }
}
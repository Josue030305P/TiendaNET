
namespace DESIGNER.Reportes
{
    partial class frmVisroReportes
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
            this.visor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.ActiveViewIndex = -1;
            this.visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visor.Cursor = System.Windows.Forms.Cursors.Default;
            this.visor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visor.Location = new System.Drawing.Point(0, 0);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(1109, 714);
            this.visor.TabIndex = 0;
            this.visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmVisroReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 714);
            this.Controls.Add(this.visor);
            this.Name = "frmVisroReportes";
            this.Text = "frmVisroReportes";
            this.Load += new System.EventHandler(this.frmVisroReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer visor;
    }
}
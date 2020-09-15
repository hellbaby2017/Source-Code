namespace Costos.presentador
{
    partial class frmrcostoxtip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrcostoxtip));
            this.ECOSTOXTIPBindingSource = new System.Windows.Forms.BindingSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtafinal = new DevExpress.XtraEditors.DateEdit();
            this.dtainicio = new DevExpress.XtraEditors.DateEdit();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ECOSTOXTIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ECOSTOXTIPBindingSource
            // 
            this.ECOSTOXTIPBindingSource.DataSource = typeof(Costos.Entidades.ECOSTOXTIP);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(916, 117);
            this.panelControl1.TabIndex = 26;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.dtafinal);
            this.groupControl2.Controls.Add(this.dtainicio);
            this.groupControl2.Location = new System.Drawing.Point(12, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(576, 100);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Parametros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha Final";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(457, 33);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(114, 23);
            this.simpleButton4.TabIndex = 25;
            this.simpleButton4.Text = "&Consultar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha Inicio";
            // 
            // dtafinal
            // 
            this.dtafinal.EditValue = null;
            this.dtafinal.Location = new System.Drawing.Point(110, 59);
            this.dtafinal.Name = "dtafinal";
            this.dtafinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtafinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtafinal.Size = new System.Drawing.Size(341, 20);
            this.dtafinal.TabIndex = 29;
            // 
            // dtainicio
            // 
            this.dtainicio.EditValue = null;
            this.dtainicio.Location = new System.Drawing.Point(110, 33);
            this.dtainicio.Name = "dtainicio";
            this.dtainicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtainicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtainicio.Size = new System.Drawing.Size(341, 20);
            this.dtainicio.TabIndex = 28;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Costoxtipop";
            reportDataSource1.Value = this.ECOSTOXTIPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Costos.presentador.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 439);
            this.reportViewer1.TabIndex = 27;
            // 
            // frmrcostoxtip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 556);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrcostoxtip";
            this.Text = "Reporte de Costo por Tipo deproducto";
            this.Load += new System.EventHandler(this.frmrcostoxtip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ECOSTOXTIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtafinal;
        private DevExpress.XtraEditors.DateEdit dtainicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ECOSTOXTIPBindingSource;
    }
}
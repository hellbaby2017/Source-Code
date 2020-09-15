namespace Costos.presentador
{
    partial class frmkardexcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkardexcs));
            this.EKARDEXBindingSource = new System.Windows.Forms.BindingSource();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.gralternativa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.mvi_cAlternativasBindingSource = new System.Windows.Forms.BindingSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cAlt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtafinal = new DevExpress.XtraEditors.DateEdit();
            this.dtainicio = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EKARDEXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gralternativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvi_cAlternativasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EKARDEXBindingSource
            // 
            this.EKARDEXBindingSource.DataSource = typeof(Costos.Entidades.EKARDEX);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.gralternativa);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.dtafinal);
            this.groupControl2.Controls.Add(this.dtainicio);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(576, 120);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Parametros";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Alternativa";
            // 
            // gralternativa
            // 
            this.gralternativa.EditValue = "";
            this.gralternativa.Location = new System.Drawing.Point(110, 85);
            this.gralternativa.Name = "gralternativa";
            this.gralternativa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gralternativa.Properties.DataSource = this.mvi_cAlternativasBindingSource;
            this.gralternativa.Properties.DisplayMember = "cAltClave";
            this.gralternativa.Properties.ValueMember = "cAltClave";
            this.gralternativa.Properties.View = this.gridLookUpEdit1View;
            this.gralternativa.Size = new System.Drawing.Size(341, 20);
            this.gralternativa.TabIndex = 32;
            // 
            // mvi_cAlternativasBindingSource
            // 
            this.mvi_cAlternativasBindingSource.DataSource = typeof(Costos.Entidades.Mvi_cAlternativas);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cAlt});
            this.gridLookUpEdit1View.DetailHeight = 800;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowDetailButtons = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cAlt
            // 
            this.cAlt.Caption = "Alternativa";
            this.cAlt.FieldName = "cAltClave";
            this.cAlt.Name = "cAlt";
            this.cAlt.Visible = true;
            this.cAlt.VisibleIndex = 0;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(990, 143);
            this.panelControl1.TabIndex = 37;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KARDEXDATA";
            reportDataSource1.Value = this.EKARDEXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Costos.presentador.RKardex.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(990, 537);
            this.reportViewer1.TabIndex = 38;
            // 
            // frmkardexcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmkardexcs";
            this.Text = "Reporte de Kardex";
            this.Load += new System.EventHandler(this.frmkardexcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EKARDEXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gralternativa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvi_cAlternativasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit gralternativa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn cAlt;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtafinal;
        private DevExpress.XtraEditors.DateEdit dtainicio;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EKARDEXBindingSource;
        private System.Windows.Forms.BindingSource mvi_cAlternativasBindingSource;
    }
}
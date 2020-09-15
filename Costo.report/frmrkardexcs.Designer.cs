namespace Costo.report
{
    partial class frmrkardexcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrkardexcs));
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dtafinal = new DevExpress.XtraEditors.DateEdit();
            this.dtainicio = new DevExpress.XtraEditors.DateEdit();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KARDEX_ResultBindingSource = new System.Windows.Forms.BindingSource();
            this.mvi_cAlternativasBindingSource = new System.Windows.Forms.BindingSource();
            this.Alternavia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KARDEX_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvi_cAlternativasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridLookUpEdit1);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.simpleButton4);
            this.panelControl3.Controls.Add(this.dtafinal);
            this.panelControl3.Controls.Add(this.dtainicio);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(785, 120);
            this.panelControl3.TabIndex = 29;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(116, 66);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.mvi_cAlternativasBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "cAltClave";
            this.gridLookUpEdit1.Properties.ValueMember = "cAltClave";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(215, 20);
            this.gridLookUpEdit1.TabIndex = 30;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Alternavia});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Alternativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha Inicio";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(356, 10);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(114, 23);
            this.simpleButton4.TabIndex = 25;
            this.simpleButton4.Text = "&Actualizar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // dtafinal
            // 
            this.dtafinal.EditValue = null;
            this.dtafinal.Location = new System.Drawing.Point(116, 36);
            this.dtafinal.Name = "dtafinal";
            this.dtafinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtafinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtafinal.Size = new System.Drawing.Size(215, 20);
            this.dtafinal.TabIndex = 1;
            // 
            // dtainicio
            // 
            this.dtainicio.EditValue = null;
            this.dtainicio.Location = new System.Drawing.Point(116, 10);
            this.dtainicio.Name = "dtainicio";
            this.dtainicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtainicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtainicio.Size = new System.Drawing.Size(215, 20);
            this.dtainicio.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SETKardex";
            reportDataSource1.Value = this.KARDEX_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COSTOS.report.RKARDEX.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(785, 577);
            this.reportViewer1.TabIndex = 30;
            // 
            // KARDEX_ResultBindingSource
            // 
            this.KARDEX_ResultBindingSource.DataSource = typeof(Costos.Entidades.KARDEX_Result);
            // 
            // mvi_cAlternativasBindingSource
            // 
            this.mvi_cAlternativasBindingSource.DataSource = typeof(Costos.Entidades.Mvi_cAlternativas);
            // 
            // Alternavia
            // 
            this.Alternavia.Caption = "Alternativa";
            this.Alternavia.FieldName = "cAltClave";
            this.Alternavia.Name = "Alternavia";
            this.Alternavia.OptionsColumn.AllowEdit = false;
            this.Alternavia.Visible = true;
            this.Alternavia.VisibleIndex = 0;
            // 
            // frmrkardexcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 697);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrkardexcs";
            this.Text = "Reporte de Kardex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmrkardexcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtainicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KARDEX_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvi_cAlternativasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.DateEdit dtafinal;
        private DevExpress.XtraEditors.DateEdit dtainicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private System.Windows.Forms.BindingSource mvi_cAlternativasBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource KARDEX_ResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn Alternavia;
    }
}
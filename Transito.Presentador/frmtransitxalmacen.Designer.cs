namespace Transito.Presentador
{
    partial class frmtransitxalmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtransitxalmacen));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.svp_rTransitosxAlmacenBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcAlmClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.svpcAlmacenesBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcTranClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.svpCTransitoBindingSource = new System.Windows.Forms.BindingSource();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrMxASQL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrMxAPrefijoFehca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrMxUActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdeditar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdeliminar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdguardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdcancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdnuevo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkactivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtsql = new System.Windows.Forms.TextBox();
            this.txtprefijofecha = new DevExpress.XtraEditors.TextEdit();
            this.cmbtran = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbalmacen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_rTransitosxAlmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svpcAlmacenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svpCTransitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkactivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprefijofecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbalmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.svp_rTransitosxAlmacenBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(361, 674);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // svp_rTransitosxAlmacenBindingSource
            // 
            this.svp_rTransitosxAlmacenBindingSource.DataSource = typeof(Transito.Entidades.Svp_rTransitosxAlmacen);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcAlmClave,
            this.colcTranClave,
            this.colrMxASQL,
            this.colrMxAPrefijoFehca,
            this.colrMxUActivo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Skin";
            // 
            // colcAlmClave
            // 
            this.colcAlmClave.Caption = "No Almacen";
            this.colcAlmClave.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colcAlmClave.FieldName = "cAlmClave";
            this.colcAlmClave.Name = "colcAlmClave";
            this.colcAlmClave.OptionsColumn.AllowEdit = false;
            this.colcAlmClave.Visible = true;
            this.colcAlmClave.VisibleIndex = 0;
            this.colcAlmClave.Width = 77;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.svpcAlmacenesBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "CAlmClave";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "CAlmClave";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // svpcAlmacenesBindingSource
            // 
            this.svpcAlmacenesBindingSource.DataSource = typeof(Transito.Entidades.Svp_cAlmacenes);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "N° Almacen";
            this.gridColumn3.FieldName = "CAlmClave";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nombre Almacen";
            this.gridColumn4.FieldName = "CAlmNombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 376;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ceco";
            this.gridColumn5.FieldName = "CUdNContabilidad";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 171;
            // 
            // colcTranClave
            // 
            this.colcTranClave.Caption = "Tipo de transacción";
            this.colcTranClave.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colcTranClave.FieldName = "cTranClave";
            this.colcTranClave.Name = "colcTranClave";
            this.colcTranClave.OptionsColumn.AllowEdit = false;
            this.colcTranClave.Visible = true;
            this.colcTranClave.VisibleIndex = 1;
            this.colcTranClave.Width = 122;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.svpCTransitoBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "cTranNombre";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "cTranClave";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // svpCTransitoBindingSource
            // 
            this.svpCTransitoBindingSource.DataSource = typeof(Transito.Entidades.Svp_CTransito);
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "N° Transacción";
            this.gridColumn1.FieldName = "cTranClave";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 104;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "cTranNombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 533;
            // 
            // colrMxASQL
            // 
            this.colrMxASQL.Caption = "SQL";
            this.colrMxASQL.FieldName = "rMxASQL";
            this.colrMxASQL.Name = "colrMxASQL";
            this.colrMxASQL.OptionsColumn.AllowEdit = false;
            this.colrMxASQL.Visible = true;
            this.colrMxASQL.VisibleIndex = 2;
            this.colrMxASQL.Width = 214;
            // 
            // colrMxAPrefijoFehca
            // 
            this.colrMxAPrefijoFehca.Caption = "Prefijo de Fecha";
            this.colrMxAPrefijoFehca.FieldName = "rMxAPrefijoFehca";
            this.colrMxAPrefijoFehca.Name = "colrMxAPrefijoFehca";
            this.colrMxAPrefijoFehca.OptionsColumn.AllowEdit = false;
            this.colrMxAPrefijoFehca.Visible = true;
            this.colrMxAPrefijoFehca.VisibleIndex = 3;
            this.colrMxAPrefijoFehca.Width = 149;
            // 
            // colrMxUActivo
            // 
            this.colrMxUActivo.Caption = "Activo";
            this.colrMxUActivo.FieldName = "rMxUActivo";
            this.colrMxUActivo.Name = "colrMxUActivo";
            this.colrMxUActivo.OptionsColumn.AllowEdit = false;
            this.colrMxUActivo.Visible = true;
            this.colrMxUActivo.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cmdeditar);
            this.panelControl1.Controls.Add(this.cmdeliminar);
            this.panelControl1.Controls.Add(this.cmdguardar);
            this.panelControl1.Controls.Add(this.cmdcancelar);
            this.panelControl1.Controls.Add(this.cmdnuevo);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(361, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(570, 674);
            this.panelControl1.TabIndex = 24;
            // 
            // cmdeditar
            // 
            this.cmdeditar.Location = new System.Drawing.Point(444, 39);
            this.cmdeditar.Name = "cmdeditar";
            this.cmdeditar.Size = new System.Drawing.Size(114, 23);
            this.cmdeditar.TabIndex = 49;
            this.cmdeditar.Text = "&Editar";
            this.cmdeditar.Click += new System.EventHandler(this.cmdeditar_Click);
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(444, 120);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(114, 23);
            this.cmdeliminar.TabIndex = 48;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmdguardar
            // 
            this.cmdguardar.Location = new System.Drawing.Point(444, 93);
            this.cmdguardar.Name = "cmdguardar";
            this.cmdguardar.Size = new System.Drawing.Size(114, 23);
            this.cmdguardar.TabIndex = 47;
            this.cmdguardar.Text = "&Guardar";
            this.cmdguardar.Click += new System.EventHandler(this.cmdguardar_Click);
            // 
            // cmdcancelar
            // 
            this.cmdcancelar.Location = new System.Drawing.Point(444, 66);
            this.cmdcancelar.Name = "cmdcancelar";
            this.cmdcancelar.Size = new System.Drawing.Size(114, 23);
            this.cmdcancelar.TabIndex = 46;
            this.cmdcancelar.Text = "&Cancelar";
            this.cmdcancelar.Click += new System.EventHandler(this.cmdcancelar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(444, 12);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(114, 23);
            this.cmdnuevo.TabIndex = 45;
            this.cmdnuevo.Text = "&Nuevo";
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.chkactivo);
            this.groupControl1.Controls.Add(this.txtsql);
            this.groupControl1.Controls.Add(this.txtprefijofecha);
            this.groupControl1.Controls.Add(this.cmbtran);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cmbalmacen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(6, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 513);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Modulo";
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_rTransitosxAlmacenBindingSource, "id", true));
            this.txtid.Enabled = false;
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(407, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(20, 20);
            this.txtid.TabIndex = 66;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Id";
            // 
            // chkactivo
            // 
            this.chkactivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_rTransitosxAlmacenBindingSource, "rMxUActivo", true));
            this.chkactivo.Location = new System.Drawing.Point(405, 138);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Properties.Caption = "";
            this.chkactivo.Size = new System.Drawing.Size(22, 19);
            this.chkactivo.TabIndex = 65;
            // 
            // txtsql
            // 
            this.txtsql.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svp_rTransitosxAlmacenBindingSource, "rMxASQL", true));
            this.txtsql.Enabled = false;
            this.txtsql.Location = new System.Drawing.Point(11, 172);
            this.txtsql.Multiline = true;
            this.txtsql.Name = "txtsql";
            this.txtsql.Size = new System.Drawing.Size(416, 308);
            this.txtsql.TabIndex = 63;
            // 
            // txtprefijofecha
            // 
            this.txtprefijofecha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_rTransitosxAlmacenBindingSource, "rMxAPrefijoFehca", true));
            this.txtprefijofecha.Enabled = false;
            this.txtprefijofecha.EnterMoveNextControl = true;
            this.txtprefijofecha.Location = new System.Drawing.Point(262, 111);
            this.txtprefijofecha.Name = "txtprefijofecha";
            this.txtprefijofecha.Size = new System.Drawing.Size(165, 20);
            this.txtprefijofecha.TabIndex = 1;
            // 
            // cmbtran
            // 
            this.cmbtran.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_rTransitosxAlmacenBindingSource, "cTranClave", true));
            this.cmbtran.EditValue = "Ingresar Alternativa";
            this.cmbtran.Enabled = false;
            this.cmbtran.EnterMoveNextControl = true;
            this.cmbtran.Location = new System.Drawing.Point(262, 84);
            this.cmbtran.Name = "cmbtran";
            this.cmbtran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbtran.Properties.DataSource = this.svpCTransitoBindingSource;
            this.cmbtran.Properties.DisplayMember = "cTranNombre";
            this.cmbtran.Properties.ValueMember = "cTranClave";
            this.cmbtran.Properties.View = this.gridView3;
            this.cmbtran.Size = new System.Drawing.Size(165, 20);
            this.cmbtran.TabIndex = 62;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "N° Transacción";
            this.gridColumn6.FieldName = "cTranClave";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 83;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nombre ";
            this.gridColumn7.FieldName = "cTranNombre";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 554;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 129);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(30, 13);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Activo";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(11, 153);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(19, 13);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "SQL";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 105);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 13);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Prefijo de fecha";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Tag = "";
            this.labelControl7.Text = "Tipo Transacción";
            // 
            // cmbalmacen
            // 
            this.cmbalmacen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_rTransitosxAlmacenBindingSource, "cAlmClave", true));
            this.cmbalmacen.EditValue = "Ingresar Alternativa";
            this.cmbalmacen.Enabled = false;
            this.cmbalmacen.EnterMoveNextControl = true;
            this.cmbalmacen.Location = new System.Drawing.Point(262, 57);
            this.cmbalmacen.Name = "cmbalmacen";
            this.cmbalmacen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbalmacen.Properties.DataSource = this.svpcAlmacenesBindingSource;
            this.cmbalmacen.Properties.DisplayMember = "CAlmClave";
            this.cmbalmacen.Properties.ValueMember = "CAlmClave";
            this.cmbalmacen.Properties.View = this.gridView4;
            this.cmbalmacen.Size = new System.Drawing.Size(165, 20);
            this.cmbalmacen.TabIndex = 50;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "N° Almacen";
            this.gridColumn8.FieldName = "CAlmClave";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 84;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Nombre del Almacen";
            this.gridColumn9.FieldName = "CAlmNombre";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 435;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Activo";
            this.gridColumn10.FieldName = "cAlmActivo";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Almacen";
            // 
            // frmtransitxalmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 674);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmtransitxalmacen";
            this.Text = "Configuración de Consultas por almacen";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_rTransitosxAlmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svpcAlmacenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svpCTransitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkactivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprefijofecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbalmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdeditar;
        private DevExpress.XtraEditors.SimpleButton cmdeliminar;
        private DevExpress.XtraEditors.SimpleButton cmdguardar;
        private DevExpress.XtraEditors.SimpleButton cmdcancelar;
        private DevExpress.XtraEditors.SimpleButton cmdnuevo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtprefijofecha;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource svp_rTransitosxAlmacenBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcAlmClave;
        private System.Windows.Forms.BindingSource svpcAlmacenesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colcTranClave;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private System.Windows.Forms.BindingSource svpCTransitoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colrMxASQL;
        private DevExpress.XtraGrid.Columns.GridColumn colrMxAPrefijoFehca;
        private DevExpress.XtraGrid.Columns.GridColumn colrMxUActivo;
        private DevExpress.XtraEditors.GridLookUpEdit cmbtran;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit cmbalmacen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.CheckEdit chkactivo;
        private System.Windows.Forms.TextBox txtsql;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
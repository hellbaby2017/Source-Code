namespace Transito.Presentador
{
    partial class frmproyecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproyecto));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.svp_cProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcProClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcProNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcProFechade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcProFechaha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdeditar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdeliminar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdguardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdcancelar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdnuevo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.datefechaa = new DevExpress.XtraEditors.DateEdit();
            this.datefecha = new DevExpress.XtraEditors.DateEdit();
            this.txtnombreproyecto = new DevExpress.XtraEditors.TextEdit();
            this.txtnoproyecto = new DevExpress.XtraEditors.TextEdit();
            this.txtobservacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_cProyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datefechaa.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefechaa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombreproyecto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoproyecto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtobservacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.svp_cProyectosBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(639, 628);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // svp_cProyectosBindingSource
            // 
            this.svp_cProyectosBindingSource.DataSource = typeof(Transito.Entidades.Svp_cProyectos);
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
            this.colcProClave,
            this.colcProNombre,
            this.colcProFechade,
            this.colcProFechaha,
            this.colObservaciones});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Skin";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcProFechaha, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colcProClave
            // 
            this.colcProClave.Caption = "N° Proyecto";
            this.colcProClave.FieldName = "cProClave";
            this.colcProClave.Name = "colcProClave";
            this.colcProClave.OptionsColumn.AllowEdit = false;
            this.colcProClave.Visible = true;
            this.colcProClave.VisibleIndex = 0;
            // 
            // colcProNombre
            // 
            this.colcProNombre.Caption = "Nombre de Proyecto";
            this.colcProNombre.FieldName = "cProNombre";
            this.colcProNombre.Name = "colcProNombre";
            this.colcProNombre.OptionsColumn.AllowEdit = false;
            this.colcProNombre.Visible = true;
            this.colcProNombre.VisibleIndex = 1;
            this.colcProNombre.Width = 153;
            // 
            // colcProFechade
            // 
            this.colcProFechade.Caption = "Fecha de ";
            this.colcProFechade.FieldName = "cProFechade";
            this.colcProFechade.Name = "colcProFechade";
            this.colcProFechade.OptionsColumn.AllowEdit = false;
            this.colcProFechade.Visible = true;
            this.colcProFechade.VisibleIndex = 2;
            this.colcProFechade.Width = 105;
            // 
            // colcProFechaha
            // 
            this.colcProFechaha.Caption = "Fecha Fin";
            this.colcProFechaha.FieldName = "cProFechaha";
            this.colcProFechaha.Name = "colcProFechaha";
            this.colcProFechaha.OptionsColumn.AllowEdit = false;
            this.colcProFechaha.Visible = true;
            this.colcProFechaha.VisibleIndex = 3;
            this.colcProFechaha.Width = 96;
            // 
            // colObservaciones
            // 
            this.colObservaciones.Caption = "Observaciones";
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.OptionsColumn.AllowEdit = false;
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 4;
            this.colObservaciones.Width = 215;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Nombre";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "causutipo";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Usuario});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Usuario
            // 
            this.Usuario.Caption = "TipoUsuario";
            this.Usuario.FieldName = "Nombre";
            this.Usuario.Name = "Usuario";
            this.Usuario.Visible = true;
            this.Usuario.VisibleIndex = 0;
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
            this.panelControl1.Location = new System.Drawing.Point(639, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(472, 628);
            this.panelControl1.TabIndex = 22;
            // 
            // cmdeditar
            // 
            this.cmdeditar.Location = new System.Drawing.Point(376, 39);
            this.cmdeditar.Name = "cmdeditar";
            this.cmdeditar.Size = new System.Drawing.Size(114, 23);
            this.cmdeditar.TabIndex = 49;
            this.cmdeditar.Text = "&Editar";
            this.cmdeditar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(376, 120);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(114, 23);
            this.cmdeliminar.TabIndex = 48;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmdguardar
            // 
            this.cmdguardar.Location = new System.Drawing.Point(376, 93);
            this.cmdguardar.Name = "cmdguardar";
            this.cmdguardar.Size = new System.Drawing.Size(114, 23);
            this.cmdguardar.TabIndex = 47;
            this.cmdguardar.Text = "&Guardar";
            this.cmdguardar.Click += new System.EventHandler(this.cmdguardar_Click);
            // 
            // cmdcancelar
            // 
            this.cmdcancelar.Location = new System.Drawing.Point(376, 66);
            this.cmdcancelar.Name = "cmdcancelar";
            this.cmdcancelar.Size = new System.Drawing.Size(114, 23);
            this.cmdcancelar.TabIndex = 46;
            this.cmdcancelar.Text = "&Cancelar";
            this.cmdcancelar.Click += new System.EventHandler(this.cmdcancelar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(376, 12);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(114, 23);
            this.cmdnuevo.TabIndex = 45;
            this.cmdnuevo.Text = "&Nuevo";
            this.cmdnuevo.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.datefechaa);
            this.groupControl1.Controls.Add(this.datefecha);
            this.groupControl1.Controls.Add(this.txtnombreproyecto);
            this.groupControl1.Controls.Add(this.txtnoproyecto);
            this.groupControl1.Controls.Add(this.txtobservacion);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(6, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 174);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Modulo";
            // 
            // datefechaa
            // 
            this.datefechaa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cProyectosBindingSource, "cProFechaha", true));
            this.datefechaa.EditValue = new System.DateTime(2019, 3, 27, 12, 29, 48, 403);
            this.datefechaa.Enabled = false;
            this.datefechaa.Location = new System.Drawing.Point(167, 105);
            this.datefechaa.Name = "datefechaa";
            this.datefechaa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datefechaa.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datefechaa.Size = new System.Drawing.Size(188, 20);
            this.datefechaa.TabIndex = 5;
            // 
            // datefecha
            // 
            this.datefecha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cProyectosBindingSource, "cProFechade", true));
            this.datefecha.EditValue = new System.DateTime(2019, 3, 27, 12, 29, 48, 403);
            this.datefecha.Enabled = false;
            this.datefecha.Location = new System.Drawing.Point(167, 79);
            this.datefecha.Name = "datefecha";
            this.datefecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datefecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datefecha.Size = new System.Drawing.Size(188, 20);
            this.datefecha.TabIndex = 4;
            // 
            // txtnombreproyecto
            // 
            this.txtnombreproyecto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svp_cProyectosBindingSource, "cProNombre", true));
            this.txtnombreproyecto.Enabled = false;
            this.txtnombreproyecto.EnterMoveNextControl = true;
            this.txtnombreproyecto.Location = new System.Drawing.Point(167, 53);
            this.txtnombreproyecto.Name = "txtnombreproyecto";
            this.txtnombreproyecto.Size = new System.Drawing.Size(188, 20);
            this.txtnombreproyecto.TabIndex = 2;
            // 
            // txtnoproyecto
            // 
            this.txtnoproyecto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cProyectosBindingSource, "cProClave", true));
            this.txtnoproyecto.Enabled = false;
            this.txtnoproyecto.EnterMoveNextControl = true;
            this.txtnoproyecto.Location = new System.Drawing.Point(296, 26);
            this.txtnoproyecto.Name = "txtnoproyecto";
            this.txtnoproyecto.Size = new System.Drawing.Size(59, 20);
            this.txtnoproyecto.TabIndex = 1;
            // 
            // txtobservacion
            // 
            this.txtobservacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.svp_cProyectosBindingSource, "Observaciones", true));
            this.txtobservacion.Enabled = false;
            this.txtobservacion.EnterMoveNextControl = true;
            this.txtobservacion.Location = new System.Drawing.Point(88, 135);
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(267, 20);
            this.txtobservacion.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 138);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(71, 13);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Observaciones";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(11, 108);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(59, 13);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Fecha hasta";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Fecha de ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(100, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Tag = "";
            this.labelControl7.Text = "Nombre del Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "N° de Proyecto";
            // 
            // frmproyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 628);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmproyecto";
            this.Text = "Lista de Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_cProyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datefechaa.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefechaa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombreproyecto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoproyecto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtobservacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource svp_cProyectosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdeditar;
        private DevExpress.XtraEditors.SimpleButton cmdeliminar;
        private DevExpress.XtraEditors.SimpleButton cmdguardar;
        private DevExpress.XtraEditors.SimpleButton cmdcancelar;
        private DevExpress.XtraEditors.SimpleButton cmdnuevo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtnoproyecto;
        private DevExpress.XtraEditors.TextEdit txtobservacion;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colcProClave;
        private DevExpress.XtraGrid.Columns.GridColumn colcProNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcProFechade;
        private DevExpress.XtraGrid.Columns.GridColumn colcProFechaha;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraEditors.TextEdit txtnombreproyecto;
        private DevExpress.XtraEditors.DateEdit datefechaa;
        private DevExpress.XtraEditors.DateEdit datefecha;
    }
}
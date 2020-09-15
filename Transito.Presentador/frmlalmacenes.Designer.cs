namespace Transito.Presentador
{
    partial class frmlalmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlalmacenes));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.svp_cAlmacenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAlmClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUdNContabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAlmNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcAlmPrefijoSIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcAlmIPServidor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcAlmActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcUniversal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.textnoalmacen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkuniversal = new System.Windows.Forms.CheckBox();
            this.txtceco = new DevExpress.XtraEditors.TextEdit();
            this.txtprefijosia = new DevExpress.XtraEditors.TextEdit();
            this.txtnomalmacen = new DevExpress.XtraEditors.TextEdit();
            this.txtipservidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_cAlmacenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textnoalmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtceco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprefijosia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnomalmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtipservidor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.svp_cAlmacenesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(937, 566);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // svp_cAlmacenesBindingSource
            // 
            this.svp_cAlmacenesBindingSource.DataSource = typeof(Transito.Entidades.Svp_cAlmacenes);
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
            this.colCAlmClave,
            this.colCUdNContabilidad,
            this.colCAlmNombre,
            this.colcAlmPrefijoSIA,
            this.colcAlmIPServidor,
            this.colcAlmActivo,
            this.colcUniversal});
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
            // colCAlmClave
            // 
            this.colCAlmClave.Caption = "No almacen";
            this.colCAlmClave.FieldName = "CAlmClave";
            this.colCAlmClave.Name = "colCAlmClave";
            this.colCAlmClave.OptionsColumn.AllowEdit = false;
            this.colCAlmClave.Visible = true;
            this.colCAlmClave.VisibleIndex = 0;
            this.colCAlmClave.Width = 67;
            // 
            // colCUdNContabilidad
            // 
            this.colCUdNContabilidad.Caption = "No Contabilidad";
            this.colCUdNContabilidad.FieldName = "CUdNContabilidad";
            this.colCUdNContabilidad.Name = "colCUdNContabilidad";
            this.colCUdNContabilidad.OptionsColumn.AllowEdit = false;
            this.colCUdNContabilidad.Visible = true;
            this.colCUdNContabilidad.VisibleIndex = 1;
            this.colCUdNContabilidad.Width = 106;
            // 
            // colCAlmNombre
            // 
            this.colCAlmNombre.Caption = "Nombre del Almacen";
            this.colCAlmNombre.FieldName = "CAlmNombre";
            this.colCAlmNombre.Name = "colCAlmNombre";
            this.colCAlmNombre.OptionsColumn.AllowEdit = false;
            this.colCAlmNombre.Visible = true;
            this.colCAlmNombre.VisibleIndex = 2;
            this.colCAlmNombre.Width = 181;
            // 
            // colcAlmPrefijoSIA
            // 
            this.colcAlmPrefijoSIA.Caption = "Prefijo SIA";
            this.colcAlmPrefijoSIA.FieldName = "cAlmPrefijoSIA";
            this.colcAlmPrefijoSIA.Name = "colcAlmPrefijoSIA";
            this.colcAlmPrefijoSIA.OptionsColumn.AllowEdit = false;
            this.colcAlmPrefijoSIA.Visible = true;
            this.colcAlmPrefijoSIA.VisibleIndex = 3;
            this.colcAlmPrefijoSIA.Width = 106;
            // 
            // colcAlmIPServidor
            // 
            this.colcAlmIPServidor.Caption = "IP servidor";
            this.colcAlmIPServidor.FieldName = "cAlmIPServidor";
            this.colcAlmIPServidor.Name = "colcAlmIPServidor";
            this.colcAlmIPServidor.OptionsColumn.AllowEdit = false;
            this.colcAlmIPServidor.Visible = true;
            this.colcAlmIPServidor.VisibleIndex = 4;
            this.colcAlmIPServidor.Width = 110;
            // 
            // colcAlmActivo
            // 
            this.colcAlmActivo.Caption = "Activo";
            this.colcAlmActivo.FieldName = "cAlmActivo";
            this.colcAlmActivo.Name = "colcAlmActivo";
            this.colcAlmActivo.OptionsColumn.AllowEdit = false;
            this.colcAlmActivo.Visible = true;
            this.colcAlmActivo.VisibleIndex = 5;
            // 
            // colcUniversal
            // 
            this.colcUniversal.Caption = "es Total";
            this.colcUniversal.FieldName = "cUniversal";
            this.colcUniversal.Name = "colcUniversal";
            this.colcUniversal.OptionsColumn.AllowEdit = false;
            this.colcUniversal.Visible = true;
            this.colcUniversal.VisibleIndex = 6;
            this.colcUniversal.Width = 72;
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
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(937, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(502, 566);
            this.panelControl1.TabIndex = 20;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(376, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 23);
            this.simpleButton1.TabIndex = 49;
            this.simpleButton1.Text = "&Editar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(376, 120);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 23);
            this.simpleButton2.TabIndex = 48;
            this.simpleButton2.Text = "&Eliminar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(376, 93);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(114, 23);
            this.simpleButton3.TabIndex = 47;
            this.simpleButton3.Text = "&Guardar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(376, 66);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(114, 23);
            this.simpleButton4.TabIndex = 46;
            this.simpleButton4.Text = "&Cancelar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(376, 12);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(114, 23);
            this.simpleButton5.TabIndex = 45;
            this.simpleButton5.Text = "&Nuevo";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.chkactivo);
            this.groupControl1.Controls.Add(this.textnoalmacen);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.chkuniversal);
            this.groupControl1.Controls.Add(this.txtceco);
            this.groupControl1.Controls.Add(this.txtprefijosia);
            this.groupControl1.Controls.Add(this.txtnomalmacen);
            this.groupControl1.Controls.Add(this.txtipservidor);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(6, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 221);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Modulo";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 188);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 66;
            this.labelControl2.Text = "Activo";
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.svp_cAlmacenesBindingSource, "cAlmActivo", true));
            this.chkactivo.Enabled = false;
            this.chkactivo.Location = new System.Drawing.Point(340, 187);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(15, 14);
            this.chkactivo.TabIndex = 65;
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // textnoalmacen
            // 
            this.textnoalmacen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cAlmacenesBindingSource, "CAlmClave", true));
            this.textnoalmacen.Enabled = false;
            this.textnoalmacen.EnterMoveNextControl = true;
            this.textnoalmacen.Location = new System.Drawing.Point(296, 26);
            this.textnoalmacen.Name = "textnoalmacen";
            this.textnoalmacen.Size = new System.Drawing.Size(59, 20);
            this.textnoalmacen.TabIndex = 64;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 168);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "Todos los Almacenes";
            // 
            // chkuniversal
            // 
            this.chkuniversal.AutoSize = true;
            this.chkuniversal.Enabled = false;
            this.chkuniversal.Location = new System.Drawing.Point(340, 167);
            this.chkuniversal.Name = "chkuniversal";
            this.chkuniversal.Size = new System.Drawing.Size(15, 14);
            this.chkuniversal.TabIndex = 62;
            this.chkuniversal.UseVisualStyleBackColor = true;
            // 
            // txtceco
            // 
            this.txtceco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cAlmacenesBindingSource, "CUdNContabilidad", true));
            this.txtceco.Enabled = false;
            this.txtceco.EnterMoveNextControl = true;
            this.txtceco.Location = new System.Drawing.Point(167, 141);
            this.txtceco.Name = "txtceco";
            this.txtceco.Size = new System.Drawing.Size(188, 20);
            this.txtceco.TabIndex = 57;
            // 
            // txtprefijosia
            // 
            this.txtprefijosia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cAlmacenesBindingSource, "cAlmPrefijoSIA", true));
            this.txtprefijosia.Enabled = false;
            this.txtprefijosia.EnterMoveNextControl = true;
            this.txtprefijosia.Location = new System.Drawing.Point(167, 115);
            this.txtprefijosia.Name = "txtprefijosia";
            this.txtprefijosia.Size = new System.Drawing.Size(188, 20);
            this.txtprefijosia.TabIndex = 56;
            // 
            // txtnomalmacen
            // 
            this.txtnomalmacen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cAlmacenesBindingSource, "CAlmNombre", true));
            this.txtnomalmacen.Enabled = false;
            this.txtnomalmacen.EnterMoveNextControl = true;
            this.txtnomalmacen.Location = new System.Drawing.Point(167, 85);
            this.txtnomalmacen.Name = "txtnomalmacen";
            this.txtnomalmacen.Size = new System.Drawing.Size(188, 20);
            this.txtnomalmacen.TabIndex = 55;
            // 
            // txtipservidor
            // 
            this.txtipservidor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_cAlmacenesBindingSource, "cAlmIPServidor", true));
            this.txtipservidor.Enabled = false;
            this.txtipservidor.EnterMoveNextControl = true;
            this.txtipservidor.Location = new System.Drawing.Point(167, 59);
            this.txtipservidor.Name = "txtipservidor";
            this.txtipservidor.Size = new System.Drawing.Size(188, 20);
            this.txtipservidor.TabIndex = 54;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 138);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 13);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Centro de Costo";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(11, 112);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 13);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Prefijo SIA";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(95, 13);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Nombre de Almacen";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Tag = "";
            this.labelControl7.Text = "IP de Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Clave de Almacen";
            // 
            // frmlalmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 566);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlalmacenes";
            this.Text = "Lista de Almacenes";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_cAlmacenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textnoalmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtceco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprefijosia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnomalmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtipservidor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource svp_cAlmacenesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCAlmClave;
        private DevExpress.XtraGrid.Columns.GridColumn colCUdNContabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCAlmNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcAlmPrefijoSIA;
        private DevExpress.XtraGrid.Columns.GridColumn colcAlmIPServidor;
        private DevExpress.XtraGrid.Columns.GridColumn colcAlmActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colcUniversal;
        private DevExpress.XtraEditors.TextEdit txtceco;
        private DevExpress.XtraEditors.TextEdit txtprefijosia;
        private DevExpress.XtraEditors.TextEdit txtnomalmacen;
        private DevExpress.XtraEditors.TextEdit txtipservidor;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox chkuniversal;
        private DevExpress.XtraEditors.TextEdit textnoalmacen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox chkactivo;
    }
}
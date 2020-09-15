namespace Transito.Presentador
{
    partial class frmctransito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmctransito));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.svp_CTransitoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcTranClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcTranNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcTranTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCTranActivo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.chktipo = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.txtnombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_CTransitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.svp_CTransitoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(507, 628);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // svp_CTransitoBindingSource
            // 
            this.svp_CTransitoBindingSource.DataSource = typeof(Transito.Entidades.Svp_CTransito);
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
            this.colcTranClave,
            this.colcTranNombre,
            this.colcTranTipo,
            this.colCTranActivo});
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
            // colcTranClave
            // 
            this.colcTranClave.Caption = "N° Almacen";
            this.colcTranClave.FieldName = "cTranClave";
            this.colcTranClave.Name = "colcTranClave";
            this.colcTranClave.Visible = true;
            this.colcTranClave.VisibleIndex = 0;
            this.colcTranClave.Width = 82;
            // 
            // colcTranNombre
            // 
            this.colcTranNombre.Caption = "Nombre";
            this.colcTranNombre.FieldName = "cTranNombre";
            this.colcTranNombre.Name = "colcTranNombre";
            this.colcTranNombre.Visible = true;
            this.colcTranNombre.VisibleIndex = 1;
            this.colcTranNombre.Width = 219;
            // 
            // colcTranTipo
            // 
            this.colcTranTipo.Caption = "Tipo de folio";
            this.colcTranTipo.FieldName = "cTranTipo";
            this.colcTranTipo.Name = "colcTranTipo";
            this.colcTranTipo.Visible = true;
            this.colcTranTipo.VisibleIndex = 2;
            // 
            // colCTranActivo
            // 
            this.colCTranActivo.Caption = "Activo";
            this.colCTranActivo.FieldName = "CTranActivo";
            this.colCTranActivo.Name = "colCTranActivo";
            this.colCTranActivo.Visible = true;
            this.colCTranActivo.VisibleIndex = 3;
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
            this.panelControl1.Location = new System.Drawing.Point(507, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(502, 628);
            this.panelControl1.TabIndex = 22;
            // 
            // cmdeditar
            // 
            this.cmdeditar.Location = new System.Drawing.Point(376, 40);
            this.cmdeditar.Name = "cmdeditar";
            this.cmdeditar.Size = new System.Drawing.Size(114, 23);
            this.cmdeditar.TabIndex = 49;
            this.cmdeditar.Text = "&Editar";
            this.cmdeditar.Click += new System.EventHandler(this.cmdeditar_Click);
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(376, 126);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(114, 23);
            this.cmdeliminar.TabIndex = 48;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmdguardar
            // 
            this.cmdguardar.Location = new System.Drawing.Point(376, 97);
            this.cmdguardar.Name = "cmdguardar";
            this.cmdguardar.Size = new System.Drawing.Size(114, 23);
            this.cmdguardar.TabIndex = 47;
            this.cmdguardar.Text = "&Guardar";
            this.cmdguardar.Click += new System.EventHandler(this.cmdguardar_Click);
            // 
            // cmdcancelar
            // 
            this.cmdcancelar.Location = new System.Drawing.Point(376, 68);
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
            this.groupControl1.Controls.Add(this.chktipo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.chkactivo);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.txtnombre);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(6, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 137);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Modulo";
            // 
            // chktipo
            // 
            this.chktipo.AutoSize = true;
            this.chktipo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.svp_CTransitoBindingSource, "CTranActivo", true));
            this.chktipo.Enabled = false;
            this.chktipo.Location = new System.Drawing.Point(340, 85);
            this.chktipo.Name = "chktipo";
            this.chktipo.Size = new System.Drawing.Size(15, 14);
            this.chktipo.TabIndex = 67;
            this.chktipo.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 66;
            this.labelControl2.Text = "Activo";
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.svp_CTransitoBindingSource, "CTranActivo", true));
            this.chkactivo.Enabled = false;
            this.chkactivo.Location = new System.Drawing.Point(340, 111);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(15, 14);
            this.chkactivo.TabIndex = 65;
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_CTransitoBindingSource, "cTranClave", true));
            this.txtid.Enabled = false;
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(296, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 20);
            this.txtid.TabIndex = 64;
            // 
            // txtnombre
            // 
            this.txtnombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.svp_CTransitoBindingSource, "cTranNombre", true));
            this.txtnombre.Enabled = false;
            this.txtnombre.EnterMoveNextControl = true;
            this.txtnombre.Location = new System.Drawing.Point(167, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(188, 20);
            this.txtnombre.TabIndex = 54;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Tipo de Folio";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Tag = "";
            this.labelControl7.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "N° Id";
            // 
            // frmctransito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 628);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmctransito";
            this.Text = "Lista de Tipo de transitos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svp_CTransitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox chkactivo;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.TextEdit txtnombre;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource svp_CTransitoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcTranClave;
        private DevExpress.XtraGrid.Columns.GridColumn colcTranNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcTranTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colCTranActivo;
        private System.Windows.Forms.CheckBox chktipo;
    }
}
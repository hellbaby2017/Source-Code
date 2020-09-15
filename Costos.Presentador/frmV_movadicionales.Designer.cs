namespace Costos.presentador
{
    partial class frmV_movadicionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmV_movadicionales));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmovalmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_MOVADICIONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidMMovimientos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcMoAClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcPrvClaveFab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSIRemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSIFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSILote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcCalClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSIFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSIFechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSIPedimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSIFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmMSICostoP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcAltClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcAlmClave = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_MOVADICIONALESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.v_MOVADICIONALESBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(944, 593);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colidMMovimientos,
            this.colcMoAClave,
            this.colcPrvClaveFab,
            this.colmMSIRemision,
            this.colmMSIFactura,
            this.colmMSILote,
            this.colcCalClave,
            this.colmMSIFecha,
            this.colmMSIFechaFactura,
            this.colmMSIPedimento,
            this.colUnidades,
            this.colCosto,
            this.colmMSIFolio,
            this.colmMSICostoP,
            this.colDetalle,
            this.colcAltClave,
            this.colcAlmClave});
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
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DisplayMember = "cMoANombre";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemGridLookUpEdit2.ShowFooter = false;
            this.repositoryItemGridLookUpEdit2.ValueMember = "cMoAClave";
            this.repositoryItemGridLookUpEdit2.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmovalmacen,
            this.colNombre});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colmovalmacen
            // 
            this.colmovalmacen.Caption = "No. Mov";
            this.colmovalmacen.FieldName = "cMoAClave";
            this.colmovalmacen.Name = "colmovalmacen";
            this.colmovalmacen.OptionsColumn.AllowEdit = false;
            this.colmovalmacen.Visible = true;
            this.colmovalmacen.VisibleIndex = 0;
            this.colmovalmacen.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Movimiento";
            this.colNombre.FieldName = "cMoANombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 361;
            // 
            // v_MOVADICIONALESBindingSource
            // 
            this.v_MOVADICIONALESBindingSource.DataSource = typeof(Costos.Entidades.V_MOVADICIONALES);
            // 
            // colidMMovimientos
            // 
            this.colidMMovimientos.Caption = "IdMovimientos";
            this.colidMMovimientos.FieldName = "idMMovimientos";
            this.colidMMovimientos.Name = "colidMMovimientos";
            this.colidMMovimientos.Visible = true;
            this.colidMMovimientos.VisibleIndex = 0;
            // 
            // colcMoAClave
            // 
            this.colcMoAClave.Caption = "No Movimiento";
            this.colcMoAClave.FieldName = "cMoAClave";
            this.colcMoAClave.Name = "colcMoAClave";
            this.colcMoAClave.Visible = true;
            this.colcMoAClave.VisibleIndex = 1;
            // 
            // colcPrvClaveFab
            // 
            this.colcPrvClaveFab.Caption = "CPrvClaveFab";
            this.colcPrvClaveFab.FieldName = "cPrvClaveFab";
            this.colcPrvClaveFab.Name = "colcPrvClaveFab";
            this.colcPrvClaveFab.Visible = true;
            this.colcPrvClaveFab.VisibleIndex = 2;
            // 
            // colmMSIRemision
            // 
            this.colmMSIRemision.Caption = "Remisión";
            this.colmMSIRemision.FieldName = "mMSIRemision";
            this.colmMSIRemision.Name = "colmMSIRemision";
            this.colmMSIRemision.Visible = true;
            this.colmMSIRemision.VisibleIndex = 3;
            // 
            // colmMSIFactura
            // 
            this.colmMSIFactura.Caption = "Factura";
            this.colmMSIFactura.FieldName = "mMSIFactura";
            this.colmMSIFactura.Name = "colmMSIFactura";
            this.colmMSIFactura.Visible = true;
            this.colmMSIFactura.VisibleIndex = 4;
            // 
            // colmMSILote
            // 
            this.colmMSILote.Caption = "Lote";
            this.colmMSILote.FieldName = "mMSILote";
            this.colmMSILote.Name = "colmMSILote";
            this.colmMSILote.Visible = true;
            this.colmMSILote.VisibleIndex = 5;
            // 
            // colcCalClave
            // 
            this.colcCalClave.Caption = "No Clave ";
            this.colcCalClave.FieldName = "cCalClave";
            this.colcCalClave.Name = "colcCalClave";
            this.colcCalClave.Visible = true;
            this.colcCalClave.VisibleIndex = 6;
            // 
            // colmMSIFecha
            // 
            this.colmMSIFecha.Caption = "Fecha";
            this.colmMSIFecha.FieldName = "mMSIFecha";
            this.colmMSIFecha.Name = "colmMSIFecha";
            this.colmMSIFecha.Visible = true;
            this.colmMSIFecha.VisibleIndex = 7;
            // 
            // colmMSIFechaFactura
            // 
            this.colmMSIFechaFactura.Caption = "FechaFactura";
            this.colmMSIFechaFactura.FieldName = "mMSIFechaFactura";
            this.colmMSIFechaFactura.Name = "colmMSIFechaFactura";
            this.colmMSIFechaFactura.Visible = true;
            this.colmMSIFechaFactura.VisibleIndex = 8;
            // 
            // colmMSIPedimento
            // 
            this.colmMSIPedimento.Caption = "No Pedimento";
            this.colmMSIPedimento.FieldName = "mMSIPedimento";
            this.colmMSIPedimento.Name = "colmMSIPedimento";
            this.colmMSIPedimento.Visible = true;
            this.colmMSIPedimento.VisibleIndex = 9;
            // 
            // colUnidades
            // 
            this.colUnidades.Caption = "Unidades";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 10;
            // 
            // colCosto
            // 
            this.colCosto.Caption = "Costo";
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 11;
            // 
            // colmMSIFolio
            // 
            this.colmMSIFolio.Caption = "No folio";
            this.colmMSIFolio.FieldName = "mMSIFolio";
            this.colmMSIFolio.Name = "colmMSIFolio";
            this.colmMSIFolio.Visible = true;
            this.colmMSIFolio.VisibleIndex = 12;
            // 
            // colmMSICostoP
            // 
            this.colmMSICostoP.Caption = "Costo O";
            this.colmMSICostoP.FieldName = "mMSICostoP";
            this.colmMSICostoP.Name = "colmMSICostoP";
            this.colmMSICostoP.Visible = true;
            this.colmMSICostoP.VisibleIndex = 13;
            // 
            // colDetalle
            // 
            this.colDetalle.Caption = "Detalle";
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 14;
            // 
            // colcAltClave
            // 
            this.colcAltClave.Caption = "Alternativa";
            this.colcAltClave.FieldName = "cAltClave";
            this.colcAltClave.Name = "colcAltClave";
            this.colcAltClave.Visible = true;
            this.colcAltClave.VisibleIndex = 15;
            // 
            // colcAlmClave
            // 
            this.colcAlmClave.Caption = "No almacen";
            this.colcAlmClave.FieldName = "cAlmClave";
            this.colcAlmClave.Name = "colcAlmClave";
            this.colcAlmClave.Visible = true;
            this.colcAlmClave.VisibleIndex = 16;
            // 
            // frmV_movadicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 593);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmV_movadicionales";
            this.Text = "Lista de Movimientos Adicionales";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_MOVADICIONALESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colmovalmacen;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private System.Windows.Forms.BindingSource v_MOVADICIONALESBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidMMovimientos;
        private DevExpress.XtraGrid.Columns.GridColumn colcMoAClave;
        private DevExpress.XtraGrid.Columns.GridColumn colcPrvClaveFab;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSIRemision;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSIFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSILote;
        private DevExpress.XtraGrid.Columns.GridColumn colcCalClave;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSIFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSIFechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSIPedimento;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSIFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colmMSICostoP;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcAltClave;
        private DevExpress.XtraGrid.Columns.GridColumn colcAlmClave;
    }
}
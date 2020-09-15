namespace Costos.presentador
{
    partial class FrmCostosxudn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCostosxudn));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtaño = new DevExpress.XtraEditors.TextEdit();
            this.txtmes = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.eCOSTOXUDNBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLAVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcTiPNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOSTOEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOSTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAJUSTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtaño.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCOSTOXUDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(806, 117);
            this.panelControl1.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtaño);
            this.groupControl2.Controls.Add(this.txtmes);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(12, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(356, 100);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Parametros: Seleccione el mes y año para contemplar en el ajuste";
            // 
            // txtaño
            // 
            this.txtaño.EnterMoveNextControl = true;
            this.txtaño.Location = new System.Drawing.Point(49, 59);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(100, 20);
            this.txtaño.TabIndex = 33;
            // 
            // txtmes
            // 
            this.txtmes.EnterMoveNextControl = true;
            this.txtmes.Location = new System.Drawing.Point(49, 33);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 20);
            this.txtmes.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Año";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(225, 33);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(114, 23);
            this.simpleButton4.TabIndex = 25;
            this.simpleButton4.Text = "&Actualizar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mes";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.eCOSTOXUDNBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 117);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(806, 450);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // eCOSTOXUDNBindingSource
            // 
            this.eCOSTOXUDNBindingSource.DataSource = typeof(Costos.Entidades.COSTOXUDNL);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmes,
            this.colano,
            this.colCLAVE,
            this.colNOMBRE,
            this.colcTiPNombre,
            this.colunidades,
            this.colCOSTOEST,
            this.colCOSTOP,
            this.colAJUSTE});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", this.colunidades, "n0")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupedColumns = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PaintStyleName = "Skin";
            // 
            // colmes
            // 
            this.colmes.Caption = "MES";
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.OptionsColumn.AllowEdit = false;
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 0;
            this.colmes.Width = 52;
            // 
            // colano
            // 
            this.colano.Caption = "AÑO";
            this.colano.FieldName = "ano";
            this.colano.Name = "colano";
            this.colano.OptionsColumn.AllowEdit = false;
            this.colano.Visible = true;
            this.colano.VisibleIndex = 1;
            // 
            // colCLAVE
            // 
            this.colCLAVE.Caption = "N° CLAVE";
            this.colCLAVE.FieldName = "CLAVE";
            this.colCLAVE.Name = "colCLAVE";
            this.colCLAVE.OptionsColumn.AllowEdit = false;
            this.colCLAVE.Visible = true;
            this.colCLAVE.VisibleIndex = 2;
            // 
            // colNOMBRE
            // 
            this.colNOMBRE.Caption = "NOMBRE";
            this.colNOMBRE.FieldName = "NOMBRE";
            this.colNOMBRE.Name = "colNOMBRE";
            this.colNOMBRE.OptionsColumn.AllowEdit = false;
            this.colNOMBRE.Visible = true;
            this.colNOMBRE.VisibleIndex = 3;
            this.colNOMBRE.Width = 116;
            // 
            // colcTiPNombre
            // 
            this.colcTiPNombre.Caption = "TIPO DE PRODUCTO";
            this.colcTiPNombre.FieldName = "cTiPNombre";
            this.colcTiPNombre.Name = "colcTiPNombre";
            this.colcTiPNombre.OptionsColumn.AllowEdit = false;
            this.colcTiPNombre.Visible = true;
            this.colcTiPNombre.VisibleIndex = 4;
            this.colcTiPNombre.Width = 127;
            // 
            // colunidades
            // 
            this.colunidades.Caption = "UNIDADES";
            this.colunidades.DisplayFormat.FormatString = "N0";
            this.colunidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colunidades.FieldName = "unidades";
            this.colunidades.Name = "colunidades";
            this.colunidades.OptionsColumn.AllowEdit = false;
            this.colunidades.Visible = true;
            this.colunidades.VisibleIndex = 5;
            // 
            // colCOSTOEST
            // 
            this.colCOSTOEST.Caption = "COSTO ESTIMADO";
            this.colCOSTOEST.DisplayFormat.FormatString = "N2";
            this.colCOSTOEST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCOSTOEST.FieldName = "COSTOEST";
            this.colCOSTOEST.Name = "colCOSTOEST";
            this.colCOSTOEST.OptionsColumn.AllowEdit = false;
            this.colCOSTOEST.Visible = true;
            this.colCOSTOEST.VisibleIndex = 6;
            this.colCOSTOEST.Width = 116;
            // 
            // colCOSTOP
            // 
            this.colCOSTOP.Caption = "COSTO PROMEDIO";
            this.colCOSTOP.DisplayFormat.FormatString = "N2";
            this.colCOSTOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCOSTOP.FieldName = "COSTOP";
            this.colCOSTOP.Name = "colCOSTOP";
            this.colCOSTOP.OptionsColumn.AllowEdit = false;
            this.colCOSTOP.Visible = true;
            this.colCOSTOP.VisibleIndex = 7;
            this.colCOSTOP.Width = 109;
            // 
            // colAJUSTE
            // 
            this.colAJUSTE.Caption = "AJUSTE";
            this.colAJUSTE.DisplayFormat.FormatString = "n2";
            this.colAJUSTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAJUSTE.FieldName = "AJUSTE";
            this.colAJUSTE.Name = "colAJUSTE";
            this.colAJUSTE.OptionsColumn.AllowEdit = false;
            this.colAJUSTE.Visible = true;
            this.colAJUSTE.VisibleIndex = 8;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DisplayMember = "cMoANombre";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "cMoAClave";
            this.repositoryItemGridLookUpEdit2.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // FrmCostosxudn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 567);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCostosxudn";
            this.Text = "Lista de Costos x udn";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtaño.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCOSTOXUDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtaño;
        private DevExpress.XtraEditors.TextEdit txtmes;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource eCOSTOXUDNBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn colano;
        private DevExpress.XtraGrid.Columns.GridColumn colCLAVE;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colcTiPNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades;
        private DevExpress.XtraGrid.Columns.GridColumn colCOSTOEST;
        private DevExpress.XtraGrid.Columns.GridColumn colCOSTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colAJUSTE;
    }
}
namespace Costos.presentador
{
    partial class frmcmovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcmovimientos));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cmovimientosalmacenBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcMoAClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcMoANombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcMoATipoMovto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcMoAIntegrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PAN1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtnomodulo = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmovimientosalmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAN1)).BeginInit();
            this.PAN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cmovimientosalmacenBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(450, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(656, 586);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cmovimientosalmacenBindingSource
            // 
            this.cmovimientosalmacenBindingSource.DataSource = typeof(Costos.Entidades.cmovimientosalmacen);
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
            this.colcMoAClave,
            this.colcMoANombre,
            this.colcMoATipoMovto,
            this.colcMoAIntegrado});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", null, "n0")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowGroup = false;
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
            // colcMoAClave
            // 
            this.colcMoAClave.Caption = "No Clave";
            this.colcMoAClave.FieldName = "cMoAClave";
            this.colcMoAClave.Name = "colcMoAClave";
            this.colcMoAClave.OptionsColumn.AllowEdit = false;
            this.colcMoAClave.Visible = true;
            this.colcMoAClave.VisibleIndex = 0;
            // 
            // colcMoANombre
            // 
            this.colcMoANombre.Caption = "Nombre Movimiento";
            this.colcMoANombre.FieldName = "cMoANombre";
            this.colcMoANombre.Name = "colcMoANombre";
            this.colcMoANombre.OptionsColumn.AllowEdit = false;
            this.colcMoANombre.Visible = true;
            this.colcMoANombre.VisibleIndex = 1;
            this.colcMoANombre.Width = 269;
            // 
            // colcMoATipoMovto
            // 
            this.colcMoATipoMovto.Caption = "Tipo Movimiento";
            this.colcMoATipoMovto.FieldName = "cMoATipoMovto";
            this.colcMoATipoMovto.Name = "colcMoATipoMovto";
            this.colcMoATipoMovto.OptionsColumn.AllowEdit = false;
            this.colcMoATipoMovto.Visible = true;
            this.colcMoATipoMovto.VisibleIndex = 2;
            // 
            // colcMoAIntegrado
            // 
            this.colcMoAIntegrado.Caption = "Integrado";
            this.colcMoAIntegrado.FieldName = "cMoAIntegrado";
            this.colcMoAIntegrado.Name = "colcMoAIntegrado";
            this.colcMoAIntegrado.OptionsColumn.AllowEdit = false;
            this.colcMoAIntegrado.Visible = true;
            this.colcMoAIntegrado.VisibleIndex = 3;
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
            // PAN1
            // 
            this.PAN1.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.PAN1.Appearance.Options.UseBackColor = true;
            this.PAN1.Controls.Add(this.groupControl1);
            this.PAN1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PAN1.Location = new System.Drawing.Point(0, 0);
            this.PAN1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.PAN1.Name = "PAN1";
            this.PAN1.Size = new System.Drawing.Size(450, 586);
            this.PAN1.TabIndex = 24;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.checkEdit2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtnomodulo);
            this.groupControl1.Controls.Add(this.txtfecha);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(423, 280);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Detalle";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Integrado";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Tipo de Movimiento";
            // 
            // checkEdit2
            // 
            this.checkEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cmovimientosalmacenBindingSource, "cMoAIntegrado", true));
            this.checkEdit2.Enabled = false;
            this.checkEdit2.Location = new System.Drawing.Point(378, 105);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "";
            this.checkEdit2.Size = new System.Drawing.Size(20, 19);
            this.checkEdit2.TabIndex = 37;
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cmovimientosalmacenBindingSource, "cMoATipoMovto", true));
            this.checkEdit1.Enabled = false;
            this.checkEdit1.Location = new System.Drawing.Point(378, 80);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(20, 19);
            this.checkEdit1.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "No";
            // 
            // txtnomodulo
            // 
            this.txtnomodulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmovimientosalmacenBindingSource, "cMoAClave", true));
            this.txtnomodulo.Enabled = false;
            this.txtnomodulo.Location = new System.Drawing.Point(355, 28);
            this.txtnomodulo.Name = "txtnomodulo";
            this.txtnomodulo.ReadOnly = true;
            this.txtnomodulo.Size = new System.Drawing.Size(43, 20);
            this.txtnomodulo.TabIndex = 34;
            // 
            // txtfecha
            // 
            this.txtfecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmovimientosalmacenBindingSource, "cMoANombre", true));
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(185, 54);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(213, 20);
            this.txtfecha.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre de Movimiento";
            // 
            // frmcmovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 586);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.PAN1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcmovimientos";
            this.Text = "Catalogo de Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmovimientosalmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAN1)).EndInit();
            this.PAN1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.PanelControl PAN1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtnomodulo;
        private System.Windows.Forms.TextBox txtfecha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource cmovimientosalmacenBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcMoAClave;
        private DevExpress.XtraGrid.Columns.GridColumn colcMoANombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcMoATipoMovto;
        private DevExpress.XtraGrid.Columns.GridColumn colcMoAIntegrado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
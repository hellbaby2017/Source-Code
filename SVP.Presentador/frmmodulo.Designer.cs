namespace SVP.presentador
{
    partial class frmmodulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodulo));
            this.bindingModulo = new System.Windows.Forms.BindingSource();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtnomodulo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bteliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btguardar = new DevExpress.XtraEditors.SimpleButton();
            this.btcancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnuevo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingModulo
            // 
            this.bindingModulo.DataSource = typeof(SVP.Entidades.Cfg_cModulos);
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "cMoANombre";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.ValueMember = "cMoAClave";
            this.repositoryItemGridLookUpEdit1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DisplayMember = "cMoANombre";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.NullText = "";
            this.repositoryItemGridLookUpEdit3.ValueMember = "cMoAClave";
            this.repositoryItemGridLookUpEdit3.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DisplayMember = "cMoANombre";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.NullText = "";
            this.repositoryItemGridLookUpEdit4.ValueMember = "cMoAClave";
            this.repositoryItemGridLookUpEdit4.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEditar);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.bteliminar);
            this.panelControl1.Controls.Add(this.btguardar);
            this.panelControl1.Controls.Add(this.btcancelar);
            this.panelControl1.Controls.Add(this.btnuevo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(538, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(486, 591);
            this.panelControl1.TabIndex = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(313, 40);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 23);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtnomodulo);
            this.groupControl1.Controls.Add(this.txtnombre);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(6, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 96);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "Modulo";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "No modulo";
            // 
            // txtnomodulo
            // 
            this.txtnomodulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingModulo, "cModulo", true));
            this.txtnomodulo.Location = new System.Drawing.Point(95, 25);
            this.txtnomodulo.Name = "txtnomodulo";
            this.txtnomodulo.ReadOnly = true;
            this.txtnomodulo.Size = new System.Drawing.Size(43, 20);
            this.txtnomodulo.TabIndex = 34;
            // 
            // txtnombre
            // 
            this.txtnombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingModulo, "Nombre", true));
            this.txtnombre.Location = new System.Drawing.Point(95, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(135, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingModulo, "cModulo", true));
            this.textBox1.Location = new System.Drawing.Point(339, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 32;
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(313, 124);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(114, 23);
            this.bteliminar.TabIndex = 31;
            this.bteliminar.Text = "&Eliminar";
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click_1);
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(313, 96);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(114, 23);
            this.btguardar.TabIndex = 30;
            this.btguardar.Text = "&Guardar";
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click_1);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(313, 68);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(114, 23);
            this.btcancelar.TabIndex = 29;
            this.btcancelar.Text = "&Cancelar";
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click_1);
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(313, 12);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(114, 23);
            this.btnuevo.TabIndex = 28;
            this.btnuevo.Text = "&Nuevo";
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingModulo;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(538, 591);
            this.gridControl1.TabIndex = 31;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.colcModulo,
            this.colNombre});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", null, "n0")});
            this.gridView2.Name = "gridView2";
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
            // colcModulo
            // 
            this.colcModulo.Caption = "No Modulo";
            this.colcModulo.FieldName = "cModulo";
            this.colcModulo.Name = "colcModulo";
            this.colcModulo.OptionsColumn.AllowEdit = false;
            this.colcModulo.Visible = true;
            this.colcModulo.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 170;
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
            // frmmodulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 591);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmodulo";
            this.Text = "Lista de Modulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bindingModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.BindingSource bindingModulo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtnomodulo;
        private System.Windows.Forms.TextBox txtnombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton bteliminar;
        private DevExpress.XtraEditors.SimpleButton btguardar;
        private DevExpress.XtraEditors.SimpleButton btcancelar;
        private DevExpress.XtraEditors.SimpleButton btnuevo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
    }
}
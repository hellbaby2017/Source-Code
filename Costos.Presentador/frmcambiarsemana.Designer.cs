namespace Costos.presentador
{
    partial class frmcambiarsemana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcambiarsemana));
            this.label1 = new System.Windows.Forms.Label();
            this.GrOrigensemana = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.GrFinalSemana = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblusuario = new System.Windows.Forms.Label();
            this.bindingMvi_cCalendario = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nocalendario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Semana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fechfinal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrOrigensemana.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrFinalSemana.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMvi_cCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semana Origen";
            // 
            // GrOrigensemana
            // 
            this.GrOrigensemana.EditValue = "";
            this.GrOrigensemana.Location = new System.Drawing.Point(111, 9);
            this.GrOrigensemana.Name = "GrOrigensemana";
            this.GrOrigensemana.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GrOrigensemana.Properties.DataSource = this.bindingMvi_cCalendario;
            this.GrOrigensemana.Properties.DisplayMember = "cCalNoSemana";
            this.GrOrigensemana.Properties.PopupFormMinSize = new System.Drawing.Size(600, 200);
            this.GrOrigensemana.Properties.PopupFormSize = new System.Drawing.Size(600, 200);
            this.GrOrigensemana.Properties.ValueMember = "cCalClave";
            this.GrOrigensemana.Properties.View = this.gridLookUpEdit1View;
            this.GrOrigensemana.Size = new System.Drawing.Size(83, 20);
            this.GrOrigensemana.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nocalendario,
            this.Semana,
            this.Anno,
            this.gmes,
            this.FechaIni,
            this.Fechfinal});
            this.gridLookUpEdit1View.DetailHeight = 500;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semana Destino";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(223, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(223, 35);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // GrFinalSemana
            // 
            this.GrFinalSemana.EditValue = "";
            this.GrFinalSemana.Location = new System.Drawing.Point(111, 35);
            this.GrFinalSemana.Name = "GrFinalSemana";
            this.GrFinalSemana.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GrFinalSemana.Properties.DataSource = this.bindingMvi_cCalendario;
            this.GrFinalSemana.Properties.DisplayMember = "cCalNoSemana";
            this.GrFinalSemana.Properties.PopupFormMinSize = new System.Drawing.Size(600, 200);
            this.GrFinalSemana.Properties.PopupFormSize = new System.Drawing.Size(600, 200);
            this.GrFinalSemana.Properties.ValueMember = "cCalClave";
            this.GrFinalSemana.Properties.View = this.gridView1;
            this.GrFinalSemana.Size = new System.Drawing.Size(83, 20);
            this.GrFinalSemana.TabIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(13, 55);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 13);
            this.lblusuario.TabIndex = 8;
            // 
            // bindingMvi_cCalendario
            // 
            this.bindingMvi_cCalendario.DataSource = typeof(Costos.Entidades.Mvi_cCalendario);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "No Calendario";
            this.gridColumn1.FieldName = "cCalClave";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 853;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "No semana";
            this.gridColumn2.FieldName = "cCalNoSemana";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 99;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Año";
            this.gridColumn3.FieldName = "cCalAnio";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 136;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mes";
            this.gridColumn4.FieldName = "cCalMes";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 169;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha Inicial";
            this.gridColumn5.FieldName = "cCalFechaInicio";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 244;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha Final";
            this.gridColumn6.FieldName = "cCalFechaFinal";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 233;
            // 
            // Nocalendario
            // 
            this.Nocalendario.Caption = "No Calendario";
            this.Nocalendario.FieldName = "cCalClave";
            this.Nocalendario.Name = "Nocalendario";
            this.Nocalendario.Visible = true;
            this.Nocalendario.VisibleIndex = 5;
            this.Nocalendario.Width = 110;
            // 
            // Semana
            // 
            this.Semana.Caption = "No semana";
            this.Semana.FieldName = "cCalNoSemana";
            this.Semana.Name = "Semana";
            this.Semana.Visible = true;
            this.Semana.VisibleIndex = 0;
            this.Semana.Width = 86;
            // 
            // Anno
            // 
            this.Anno.Caption = "Año";
            this.Anno.FieldName = "cCalAnio";
            this.Anno.Name = "Anno";
            this.Anno.Visible = true;
            this.Anno.VisibleIndex = 1;
            // 
            // gmes
            // 
            this.gmes.Caption = "Mes";
            this.gmes.FieldName = "cCalMes";
            this.gmes.Name = "gmes";
            this.gmes.Visible = true;
            this.gmes.VisibleIndex = 2;
            // 
            // FechaIni
            // 
            this.FechaIni.Caption = "Fecha Inicial";
            this.FechaIni.FieldName = "cCalFechaInicio";
            this.FechaIni.Name = "FechaIni";
            this.FechaIni.Visible = true;
            this.FechaIni.VisibleIndex = 3;
            this.FechaIni.Width = 121;
            // 
            // Fechfinal
            // 
            this.Fechfinal.Caption = "Fecha Final";
            this.Fechfinal.FieldName = "cCalFechaFinal";
            this.Fechfinal.Name = "Fechfinal";
            this.Fechfinal.Visible = true;
            this.Fechfinal.VisibleIndex = 4;
            this.Fechfinal.Width = 127;
            // 
            // frmcambiarsemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 76);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.GrFinalSemana);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrOrigensemana);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcambiarsemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Semana";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmcambiarsemana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrOrigensemana.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrFinalSemana.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMvi_cCalendario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit GrOrigensemana;
           private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Nocalendario;
        private DevExpress.XtraGrid.Columns.GridColumn Semana;
        private DevExpress.XtraGrid.Columns.GridColumn Anno;
        private DevExpress.XtraGrid.Columns.GridColumn gmes;
        private DevExpress.XtraGrid.Columns.GridColumn FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn Fechfinal;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GridLookUpEdit GrFinalSemana;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.BindingSource bindingMvi_cCalendario;
        public System.Windows.Forms.Label lblusuario;
    }
}
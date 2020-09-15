namespace Costos.presentador
{
    partial class Frmborrarsemana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmborrarsemana));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblusuario = new System.Windows.Forms.Label();
            this.cmbcalendario = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.mvicCalendarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcalendario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvicCalendarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblusuario);
            this.groupControl2.Controls.Add(this.cmbcalendario);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(581, 98);
            this.groupControl2.TabIndex = 39;
            this.groupControl2.Text = "Seleccione el no de Calendario  de la semana a borrar:";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(8, 68);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 13);
            this.lblusuario.TabIndex = 34;
            // 
            // cmbcalendario
            // 
            this.cmbcalendario.EditValue = 0;
            this.cmbcalendario.EnterMoveNextControl = true;
            this.cmbcalendario.Location = new System.Drawing.Point(71, 33);
            this.cmbcalendario.Name = "cmbcalendario";
            this.cmbcalendario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbcalendario.Properties.DataSource = this.mvicCalendarioBindingSource;
            this.cmbcalendario.Properties.DisplayMember = "cCalNoSemana";
            this.cmbcalendario.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.cmbcalendario.Properties.PopupFormMinSize = new System.Drawing.Size(400, 200);
            this.cmbcalendario.Properties.PopupFormSize = new System.Drawing.Size(400, 200);
            this.cmbcalendario.Properties.ValidateOnEnterKey = true;
            this.cmbcalendario.Properties.ValueMember = "cCalClave";
            this.cmbcalendario.Properties.View = this.gridView3;
            this.cmbcalendario.Size = new System.Drawing.Size(351, 20);
            this.cmbcalendario.TabIndex = 33;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView3.DetailHeight = 800;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gridView3.OptionsDetail.SmartDetailHeight = true;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(458, 59);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(114, 23);
            this.simpleButton3.TabIndex = 32;
            this.simpleButton3.Text = "&Cancelar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(458, 30);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(114, 23);
            this.simpleButton4.TabIndex = 25;
            this.simpleButton4.Text = "&Aceptar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Calendario:";
            // 
            // mvicCalendarioBindingSource
            // 
            this.mvicCalendarioBindingSource.DataSource = typeof(Costos.Entidades.Mvi_cCalendario);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "No Clave";
            this.gridColumn2.FieldName = "cCalClave";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 59;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "N° Semana";
            this.gridColumn3.FieldName = "cCalNoSemana";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 113;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Año";
            this.gridColumn4.FieldName = "cCalAnio";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 113;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "N° Mes";
            this.gridColumn7.FieldName = "cCalMes";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 86;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha Inicial";
            this.gridColumn5.FieldName = "cCalFechaInicio";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 138;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha Final";
            this.gridColumn6.FieldName = "cCalFechaFinal";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 128;
            // 
            // Frmborrarsemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 101);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmborrarsemana";
            this.Text = "Borrar semana";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcalendario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvicCalendarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit cmbcalendario;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.BindingSource mvicCalendarioBindingSource;
        public System.Windows.Forms.Label lblusuario;
    }
}
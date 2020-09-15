namespace Costos.presentador
{
    partial class frmreproceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreproceso));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblusuario = new System.Windows.Forms.Label();
            this.cmbalternativa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.mvicAlternativasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbalternativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvicAlternativasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblusuario);
            this.groupControl2.Controls.Add(this.cmbalternativa);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(581, 98);
            this.groupControl2.TabIndex = 37;
            this.groupControl2.Text = "Parametros";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(11, 68);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 13);
            this.lblusuario.TabIndex = 34;
            // 
            // cmbalternativa
            // 
            this.cmbalternativa.EditValue = "Ingresar Alternativa";
            this.cmbalternativa.EnterMoveNextControl = true;
            this.cmbalternativa.Location = new System.Drawing.Point(72, 33);
            this.cmbalternativa.Name = "cmbalternativa";
            this.cmbalternativa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbalternativa.Properties.DataSource = this.mvicAlternativasBindingSource;
            this.cmbalternativa.Properties.DisplayMember = "cAltClave";
            this.cmbalternativa.Properties.ValueMember = "cAltClave";
            this.cmbalternativa.Properties.View = this.gridView4;
            this.cmbalternativa.Size = new System.Drawing.Size(380, 20);
            this.cmbalternativa.TabIndex = 33;
            // 
            // mvicAlternativasBindingSource
            // 
            this.mvicAlternativasBindingSource.DataSource = typeof(Costos.Entidades.Mvi_cAlternativas);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Alternativa";
            this.gridColumn8.FieldName = "cAltClave";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 242;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Modelo";
            this.gridColumn9.FieldName = "cPrdModelo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 130;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Color";
            this.gridColumn10.FieldName = "cColClave";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 130;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Material";
            this.gridColumn11.FieldName = "cMatClave";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            this.gridColumn11.Width = 132;
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
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Alternativa";
            // 
            // frmreproceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 105);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmreproceso";
            this.Text = "Reproceso  por Alternativa";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbalternativa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvicAlternativasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource mvicAlternativasBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cmbalternativa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        public System.Windows.Forms.Label lblusuario;
    }
}
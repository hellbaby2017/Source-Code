namespace SVP.presentador
{
    partial class frmusuarioi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusuarioi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grpcontraseña = new DevExpress.XtraEditors.GroupControl();
            this.btncamviar = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnuevac = new System.Windows.Forms.TextBox();
            this.txtanteriorc = new System.Windows.Forms.TextBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnousuario = new System.Windows.Forms.TextBox();
            this.Cfg_cUsuariosB = new System.Windows.Forms.BindingSource();
            this.label5 = new System.Windows.Forms.Label();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbtipousuario = new System.Windows.Forms.ComboBox();
            this.Cfg_AtiposUsuariosb = new System.Windows.Forms.BindingSource();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtnomusuario = new System.Windows.Forms.TextBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcUsuNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcUsuActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcausutipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcontraseña)).BeginInit();
            this.grpcontraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cfg_cUsuariosB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cfg_AtiposUsuariosb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.grpcontraseña);
            this.panelControl1.Controls.Add(this.simpleButton6);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(645, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(438, 560);
            this.panelControl1.TabIndex = 16;
            // 
            // grpcontraseña
            // 
            this.grpcontraseña.Controls.Add(this.btncamviar);
            this.grpcontraseña.Controls.Add(this.label9);
            this.grpcontraseña.Controls.Add(this.label10);
            this.grpcontraseña.Controls.Add(this.txtnuevac);
            this.grpcontraseña.Controls.Add(this.txtanteriorc);
            this.grpcontraseña.Location = new System.Drawing.Point(6, 222);
            this.grpcontraseña.Name = "grpcontraseña";
            this.grpcontraseña.Size = new System.Drawing.Size(305, 132);
            this.grpcontraseña.TabIndex = 51;
            this.grpcontraseña.Text = "Cambiar contraseña";
            this.grpcontraseña.Visible = false;
            // 
            // btncamviar
            // 
            this.btncamviar.Location = new System.Drawing.Point(180, 92);
            this.btncamviar.Name = "btncamviar";
            this.btncamviar.Size = new System.Drawing.Size(114, 23);
            this.btncamviar.TabIndex = 48;
            this.btncamviar.Text = "&Cambiar";
            this.btncamviar.Click += new System.EventHandler(this.btncamviar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(8, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Contraseña Nueva";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(5, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Contraseña anterior";
            // 
            // txtnuevac
            // 
            this.txtnuevac.Location = new System.Drawing.Point(112, 57);
            this.txtnuevac.Name = "txtnuevac";
            this.txtnuevac.PasswordChar = '*';
            this.txtnuevac.Size = new System.Drawing.Size(186, 20);
            this.txtnuevac.TabIndex = 25;
            this.txtnuevac.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtanteriorc
            // 
            this.txtanteriorc.Location = new System.Drawing.Point(112, 31);
            this.txtanteriorc.Name = "txtanteriorc";
            this.txtanteriorc.PasswordChar = '*';
            this.txtanteriorc.Size = new System.Drawing.Size(186, 20);
            this.txtanteriorc.TabIndex = 24;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(312, 95);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(114, 23);
            this.simpleButton6.TabIndex = 50;
            this.simpleButton6.Text = "&Cambiar Contraseña";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(317, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 23);
            this.simpleButton1.TabIndex = 49;
            this.simpleButton1.Text = "&Editar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(317, 153);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 23);
            this.simpleButton2.TabIndex = 48;
            this.simpleButton2.Text = "&Eliminar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(317, 124);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(114, 23);
            this.simpleButton3.TabIndex = 47;
            this.simpleButton3.Text = "&Guardar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(317, 68);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(114, 23);
            this.simpleButton4.TabIndex = 46;
            this.simpleButton4.Text = "&Cancelar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(317, 12);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(114, 23);
            this.simpleButton5.TabIndex = 45;
            this.simpleButton5.Text = "&Nuevo";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtnousuario);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.chkactivo);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.cmbtipousuario);
            this.groupControl1.Controls.Add(this.txtpassword);
            this.groupControl1.Controls.Add(this.txtnomusuario);
            this.groupControl1.Location = new System.Drawing.Point(6, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(305, 204);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Modulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "No de Usuario";
            // 
            // txtnousuario
            // 
            this.txtnousuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Cfg_cUsuariosB, "cUsuClave", true));
            this.txtnousuario.Enabled = false;
            this.txtnousuario.Location = new System.Drawing.Point(271, 29);
            this.txtnousuario.Name = "txtnousuario";
            this.txtnousuario.Size = new System.Drawing.Size(29, 20);
            this.txtnousuario.TabIndex = 32;
            // 
            // Cfg_cUsuariosB
            // 
            this.Cfg_cUsuariosB.DataSource = typeof(SVP.Entidades.Cfg_cUsuarios);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Usuario Activo";
            // 
            // chkactivo
            // 
            this.chkactivo.BackColor = System.Drawing.Color.Transparent;
            this.chkactivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.Cfg_cUsuariosB, "cUsuActivo", true));
            this.chkactivo.Enabled = false;
            this.chkactivo.Location = new System.Drawing.Point(286, 141);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(14, 24);
            this.chkactivo.TabIndex = 30;
            this.chkactivo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(8, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre de Usuario";
            // 
            // cmbtipousuario
            // 
            this.cmbtipousuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.Cfg_cUsuariosB, "causutipo", true));
            this.cmbtipousuario.DataSource = this.Cfg_AtiposUsuariosb;
            this.cmbtipousuario.DisplayMember = "Nombre";
            this.cmbtipousuario.Enabled = false;
            this.cmbtipousuario.FormattingEnabled = true;
            this.cmbtipousuario.Location = new System.Drawing.Point(114, 114);
            this.cmbtipousuario.Name = "cmbtipousuario";
            this.cmbtipousuario.Size = new System.Drawing.Size(186, 21);
            this.cmbtipousuario.TabIndex = 26;
            this.cmbtipousuario.ValueMember = "causutipo";
            // 
            // Cfg_AtiposUsuariosb
            // 
            this.Cfg_AtiposUsuariosb.DataSource = typeof(SVP.Entidades.Cfg_AtiposUsuarios);
            // 
            // txtpassword
            // 
            this.txtpassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Cfg_cUsuariosB, "cUsucontrasena", true));
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(114, 87);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(186, 20);
            this.txtpassword.TabIndex = 25;
            // 
            // txtnomusuario
            // 
            this.txtnomusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Cfg_cUsuariosB, "cUsuNombre", true));
            this.txtnomusuario.Enabled = false;
            this.txtnomusuario.Location = new System.Drawing.Point(114, 61);
            this.txtnomusuario.Name = "txtnomusuario";
            this.txtnomusuario.Size = new System.Drawing.Size(186, 20);
            this.txtnomusuario.TabIndex = 24;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.Cfg_AtiposUsuariosb;
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
            this.colcUsuNombre,
            this.colcUsuActivo,
            this.colcausutipo});
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
            // colcUsuNombre
            // 
            this.colcUsuNombre.Caption = "Nombre del usuario";
            this.colcUsuNombre.FieldName = "cUsuNombre";
            this.colcUsuNombre.Name = "colcUsuNombre";
            this.colcUsuNombre.OptionsColumn.AllowEdit = false;
            this.colcUsuNombre.Visible = true;
            this.colcUsuNombre.VisibleIndex = 0;
            this.colcUsuNombre.Width = 123;
            // 
            // colcUsuActivo
            // 
            this.colcUsuActivo.Caption = "Usuario Activo";
            this.colcUsuActivo.FieldName = "cUsuActivo";
            this.colcUsuActivo.Name = "colcUsuActivo";
            this.colcUsuActivo.OptionsColumn.AllowEdit = false;
            this.colcUsuActivo.Visible = true;
            this.colcUsuActivo.VisibleIndex = 1;
            this.colcUsuActivo.Width = 115;
            // 
            // colcausutipo
            // 
            this.colcausutipo.Caption = "Tipo de usuario";
            this.colcausutipo.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colcausutipo.FieldName = "causutipo";
            this.colcausutipo.Name = "colcausutipo";
            this.colcausutipo.OptionsColumn.AllowEdit = false;
            this.colcausutipo.Visible = true;
            this.colcausutipo.VisibleIndex = 2;
            this.colcausutipo.Width = 213;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.Cfg_cUsuariosB;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(645, 560);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmusuarioi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 560);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmusuarioi";
            this.Text = "Lista de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcontraseña)).EndInit();
            this.grpcontraseña.ResumeLayout(false);
            this.grpcontraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cfg_cUsuariosB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cfg_AtiposUsuariosb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkactivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbtipousuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtnomusuario;
        private System.Windows.Forms.BindingSource Cfg_cUsuariosB;
        private System.Windows.Forms.BindingSource Cfg_AtiposUsuariosb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnousuario;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.GroupControl grpcontraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnuevac;
        private System.Windows.Forms.TextBox txtanteriorc;
        private DevExpress.XtraEditors.SimpleButton btncamviar;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcUsuNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcUsuActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colcausutipo;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}
Imports System.Configuration
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtusuario = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtcontrasena = New DevExpress.XtraEditors.TextEdit()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtcontrasena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Location = New System.Drawing.Point(211, 33)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdaceptar.TabIndex = 0
        Me.cmdaceptar.Text = "Aceptar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(211, 62)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancelar.TabIndex = 1
        Me.cmdcancelar.Text = "Cancelar"
        '
        'txtusuario
        '
        Me.txtusuario.EnterMoveNextControl = True
        Me.txtusuario.Location = New System.Drawing.Point(96, 36)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(21, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtcontrasena)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.cmdaceptar)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.cmdcancelar)
        Me.GroupControl1.Controls.Add(Me.txtusuario)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(311, 113)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Ingrese sus credenciales"
        '
        'txtcontrasena
        '
        Me.txtcontrasena.EnterMoveNextControl = True
        Me.txtcontrasena.Location = New System.Drawing.Point(96, 66)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtcontrasena.TabIndex = 6
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Sharp"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 113)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtcontrasena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdaceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtusuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtcontrasena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class

Imports System.Data
Imports DevExpress.Skins
Imports System.Configuration
Imports Costos.Entidades

Public Class frmlogin
    Dim entidad As New SVP.Entidades.UsuariosEntities(VarGlobales.Variables.conexionusuarios)
    Dim objmodulo As New Costos.presentador.FuncionesCRUD

    Private Sub cmdaceptar_Click(sender As Object, e As EventArgs) Handles cmdaceptar.Click
        Dim usuarios As String
        Dim contra As String
        usuarios = txtusuario.Text
        contra = txtcontrasena.Text
        Dim q = From usuario In entidad.Cfg_cUsuarios
                Where usuario.cUsuNombre = usuarios And usuario.cUsucontrasena = contra
                Select usuario
        If q.ToList.Count > 0 Then
            tusuario = q.ToList.Item(0).causutipo
            usuariot = txtusuario.Text
            objmodulo.Registrarlog("LOGIN", "REGISTRAR", "INGRESO A CONTRASEÑA", usuariot.ToString)
            FRMMDI.Show()
            Me.Close()

        Else
            MsgBox("Contraseña o usuario equivocado", MsgBoxStyle.Information, "Usuarios")
        End If
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        Me.Close()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles Me.Load


        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Sharp Plus")
        GroupControl1.Text = GroupControl1.Text & Empresa
        Me.Text = Me.Text & Empresa
    End Sub
End Class
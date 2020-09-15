Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraNavBar
Imports Costos.presentador
Imports SVP
Imports SVP.Entidades
Imports Transito.Presentador

Public Class FRMMDI

    Dim entidad As New UsuariosEntities(VarGlobales.Variables.CadenaUsuarios)
    Dim objmodulo As New Costos.presentador.FuncionesCRUD

    Private Sub barbusuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbusuarios.ItemClick

    End Sub



    Private Sub brcalendario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brcalendario.ItemClick
        If permisoc(e.Item.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmcalendario
            formulario.MdiParent = Me
            formulario.Text = "Calendario"
            formulario.Show()
        End If
    End Sub

    Private Sub brTipos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brTipos.ItemClick

    End Sub

    Private Sub FRMMDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = Me.Text & Empresa
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Sharp Plus")
        InitSkinGallery()
        txtusurio.Caption = usuariot
        Rcostos.Visible = False
        RTransitos.Visible = False
        Dim q = From tusuarios In entidad.vtipoxprogramas
                Where tusuarios.causutipo = tusuario And tusuarios.cPrograma = 1
                Select tusuarios
        If q.ToList.Count > 0 Then
            Rcostos.Visible = True
        End If

        q = From tusuarios In entidad.vtipoxprogramas
            Where tusuarios.causutipo = tusuario And tusuarios.cPrograma = 2
            Select tusuarios
        If q.ToList.Count > 0 Then
            RTransitos.Visible = True
        End If
        Dim w = From p In entidad.vtipoxmoduloes
                Select p
        'Datasource1.DataSource = w.ToList
    End Sub
    Function permisoc(text As String) As Integer
        Dim numero As Integer
        entidad = New SVP.Entidades.UsuariosEntities(VarGlobales.Variables.conexionusuarios)

        Dim q = From t In entidad.vtipoxmoduloes
                Where t.causutipo = tusuario And t.Nombre = text
                Select t
        numero = q.Count
        If numero >= 1 Then
            Return 1
        Else
            MsgBox("No se tiene los permisos necesarios para el modulo " & text.TrimStart)
            Return 0
        End If
    End Function
    Private Sub InitSkinGallery()
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Sub cmdusuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdusuarios.ItemClick
        If permisoc(e.Item.Caption) = 1 Then
            Dim formulario As New SVP.Presentador.frmusuarioi
            formulario.MdiParent = Me
        formulario.Show()
            formulario.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub BarTipoUsuario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarTipoUsuario.ItemClick
        If permisoc(e.Item.Caption) = 1 Then
            Dim formulario As New SVP.Presentador.FrmTipodUsuario
            formulario.MdiParent = Me
        formulario.Show()
            formulario.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If permisoc(e.Item.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmlmovimientosi
            Cursor.Current = Cursors.WaitCursor
            formulario.MdiParent = Me
            formulario.Show()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub barkardex_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barkardex.ItemClick
        If permisoc(e.Item.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmKardexi
            formulario.MdiParent = Me

            formulario.Show()
        End If
    End Sub



    Private Sub rptkardex_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles rptkardex.LinkClicked
        If permisoc(e.Link.Caption) = 1 Then
            Dim formulario As New Costos.presentador.frmkardexcs
            formulario.MdiParent = Me
            formulario.WindowState = FormWindowState.Maximized
            formulario.Show()
        End If
    End Sub

    Private Sub brcalcular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles brcalcular.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            objmodulo.RecalcularInv()

        End If
    End Sub



    Private Sub barModulo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barModulo.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            Dim formulario As New Presentador.frmmodulo
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub





    Private Sub Bareliminars_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Bareliminars.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.Frmborrarsemana
            formulario.lblusuario.Text = txtusurio.Caption
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub Barcsemana_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Barcsemana.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmComparacionsem
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub barcostoxalt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barcostoxalt.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmcostoxalt
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub Rptcxalternativa_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles Rptcxalternativa.LinkClicked
        If permisoc(e.Link.Caption) = 1 Then
            Dim formulario As New Costos.presentador.frmreportecostoxalt
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarExcel.ItemClick
        Dim objmodulo2 As New Costos.Funciones.FUNCIONES
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Cursor.Current = Cursors.WaitCursor
            objmodulo2.excel()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub Barkardexl_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Barkardexl.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            Dim formulario As New Costos.presentador.frmkardexL
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub rptkardexfecha_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles rptkardexfecha.LinkClicked
        If permisoc(e.Link.Caption) = 1 Then
            Dim formulario As New Costos.presentador.frmRKardexL
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub Barinventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Barinventario.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frminventario
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub rptInventario_LinkPressed(sender As Object, e As NavBarLinkEventArgs) Handles rptInventario.LinkPressed
        If permisoc(e.Link.Caption) = 1 Then
            Dim formulario As New Costos.presentador.Frmrinventario
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BarCostoxtipo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Cto.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmCostoxtip
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub RptCostoxtipo_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles RptCostoxtipo.LinkClicked
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Link.Caption, e.Link.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmrcostoxtip
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BarInventipo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarInventipo.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmcapas1
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub barcostoxudn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barcostoxudn.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.FrmCostosxudn
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim activeChild As Form = Me.ActiveMdiChild
        If activeChild IsNot Nothing Then
            If TypeOf activeChild.ActiveControl Is DevExpress.XtraGrid.GridControl Then
                'Dim theBox As DevExpress.XtraGrid.GridControl = ActiveControl.Controls("gridControl1")
                Dim theBox As DevExpress.XtraGrid.GridControl = CType(activeChild.ActiveControl, DevExpress.XtraGrid.GridControl)
                Exportar.exportarexcel(theBox)
            Else
                XtraMessageBox.Show("Seleccione la malla a Exportar", "Exportacion Excel")
            End If
        End If
    End Sub

    Private Sub barexpdf_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barexpdf.ItemClick
        Dim activeChild As Form = Me.ActiveMdiChild
        If activeChild IsNot Nothing Then
            If TypeOf activeChild.ActiveControl Is DevExpress.XtraGrid.GridControl Then
                'Dim theBox As DevExpress.XtraGrid.GridControl = ActiveControl.Controls("gridControl1")
                Dim theBox As DevExpress.XtraGrid.GridControl = CType(activeChild.ActiveControl, DevExpress.XtraGrid.GridControl)
                Exportar.exportarpdf(theBox)
            Else
                XtraMessageBox.Show("Seleccione la malla a Exportar", "Exportacion PDF")
            End If
        End If
    End Sub

    Private Sub Barexphtml_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Barexphtml.ItemClick
        Dim activeChild As Form = Me.ActiveMdiChild
        If activeChild IsNot Nothing Then
            If TypeOf activeChild.ActiveControl Is DevExpress.XtraGrid.GridControl Then
                'Dim theBox As DevExpress.XtraGrid.GridControl = ActiveControl.Controls("gridControl1")
                Dim theBox As DevExpress.XtraGrid.GridControl = CType(activeChild.ActiveControl, DevExpress.XtraGrid.GridControl)
                Exportar.exportarhtml(theBox)
            Else
                XtraMessageBox.Show("Seleccione la malla a Exportar", "Exportacion HTML")
            End If
        End If
    End Sub

    Private Sub barreprocesoalt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barreprocesoalt.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmreproceso
            formulario.lblusuario.Text = txtusurio.Caption
            formulario.Show()
        End If
    End Sub

    Private Sub BarRepfecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarRepfecha.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmreprocesofecha
            formulario.Show()
        End If
    End Sub

    Private Sub barimpmvi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barimpmvi.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmimportar
            formulario.WindowState = FormWindowState.Maximized
            formulario.lblusuario.Text = txtusurio.Caption
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub barcambiars_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barcambiars.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmcambiarsemana
            formulario.lblusuario.Text = txtusurio.Caption
            formulario.Show()
        End If
    End Sub

    Private Sub baralmacen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles baralmacen.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Transitos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Transito.Presentador.frmlalmacenes
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub Barctransito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Barctransito.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Transitos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Transito.Presentador.frmctransito
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub barProyecto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barProyecto.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Transitos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Transito.Presentador.frmproyecto
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub baralmsql_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles baralmsql.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Transitos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Transito.Presentador.frmtransitxalmacen
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BCatalogos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BCatalogos.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Catalogos Costos", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmcmovimientos
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub NavBarControl1_Click(sender As Object, e As EventArgs) Handles NavBarControl1.Click

    End Sub

    Private Sub Blmovad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Blmovad.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Reporte Mov Especiales", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.frmV_movadicionales
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If permisoc(e.Link.Caption) = 1 Then
            objmodulo.Registrarlog("Reporte Mov Especiales", e.Item.Caption, e.Item.Caption, txtusurio.Caption)
            Dim formulario As New Costos.presentador.FrmRInvetarioxfecha
            formulario.WindowState = FormWindowState.Maximized
            formulario.MdiParent = Me
            formulario.Show()
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barusemana.ItemClick
        objmodulo.ultmsemana()
        MsgBox(objmodulo.ultmsemana, MsgBoxStyle.Information, "Ultima semana Exportada")
    End Sub
End Class
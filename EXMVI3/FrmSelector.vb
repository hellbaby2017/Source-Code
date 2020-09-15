Imports System.Configuration
Imports DevExpress.Skins
Imports Andrea
Imports VarGlobales
Imports System.Data.EntityClient

Public Class FrmSelector

    Private Sub FrmSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Sharp Plus")

    End Sub

    Private Sub btnmexico_Click(sender As Object, e As EventArgs) Handles btnmexico.Click
        'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        'config.ConnectionStrings.ConnectionStrings("adminpaqEntities").ConnectionString = "metadata=res://*/Adminpaq.csdl|res://*/Adminpaq.ssdl|res://*/Adminpaq.msl;provider=System.Data.SqlClient;provider connection string=""data source=192.168.4.44\SQLEXPRESS;initial catalog=Adminpaqcopia;persist security info=True;user id=eduardo;password=96450324;MultipleActiveResultSets=True;App=EntityFramework;"""
        'config.Save()
        'config.Save(ConfigurationSaveMode.Full, False)
        SetConnectionString(1)
        Empresa = " MEXICO "
        'entidad.Connection = "adminpaqEntities", "metadata=res://*/Adminpaq.csdl|res://*/Adminpaq.ssdl|res://*/Adminpaq.msl;provider=System.Data.SqlClient;provider connection string=""data source=192.168.4.44\SQLEXPRESS;initial catalog=Adminpaqcopia;persist security info=True;user id=eduardo;password=96450324;MultipleActiveResultSets=True;App=EntityFramework;"""
        frmlogin.Show()
        Me.Close()
    End Sub

    Private Sub btneu_Click(sender As Object, e As EventArgs) Handles btneu.Click
        'Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        'config.ConnectionStrings.ConnectionStrings("adminpaqEntities").ConnectionString = "metadata=res://*/Adminpaq.csdl|res://*/Adminpaq.ssdl|res://*/Adminpaq.msl;provider=System.Data.SqlClient;provider connection string=""data source=192.168.4.44\SQLEXPRESS;initial catalog=AdminpaqUSA;persist security info=True;user id=eduardo;password=96450324;MultipleActiveResultSets=True;App=EntityFramework;"""
        'config.Save()
        'config.Save(ConfigurationSaveMode.Full, False)
        SetConnectionString(2)
        Empresa = " USA "
        'entidad.Connection = "adminpaqEntities", "metadata=res://*/Adminpaq.csdl|res://*/Adminpaq.ssdl|res://*/Adminpaq.msl;provider=System.Data.SqlClient;provider connection string=""data source=192.168.4.44\SQLEXPRESS;initial catalog=AdminpaqUSA;persist security info=True;user id=eduardo;password=96450324;MultipleActiveResultSets=True;App=EntityFramework;"""
        frmlogin.Show()
        Me.Close()
    End Sub
    Friend Shared Sub SetConnectionString(opcion As Integer)

        ' Obtenemos el archivo de configuración de la aplicación cliente.
        '
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connectionStrings As ConfigurationSection = config.GetSection("connectionStrings")
        'Dim conexiondes As String
        Dim seccion As String
        Dim section As ConnectionStringsSection = config.ConnectionStrings
        ' Obtenemos la sección correspondiente a las cadenas de conexión.
        'If connectionStrings IsNot Nothing Then
        '    If connectionStrings.SectionInformation.IsProtected Then
        '        connectionStrings.SectionInformation.UnprotectSection()
        '        config.Save()
        '        ConfigurationManager.RefreshSection("connectionStrings")
        '    End If
        'End IfMVI_IPEntities
        Dim settingsusuarios As ConnectionStringSettings = section.ConnectionStrings("UsuariosEntities")
        Dim settingsmvi As ConnectionStringSettings = section.ConnectionStrings("MVI_IPEntities")
        If opcion = 1 Then
            seccion = "Adminpaqmex"
        Else
            seccion = "AdminpaqUSA"
        End If
        Dim settingadminpaq As ConnectionStringSettings = section.ConnectionStrings(seccion)
        VarGlobales.Variables.CadenaAdminpaq = Andrea.Encriptacion.Desencriptar(settingadminpaq.ConnectionString)
        VarGlobales.Variables.CadenaUsuarios = Andrea.Encriptacion.Desencriptar(settingsusuarios.ConnectionString)
        VarGlobales.Variables.CadenaMVI = Andrea.Encriptacion.Desencriptar(settingsmvi.ConnectionString)
        Variables.conexionusuarios = New EntityConnection(VarGlobales.Variables.CadenaUsuarios)
        Variables.conexionAdminpaq = New EntityConnection(VarGlobales.Variables.CadenaAdminpaq)
        Variables.conexionMVI = New EntityConnection(VarGlobales.Variables.CadenaMVI)
        'Variables.conexionusuarios.Open()
        'If (section Is Nothing) Then
        '    Throw New ArgumentException("No se puede obtener la sección correspondiente a las cadenas de conexión.")
        'End If

        'Dim info As SectionInformation = section.SectionInformation
        'If ((section.IsReadOnly) OrElse (info.IsLocked)) Then
        '    Throw New InvalidOperationException("La sección del archivo correspondiente a las cadenas de conexión es de sólo lectura o está bloqueada.")
        'End If

        '' Referenciamos la cadena de conexión correspondiente al nombre especificado.
        ''
        'Dim settings As ConnectionStringSettings = section.ConnectionStrings(nameConnectionString)
        'If (settings Is Nothing) Then
        '    Throw New ArgumentException("No existe la cadena de conexión especificada.")
        'End If

        ' Asignamos el valor de la nueva cadena de conexión.
        '
        'settings.ConnectionString = conexiondes

        ' Guardar el archivo.
        '
        'config.Save(ConfigurationSaveMode.Modified, True)  'ConfigurationSaveMode.Modified, False)
        'ConfigurationManager.RefreshSection("connectionStrings")

        'If connectionStrings IsNot Nothing Then
        '    If Not connectionStrings.SectionInformation.IsProtected Then
        '        connectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
        '        connectionStrings.SectionInformation.ForceSave = True
        '        config.Save(ConfigurationSaveMode.Full)
        '    End If
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connectionStrings As ConfigurationSection = config.GetSection("connectionStrings")
        If connectionStrings IsNot Nothing Then
            If connectionStrings.SectionInformation.IsProtected Then
                connectionStrings.SectionInformation.UnprotectSection()
                config.Save()
            End If
        End If
    End Sub
End Class
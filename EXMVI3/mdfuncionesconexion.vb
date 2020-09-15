Imports System.Configuration

Module mdfuncionesconexion

    Public Sub CambiarCadenaConexion(ByVal setName As String, ByVal cnString As String)

        Dim cnStringsettings As New System.Configuration.ConnectionStringSettings

        cnStringsettings.Name = setName

        cnStringsettings.ConnectionString = cnString

        Dim config As System.Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None)

        'config.ConnectionStrings.ConnectionStrings.Remove(cnStringsettings)

        'config.ConnectionStrings.ConnectionStrings.Add(cnStringsettings)

        config.ConnectionStrings.ConnectionStrings.Item(setName).ConnectionString = cnString
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")

    End Sub
    Public Sub encriptar()
        Dim appconfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim constringsec As ConnectionStringsSection = appconfig.ConnectionStrings
        constringsec.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
        appconfig.Save()
    End Sub
End Module

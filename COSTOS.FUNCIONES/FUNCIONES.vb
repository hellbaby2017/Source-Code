Option Explicit On

Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FUNCIONES
    Public formulario As String
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public contador As Integer = 0
    Public total As Integer
    Public contadora As Integer = 0
    Public usuario As String
    Public contraseña As String
    Public tiposuaurio As Integer = 0
    'Permitir conectarnos con nuestro archivo de excel'
    Public conn As OleDbConnection

    Public tabla As String

    'Permitir conectarnos a nuestra base de datos sqlserver'
    Public cnn As SqlConnection
    Public Sub exportación(tablaexp As DataTable)
        Dim duracion As TimeSpan
        Dim conexion As New SqlConnection
        Dim conexion2 As New SqlConnection
        Dim conexion3 As New SqlConnection
        Dim conexiong As New SqlConnection
        Dim comando As New SqlCommand
        Dim tablas As New DataTable
        Dim lector2 As SqlDataReader
        Dim comando3 As New SqlCommand
        Dim comando4 As New SqlCommand
        Dim comando5 As New SqlCommand
        Dim costou As Double
        Dim unidades As Double
        Dim importe As Decimal
        Dim mes As String
        Dim dia As String
        Dim mes2 As String
        Dim dia2 As String
        Dim fecha As String
        Dim fecha2 As String
        Dim costouni As Double
        Dim total2

        duracion = Now.TimeOfDay

        total = tablaexp.Rows.Count
        contador = 0
        conexion.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        conexion2.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        conexion2.Open()
        conexion3.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        conexion3.Open()
        conexiong.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        comando.Connection = conexion2
        comando.CommandTimeout = 0
        comando3.Connection = conexion
        comando3.CommandTimeout = 0
        comando4.Connection = conexion3
        comando4.CommandTimeout = 0
        comando5.Connection = conexiong
        comando5.CommandTimeout = 0
        For Each dr As DataRow In tablaexp.Rows
            'MOVIMIENTOS SIN INTEGRAR'
            If dr.Item(19 + 1) = False Then
                'ENTRADA MOVIMIENTOS SIN INTEGRAR
                If dr.Item(16 + 1) = True Then
                    mes = Month(dr.Item(6 + 1))
                    If Len(mes) = 1 Then
                        mes = "0" & mes
                    End If
                    dia = DateAndTime.Day(dr.Item(6 + 1))
                    If Len(dia) = 1 Then
                        dia = "0" & dia
                    End If
                    If IsDBNull(dr.Item(7 + 1)) Then
                        mes2 = Month(dr.Item(6 + 1))
                        dia2 = DateAndTime.Day(dr.Item(6 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                    Else
                        mes2 = Month(dr.Item(7 + 1))
                        dia2 = DateAndTime.Day(dr.Item(7 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                    End If

                    If Len(mes2) = 1 Then
                        mes2 = "0" & mes2
                    End If

                    If Len(dia) = 1 Then
                        dia2 = "0" & dia2
                    End If
                    fecha = Convert.ToDateTime(dr.Item(6 + 1))
                    If IsDBNull(dr.Item(7 + 1)) Then
                        fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                    Else
                        fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                        fecha2 = fecha2.ToString.Substring(0, 10)
                    End If
                    'SE INSERTA EL MOVIMIENTOS COMPRA
                    comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & dr.Item(10 + 1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                    comando.ExecuteNonQuery()
                    conexion.Open()
                    'SE REVISA SI TIENE CAPAS DENTRO DE LA TABLA
                    comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14 + 1) & "'"
                    lector2 = comando3.ExecuteReader()
                    ' SI TIENE HACE EL UPDATE EN CASO QUE NO INSERTA EL RESGISTRO
                    If lector2.HasRows Then
                        lector2.Read()
                        unidades = lector2.GetValue(2) + dr.Item(9 + 1)
                        importe = lector2.GetValue(3) + (dr.Item(9 + 1) * dr.Item(10 + 1))
                        If unidades = 0 Then
                            costou = 0
                        Else
                            costou = importe / unidades
                        End If
                        comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14 + 1) & "'"
                        comando4.ExecuteNonQuery()

                    Else
                        unidades = dr.Item(9 + 1)
                        costou = dr.Item(10 + 1)
                        importe = dr.Item(9 + 1) * dr.Item(10 + 1)
                        comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14 + 1) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                        comando4.ExecuteNonQuery()

                    End If
                    lector2.Close()
                    conexion.Close()
                    'SALIDA DE MOVIMIENTOS SIN INTEGRAR
                Else
                    mes = Month(dr.Item(6 + 1))
                    If Len(mes) = 1 Then
                        mes = "0" & mes
                    End If
                    dia = DateAndTime.Day(dr.Item(6 + 1))
                    If Len(dia) = 1 Then
                        dia = "0" & dia
                    End If
                    fecha = Convert.ToDateTime(dr.Item(6 + 1))
                    If IsDBNull(dr.Item(7 + 1)) Then
                        mes2 = Month(dr.Item(6 + 1))
                        dia2 = DateAndTime.Day(dr.Item(6 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                    Else
                        mes2 = Month(dr.Item(7 + 1))
                        dia2 = DateAndTime.Day(dr.Item(7 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                    End If
                    conexion.Open()
                    comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14 + 1) & "'"
                    lector2 = comando3.ExecuteReader()
                    If lector2.HasRows Then
                        lector2.Read()
                        If lector2.GetValue(2) < dr.Item(9 + 1) Then
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) - lector2.GetValue(2) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) - lector2.GetValue(2) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                            comando.ExecuteNonQuery()
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & lector2.GetValue(1 + 1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                            comando.ExecuteNonQuery()
                            unidades = 0
                            costou = lector2.GetValue(1)
                            importe = 0
                            comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14 + 1) & "'"
                            comando4.ExecuteNonQuery()
                            'SI ES MAYOR QUE LO QUE SE ENCUENTRA EN LA TABLA'
                        Else
                            costouni = lector2.GetValue(1)
                            unidades = lector2.GetValue(2) - dr.Item(9 + 1)
                            importe = lector2.GetValue(3) - (dr.Item(9 + 1) * costouni)
                            If unidades = 0 Then
                                costou = 0
                            Else
                                costou = importe / unidades
                            End If
                            comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14 + 1) & "'"
                            comando4.ExecuteNonQuery()
                            fecha = Convert.ToDateTime(dr.Item(6 + 1))
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & costouni & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                        End If
                    Else
                        comando.CommandText = "INSERT INTO mmovimientos(cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & dr.Item(10 + 1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                        'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) - lector2.GetValue(2) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()
                        comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & dr.Item(10 + 1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                        'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()
                        unidades = 0
                        costou = dr.Item(10 + 1)
                        importe = 0
                        comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14 + 1) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                        comando4.ExecuteNonQuery()
                    End If
                    lector2.Close()
                    conexion.Close()
                End If
                'Movimientos sin integrar
            Else
                'movimientos de entrada
                If dr.Item(16 + 1) = True Then
                    mes = Month(dr.Item(6 + 1))
                    If Len(mes) = 1 Then
                        mes = "0" & mes
                    End If
                    dia = DateAndTime.Day(dr.Item(6 + 1))
                    If Len(dia) = 1 Then
                        dia = "0" & dia
                    End If
                    fecha = Convert.ToDateTime(dr.Item(6 + 1))
                    If IsDBNull(dr.Item(7 + 1)) Then
                        mes2 = Month(dr.Item(6 + 1))
                        dia2 = DateAndTime.Day(dr.Item(6 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                    Else
                        mes2 = Month(dr.Item(7 + 1))
                        dia2 = DateAndTime.Day(dr.Item(7 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                    End If
                    conexion.Open()
                    comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14 + 1) & "'"
                    lector2 = comando3.ExecuteReader()
                    If lector2.HasRows Then
                        lector2.Read()
                        costouni = lector2.GetValue(1)
                        unidades = lector2.GetValue(2) + dr.Item(9 + 1)
                        importe = lector2.GetValue(3) + (dr.Item(9 + 1) * costouni)
                        If unidades = 0 Then
                            costou = 0
                        Else
                            costou = importe / unidades
                        End If
                        comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14 + 1) & "'"
                        comando4.ExecuteNonQuery()
                        fecha = Convert.ToDateTime(dr.Item(6 + 1))
                        If IsDBNull(dr.Item(7 + 1)) Then
                            mes2 = Month(dr.Item(6 + 1))
                            dia2 = DateAndTime.Day(dr.Item(6 + 1))
                            fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                        Else
                            mes2 = Month(dr.Item(7 + 1))
                            dia2 = DateAndTime.Day(dr.Item(7 + 1))
                            fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                        End If
                        comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & costouni & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                        'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()
                    Else
                        unidades = dr.Item(9 + 1)
                        costou = dr.Item(10 + 1)
                        importe = (dr.Item(9 + 1) * dr.Item(10 + 1))
                        comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14 + 1) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                        comando4.ExecuteNonQuery()
                        fecha = Convert.ToDateTime(dr.Item(6 + 1))
                        If IsDBNull((dr.Item(7 + 1))) Then
                            fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                        Else
                            fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                        End If
                        comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & costou & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                        ' comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()

                    End If
                    lector2.Close()
                    conexion.Close()
                    'SALIDA DE MOVIMIENTOS INTEGRADOS
                Else
                    mes = Month(dr.Item(6 + 1))
                    If Len(mes) = 1 Then
                        mes = "0" & mes
                    End If
                    dia = DateAndTime.Day(dr.Item(6 + 1))
                    If Len(dia) = 1 Then
                        dia = "0" & dia
                    End If
                    fecha = Convert.ToDateTime(dr.Item(6 + 1))
                    If IsDBNull(dr.Item(7 + 1)) Then
                        mes2 = Month(dr.Item(6 + 1))
                        dia2 = DateAndTime.Day(dr.Item(6 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                    Else
                        mes2 = Month(dr.Item(7 + 1))
                        dia2 = DateAndTime.Day(dr.Item(7 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                    End If
                    conexion.Open()
                    comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14 + 1) & "'"
                    lector2 = comando3.ExecuteReader()
                    If lector2.HasRows Then
                        lector2.Read()
                        If lector2.GetValue(2) < dr.Item(9 + 1) Then
                            fecha = Convert.ToDateTime(dr.Item(6 + 1))
                            If IsDBNull(dr.Item(7 + 1)) Then
                                mes2 = Month(dr.Item(6 + 1))
                                dia2 = DateAndTime.Day(dr.Item(6 + 1))
                                fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                            Else
                                mes2 = Month(dr.Item(7 + 1))
                                dia2 = DateAndTime.Day(dr.Item(7 + 1))
                                fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                            End If
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) - lector2.GetValue(2) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', 'EXP', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            unidades = 0
                            costou = lector2.GetValue(2)
                            importe = 0
                            comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14 + 1) & "'"
                            comando4.ExecuteNonQuery()
                            ' SI ES MAYOR O IGUAL A 0
                        Else
                            costouni = lector2.GetValue(1)
                            unidades = lector2.GetValue(2) - dr.Item(9 + 1)
                            importe = lector2.GetValue(3) - (dr.Item(9 + 1) * costouni)
                            If unidades = 0 Then
                                costou = 0
                            Else
                                costou = importe / unidades
                            End If
                            If costou = 0 Then
                                costou = costouni
                            End If
                            comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14 + 1) & "'"
                            comando4.ExecuteNonQuery()
                            fecha = Convert.ToDateTime(dr.Item(6 + 1))
                            If IsDBNull(dr.Item(7 + 1)) Then
                                fecha2 = Convert.ToDateTime(dr.Item(6 + 1))
                            Else
                                fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                            End If
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & costouni & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                        End If
                    Else
                        fecha = Convert.ToDateTime(dr.Item(6 + 1))
                        fecha2 = Convert.ToDateTime(dr.Item(7 + 1))
                        comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & dr.Item(10 + 1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                        'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()
                        comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0 + 1) & "', '" & dr.Item(1 + 1) & "', '" & dr.Item(2 + 1) & "', '" & dr.Item(3 + 1) & "', '" & dr.Item(4 + 1) & "', '" & dr.Item(5 + 1) & "', '" & fecha & "', '" & fecha2 & "', '" & dr.Item(8 + 1) & "', '" & dr.Item(9 + 1) & "', '" & dr.Item(10 + 1) & "', '" & dr.Item(11 + 1) & "', '" & dr.Item(12 + 1) & "', '" & dr.Item(13 + 1) & "', '" & dr.Item(14 + 1) & "', '" & dr.Item(15 + 1) & "');"
                        'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()
                        unidades = 0
                        costou = dr.Item(10 + 1)
                        importe = 0
                        comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14 + 1) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                        comando4.ExecuteNonQuery()
                    End If
                    lector2.Close()
                    conexion.Close()
                End If
            End If
            contador = contador + 1
        Next
        total2 = Now.TimeOfDay - duracion
        MsgBox("PROCESO TERMINADO  ", MsgBoxStyle.ApplicationModal, "HAPCO")

    End Sub
    Public Sub excel()
        Dim duracion As Date
        Dim tabla As New DataTable
        Dim conexion As New SqlConnection
        Dim conexion2 As New SqlConnection
        Dim conexion3 As New SqlConnection
        Dim conexiong As New SqlConnection
        Dim comando As New SqlCommand
        Dim tablas As New DataTable
        Dim lector As OleDbDataReader
        Dim lector2 As SqlDataReader
        Dim lector3 As SqlDataReader
        Dim comando3 As New SqlCommand
        Dim comando4 As New SqlCommand
        Dim comando5 As New SqlCommand
        Dim costou As Double
        Dim unidades As Double
        Dim importe As Decimal
        Dim mes As String
        Dim dia As String
        Dim fecha As String
        Dim costouni As Double
        duracion = Today
        contador = 0
        conexion.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        conexion2.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        conexion2.Open()
        conexion3.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        conexion3.Open()
        conexiong.ConnectionString = "Data Source=192.168.1.112;Initial Catalog=HAPCO;User ID=usrHAPCO ;Password=wX4ju5n"
        comando.Connection = conexion2
        comando3.Connection = conexion
        comando4.Connection = conexion3
        comando5.Connection = conexiong
        '        Dim objadapter As New SqlDataAdapter("select * from adminpaq.mmovimientos", conexion)
        '        Dim cmdbuilder As New SqlCommandBuilder(objadapter)
        '        cmdbuilder.QuotePrefix = ""
        '        cmdbuilder.QuoteSuffix = ""
        ' objadapter.InsertCommand = cmdbuilder.GetInsertCommand
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = String.Empty
        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()

        End With

        If myFileDialog.FileName.ToString <> String.Empty Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString
            Dim comando2 As New OleDbCommand
            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Exportar a Excel", "Hoja1")
            comando2.CommandText = "SELECT * FROM  [" & xSheet & "$] ORDER BY mMSIFecha,[TIPO MOVIMIENTO] DESC"
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")
            ' Try
            conn.Open()
            comando2.Connection = conn
            lector = comando2.ExecuteReader
            tabla.Load(lector)
            '          frmprincipal.PRBAREXP.Maximum = tabla.Rows.Count
            '          frmprincipal.PRBAREXP.Visible = True
            comando.CommandTimeout = 0
            comando2.CommandTimeout = 0
            comando3.CommandTimeout = 0
            comando4.CommandTimeout = 0
            comando5.CommandTimeout = 0
            For Each dr As DataRow In tabla.Rows
                conexiong.Open()
                comando5.CommandText = "select * from cmovimientosalmacen where cmoAclave=" & dr.Item(0).ToString
                lector3 = comando5.ExecuteReader
                lector3.Read()
                'MOVIMIENTOS SIN INTEGRAR'
                If lector3.GetValue(3) = False Then
                    'ENTRADA MOVIMIENTOS SIN INTEGRAR
                    If lector3.GetValue(2) = True Then
                        mes = Month(dr.Item(6))
                        If Len(mes) = 1 Then
                            mes = "0" & mes
                        End If
                        dia = DateAndTime.Day(dr.Item(6))
                        If Len(dia) = 1 Then
                            dia = "0" & dia
                        End If
                        fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                        'SE INSERTA EL MOVIMIENTOS COMPRA
                        comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                        comando.ExecuteNonQuery()
                        conexion.Open()
                        'SE REVISA SI TIENE CAPAS DENTRO DE LA TABLA
                        comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14) & "'"
                        lector2 = comando3.ExecuteReader()
                        ' SI TIENE HACE EL UPDATE EN CASO QUE NO INSERTA EL REGISTRO
                        If lector2.HasRows Then
                            lector2.Read()
                            unidades = lector2.GetValue(2) + dr.Item(9)
                            importe = lector2.GetValue(3) + (dr.Item(9) * dr.Item(10))
                            If unidades = 0 Then
                                costou = 0
                            Else
                                costou = importe / unidades
                            End If
                            comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14) & "'"
                            comando4.ExecuteNonQuery()

                        Else
                            unidades = dr.Item(9)
                            costou = dr.Item(10)
                            importe = dr.Item(9) * dr.Item(10)
                            comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                            comando4.ExecuteNonQuery()

                        End If
                        lector2.Close()
                        conexion.Close()
                        'SALIDA DE MOVIMIENTOS SIN INTEGRAR
                    Else
                        mes = Month(dr.Item(6))
                        If Len(mes) = 1 Then
                            mes = "0" & mes
                        End If
                        dia = DateAndTime.Day(dr.Item(6))
                        If Len(dia) = 1 Then
                            dia = "0" & dia
                        End If
                        fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                        conexion.Open()
                        comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14) & "'"
                        lector2 = comando3.ExecuteReader()
                        If lector2.HasRows Then
                            lector2.Read()
                            If lector2.GetValue(2) < dr.Item(9) Then
                                'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) - lector2.GetValue(2) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.CommandText = "INSERT INTO mmovimientos(cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) - lector2.GetValue(2) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.ExecuteNonQuery()
                                comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.ExecuteNonQuery()
                                unidades = 0
                                costou = lector2.GetValue(1)
                                importe = 0
                                comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14) & "'"
                                comando4.ExecuteNonQuery()
                                'SI ES MAYOR QUE LO QUE SE ENCUENTRA EN LA TABLA'
                            Else
                                costouni = lector2.GetValue(1)
                                unidades = lector2.GetValue(2) - dr.Item(9)
                                importe = lector2.GetValue(3) - (dr.Item(9) * costouni)
                                If unidades = 0 Then
                                    costou = 0
                                Else
                                    costou = importe / unidades
                                End If
                                comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14) & "'"
                                comando4.ExecuteNonQuery()
                                fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                                comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.ExecuteNonQuery()
                            End If
                        Else
                            comando.CommandText = "INSERT INTO mmovimientos(cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) - lector2.GetValue(2) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            unidades = 0
                            costou = dr.Item(10)
                            importe = 0
                            comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                            comando4.ExecuteNonQuery()
                        End If
                        lector2.Close()
                        conexion.Close()
                    End If
                    'Movimientos sin integrar
                Else
                    'movimientos de entrada
                    If lector3.GetValue(2) = True Then
                        mes = Month(dr.Item(6))
                        If Len(mes) = 1 Then
                            mes = "0" & mes
                        End If
                        dia = DateAndTime.Day(dr.Item(6))
                        If Len(dia) = 1 Then
                            dia = "0" & dia
                        End If
                        fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                        conexion.Open()
                        comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14) & "'"
                        lector2 = comando3.ExecuteReader()
                        If lector2.HasRows Then
                            lector2.Read()
                            If lector2.GetValue(1) = 0 Then
                                costouni = dr.Item(10)
                            Else
                                costouni = lector2.GetValue(1)
                            End If
                            unidades = lector2.GetValue(2) + dr.Item(9)
                            importe = lector2.GetValue(3) + (dr.Item(9) * costouni)
                            If unidades = 0 Then
                                costou = 0
                            Else
                                costou = importe / unidades
                            End If
                            comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14) & "'"
                            comando4.ExecuteNonQuery()
                            fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                        Else
                            unidades = dr.Item(9)
                            costou = dr.Item(10)
                            importe = (dr.Item(9) * dr.Item(10))
                            comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            ' comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            comando4.ExecuteNonQuery()
                        End If
                        lector2.Close()
                        conexion.Close()
                        'SALIDA DE MOVIMIENTOS INTEGRADOS
                    Else
                        mes = Month(dr.Item(6))
                        If Len(mes) = 1 Then
                            mes = "0" & mes
                        End If
                        dia = DateAndTime.Day(dr.Item(6))
                        If Len(dia) = 1 Then
                            dia = "0" & dia
                        End If
                        fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                        conexion.Open()
                        comando3.CommandText = "select * from mcapas where cAltClave ='" & dr.Item(14) & "'"
                        lector2 = comando3.ExecuteReader()
                        If lector2.HasRows Then
                            lector2.Read()
                            If lector2.GetValue(2) < dr.Item(9) Then
                                comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) - lector2.GetValue(2) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.ExecuteNonQuery()
                                comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & lector2.GetValue(1) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.ExecuteNonQuery()
                                unidades = 0
                                costou = lector2.GetValue(2)
                                importe = 0
                                comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14) & "'"
                                comando4.ExecuteNonQuery()
                                ' SI ES MAYOR O IGUAL A 0
                            Else
                                costouni = lector2.GetValue(1)
                                unidades = lector2.GetValue(2) - dr.Item(9)
                                importe = lector2.GetValue(3) - (dr.Item(9) * costouni)
                                If unidades = 0 Then
                                    costou = 0
                                Else
                                    costou = importe / unidades
                                End If
                                comando4.CommandText = "UPDATE mcapas SET Costo='" & costou & "',unidades='" & unidades & "',importe='" & importe & "' where cAltClave='" & dr.Item(14) & "'"
                                comando4.ExecuteNonQuery()
                                fecha = Year(dr.Item(6)) & "-" & mes & "-" & dia
                                comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & costouni & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                                comando.ExecuteNonQuery()
                            End If
                        Else
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('5', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', 'MOVIMIENTO ADICIONAL POR ENTRADA EN CERO', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cPrvClaveFab,mMSIRemision,mMSIFactura,mMSILote,cCalClave,mMSIFecha,mMSIFechaFactura,mMSIPedimento, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(1) & "', '" & dr.Item(2) & "', '" & dr.Item(3) & "', '" & dr.Item(4) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(7) & "', '" & dr.Item(8) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            'comando.CommandText = "INSERT INTO mmovimientos (cMoAClave, cCalClave, mMSIFactura, Unidades, Costo, mMSIFolio, mMSICostoP, Detalle, cAltClave, cAlmClave) VALUES ('" & dr.Item(0) & "', '" & dr.Item(5) & "', '" & dr.Item(6) & "', '" & dr.Item(9) & "', '" & dr.Item(10) & "', '" & dr.Item(11) & "', '" & dr.Item(12) & "', '" & dr.Item(13) & "', '" & dr.Item(14) & "', '" & dr.Item(15) & "');"
                            comando.ExecuteNonQuery()
                            unidades = 0
                            costou = dr.Item(10)
                            importe = 0
                            comando4.CommandText = "INSERT INTO mcapas(cAltClave,Costo,unidades,importe) VALUES ( '" & dr.Item(14) & "','" & costou & "' ,'" & unidades & "','" & importe & "')"
                            comando4.ExecuteNonQuery()
                        End If
                        lector2.Close()
                        conexion.Close()
                    End If
                End If
                lector3.Close()
                conexiong.Close()
                contador = contador + 1
            Next
            MsgBox("Archivo Cargado Excel")
        End If
    End Sub
End Class

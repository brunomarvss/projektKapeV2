Module connectionModule

    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub Connect()
        Try
            cn = New ADODB.Connection
            With cn
                If .State <> 0 Then .Close()
                .ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=../../../dbInventory.mdb;Jet OLEDB:Database Password=PASSWORD;"
                .Open()
                'msgbox("Connected to Database")
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Module

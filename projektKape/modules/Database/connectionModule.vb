Module connectionModule

    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Int32
    Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32

    Public Function TerminateExcel()

        Dim ClassName As String = "XLMain"
        Dim WindowHandle As Int32
        Dim ReturnVal As Int32
        Const WM_QUIT = &H12
        Do
            WindowHandle = FindWindow(ClassName, Nothing)
            If WindowHandle Then
                ReturnVal = PostMessage(WindowHandle, WM_QUIT, 0, 0)
            End If
        Loop Until WindowHandle = 0

    End Function

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

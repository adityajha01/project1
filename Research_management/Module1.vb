
Imports System.Data.OleDb

Module Module1
    Public con As OleDbConnection
    Public Function connect()
        Try
            'con = New OleDbConnection("provider=sqloledb;Data Source=User;Integrated Security=SSPI;Initial Catalog=Res_manag")

            'con = New OleDbConnection("provider=sqloledb;Data Source=PCV\HARSHI;Integrated Security=SSPI;Initial Catalog=Res_manag")
            con = New OleDbConnection("provider=sqloledb;server=HP;database=Res_manag;uid=student;pwd=student;")
            con.Open()
            MsgBox("connected to database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function check(ByVal st As String) As Boolean

        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        da = New OleDbDataAdapter(st, con)
        dt = New DataTable
        da.Fill(dt)
        If (dt.Rows.Count) = 0 Then
            Return True
        Else : Return False

        End If
    End Function

End Module


Imports System.Data.OleDb
Public Class delman

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub delman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtadapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            dtadapt = New OleDbDataAdapter("select * from MANAGEMENT", con)
            dt = New DataTable()
            dtadapt.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim st As String

        If TextBox1.Text = "" Then
            MsgBox("please enter the MANAGEMENT Dpartment no")
            TextBox1.Focus()
            Exit Sub
        End If
        st = "select * from MANAGEMENT where dept_no=" & Val(Trim(TextBox1.Text)) & ""
        If check(st) = True Then
            MsgBox("Its not a valid MANAGEMENT Dpartment no ...Please enter a valid ...Dpartment no")
            Exit Sub

        End If
        Dim com As OleDbCommand
        com = New OleDbCommand
        Try
            com.Connection = con
            com.CommandText = "delete from MANAGEMENT where dept_no=" & Val(Trim(TextBox1.Text)) & ""
            com.ExecuteNonQuery()
            MsgBox("Data deleted successfully!!!")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
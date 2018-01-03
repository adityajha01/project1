Imports System.Data.OleDb
Public Class insmanag

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub insmanag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataAdapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            dataAdapt = New OleDbDataAdapter("Select * from MANAGEMENT", con)
            dt = New DataTable
            dataAdapt.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then '
            MsgBox("Enter Management Name")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then '
            MsgBox("Please enter dept_no")
            TextBox2.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox2.Text) Then
            MsgBox("dept_no must be an integer")
            TextBox2.Focus()
            Exit Sub
        End If
        Dim com As OleDbCommand
        Try
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "insert into MANAGEMENT values('" & Trim(TextBox1.Text) & "'," & Val(TextBox2.Text) & ")"
            com.ExecuteNonQuery()
            MsgBox("Data Inserted!!!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
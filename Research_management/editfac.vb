Imports System.Data.OleDb
Public Class editfac

    Private Sub editfac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtadapt As New OleDbDataAdapter
        Dim dt As New DataTable
        dtadapt = New OleDbDataAdapter("select * from FACILITIES", con)
        dtadapt.Fill(dt)
        DataGridView1.DataSource = dt
        TextBox2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim com As OleDbCommand
        Dim dtadapt As New OleDbDataAdapter
        Dim dt As New DataTable
        Try
            com = New OleDbCommand()
            com.Connection = con
            com.CommandText = "update FACILITIES set construction_and_launch = '" & Trim(TextBox1.Text) & "',test = '" & Trim(TextBox2.Text) & "',research = '" & Trim(TextBox3.Text) & "',dept_no = " & Val(Trim(TextBox4.Text)) & " where research = '" & Trim(TextBox3.Text) & "'"
            com.ExecuteNonQuery()
            MsgBox("Data updated")
            DataGridView1.Refresh()
            dtadapt = New OleDbDataAdapter("select * from FACILITIES", con)
            dtadapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class
Imports System.Data.OleDb
Public Class editlab

    Private Sub editlab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtadapt As New OleDbDataAdapter
        Dim dt As New DataTable
        dtadapt = New OleDbDataAdapter("select * from LABORATORY", con)
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
            com.CommandText = "update LABORATORY set equipment= '" & Trim(TextBox1.Text) & "',location='" & Trim(TextBox2.Text) & "',lab_id ='" & Trim(TextBox3.Text) & "',dept_no = " & Val(Trim(TextBox4.Text)) & " where lab_id ='" & Trim(TextBox5.Text) & "'"
            com.ExecuteNonQuery()
            MsgBox("Data updated")
            DataGridView1.Refresh()
            dtadapt = New OleDbDataAdapter("select * from LABORATORY", con)
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
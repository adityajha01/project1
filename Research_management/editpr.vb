﻿Imports System.Data.OleDb
Public Class editpr

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim com As OleDbCommand
        Dim dtadapt As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sex As Char
        If RadioButton1.Checked = True Then
            sex = "M"
        Else
            sex = "F"
        End If
        Try
            com = New OleDbCommand()
            com.Connection = con
            com.CommandText = "update PROGRAM_MANAGER set fname='" & Trim(TextBox1.Text) & "',mname='" & Trim(TextBox2.Text) & "',lname ='" & Trim(TextBox3.Text) & "',mgrssn ='" & Trim(TextBox4.Text) & "',age = " & Val(Trim(TextBox5.Text)) & ",sex ='" & sex & "',Bdate='" & DateTimePicker1.Value & "',salary = " & Val(Trim(TextBox6.Text)) & ",phone_no='" & Trim(TextBox7.Text) & "',manager_address ='" & Trim(TextBox8.Text) & "' where mgrssn= '" & TextBox10.Text & "'"
            com.ExecuteNonQuery()
            MsgBox("Data updated")
            DataGridView1.Refresh()
            dtadapt = New OleDbDataAdapter("select * from PROGRAM_MANAGER", con)
            dtadapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editpr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtadapt As New OleDbDataAdapter
        Dim dt As New DataTable
        dtadapt = New OleDbDataAdapter("select * from PROGRAM_MANAGER", con)
        dtadapt.Fill(dt)
        DataGridView1.DataSource = dt
        TextBox2.Enabled = True
    End Sub
End Class
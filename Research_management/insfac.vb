﻿Imports System.Data.OleDb
Public Class insfac

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then '
            MsgBox("Enter construction_and_launch Name")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then '
            MsgBox("Please enter Test")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then '
            MsgBox("Please enter Research Name")
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then '
            MsgBox("Please enter dept_no")
            TextBox4.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("dept_no must be an integer")
            TextBox4.Focus()
            Exit Sub
        End If
        Dim com As OleDbCommand
        Try
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "insert into FACILITIES values ('" & Trim(TextBox1.Text) & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "'," & Val(TextBox4.Text) & ")"
            com.ExecuteNonQuery()
            MsgBox("Data Inserted!!!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub insfac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataAdapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            dataAdapt = New OleDbDataAdapter("Select * from FACILITIES", con)
            dt = New DataTable
            dataAdapt.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
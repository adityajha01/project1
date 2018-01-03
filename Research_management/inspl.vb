Imports System.Data.OleDb
Public Class inspl

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then '
            MsgBox("Please enter Planning_Group name")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then '
            MsgBox("Please enter Planning_Group Id")
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox3.Text = "" Then '
            MsgBox("Please enter Planning_Group memmber")
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then '
            MsgBox("Please enter Department Number")
            TextBox4.Focus()
            Exit Sub
        End If
        Dim com As OleDbCommand
        Try
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "insert into PLANNING_GROUP values('" & Trim(TextBox1.Text) & _
            "'," & Val(Trim(TextBox3.Text)) & _
            ",'" & Trim(TextBox2.Text) & "'," & Val(Trim(TextBox4.Text)) & ")"
            com.ExecuteNonQuery()
            MsgBox("Data Inserted!!!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub inspl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataAdapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            dataAdapt = New OleDbDataAdapter("Select * from PLANNING_GROUP", con)
            dt = New DataTable
            dataAdapt.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
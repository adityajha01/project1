Imports System.Data.OleDb
Public Class inspr

    Private Sub inspr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataAdapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            dataAdapt = New OleDbDataAdapter("Select * from PROGRAM_MANAGER", con)
            dt = New DataTable
            dataAdapt.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then '
            MsgBox("Please enter Program Manager First Name")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox3.Text = "" Then '
            MsgBox("Please enter Program Manager Last Name")
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox5.Text = "" Then '
            MsgBox("Please enter Program Manager Age")
            TextBox5.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then '
            MsgBox("Please enter Program Manager SSN")
            TextBox4.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBox5.Text) Then
            MsgBox("Program Manager age must be an integer")
            TextBox5.Focus()
            Exit Sub
        End If
        If TextBox6.Text = "" Then '
            MsgBox("Please enter Program Manager salary")
            TextBox6.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBox6.Text) Then
            MsgBox("Program Manager salary must be an integer")
            TextBox6.Focus()
            Exit Sub
        End If
        If TextBox8.Text = "" Then '
            MsgBox("Please enter Program Manager address")
            TextBox8.Focus()
            Exit Sub
        End If
        If TextBox7.Text = "" Then '
            MsgBox("Please enter Program Manager phone Number")
            TextBox7.Focus()
            Exit Sub
        End If
        Dim com As OleDbCommand
        Dim sex As Char
        If RadioButton1.Checked = True Then
            sex = "M"
        Else
            sex = "F"


        End If
        Try
            com = New OleDbCommand
            com.Connection = con
            com.CommandText = "insert into PROGRAM_MANAGER values('" & Trim(TextBox1.Text) & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "'," & Val(Trim(TextBox5.Text)) & ",'" & sex & "','" & DateTimePicker1.Value & "'," & Val(Trim(TextBox6.Text)) & ",'" & Trim(TextBox7.Text) & "','" & Trim(TextBox8.Text) & "')"
            com.ExecuteNonQuery()
            MsgBox("Data Inserted!!!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub










    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
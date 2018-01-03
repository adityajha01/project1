Imports System.Data.OleDb
Public Class inssc

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then '
            MsgBox("Please enter Scientist First Name")
            TextBox1.Focus()
            Exit Sub
        End If
        
        If TextBox3.Text = "" Then '
            MsgBox("Please enter Scientist Last Name")
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox5.Text = "" Then '
            MsgBox("Please enter Scientist Age")
            TextBox5.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then '
            MsgBox("Please enter Scientist SSN")
            TextBox4.Focus()
            Exit Sub
        End If
        If Not IsNumeric(TextBox5.Text) Then
            MsgBox("Scientist age must be an integer")
            TextBox5.Focus()
            Exit Sub
        End If
        If TextBox6.Text = "" Then '
            MsgBox("Please enter Scientist salary")
            TextBox6.Focus()
            Exit Sub
        End If
        If TextBox8.Text = "" Then '
            MsgBox("Please enter Scientist address")
            TextBox8.Focus()
            Exit Sub
        End If
        If TextBox7.Text = "" Then '
            MsgBox("Please enter Scientist phone Number")
            TextBox7.Focus()
            Exit Sub
        End If
        If TextBox9.Text = "" Then '
            MsgBox("Please enter Scientist Department Number")
            TextBox9.Focus()
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
            com.CommandText = "insert into SCIENTIST values('" & Trim(TextBox1.Text) & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "'," & Val(Trim(TextBox5.Text)) & ",'" & sex & "','" & DateTimePicker1.Value & "'," & Val(Trim(TextBox6.Text)) & ",'" & Trim(TextBox7.Text) & "','" & Trim(TextBox8.Text) & "'," & Val(Trim(TextBox9.Text)) & ")"
            com.ExecuteNonQuery()
            MsgBox("Data Inserted!!!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub inssc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataAdapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            dataAdapt = New OleDbDataAdapter("Select * from SCIENTIST", con)
            dt = New DataTable
            dataAdapt.Fill(dt)
            
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class
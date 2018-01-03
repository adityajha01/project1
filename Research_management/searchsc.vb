Imports System.Data.OleDb
Public Class searchsc

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Dim sql As String
        If RadioButton1.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = False Then
            sql = "select * from SCIENTIST where fname like '%" & Trim(TextBox1.Text) & "%' and sex='M'"
        ElseIf RadioButton1.Checked = True And CheckBox2.Checked = True And CheckBox1.Checked = False Then
            sql = "select * from SCIENTIST where fname like '%" & Trim(TextBox1.Text) & "%' and sex='F'"
        ElseIf RadioButton2.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = False Then
            sql = "select * from SCIENTIST where ssn='" & Trim(TextBox1.Text) & "' and sex='M'"
        ElseIf RadioButton2.Checked = True And CheckBox2.Checked = True And CheckBox1.Checked = False Then
            sql = "select * from SCIENTIST where ssn='" & Trim(TextBox1.Text) & "' and sex='F'"

        ElseIf RadioButton1.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = True Then
            sql = "select * from SCIENTIST where fname like '%" & Trim(TextBox1.Text) & "%'"
        ElseIf RadioButton2.Checked = True And CheckBox1.Checked = True And CheckBox2.Checked = True Then
            sql = "select * from SCIENTIST where ssn='" & Trim(TextBox1.Text) & "'"
        Else
            MsgBox("Please select sex")
            Exit Sub

        End If
        adapt = New OleDbDataAdapter(sql, con)
        dt = New DataTable
        adapt.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
End Class
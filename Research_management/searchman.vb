Imports System.Data.OleDb
Public Class searchman

    Private Sub searchman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Dim sql As String
        If RadioButton1.Checked = True Then
            sql = "select * from MANAGEMENT where dept_no =" & Trim(TextBox1.Text) & ""
        ElseIf RadioButton2.Checked = True Then
            sql = "select * from MANAGEMENT where mgname like '%" & Trim(TextBox1.Text) & "%' "
        Else
            MsgBox("Please select Dept_no or Management name")
            Exit Sub

        End If
        adapt = New OleDbDataAdapter(sql, con)
        dt = New DataTable
        adapt.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class
Imports System.Data.OleDb
Public Class searchpl

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Dim sql As String
        If RadioButton1.Checked = True Then
            sql = "select * from PLANNING_GROUP where pgname like '%" & Trim(TextBox1.Text) & "%'"
        ElseIf RadioButton2.Checked = True Then
            sql = "select * from PLANNING_GROUP where pgid='" & Trim(TextBox1.Text) & "' "
        Else
            MsgBox("Please select Name or id")
            Exit Sub

        End If
        adapt = New OleDbDataAdapter(sql, con)
        dt = New DataTable
        adapt.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
Imports System.Data.OleDb
Public Class welcome


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim username As String = Trim(TextBox1.Text)
        'Dim password As String = Trim(TextBox2.Text)

        If TextBox1.Text = "" Then
            MsgBox("Please enter username!!")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MsgBox("Please enter password!!")
            TextBox2.Focus()
            Exit Sub

        End If
        If TextBox1.Text = "4nm14cs004" And TextBox2.Text = "4nm14cs004" And RadioButton1.Checked = True And RadioButton2.Checked = False Then
            MsgBox("Hello Admin!!!!")
            start.Show()
        ElseIf TextBox1.Text = "4nm14cs001" And TextBox2.Text = "4nm14cs001" And RadioButton1.Checked = True And RadioButton2.Checked = False Then
            MsgBox("Hello Admin!!!!")
            start.Show()
        ElseIf RadioButton2.Checked = True And RadioButton1.Checked = False Then
            MsgBox("Welcome user!!!!")
            user.Show()
        Else
            MsgBox("Select Admin or others and enter login and password")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

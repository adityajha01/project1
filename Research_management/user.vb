Public Class user

    Private Sub MANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANAGEMENTToolStripMenuItem.Click
        datagridmang.Show()
    End Sub

    Private Sub SCIENTISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCIENTISTToolStripMenuItem.Click
        datagridsc.Show()
    End Sub

    Private Sub CONTROLLERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLLERToolStripMenuItem.Click
        datagridcon.Show()
    End Sub

    Private Sub PROGRAMMANAGERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROGRAMMANAGERToolStripMenuItem.Click
        datagridpro.Show()
    End Sub

    Private Sub PLANNINGGROUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANNINGGROUPToolStripMenuItem.Click
        datagridpl.Show()
    End Sub

    Private Sub FACILITIESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACILITIESToolStripMenuItem.Click
        datagridfac.Show()
    End Sub

    Private Sub LABORATORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LABORATORYToolStripMenuItem.Click
        datagridlab.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
    End Sub

    Private Sub MANAGEMENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MANAGEMENTToolStripMenuItem1.Click
        searchman.Show()
    End Sub

    Private Sub SCIENTISTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SCIENTISTToolStripMenuItem1.Click
        searchsc.Show()
    End Sub

    Private Sub CONTROLLERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONTROLLERToolStripMenuItem1.Click
        searchco.Show()
    End Sub

    Private Sub PROGRAMMANAGERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PROGRAMMANAGERToolStripMenuItem1.Click
        searchpr.Show()
    End Sub

    Private Sub PLANNINGGTOUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANNINGGTOUPToolStripMenuItem.Click
        searchpl.Show()
    End Sub

    Private Sub FACILITIESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FACILITIESToolStripMenuItem1.Click
        serachfac.Show()
    End Sub

    Private Sub LABORATORYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LABORATORYToolStripMenuItem1.Click
        searchlab.Show()
    End Sub
End Class
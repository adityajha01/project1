Public Class start

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()


    End Sub

    Private Sub MENUToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VIEWToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.Click

    End Sub

    Private Sub PROGRAMMANAGERToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PROGRAMMANAGERToolStripMenuItem2.Click
        searchman.Show()
    End Sub

    Private Sub CONTROLLERToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CONTROLLERToolStripMenuItem2.Click
        searchpr.Show()
    End Sub

    Private Sub SCIENTISTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SCIENTISTToolStripMenuItem2.Click
        searchco.Show()
    End Sub

    Private Sub PLANNINGGROUPToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PLANNINGGROUPToolStripMenuItem2.Click
        searchsc.Show()
    End Sub

    Private Sub PROGRAMMANAGERToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PROGRAMMANAGERToolStripMenuItem3.Click
        delpr.Show()
    End Sub

    Private Sub CONTROLLERToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CONTROLLERToolStripMenuItem3.Click
        delco.Show()
    End Sub

    Private Sub SCIENTISTToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SCIENTISTToolStripMenuItem3.Click
        delsc.Show()
    End Sub

    Private Sub PLANNINGGROUPToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PLANNINGGROUPToolStripMenuItem3.Click
        delpl.Show()
    End Sub

    Private Sub PROGRAMMANAGERToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles PROGRAMMANAGERToolStripMenuItem4.Click
        editpr.Show()
    End Sub

    Private Sub CONTROLLERToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CONTROLLERToolStripMenuItem4.Click
        editco.Show()
    End Sub

    Private Sub SCIENTISTToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles SCIENTISTToolStripMenuItem4.Click
        editsc.Show()
    End Sub

    Private Sub PLANNINGGROUPToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles PLANNINGGROUPToolStripMenuItem4.Click
        editpl.Show()
    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click

    End Sub

    Private Sub DYNAMICToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DYNAMICToolStripMenuItem.Click
        help.Show()
    End Sub

    Private Sub AboutOUTLOOkToolStripMenuItem_Click(sender As Object, e As EventArgs)
        about.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub SEARCHToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SEARCHToolStripMenuItem.Click

    End Sub

    Private Sub PLANNINGGROUPToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles PLANNINGGROUPToolStripMenuItem5.Click
        searchpl.Show()
    End Sub

    Private Sub FACILITIESToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FACILITIESToolStripMenuItem2.Click
        serachfac.Show()
    End Sub

    Private Sub LABORTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LABORTORYToolStripMenuItem.Click
        searchlab.Show()
    End Sub

    Private Sub MANAGEMENTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MANAGEMENTToolStripMenuItem2.Click
        delman.Show()
    End Sub

    Private Sub FACILITIESToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles FACILITIESToolStripMenuItem3.Click
        delfac.Show()
    End Sub

    Private Sub LABORATORYToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LABORATORYToolStripMenuItem2.Click
        dellab.Show()
    End Sub

    Private Sub MANAGEMENTToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MANAGEMENTToolStripMenuItem3.Click
        editman.Show()
    End Sub

    Private Sub FACILITIESToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles FACILITIESToolStripMenuItem4.Click
        editfac.Show()
    End Sub

    Private Sub LABORATORYToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles LABORATORYToolStripMenuItem3.Click
        editlab.Show()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click

    End Sub

    Private Sub EXITToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Dispose()
    End Sub

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

    Private Sub MANGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANGEMENTToolStripMenuItem.Click
        insmanag.Show()
    End Sub

    Private Sub SCIENTISTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SCIENTISTToolStripMenuItem1.Click
        inssc.Show()
    End Sub

    Private Sub CONTROLLERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONTROLLERToolStripMenuItem1.Click
        insco.Show()
    End Sub

    Private Sub PROGRAMMANAGERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PROGRAMMANAGERToolStripMenuItem1.Click
        inspr.Show()
    End Sub

    Private Sub PLANNINGGROUPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PLANNINGGROUPToolStripMenuItem1.Click
        inspl.Show()
    End Sub

    Private Sub LABORATORYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LABORATORYToolStripMenuItem1.Click
        inslab.Show()
    End Sub

    Private Sub FACILITIESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FACILITIESToolStripMenuItem1.Click
        insfac.Show()
    End Sub
End Class
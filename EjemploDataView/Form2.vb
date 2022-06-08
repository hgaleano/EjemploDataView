Public Class Form2
    Dim dvwGenerico As New DataView
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As New Form1
        frm.dvwGenerico = dvwGenerico
    End Sub
End Class
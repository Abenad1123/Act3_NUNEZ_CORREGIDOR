Public Class Form3
    Private Sub go_back_btn_BEnter(sender As Object, e As EventArgs) Handles go_back_btn.MouseEnter
        go_back_btn.Image = My.Resources.go_back_btn_hover
    End Sub
    Private Sub go_back_btn_BLeave(sender As Object, e As EventArgs) Handles go_back_btn.MouseLeave
        go_back_btn.Image = My.Resources.go_back_btn
    End Sub

    Private Sub go_back_btn_Click(sender As Object, e As EventArgs) Handles go_back_btn.Click
        Dim main_menu As New Form1()
        main_menu.Show()
        Me.Close()
    End Sub
End Class
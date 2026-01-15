Public Class Form1
    ' ---- STANDARD FEES ----
    Public Shared tuition_fee As Integer = 140143
    Public Shared miscellaneous_fee As Integer = 5150

    ' ---- ITEMS ----
    Public Shared school_bus_fee_yearly As Integer = 80000
    Public Shared shuttle_fee_yearly As Integer = 50000
    Public Shared books_fee As Integer

    Public Shared reg_uniform_fullSet() As Integer = {800, 900, 1040, 1160, 1300, 1500}
    Public Shared pe_uniform_buttom_fullSet() As Integer = {800, 900, 1040, 1160, 1300, 1500}

    ' ---- DISCOUNTS ----
    ' Para sa mga PWD
    Public Shared discount_pwd As Double = 0.1
    ' Kapag may 2 or more na kapamilyang enrolled sa school
    Public Shared discount_family As Double = 0.03
    ' Kapag anak ng employee sa school
    Public Shared discount_employee As Double = 0

    Public Shared intial_pay As Double = 0
    Public Shared total_pay As Double = 0

    Public Shared reg_uniform_set_amount As Integer = 0
    Public Shared pe_uniform_set_amount As Integer = 0

    Public Shared reg_uniform_set_size As Integer = 0
    Public Shared pe_uniform_set_size As Integer = 0

    Private Sub enroll_btn_MEnter(sender As Object, e As EventArgs) Handles enroll_btn.MouseEnter
        enroll_btn.Image = My.Resources.enroll_btn_hover
    End Sub

    Private Sub enroll_btn_MLeave(sender As Object, e As EventArgs) Handles enroll_btn.MouseLeave
        enroll_btn.Image = My.Resources.enroll_btn
    End Sub

    Private Sub acad_btn_MEnter(sender As Object, e As EventArgs) Handles acad_btn.MouseEnter
        acad_btn.Image = My.Resources.acad_calendar_btn_hover
    End Sub

    Private Sub acad_btn_MLeave(sender As Object, e As EventArgs) Handles acad_btn.MouseLeave
        acad_btn.Image = My.Resources.acad_calendar_btn
    End Sub

    Private Sub about_btn_MEnter(sender As Object, e As EventArgs) Handles about_btn.MouseEnter
        about_btn.Image = My.Resources.about_btn_hover
    End Sub

    Private Sub about_btn_MLeave(sender As Object, e As EventArgs) Handles about_btn.MouseLeave
        about_btn.Image = My.Resources.about_btn
    End Sub

    Private Sub enroll_btn_Click(sender As Object, e As EventArgs) Handles enroll_btn.Click
        Dim enroll As New Form2()
        enroll.Show()
        Me.Close()
    End Sub

    Private Sub acad_btn_Click(sender As Object, e As EventArgs) Handles acad_btn.Click
        Dim acad As New Form3()
        acad.Show()
        Me.Close()
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        Dim about As New Form4()
        about.Show()
        Me.Close()
    End Sub
End Class

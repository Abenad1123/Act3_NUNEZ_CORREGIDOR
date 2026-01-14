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

    Public Shared reg_uniform_set_amount As Integer
    Public Shared pe_uniform_set_amount As Integer

    Public Shared reg_uniform_set_size As Integer
    Public Shared pe_uniform_set_size As Integer

End Class

Public Class Calculate
    Private op1 As Double
    Private op2 As Double
    Private op As String
    Private retValue As Double

    Public Sub New(ope1 As String, ope As String, ope2 As String)
        op1 = Double.Parse(ope1)
        op = ope
        op2 = Double.Parse(ope2)
    End Sub

    Public Sub New()
        op1 = 0
        op = ""
        op2 = 0
    End Sub
    Public Sub SetValues(ope1 As String, ope As String, ope2 As String)
        op1 = Double.Parse(ope1)
        op = ope
        op2 = Double.Parse(ope2)
    End Sub
    Public Function Calc()

        Select Case op
            Case "＋"
                retValue = op1 + op2
            Case "－"
                retValue = op1 - op2
            Case "×"
                retValue = op1 * op2
            Case "÷"
                retValue = op1 / op2
            Case Else
                retValue = 0
        End Select

        Return retValue.ToString()
    End Function

End Class

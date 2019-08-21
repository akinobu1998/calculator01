Public Class Form1
    ' for the equation 
    Dim reg01 As Reg01 = New Reg01()
    ' to make number
    Dim regNum As RegNum = New RegNum()

    'Private Sub Print_Stack(stack As Stack)
    '    Dim array As Array = stack.ToArray()
    '    For Each item As String In array
    '        regNum.Append(item)
    '    Next
    '    debug01.Text = regNum.getRegister()
    'End Sub


    Private Sub Num_Click(sender As Object, e As EventArgs) Handles zero.Click, one.Click, two.Click, three.Click, four.Click, five.Click, six.Click, seven.Click, eight.Click, nine.Click
        regNum.Append(sender.Text)
        debug01.Text = regNum.getRegister()
        reg01.Print(debug01, regNum)
    End Sub

    Private Sub Ope_Click(sender As Object, e As EventArgs) Handles plus.Click, minus.Click, divide.Click, multiple.Click
        ' number
        reg01.Add(regNum.getRegister())
        ' operator
        reg01.Add(sender.Text)
        reg01.Print(debug01)
        regNum.Clear()
    End Sub


    Private Sub Equal_Clisk(sender As Object, e As EventArgs) Handles equal.Click
        'Dim ret As String
        Dim calc As Calculate = New Calculate()

        reg01.Add(regNum.getRegister())

        ' No.1 mul and div
        Dim temp As String
        While Not reg01.IsEmpty
            temp = reg01.Pick()
            If temp.Equals("×") Or temp.Equals("÷") Then
                reg01.debugPrint()
                calc.SetValues(reg01.GetOp1, temp, reg01.GetOp2)
                'ret = calc.Calc()
                reg01.Store(calc.Calc())
            Else
                reg01.Store(temp)
            End If
        End While

        reg01.Init()
        'reg01.PrintEquation(debug1)
        reg01.Print(debug01)


        'reg01.Store(reg01.Pick())
        'reg01.debugPrint()




    End Sub
End Class

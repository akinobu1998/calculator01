
' save the equation and calcurate
Public Class Reg01
    ' main register
    Private register01 As List(Of String) = New List(Of String)
    ' temp register
    Private register02 As List(Of String) = New List(Of String)
    Private equation As List(Of String) = New List(Of String)



    'Public Sub New()
    '
    'End Sub

    Public Sub Add(item As String)
        register01.Add(item)
        equation.Add(item)
    End Sub

    Public Function Remove() As String
        Dim temp As String = register01(0)
        register01.RemoveAt(0)
        Return temp
    End Function


    Public Sub Print(display As TextBox)
        Dim temp(50) As String
        Dim tempString As String = ""
        register01.CopyTo(temp, 0)

        For Each item As String In temp
            tempString &= item
        Next

        display.Text = tempString
    End Sub

    Public Sub Print(display As TextBox, regNum As RegNum)
        Dim temp(50) As String
        Dim tempString As String = ""
        register01.CopyTo(temp, 0)

        For Each item As String In temp
            tempString &= item
        Next
        tempString &= regNum.getRegister()

        display.Text = tempString
    End Sub

    'Public Sub PrintEquation(display As TextBox, regNum As RegNum)
    '    'Dim temp(50) As String
    '    Dim tempString As String = ""
    '    'register01.CopyTo(temp, 0)

    '    For Each item As String In equation
    '        tempString &= item
    '    Next
    '    tempString &= regNum.getRegister()
    '    tempString &= "="

    '    display.Text = tempString
    'End Sub

    Public Function Pick()
        Dim temp As String = register01(0)
        register01.RemoveAt(0)
        Return temp
    End Function

    ' return the last item of register02, op1
    Public Function GetOp1()
        Dim index = register02.Count - 1
        Debug.Print(index)
        Dim temp As String = register02(index)
        register02.RemoveAt(index)
        Return temp
    End Function
    ' return the first item of register01, op2
    Public Function GetOp2()
        Dim index = 0
        Dim temp As String = register01(index)
        register01.RemoveAt(index)
        Return temp
    End Function

    Public Sub Store(item As String)
        register02.Add(item)
    End Sub

    Public Sub Init()
        register01 = New List(Of String)(register02)
    End Sub

    Public Function IsEmpty() As Boolean
        Return register01.Count = 0
    End Function

    Public Sub debugPrint()
        Debug.Print("register01: ")
        For Each item As String In register01
            Debug.Print(item)
        Next

        Debug.Print("register02: ")
        For Each item As String In register02
            Debug.Print(item)
        Next
    End Sub


End Class

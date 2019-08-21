' to make the number
' ex) 1,2,3 -> 123

Public Class RegNum
    Dim register As String

    Public Sub New()
        register = ""
    End Sub

    Public Sub Append(item As String)
        register &= item
    End Sub

    Public Sub Clear()
        register = ""
    End Sub

    Public Function getRegister() As String
        Return register
    End Function

End Class

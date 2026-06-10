Public Class Cliente

    Public Property Nome As String
    Public Property Contato As String

    Public Overrides Function ToString() As String
        Return Nome & " - " & Contato
    End Function

End Class
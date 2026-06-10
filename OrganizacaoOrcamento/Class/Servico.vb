Public Class Servico

    Public Property Nome As String
    Public Property Preco As Decimal

    Public Overrides Function ToString() As String
        Return Nome & " - R$ " & Preco
    End Function

End Class
Public Class ItemOrcamento

    Public Property Servico As Servico

    Public Property Quantidade As Integer

    Public ReadOnly Property Total As Decimal
        Get
            Return Servico.Preco * Quantidade
        End Get
    End Property

End Class
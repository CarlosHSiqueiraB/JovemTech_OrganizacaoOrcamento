Public Class Orcamento

    Public Property Cliente As Cliente

    Public Property Item As ItemOrcamento

    Public Property Status As String = "Pendente"

    Public Property NumeroPedido As Integer?

    Public Property MotivoRejeicao As String

    Public ReadOnly Property ValorTotal As Decimal
        Get
            Return Item.Total
        End Get
    End Property

    Public Overrides Function ToString() As String

        Return Cliente.Nome &
           " | " &
           Item.Servico.Nome &
           " | Qtd: " &
           Item.Quantidade &
           " | Total: R$ " &
           ValorTotal.ToString("N2") &
           " | " &
           Status

    End Function

End Class
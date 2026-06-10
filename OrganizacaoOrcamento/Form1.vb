Public Class Form1

    Private clientes As New List(Of Cliente)

    Private servicos As New List(Of Servico)

    Private orcamentos As New List(Of Orcamento)

    Private proximoPedido As Integer = 1

    Private Sub NomeLabel(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ContatoLabel(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BotaoCadastrarPessoa(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cliente As New Cliente

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Informe o nome.")
            Exit Sub
        End If

        If TextBox1.Text.Trim.Length < 3 Then
            MessageBox.Show("Nome deve possuir ao menos 3 caracteres.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Informe o contato.")
            Exit Sub
        End If

        If Not IsNumeric(TextBox2.Text) Then
            MessageBox.Show("Contato deve conter apenas números.")
            Exit Sub
        End If

        cliente.Nome = TextBox1.Text.Trim()
        cliente.Contato = TextBox2.Text.Trim()

        clientes.Add(cliente)

        Lista_Cadastro.Items.Add(cliente)

        ComboBox2.Items.Add(cliente)

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub ListBoxCadastroPessoa(sender As Object, e As EventArgs) Handles Lista_Cadastro.SelectedIndexChanged

        If Lista_Cadastro.SelectedItem IsNot Nothing Then

            MessageBox.Show(Lista_Cadastro.SelectedItem.ToString())

        End If

    End Sub

    Private Sub ServicoLabel(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBoxService(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBoxCadastroPessoa(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBoxCadastroContato(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PrecoLabel(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBoxServices(sender As Object, e As EventArgs) Handles Lista_Serviço.SelectedIndexChanged

        If Lista_Serviço.SelectedItem Is Nothing Then Exit Sub

        Dim servico As Servico

        servico = CType(Lista_Serviço.SelectedItem, Servico)

        MessageBox.Show(
        "=== SERVIÇO CADASTRADO ===" & vbCrLf & vbCrLf &
        "Nome: " & servico.Nome & vbCrLf &
        "Preço: R$ " & servico.Preco.ToString("N2")
    )

    End Sub

    Private Sub BotaoCadastraService(sender As Object, e As EventArgs) Handles Button2.Click

        Dim servico As New Servico

        Dim preco As Decimal

        If Not Decimal.TryParse(TextBox3.Text, preco) Then

            MessageBox.Show("Preço inválido.")
            Exit Sub

        End If

        If preco <= 0 Then

            MessageBox.Show("Preço deve ser maior que zero.")
            Exit Sub

        End If
        servico.Nome = TextBox4.Text.Trim()
        servico.Preco = preco

        servicos.Add(servico)

        Lista_Serviço.Items.Add(servico)

        ComboBox1.Items.Add(servico)

        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub TextBoxNomeCliente(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxNomeService(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxQuantidadeService(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub ListBoxDetalhesServices(sender As Object, e As EventArgs) Handles ListaPendência.SelectedIndexChanged

    End Sub

    Private Sub BotaoAprovar(sender As Object, e As EventArgs) Handles Button3.Click

        If ListaPendência.SelectedItem Is Nothing Then

            MessageBox.Show("Selecione um orçamento.")
            Exit Sub

        End If

        Dim orcamento As Orcamento

        orcamento = CType(ListaPendência.SelectedItem, Orcamento)

        orcamento.Status = "Aprovado"

        orcamento.NumeroPedido = proximoPedido

        proximoPedido += 1

        HistoricosAprovados.Items.Add(orcamento)

        ListaPendência.Items.Remove(orcamento)

    End Sub

    Private Sub BotaoAdicionarPendente(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox2.SelectedItem Is Nothing Then

            MessageBox.Show("Selecione um cliente.")
            Exit Sub

        End If

        If ComboBox1.SelectedItem Is Nothing Then

            MessageBox.Show("Selecione um serviço.")
            Exit Sub

        End If

        Dim quantidade As Integer

        If Not Integer.TryParse(TextBox7.Text, quantidade) Then

            MessageBox.Show("Quantidade inválida.")
            Exit Sub

        End If

        If quantidade <= 0 Then

            MessageBox.Show("Quantidade deve ser maior que zero.")
            Exit Sub

        End If

        Dim item As New ItemOrcamento

        item.Servico = CType(ComboBox1.SelectedItem, Servico)
        item.Quantidade = quantidade

        Dim orcamento As New Orcamento

        orcamento.Cliente = CType(ComboBox2.SelectedItem, Cliente)
        orcamento.Item = item

        orcamentos.Add(orcamento)

        ListaPendência.Items.Add(orcamento)

        TextBox7.Clear()


    End Sub

    Private Sub ListaPendência_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPendência.SelectedIndexChanged

        If ListaPendência.SelectedItem Is Nothing Then Exit Sub

        Dim orcamento As Orcamento

        orcamento = CType(ListaPendência.SelectedItem, Orcamento)

        MessageBox.Show(
        "Cliente: " & orcamento.Cliente.Nome & vbCrLf &
        "Contato: " & orcamento.Cliente.Contato & vbCrLf &
        "Serviço: " & orcamento.Item.Servico.Nome & vbCrLf &
        "Preço Unitário: R$ " & orcamento.Item.Servico.Preco.ToString("N2") & vbCrLf &
        "Quantidade: " & orcamento.Item.Quantidade & vbCrLf &
        "Total: R$ " & orcamento.ValorTotal.ToString("N2") & vbCrLf &
        "Status: " & orcamento.Status
    )

    End Sub

    Private Sub HistoricosAprovados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HistoricosAprovados.SelectedIndexChanged

        If HistoricosAprovados.SelectedItem Is Nothing Then Exit Sub

        Dim orcamento As Orcamento

        orcamento = CType(HistoricosAprovados.SelectedItem, Orcamento)

        MessageBox.Show(
        "Pedido #" & orcamento.NumeroPedido & vbCrLf &
        "Cliente: " & orcamento.Cliente.Nome & vbCrLf &
        "Valor Total: R$ " & orcamento.ValorTotal.ToString("N2")
    )

    End Sub

    Private Sub HistoricoRecusados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HistoricoRecusados.SelectedIndexChanged

        If HistoricoRecusados.SelectedItem Is Nothing Then Exit Sub

        Dim orcamento As Orcamento

        orcamento = CType(HistoricoRecusados.SelectedItem, Orcamento)

        MessageBox.Show(
        "Cliente: " & orcamento.Cliente.Nome & vbCrLf &
        "Motivo: " & orcamento.MotivoRejeicao
    )

    End Sub

    Private Sub BotaoRecusar(sender As Object, e As EventArgs) Handles Button4.Click

        If ListaPendência.SelectedItem Is Nothing Then

            MessageBox.Show("Selecione um orçamento.")
            Exit Sub

        End If

        Dim motivo As String

        motivo = InputBox("Informe o motivo da rejeição")

        Dim orcamento As Orcamento

        orcamento = CType(ListaPendência.SelectedItem, Orcamento)

        orcamento.Status = "Rejeitado"

        orcamento.MotivoRejeicao = motivo

        HistoricoRecusados.Items.Add(orcamento)

        ListaPendência.Items.Remove(orcamento)

    End Sub

    Private Sub ListBoxHistoricoAprovados(sender As Object, e As EventArgs) Handles HistoricosAprovados.SelectedIndexChanged

    End Sub

    Private Sub ListBoxHistoricoRecusados(sender As Object, e As EventArgs) Handles HistoricoRecusados.SelectedIndexChanged

        If HistoricoRecusados.SelectedItem Is Nothing Then Exit Sub

        Dim orcamento As Orcamento

        orcamento = CType(HistoricoRecusados.SelectedItem, Orcamento)

        MessageBox.Show(
        "=== ORÇAMENTO REJEITADO ===" & vbCrLf & vbCrLf &
        "Cliente: " & orcamento.Cliente.Nome & vbCrLf &
        "Contato: " & orcamento.Cliente.Contato & vbCrLf & vbCrLf &
        "Serviço: " & orcamento.Item.Servico.Nome & vbCrLf &
        "Preço Unitário: R$ " & orcamento.Item.Servico.Preco.ToString("N2") & vbCrLf &
        "Quantidade: " & orcamento.Item.Quantidade & vbCrLf &
        "Valor Total: R$ " & orcamento.ValorTotal.ToString("N2") & vbCrLf & vbCrLf &
        "Status: " & orcamento.Status & vbCrLf &
        "Motivo da Rejeição: " & orcamento.MotivoRejeicao
    )

    End Sub

    Private Sub ComboBoxCliente(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxService(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class

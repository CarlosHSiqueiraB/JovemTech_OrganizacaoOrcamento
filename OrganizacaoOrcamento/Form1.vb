Public Class Form1
    Private Sub NomeLabel(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ContatoLabel(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BotaoCadastrarPessoa(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Informe o nome.")
            Exit Sub
        End If

        If TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Informe o contato.")
            Exit Sub
        End If

        If Not IsNumeric(TextBox2.Text) Then
            MessageBox.Show("O contato deve conter apenas números.")
            Exit Sub
        End If

        Dim cadastro As String

        cadastro = TextBox1.Text & " - " & TextBox2.Text

        Lista_Cadastro.Items.Add(cadastro)
        ComboBox2.Items.Add(cadastro)

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

    End Sub

    Private Sub BotaoCadastraService(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox4.Text.Trim() = "" Then
            MessageBox.Show("Informe o nome do serviço.")
            Exit Sub
        End If

        Dim preco As Decimal

        If Not Decimal.TryParse(TextBox3.Text, preco) Then
            MessageBox.Show("Preço inválido.")
            Exit Sub
        End If

        If preco <= 0 Then
            MessageBox.Show("O preço deve ser maior que zero.")
            Exit Sub
        End If

        Dim cadastroService As String

        cadastroService = TextBox4.Text & " - R$: " & TextBox3.Text

        Lista_Serviço.Items.Add(cadastroService)
        ComboBox1.Items.Add(cadastroService)

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

        If TextBox7.Text = "" Then
            MessageBox.Show("Informe a quantidade.")
            Exit Sub
        End If

        Dim pendencia As String

        pendencia = "Cliente: " & ComboBox2.SelectedItem.ToString() &
                " | Serviço: " & ComboBox1.SelectedItem.ToString() &
                " | Quantidade: " & TextBox7.Text

        ListaPendência.Items.Add(pendencia)

        TextBox7.Clear()


    End Sub

    Private Sub BotaoRecusar(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub ListBoxHistoricoAprovados(sender As Object, e As EventArgs) Handles HistoricosAprovados.SelectedIndexChanged

    End Sub

    Private Sub ListBoxHistoricoRecusados(sender As Object, e As EventArgs) Handles HistoricoRecusados.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxCliente(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxService(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class

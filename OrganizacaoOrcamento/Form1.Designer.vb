<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Lista_Cadastro = New ListBox()
        Lista_Serviço = New ListBox()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(49, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 1
        Label1.Text = "NOME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 2
        Label2.Text = "CONTATO"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(49, 167)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(63, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Cadastrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Lista_Cadastro
        ' 
        Lista_Cadastro.FormattingEnabled = True
        Lista_Cadastro.Location = New Point(49, 309)
        Lista_Cadastro.Name = "Lista_Cadastro"
        Lista_Cadastro.Size = New Size(125, 224)
        Lista_Cadastro.TabIndex = 5
        ' 
        ' Lista_Serviço
        ' 
        Lista_Serviço.FormattingEnabled = True
        Lista_Serviço.Location = New Point(252, 309)
        Lista_Serviço.Name = "Lista_Serviço"
        Lista_Serviço.Size = New Size(125, 224)
        Lista_Serviço.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(266, 231)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 10
        Button2.Text = "Cadastrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(252, 167)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(287, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 8
        Label3.Text = "PREÇO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(278, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 7
        Label4.Text = "SERVIÇO"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(252, 70)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1385, 610)
        Controls.Add(Lista_Serviço)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Lista_Cadastro)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Lista_Cadastro As ListBox
    Friend WithEvents Lista_Serviço As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox

End Class

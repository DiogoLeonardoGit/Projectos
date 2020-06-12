Public Class Form1
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            'chamar o metodo Create codificado no modulo CRUD 
            'e colocar a query no parametro para inserir os dados. 
            'atenc5o que a query deve ser uma instrucao SQL valida 
            'e usando os valores existentes nos controlos do form. 
            'sintaxe: INSERT INTO tabela (Coluna1, ...) VALUES (Valorl, ...) 
            Create("INSERT INTO Utilizadores(nome, utilizador, senha, nivel) VALUES ('" & TxtNome.Text & "1,'" & TxtUtilizador.Text & "','" & TxtSenha.Text & "'," & CbNivel.SelectedIndex + 1 & ")")
        Catch ex As Exception
            'em caso de erro exibir o mesmo 
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Try
            'chamar o motodo Reload codificado no modulo CRUD 
            'e colocar a query e o DataGridView como parametros 
            'para ser atualizada o controlo DgLista no form. 
            'a query sera um consulta a todos os dados da tabela 
            'sintaxe: SELECT * FROM tabela 
            Reload("SELECT * FROM Utilizadores ORDER BY ID ASC", DgLista)
        Catch ex As Exception
            'em caso de erro exibir o mesmo 
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            'chamar o matodo Updates codificado no modulo CRUD 
            'e colocar a query no parametro para atualizar os dados. 
            'ter em atencao que esta atualizacao so a realizada em um registo 
            'pelo que sera necessario indicar qual a (usamos o ID para isso) 
            'sintaxe: UPDATE tabela SET Colunal = valorl, ... WHERE condicao 
            Updates("UPDATE Utilizadores SET nome='" & TxtNome.Text & "', " & "utilizador='" & TxtUtilizador.Text & "', " & "senha='" & TxtSenha.Text & "', " & "nivel=" & CbNivel.SelectedIndex & " WHERE ID=" & LblID.Text)
        Catch ex As Exception
            'em caso de erro exibir o mesmo 
            MessageBox.Show("ERRO" & ex.Message, "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            'chamar o matodo Delete codificado no modulo CRUD 
            'e colocar a query no parametro para eliminar os dados. 
            'apesar de podermos eliminar varios registos de uma so vez 
            'devemos ter em atencao que esta operacAo 6 irreversivel 
            'assim 6 necessario indicar qual o registo a eliminar (usamos o ID) 
            'sintaxe: DELETE FROM tabela WHERE condicao 

            Delete("DELETE FROM Utilizadores WHERE ID=" & LblID.Text)
        Catch ex As Exception
            'em caso de erro exibir o mesmo 
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DgLista_DoubleClick(sender As Object, e As EventArgs) Handles DgLista.DoubleClick
        'ajustar o registo na lista do DataGridView para os restantes controlos 
        'obtemos a linha atraves de CurrentRow e a coluna atraves de Cells(n) 
        LblID.Text = DgLista.CurrentRow.Cells(0).Value
        TxtNome.Text = DgLista.CurrentRow.Cells(1).Value
        TxtUtilizador.Text = DgLista.CurrentRow.Cells(2).Value
        TxtSenha.Text = DgLista.CurrentRow.Cells(3).Value
        CbNivel.SelectedIndex = DgLista.CurrentRow.Cells(4).Value

    End Sub

    Private Sub DgLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgLista.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNome.Select()
        Me.BtnReload.PerformClick()
    End Sub
End Class

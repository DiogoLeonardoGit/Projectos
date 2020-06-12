Imports System.Data.SqlClient

Module CRUD
    Public Function StrLigacao() As SqlConnection
        Return New SqlConnection("Data Source=(LocalDB) \ MSSQLLocalDB;AttachDbFilename=D:\Work Folder\trabalhos na quarentena\PSI\Tarefa 10\Tarefa 10\DBusers.mdf;Integrated Security=True")
    End Function
    Public StrConexao As SqlConnection = StrLigacao()
    Public resultado As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable

    Public Sub Create(ByVal Comando As String)
        Try
            'abrir a ligacao 
            StrConexao.Open()
            'reter a instrucao a ser executada 
            With cmd
                .Connection = StrConexao
                .CommandText = Comando
                'executar a instrucao 
                resultado = cmd.ExecuteNonQuery
                'verificar se a instrucao foi corretamente executada 
                If resultado - 0 Then
                    MessageBox.Show("Falhou a operacao de inserir os dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Os dados foram inseridos com sucesso.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'fechar a ligacao 
        StrConexao.Close()
    End Sub

    Public Sub Reload(ByVal Comando As String, Grelha As Object)
        Try
            dt = New DataTable
            StrConexao.Open()
            With cmd
                .Connection = StrConexao
                .CommandText = Comando
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Grelha.DataSource = dt
        Catch ex As Exception
            'em caso de erro na ligac5o
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'fechar a ligacao 
        StrConexao.Close()
        'libertar dados em memoria 
        da.Dispose()
    End Sub

    Public Sub Updates(ByVal Comando As String)
        Try
            StrConexao.Open()
            With cmd
                .Connection = StrConexao
                .CommandText = Comando
                'executar a instrucao 
                resultado = cmd.ExecuteNonQuery
                'verificar se a instrucAo foi corretamente executada 
                If resultado - 0 Then
                    MessageBox.Show("Falhou a operacAo de atualizar os dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Os dados foram atualizados com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            'em caso de erro na ligac5o 
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        StrConexao.Close()
    End Sub

    Public Sub Delete(ByVal Comando As String)
        Try
            StrConexao.Open()
            With cmd
                .Connection = StrConexao
                .CommandText = Comando
                'executar a instrucao 
                resultado = cmd.ExecuteNonQuery
                'verificar se a instrucao foi corretamente executada 
                If resultado - 0 Then
                    MessageBox.Show("Falhou a operacao de eliminar os dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Os dados foram eliminados com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception 'em caso de erro na ligacao 
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        StrConexao.Close()
    End Sub

End Module

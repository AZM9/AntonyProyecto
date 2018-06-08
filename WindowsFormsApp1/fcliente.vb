Imports Sistem.Data.sqlClient

Public Class Class1
    Inherits conexion
    Dim cmd As New sqlCommand


    Public Function mostrar() As datatable
        Try
            conectado()
            cmd = New sqlCommand("mostrar cliente")
            cmd.commandType = CommandType.StoredProceduce
            cmd.Connection = cnn
            If cmd.ExecuteNonQuer Then
                Dim dt As New DataTable
                Dim da As New sqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt

            Else
                Return Nothing
            End If




        Catch ex As Exception
            msgBox(ex.Messahe)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function








End Class

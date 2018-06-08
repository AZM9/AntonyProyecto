Imports Sistem.Data.sqlClient

Public Class Class1
    Protected cnn As New sqlConnection
    Public idusuario As Integer

    Protected Function conectado()

        Try
            cnn = New sqlconnection("data source=(local);initial catalog=dbventas;integrated security=true")
            cnn.Open()
            Return True

        Catch ex As Exception
            msgBox(ex.Message)
            Return False
        End Try


    End Function


    Protected Function desconectado()
        Try
            If cnn.Stated = connectionState.Open Then
                cnn.close()
                Return True
            Else
                Return False


            End If
        Catch ex As Exception
            msgBox(ex.Message)
            Return False


        End Try



    End Function




End Class

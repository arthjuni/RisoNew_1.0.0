Public Class CLIENTE

    Private IdCiente As Integer
    Private CodiceFiscaleCliente As String
    Private SedeCliente As String
    Private ViaCorsoCliente As String
    Private AllOrdineClient As List(Of ORDINE)

    Public Property Id As Integer
        Get
            Return IdCiente
        End Get
        Set(value As Integer)
            IdCiente = value
        End Set
    End Property

    Property CodiceFiscale As String
        Get
            Return CodiceFiscaleCliente

        End Get
        Set(value As String)
            CodiceFiscaleCliente = value

        End Set
    End Property

    Public Property Sede As String
        Get
            Return SedeCliente
        End Get
        Set(value As String)
            SedeCliente = value
        End Set
    End Property

    Public Property ViaCorso As String
        Get
            Return ViaCorsoCliente
        End Get
        Set(value As String)
            ViaCorsoCliente = value
        End Set
    End Property

    Public Property AllOrdine As List(Of ORDINE)
        Get
            Return AllOrdineClient
        End Get
        Set(value As List(Of ORDINE))
            AllOrdineClient = value
        End Set
    End Property

    Public Sub AddOrdine(ORDI As ORDINE)
        Me.AllOrdine.Add(ORDI)

    End Sub

    Public Sub RemoveOrdine(ORDI As ORDINE)
        Me.AllOrdine.Remove(ORDI)
    End Sub

End Class

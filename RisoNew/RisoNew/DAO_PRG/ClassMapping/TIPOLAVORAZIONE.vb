Public Class TIPOLAVORAZIONE


    Private IdTipoLavorazione As Integer
    Private TipoLavorazioneLAV As Integer
    Private DescriptionLavorazione As String
    Private ALLLavoroTipoLavorazione As List(Of LAVORO)

    Public Property id As Integer
        Get
            Return IdTipoLavorazione
        End Get
        Set(value As Integer)
            IdTipoLavorazione = value
        End Set
    End Property

    Public Property TipoLavorazione As Integer
        Get
            Return TipoLavorazioneLAV
        End Get
        Set(value As Integer)
            TipoLavorazioneLAV = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return DescriptionLavorazione
        End Get
        Set(value As String)
            DescriptionLavorazione = value
        End Set
    End Property

    Public Property ALLLavoro As List(Of LAVORO)
        Get
            Return ALLLavoroTipoLavorazione
        End Get
        Set(value As List(Of LAVORO))
            ALLLavoroTipoLavorazione = value
        End Set
    End Property

    Public Sub AddLavoro(LAVA As LAVORO)
        Me.ALLLavoro.Add(LAVA)

    End Sub

    Public Sub RemoveLavoro(LAVA As LAVORO)
        Me.ALLLavoro.Remove(LAVA)
    End Sub

End Class

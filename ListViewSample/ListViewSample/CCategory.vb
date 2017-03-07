Public Class CCategory

    Private _strCatName As String
    Private _dblTotalValue As Double
    Private _intTotalCount As Integer

    'constructor
    Public Sub New(strName As String, dblValue As Double)
        _strCatName = strName
        _dblTotalValue = dblValue
        _intTotalCount = 1 'creating this object when we encounter the first art piece in this category, so current count will be 1
    End Sub

#Region "Exposed Properties"
    Public ReadOnly Property CatName() As String
        Get
            Return _strCatName
        End Get
    End Property

    Public Property TotalValue() As Double
        Get
            Return _dblTotalValue
        End Get
        Set(dblVal As Double)
            _dblTotalValue = dblVal
        End Set
    End Property

    Public Property TotalCount() As Integer
        Get
            Return _intTotalCount
        End Get
        Set(intVal As Integer)
            _intTotalCount = intVal
        End Set
    End Property
#End Region

End Class

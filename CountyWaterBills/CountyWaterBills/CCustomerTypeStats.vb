Public Class CCustomerTypeStats

    Private _numCustomers As Integer
    Private _numGallonsUsed As Integer
    Private _numGallonsBilled As Integer
    Private _totalTaxes As Single
    Private _totalBill As Single

    Public Sub New()
        _numCustomers = 0
        _numGallonsUsed = 0
        _numGallonsBilled = 0
        _totalTaxes = 0
        _totalBill = 0
    End Sub

    Public Property Customers() As Integer
        Get
            Return _numCustomers
        End Get
        Set(numCustomers As Integer)
            _numCustomers = numCustomers
        End Set
    End Property

    Public Property GallonsUsed() As Integer
        Get
            Return _numGallonsUsed
        End Get
        Set(numGallonsUsed As Integer)
            _numGallonsUsed = numGallonsUsed
        End Set
    End Property

    Public Property GallonsBilled() As Integer
        Get
            Return _numGallonsBilled
        End Get
        Set(numGallonsBilled As Integer)
            _numGallonsBilled = numGallonsBilled
        End Set
    End Property

    Public Property Taxes() As Integer
        Get
            Return _totalTaxes
        End Get
        Set(totalTaxes As Integer)
            _totalTaxes = totalTaxes
        End Set
    End Property

    Public Property Bill() As Integer
        Get
            Return _totalBill
        End Get
        Set(totalBill As Integer)
            _totalBill = totalBill
        End Set
    End Property

    Public Sub addValues(customer As CCustomerTypeStats)
        _numCustomers += customer.Customers
        _numGallonsUsed += customer.GallonsUsed
        _numGallonsBilled += customer.GallonsBilled
        _totalTaxes += customer.Taxes
        _totalBill += customer.Bill
    End Sub


End Class

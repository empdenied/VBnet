Public Class Sandwich
    Private strBread As String
    Private strMeat As String
    Private strCheese As String
    Private strCondimentList As String
    Private strName As String
    Private strIngredients As String
    

    Public Sub New(ByVal NameIn As String, ByVal BreadIn As String, ByVal CheeseIn As String, ByVal MeatIn As String, ByVal CondimentsIn As String)
        Name = NameIn
        Bread = BreadIn
        Cheese = CheeseIn
        Meat = MeatIn
        Condiments = CondimentsIn

        GetIngredients()
    End Sub

    



    Private Property Name() As String
        Get
            Return strName

        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property
    Private Property Bread() As String
        Get
            Return strBread

        End Get
        Set(ByVal value As String)
            strBread = value
        End Set
    End Property
    Private Property Cheese() As String
        Get
            Return strCheese

        End Get
        Set(ByVal value As String)
            strCheese = value
        End Set
    End Property

    Private Property Meat() As String
        Get
            Return strMeat
        End Get
        Set(ByVal value As String)
            strMeat = value
        End Set
    End Property
    Private Property Condiments() As String
        Get
            Return strCondimentList
        End Get

        Set(ByVal value As String)
            strCondimentList = value
        End Set
    End Property

    

    ReadOnly Property Ingredients() As String
        Get
            Return strIngredients
        End Get
    End Property
   
    Protected Sub GetIngredients()
        strIngredients = strName & ": " & strBread & ", " & strCheese & ", " & strMeat & ", " & strCondimentList

    End Sub
End Class

Public Class Person
    Implements IAnotherInterface

    'Class
    '   Responsibility = Logic + its data
    'Member variables /fields
    Private _name As String
    Private _email As String = "Person@infosys.com"
    Private _age As Integer



    'Sub setName(value As String)
    '    If Not value = "" Then
    '        _name = value
    '    End If
    'End Sub

    'Function getName() As String
    '    Return _name
    'End Function

    'Properties
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If Not value = "" Then
                _name = value
            End If
        End Set
    End Property

    Public ReadOnly Property Email As String
        Get
            Return _email
        End Get
    End Property

    Public WriteOnly Property Age As Integer
        Set(value As Integer)
            If Not value = 0 Then
                _age = value
            End If
        End Set
    End Property

    'Automatic properties
    Public Property Location As String

    'Constructors
    Sub New()
        Console.WriteLine("We are inside an empty constructor of the Base class")
    End Sub

    Sub New(text As String)
        Console.WriteLine("We are inside a parameterized constructor of the base class")
        Console.ReadLine()
    End Sub

    'Classes' Methods
    Overridable Sub Walk()
        Console.WriteLine("This is a person walking")
        Console.ReadLine()
    End Sub

    Public Sub Delete() Implements IAnotherInterface.Delete

    End Sub

    Public Sub render() Implements IAnotherInterface.render

    End Sub
End Class

Public Class Employee ' Sub class / Child class 
    Inherits Person 'Base class/ Parent class

    'Animal class  -- Base class
    '   Dog -- Sub class
    '   Cat etc -- Sub class

    Private _salary As Integer
    Private _companyname As String

    Property Salary As String
        Get
            Return _salary
        End Get
        Set(value As String)
            _salary = value
        End Set
    End Property
    Sub New()
        Console.WriteLine("We are inside the child class constructor now")
        Console.ReadLine()
    End Sub

    Overrides Sub Walk()
        'This employee walks differently, so i want a different behaviour
        Console.WriteLine("This is an Employee walking")
        Console.ReadLine()
    End Sub

    Sub CanCode()
        'Implemntation here
        'Specific to employee
        Console.WriteLine("Inside employee's can code method")
        Console.ReadLine()
    End Sub
End Class

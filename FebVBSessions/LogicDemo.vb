Module LogicDemo
    'Logic
    '   Functions
    '       Return a value
    '   Subroutines
    '       Do not a return value

    'Lifecycle
    '   Declare
    '   Implement it (Body of the function/Subroutine)
    '   Call it from another logic block
    '   Test

    'Function Signature
    '   Name of the function
    '   Security
    '   No. of parameters
    '   Sequence of parameters
    '   Type of parameters
    '   Return Type

    Sub DoThis()
        'Body of the subroutine
    End Sub

    Sub DoThisAsWell()
        'Call a subroutine
        DoThis()

        'Call a function
        Dim Flag As Boolean
        Flag = Calculation(25, 58.0, "Ruchira")
        'Calculation("Ruchira", 12)

        Dim num As Integer
        num = Calculation(True)

    End Sub

    'Function overloading
    'Polymorphism
    Function Calculation(age As Integer, weight As Single, name As String) As Boolean
        Console.WriteLine("We are inside first implementation of calculation function")
        Console.ReadLine()

        'Conditional Statements
        'If Statements
        If age > 25 Then
            'Body of the if block
            Console.WriteLine("Hurray, the age is as expected")
        ElseIf age < 25 And weight >= 55 Then
            Console.WriteLine("Age is less than expected")
        Else
            Console.WriteLine("All the above conditions are false")
        End If
        Console.ReadLine()

        'Select case statements
        Select Case age
            Case 25
                'Some implementation
            Case 26
                'Do this
            Case 40, 45, 47
                'Implement this piece of code
            Case Else
                'Do this if above is false
        End Select

        'Nested if statements
        If name = "Ruchira" Then
            'Do this
            If age >= 25 Then
            ElseIf age = 40 Then
            End If
        End If

        'Looping Statements
        'For Loop
        For index As Integer = 1 To 10 Step 2
            'Body of the loop
            Console.WriteLine("Students in the class are " & index)
        Next
        Console.ReadLine()

        For counter = 10 To 1 Step -1
            Console.WriteLine("Now the numbers are: " & counter)
        Next
        Console.ReadLine()

        Dim Collection2 As New Collection
        For index = 1 To 10
            Collection2.Add(index)
        Next
        For Each value In Collection2
            Console.WriteLine(value)
        Next
        Console.ReadLine()

        'While Loop
        'Dim index1 As Integer = 1
        'While index1 >= 1 And age < 25
        '    'Do this
        '    Console.WriteLine("Age is " & age)
        '    index1 = index1 + 1
        '    age = age - 1
        'End While
        'Console.ReadLine()

        'Do While loops
        Do
            Console.WriteLine("This will be run atleast once, sinc the condition is checked at the end")
        Loop While age < 25
        Console.ReadLine()

        Return True
    End Function

    Function Calculation(flag As Boolean) As Integer

        Return 0
    End Function

    Function Calculation(text As String) As String
        Return "This is another way"
    End Function

    Function Calculation() As Single

        Return 10.12
    End Function

    Function MyFunc() As Integer

        Return 0
    End Function

End Module

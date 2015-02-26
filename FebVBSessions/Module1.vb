Module Module1
    Sub Main()
        'LogicDemo.DoThisAsWell()
        Module2.AddCollections()
        ''What is a Program?
        ''   Data <---> Logic (Bidirectional relationship)
        ''   Data
        ''       Variables -- Change their value
        ''          1. Native Variables (Stored on Stack)
        ''               They are fixed in size
        ''               Faster access
        ''               Need not be explicitly disposed
        ''          2. Reference Variables/Object variables (Stored on heap)
        ''               Dynamic in size
        ''               Slower
        ''               Need to be explicitly disposed       
        ''       Constants -- do not change their value
        ''   Logic

        ''Lifecycle of a variable
        ''   Declare
        ''   Assign/ Use
        ''   Dispose

        ''Declaration
        'Dim Flag As Boolean '2 bytes
        'Dim Num As Integer '4 bytes
        'Dim Precision As Single '4 bytes
        'Dim PrecDbl As Double  '8 bytes
        'Dim Accuracy As Decimal '16 bytes
        'Dim Name As String 'Size depends on the value of string variable

        ''Assignment
        'Flag = True ' Default = 0 or false
        'Num = 10
        'Precision = 0.1234567
        'PrecDbl = 0.123456789101112
        'Accuracy = 0.12345678910111213
        'Name = "Ruchira"

        ''Printing on the console window
        'Console.WriteLine("The vallue of Flag is {0}", Flag)
        'Console.WriteLine("The value of Num is {0}", Num)
        'Console.WriteLine("The value of Precision is {0}", Precision)
        'Console.WriteLine("The value of PrecDbl is {0}", PrecDbl)
        'Console.WriteLine("The value of Accuracy is (0)", Accuracy)
        'Console.WriteLine("The value of Name is {0}", Name)
        'Console.ReadLine()

        ''Integer Operations
        'Dim LeftInt As Integer
        'Dim RightInt As Integer
        'Dim SumOfIntegers As Integer
        'Dim DiffOfIntegers As Integer
        'Dim ProdOfIntegers As Integer
        'Dim DivOfIntegers As Integer
        'Dim Quotient As Integer
        'Dim Remainder As Integer

        'LeftInt = 10
        'RightInt = 20
        'SumOfIntegers = LeftInt + RightInt
        'DiffOfIntegers = RightInt - LeftInt
        'ProdOfIntegers = LeftInt * RightInt
        'DivOfIntegers = RightInt / LeftInt
        'Quotient = Math.DivRem(RightInt, LeftInt, Remainder)

        ''Printing on the console window
        'Console.WriteLine("The value of LeftInt is {0}", LeftInt)
        'Console.WriteLine("The value of RightInt is {0}", RightInt)
        'Console.WriteLine("The Sum of numbers is {0}", SumOfIntegers)
        'Console.WriteLine("The Difference of numbers is {0}", DiffOfIntegers)
        'Console.WriteLine("The Product of numbers is {0}", ProdOfIntegers)
        'Console.WriteLine("The Division of numbers is {0}", DivOfIntegers)
        'Console.WriteLine("The value of Remainder is {0} and Quotient is {1}", Remainder, Quotient)
        'Console.ReadLine()

        ''String Operations
        'Dim Message1 As String
        'Dim Message2 As String
        'Dim ResultMessage As String
        'Dim Position1 As Integer
        'Dim Position2 As Integer
        'Dim LeftString As String
        'Dim RightString As String

        'Message1 = "This is Day 1 code of VB session"
        'Message2 = " and we are confident of learning VB"

        ''Concatenation of Strings
        ''ResultMessage = Message1 + Message2 -- Use Sparingly as will falter when trying to concatenate numerals
        'ResultMessage = Message1 & Message2
        'Console.WriteLine("ResultMessage : " & ResultMessage)
        'Console.ReadLine()

        'Position1 = InStr(ResultMessage, "vb".ToUpper())
        'Position2 = InStr(Position1 + 1, ResultMessage, "VB")
        'Console.WriteLine("First occurance of VB is at {0} and second occurance at {1}", Position1, Position2)
        'Console.ReadLine()

        'LeftString = Left(ResultMessage, 14)
        'RightString = Right(ResultMessage, 25)
        'Console.WriteLine("Left Portion of the string is : " & LeftString)
        'Console.WriteLine("Right Portion of the string is : " & RightString)
        'Console.ReadLine()

        ''Conversion operations
        'Dim NewNumber As Integer
        'Dim NumberAsString As String
        'NewNumber = 10
        'NumberAsString = NewNumber.ToString()
        'NumberAsString = CStr(NewNumber)
        'Console.WriteLine("Converted number is " & NumberAsString)
        'Console.ReadLine()

        'Dim NewString As String
        'Dim StringAsNumber As Integer
        'NewString = "18"
        'StringAsNumber = CInt(NewString)
        'Console.WriteLine("Converted string is " & StringAsNumber)
        'Console.ReadLine()

        'Dim NewString2 As String
        'Dim StringAsDouble As Double
        'NewString2 = "1.79"
        'StringAsDouble = CDbl(NewString2)
        'Console.WriteLine("Converted string2 is " & StringAsDouble)
        'Console.ReadLine()

        ''Reference type Variables
        ''Declaration
        'Dim Collection1 As Collection

        '' New Keyword is necessary for instantiating an object variable
        'Collection1 = New Collection

        ''Adding items of any data type to the collection
        'Collection1.Add("Ruchira")
        'Collection1.Add("Venkat")
        'Collection1.Add("Vijay")
        'Collection1.Add(1)
        'Collection1.Add(1.98)
        'Collection1.Add(2)

        ''Retrieving an item from a collection
        ''Collections are 1-based
        'Console.WriteLine("Items in collection are {0}, {1}, {2}, {3}, {4}, {5}", Collection1.Item(1), Collection1.Item(2), Collection1.Item(3), Collection1.Item(4), Collection1.Item(5), Collection1.Item(6))
        'Console.ReadLine()

        ''Removal of an item from a collection
        'Collection1.Remove(5)
        'Console.WriteLine("New Items in the collection are {0}, {1}, {2}, {3}, {4}", Collection1.Item(1), Collection1.Item(2), Collection1.Item(3), Collection1.Item(4), Collection1.Item(5))
        'Console.ReadLine()

        ''Dispose the collection
        'Collection1 = Nothing
        ''Retrieval of an item will now throw a null pointer exception
        ''Console.WriteLine("Items in collection are {0}, {1}, {2}, {3}, {4}", Collection1.Item(1), Collection1.Item(2), Collection1.Item(3), Collection1.Item(4), Collection1.Item(5))
        ''Console.ReadLine()
    End Sub
End Module

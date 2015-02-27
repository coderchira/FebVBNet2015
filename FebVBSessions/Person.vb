Public Class Person
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

End Class

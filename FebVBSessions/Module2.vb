Module Module2
    '2 collections
    '1 collection has 10 names
    'second collection is empty
    'code such that : transfer of all the names from one collection to another 
    'except the one which has your name

    'Declared two collections
    Dim Collection1 As New Collection
    Dim Collection2 As New Collection

    Sub AddCollections()
        'Add 10 names to collection1
        Collection1.Add("Eswar")
        Collection1.Add("Namburu")
        Collection1.Add("Venkat")
        Collection1.Add("Vijay")
        Collection1.Add("Pradeep")
        Collection1.Add("Are Veni Sulochana")
        Collection1.Add("Naren")
        Collection1.Add("Naveen")
        Collection1.Add("Sindhu")
        Collection1.Add("Vignesh")

        For index = 1 To Collection1.Count
            If Collection1.Item(index) <> "Naveen" Then
                Collection2.Add(Collection1.Item(index))
            End If
        Next
        'For counter = 1 To Collection2.Count
        '    Console.WriteLine(Collection2.Item(counter))
        'Next
        For Each item In Collection2
            Console.WriteLine(item)
        Next
        Console.ReadLine()
    End Sub
End Module

Module Module1

    Sub Main()
        Dim numbers = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13, 14, 15}  
        Dim fizzbuzz = new FizzBuzz()
        For Each number As Integer In numbers
            Console.WriteLine(fizzbuzz.GetFizzOrBuzz(number))
        Next

        Console.ReadKey()
    End Sub

End Module

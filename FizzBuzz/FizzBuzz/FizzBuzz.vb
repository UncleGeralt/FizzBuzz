Public Class FizzBuzz
    Public Function  GetFizzOrBuzz(number As Integer) As String
       
        If number = 0 Then
            Return 0
        End If

        If number Mod 3 = 0 And number Mod 5 = 0 Then
            Return "FizzBuzz"
        End If

        If number Mod 3 = 0 Then
            Return "Fizz"
        ElseIf number Mod 5 = 0 Then
            Return "Buzz"
        End If
        
        

        Return number
    End Function
End Class

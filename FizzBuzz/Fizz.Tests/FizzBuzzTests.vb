Imports NUnit.Framework
Imports FizzBuzz.FizzBuzz

<TestFixture()> _
Public Class FizzBuzzTests
    <Test()> _
    Public Sub Fizz_buzz_returns_number_0()
        Dim fizzBuzz as FizzBuzz.FizzBuzz = new FizzBuzz.FizzBuzz()
        Assert.That(fizzBuzz.GetFizzOrBuzz(0), [Is].EqualTo("0"))
    End Sub

    <Test()> _
    Public Sub Fizz_buzz_returns_number_2()
        Dim fizzBuzz as FizzBuzz.FizzBuzz = new FizzBuzz.FizzBuzz()
        Assert.That(fizzBuzz.GetFizzOrBuzz(2), [Is].EqualTo("2"))
    End Sub

    
    <Test()> _
    Public Sub Fizz_buzz_returns_number_7()
        Dim fizzBuzz as FizzBuzz.FizzBuzz = new FizzBuzz.FizzBuzz()
        Assert.That(fizzBuzz.GetFizzOrBuzz(7), [Is].EqualTo("7"))
    End Sub

    <Test()> _
    Public Sub Fizz_buzz_returns_Fizz_for_3()
        Dim fizzBuzz as FizzBuzz.FizzBuzz = new FizzBuzz.FizzBuzz()
        Assert.That(fizzBuzz.GetFizzOrBuzz(3), [Is].EqualTo("Fizz"))
    End Sub

    <Test()> _
    Public Sub Fizz_buzz_returns_Buzz_for_5()
        Dim fizzBuzz as FizzBuzz.FizzBuzz = new FizzBuzz.FizzBuzz()
        Assert.That(fizzBuzz.GetFizzOrBuzz(5), [Is].EqualTo("Buzz"))
    End Sub

    
    <Test()> _
    Public Sub Fizz_buzz_returns_FizzBuzz_for_15()
        Dim fizzBuzz as FizzBuzz.FizzBuzz = new FizzBuzz.FizzBuzz()
        Assert.That(fizzBuzz.GetFizzOrBuzz(15), [Is].EqualTo("FizzBuzz"))
    End Sub

End Class

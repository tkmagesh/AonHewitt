Imports CsCollection

Module Module1

    Sub Main()
        Dim number1 As Integer, number2 As Integer, result As Integer, calculator As New Calculator

        Console.WriteLine("Enter two numbers")
        number1 = CType(Console.ReadLine, Integer)
        number2 = CType(Console.ReadLine, Integer)
        Console.WriteLine("Add = {0}", calculator.Add(number1, number2))
        Console.WriteLine("Subtract = {0}", calculator.Subtract(number1, number2))
        Console.WriteLine("Multiply = {0}", calculator.Multiply(number1, number2))
        Console.WriteLine("Divide = {0}", calculator.Divide(number1, number2))
        Console.ReadLine()
    End Sub

End Module

Imports System

Module Module1

    ''SAMPLE PRINT

    'Sub Main()
    '    Console.WriteLine("sample")
    '    Console.ReadKey()

    'End Sub



    ''SAMPLE GETTING AREA OF RECTANGLE

    'Public Class Rectangle
    '    'Declare variable length and width
    '    Private length As Double
    '    Private width As Double

    '    'Declare subclass
    '    Public Sub Value()
    '        length = 5
    '        width = 10
    '    End Sub

    '    'Declare function GetArea
    '    Public Function GetArea() As Double
    '        GetArea = length * width
    '    End Function

    '    'Display
    '    Public Sub Display()
    '        Console.WriteLine("Length: {0}", length)
    '        Console.WriteLine("Width: {0}", width)
    '        Console.WriteLine("Area: {0}", GetArea())
    '    End Sub

    'End Class
    'Sub Main()
    '    Dim r As New Rectangle()
    '    r.Value()
    '    r.Display()
    '    Console.ReadLine()
    'End Sub


    ''SIMPLE CALCULATOR

    'Public Class Calculator
    '    Private num1 As Double
    '    Private num2 As Double

    '    Public Sub Value()
    '        num1 = 5
    '        num2 = 10
    '    End Sub

    '    Public Function Add() As Double
    '        Add = num1 + num2
    '    End Function

    '    Public Function Subtract() As Double
    '        Subtract = num1 - num2
    '    End Function

    '    Public Function Multiply() As Double
    '        Multiply = num1 * num2
    '    End Function

    '    Public Function Divide() As Double
    '        Divide = num1 / num2
    '    End Function

    '    Public Function Display() As Task
    '        Console.WriteLine("Number 1: {0}", num1)
    '        Console.WriteLine("Number 2: {0}", num2)
    '        Console.WriteLine("Addition: {0}", Add())
    '        Console.WriteLine("Subtraction: {0}", Subtract())
    '        Console.WriteLine("Multiplication: {0}", Multiply())
    '        Console.WriteLine("Division: {0}", Divide())
    '    End Function

    'End Class

    'Sub Main()
    '    Dim c As New Calculator()
    '    c.Value()
    '    c.Display()
    '    Console.ReadLine()
    'End Sub

    Public Class Calculator
        Private num1 As Double
        Private num2 As Double
        Private operation As String

        Public Sub GetValue()
            Console.WriteLine("Enter Number: ")
            num1 = Convert.ToDouble(Console.ReadLine())

            Console.WriteLine("Enter Number: ")
            num2 = Convert.ToDouble(Console.ReadLine())

            Console.WriteLine("Enter Operation: ")
            operation = Convert.ToString(Console.ReadLine())
        End Sub

        Public Function Add() As Double
            Add = num1 + num2
        End Function

        Public Function Subtract() As Double
            Subtract = num1 - num2
        End Function

        Public Function Multiply() As Double
            Multiply = num1 * num2
        End Function

        Public Function Divide() As Double
            Divide = num1 / num2
        End Function

        Public Sub Display()
            Console.WriteLine("Input Operation")
            Console.WriteLine("(+) Addition ")
            Console.WriteLine("(-) Subtract ")
            Console.WriteLine("(*) Multiply ")
            Console.WriteLine("(/) Divide ")





        End Sub

    End Class

End Module

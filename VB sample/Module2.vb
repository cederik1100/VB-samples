Module Module2
    Private Class Geometry

        Public Sub choose()

            Dim continueloop As Boolean = True

            Console.WriteLine("1. Square")
            Console.WriteLine("2. Rectangle")
            Console.WriteLine("3. Triangle")
            Console.WriteLine("4. Circle")
            Console.WriteLine("5. Trapezoid")


            Do While continueloop

                Console.Write(vbNewLine & "Enter your choice: ")
                Dim choice As Integer = Convert.ToInt32(Console.ReadLine())
                If choice = 1 Then
                    Console.Write(SquareArea())
                ElseIf choice = 2 Then
                    Console.Write(RectangleArea())
                ElseIf choice = 3 Then
                    Console.Write(TriangleArea())
                ElseIf choice = 4 Then
                    Console.Write(CircleArea())
                ElseIf choice = 5 Then
                    Console.Write(TrapezoidArea())
                Else
                    Console.Write(vbNewLine & "Invalid Choice" & vbNewLine)
                End If

                Console.Write(vbNewLine & "Do you want to continue? (y/n): ")
                Dim userInput As String = Console.ReadLine().ToLower()
                If userInput = "y" Then
                    continueloop = True
                ElseIf userInput = "n" Then
                    continueloop = False
                Else
                    Console.Write("Invalid Choice")
                End If

            Loop


        End Sub

        Public Function SquareArea() As String
            Console.Write(vbNewLine & "Enter side: ")
            Dim side As Double = Convert.ToDouble(Console.ReadLine())
            Dim area As Double = side * side
            Return side & " * " & side & " = " & area & vbNewLine
        End Function

        Public Function RectangleArea() As String
            Console.Write(vbNewLine & "Enter length: ")
            Dim length As Double = Convert.ToDouble(Console.ReadLine())
            Console.Write("Enter width: ")
            Dim width As Double = Convert.ToDouble(Console.ReadLine())
            Dim area As Double = length * width
            Return length & " * " & width & " = " & area & vbNewLine
        End Function

        Public Function TriangleArea() As String
            Console.Write(vbNewLine & "Enter Base: ")
            Dim base As Double = Convert.ToDouble(Console.ReadLine())
            Console.Write("Enter Height: ")
            Dim height As Double = Convert.ToDouble(Console.ReadLine())
            Dim area As Double = 0.5 * base * height
            Return "0.5 * " & base & " * " & height & " = " & area & vbNewLine
        End Function

        Public Function CircleArea() As String
            Console.Write(vbNewLine & "Enter Radius: ")
            Dim radius As Double = Convert.ToDouble(Console.ReadLine())
            Dim area As Double = 3.14 * (radius ^ 2)
            Return "3.14 * " & "(" & radius & "^2) = " & area & vbNewLine
        End Function

        Public Function TrapezoidArea() As String
            Console.Write(vbNewLine & "Enter Base: ")
            Dim base As Double = Convert.ToDouble(Console.ReadLine())
            Console.Write("Enter Height: ")
            Dim height As Double = Convert.ToDouble(Console.ReadLine())
            Console.Write("Enter Top: ")
            Dim top As Double = Convert.ToDouble(Console.ReadLine())
            Dim area As Double = 0.5 * (base + top) * height
            Return "0.5 * (" & base & " + " & top & ") * " & height & " = " & area & vbNewLine
        End Function

    End Class

    Sub main()
        Dim g As New Geometry()
        g.choose()
        Console.ReadLine()
    End Sub

End Module

Imports System

Module Module1

    'VB.NET Consist of this parts
    '* Namespace declaration - The namespace is a container for classes and other namespaces.
    '* Class Or module - The class is a container for fields, methods, and properties. 
    '* Procedures - The procedure is a block of code that performs a specific task.
    '* Variables - The variable is a container for a value.
    '* The Main procedure - The Main procedure is the entry point of the program.
    '* Statements And Expressions - The statement is a unit of code that performs a specific task.
    '* Comments - The comment is a unit of code that performs a specific task.

    ''SAMPLE PRINT

    ' Sub Main()
    '    Console.WriteLine("sample")
    '    Console.ReadKey()

    'End Sub

    'OOP
    'Objects - The object is a container for fields, methods, and properties.
    'Classes - The class is a container for fields, methods, and properties.
    'Methods - The method is a block of code that performs a specific task.
    'Instance Variables - The instance variable is a container for a value.

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

    ''SIMPLE CALCULATOR WITH USER INPUT AND CONDITIONAL STATEMENT
    'Public Class Calculator
    '    Private num1 As Double
    '    Private num2 As Double
    '    Private operation As String

    '    Public Sub GetValue()
    '        Console.Write("Enter Number: ")
    '        num1 = Convert.ToDouble(Console.ReadLine())

    '        Console.Write("Enter Number: ")
    '        num2 = Convert.ToDouble(Console.ReadLine())

    '        Console.WriteLine(vbNewLine & "Input Operation: ")
    '        Console.WriteLine("(+) Addition ")
    '        Console.WriteLine("(-) Subtract ")
    '        Console.WriteLine("(*) Multiply ")
    '        Console.WriteLine("(/) Divide " & vbNewLine)

    '        Console.Write("Enter Operation: ")
    '        operation = Convert.ToString(Console.ReadLine())
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
    '        If num2 <> 0 Then
    '            Divide = num1 / num2
    '        Else
    '            Console.WriteLine("Cannot divide by zero")
    '        End If

    '    End Function

    '    Public Sub Display()

    '        If (operation = "+") Then
    '            Console.WriteLine("Result: {0}", Add())

    '        ElseIf (operation = "-") Then
    '            Console.WriteLine("Result: {0}", Subtract())

    '        ElseIf (operation = "*") Then
    '            Console.WriteLine("Result: {0}", Multiply())

    '        ElseIf (operation = "/") Then
    '            Console.WriteLine("Result: {0}", Divide())

    '        Else
    '            Console.WriteLine("Invalid Operation")
    '        End If





    '    End Sub

    'End Class

    'Sub main()
    '    Dim c As New Calculator()
    '    c.GetValue()
    '    c.Display()
    '    Console.ReadLine()

    'End Sub

    ' DATA TYPES
    ' integer - whole number
    ' string - text
    ' double - decimal
    ' boolean - true or false
    ' char - single character
    ' date - date and time
    ' decimal - large number
    ' objects - references to other objects

    'VARIABLE 
    'The Dim statement is used for variable declaration and storage allocation for one or more variables.
    'The Dim statement is used at module, class, structure, procedure or block level.

    'SYNTAX
    'Dim variable_name As data_type = value

    'CONSTANTS
    'refer to fixed values that the program may not alter during its execution.
    'These fixed values are also called literals.

    'ENUMERATIONS
    'The Enum statement declares an enumeration and defines the values of its members.
    'The Enum statement can be used at the module, class, structure, procedure, or block level.

    'SYNTAX
    'Enum name
    '    [member_name] = value
    '    [member_name] = value
    '    [member_name] = value
    '    [member_name] = value
    '    [member_name] = value
    '    [member_name] = value
    'End Enum

    'MODIFIERS
    'keywords added with any programming element to give some especial emphasis on how the programming element
    'will behave or will be accessed in the program.

    'PUBLIC - Accessible from any part of the program
    'PRIVATE - Accessible only from the module, class, structure, procedure, or block in which it is declared
    'PROTECTED - Accessible only from the module, class, structure, procedure, or block in which it is declared
    'STATIC - Accessible only from the module, class, structure, procedure, or block in which it is declared
    'INTERNAL - Accessible only from the module, class, structure, procedure, or block in which it is declared
    'PRIVATE STATIC - Accessible only from the module, class, structure, procedure, or block in which it is declared

    'ARITHMETIC OPERATIONS
    '+ - addition
    '- - subtraction
    '* - multiplication
    '/ - division, floating point
    '\ - integer division
    '% - modulus
    '++ - increment
    '-- - decrement
    '^ - exponent

    'COMPARISON OPERATORS
    '== - equal to
    '!= <> - not equal to
    '> - greater than
    '< - less than
    '>= - greater than or equal to
    '<= - less than or equal to

    'LOGICAL OPERATORS
    '&& - and
    '|| - or
    '! - not

    'ASSIGNMENT OPERATORS
    '+= - addition
    '-= - subtraction
    '*= - multiplication
    '/= - division
    '\= - integer division
    '%= - modulus
    '<<= - left shift
    '>>= - right shift

    'DECISION MAKING 
    'IF - this statement is used to execute a block of code if a specified condition is true.
    'syntx: 
    'IF (condition) THEN
    '    statement
    'END IF


    'ELSE - this statement is used to execute a block of code if a specified condition is false.
    'syntx:
    'IF (condition) THEN
    '    statement
    'ELSE
    '    statement
    'END IF

    'ELSEIF - this statement is used to execute a block of code if a specified condition is false.
    'syntx:
    'IF (condition) THEN
    '    statement
    'ELSEIF (condition) THEN
    '    statement
    'ELSE
    '    statement
    'END IF

    'SWITCH - this statement is used to execute a block of code based on different cases.
    'CASE - this statement is used to execute a block of code if a specified condition is true.
    'DEFAULT - this statement is used to execute a block of code if no case is true.
    'syntx:
    'SELECT CASE (expression)
    'CASE value1
    '    statement
    'CASE value2
    '    statement
    'CASE value3
    '    statement
    'DEFAULT
    '    statement
    'END SELECT

    'END SELECT - this statement is used to end a block of code.
    'END IF - this statement is used to end a block of code.


    'LOOPING
    'WHILE - this statement is used to execute a block of code while a specified condition is true.
    'syntx:
    'WHILE (condition) LOOP
    '    statement
    'END WHILE

    'DO - this statement is used to execute a block of code while a specified condition is true.
    'syntx:
    'DO
    '    statement
    'LOOP WHILE (condition)

    'FOR - this statement is used to execute a block of code for a specified number of times.
    'syntx:
    'FOR i = 1 TO 10
    '    statement
    'NEXT i

    'FOR EACH - this statement is used to execute a block of code for each element in an array.
    'syntx:
    'FOR EACH item IN array
    '    statement
    'NEXT item

    'BREAK - this statement Is used to exit a loop Or switch statement.
    'CONTINUE - this statement Is used to skip the current iteration of a loop And continue with the next iteration.
    'EXIT - this statement Is used to exit a loop Or switch statement.

    'ARRAYS - this is used to store multiple values in a single variable.
    'syntx:
    '    Dim intData() As Integer = {12, 16, 20, 24, 28, 32}
    '    Dim names() As String = {"Karthik", "Sandhya", "Shivangi", "Ashwitha", "Somnath"}
    '    Dim miscData() As Object = {"Hello World", 12D, 16UI, "A"c}


    'SAMPLE OF GETTING ARE OF CIRCLE USING LOOP
    'Public Class Circle
    '    Dim radius As Double
    '    Dim PI As Double = 3.14
    '    Dim continueloop As Boolean = True

    '    Public Sub Value()
    '        Do While continueloop
    '            Console.Write("Enter Radius: ")
    '            radius = Convert.ToDouble(Console.ReadLine())

    '            Console.WriteLine("Area: {0}", PI * (radius ^ 2))

    '            Console.WriteLine("Do you want to continue? (y/n): ")
    '            If Console.ReadLine() = "n" Then
    '                continueloop = False
    '            End If
    '        Loop
    '    End Sub

    'End Class

    'Sub main()
    '    Dim C As New Circle()
    '    C.Value()
    '    Console.ReadLine()
    'End Sub


    'SAMPLE OF PRINTING A TRIANGLE PATTERN  
    'Sub Main()
    '    Console.Write("Enter the number of rows for the triangle: ")
    '    Dim n As Integer = Convert.ToInt32(Console.ReadLine())

    '    ' Loop through rows
    '    For i As Integer = 1 To n
    '        ' Print stars in each row
    '        For j As Integer = 1 To i
    '            Console.Write("*")
    '        Next

    '        ' Move to the next line after each row
    '        Console.WriteLine()
    '    Next

    '    Console.ReadLine()
    'End Sub

    'SAMPLE OF PRINTING ARRAYS
    'Sub main()
    '    Dim intdata() As Integer = {1, 2, 3, 4, 5}

    '    For i As Integer = 0 To intdata.Length - 1
    '        Console.WriteLine(intdata(i))
    '    Next
    'End Sub


End Module

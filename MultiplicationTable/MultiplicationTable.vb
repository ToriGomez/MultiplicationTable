'Tori Gomez
'RCET0265
'Spring 2021
'Multiplication Table
'


Option Strict On
Option Explicit On
Option Compare Binary

Module MultiplicationTable

    Sub Main()
        Dim userInput As String

        Console.WriteLine("Welcome to Multiplication Table!")
        Console.WriteLine("Enter full number to see Multiplication chart of that number.")
        userInput = Console.ReadLine()

        For i = 1 To CInt(userInput)
            For j = 1 To CInt(userInput)
                Console.Write(CStr(i * j) + vbTab)
            Next
            Console.WriteLine(vbNewLine)
        Next

        Console.ReadLine()
    End Sub

End Module

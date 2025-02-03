'Malachi Marlow
'Spring 2025
'RCET2265
'Better Calculator
'https://github.com/MalachiMarlow/evilcalculator.git

Option Explicit On
Option Strict On
Option Compare Text
Module evilcalculator

    Sub Main()

        Dim userInput As String
        Dim getoutofhere As Boolean = False
        Dim fNumber As Integer
        Dim sNumber As Integer

        Do
            Do Until userInput = "Q" Or getoutofhere = True
                Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")
                userInput = Console.ReadLine
                Console.WriteLine($"You entered {userInput}")

                Try
                    fNumber = CInt(userInput)
                    getoutofhere = True

                Catch ex As Exception

                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not a whole number.")
                    Else
                        getoutofhere = True

                    End If
                End Try
            Loop

            getoutofhere = False
            Do Until userInput = "Q" Or getoutofhere = True
                userInput = Console.ReadLine
                Console.WriteLine($"You entered {userInput}")

                Try
                    fNumber = CInt(userInput)
                    getoutofhere = True

                Catch ex As Exception

                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not a whole number.")
                    Else
                        getoutofhere = True

                    End If
                End Try
            Loop

            getoutofhere = False
            Do Until userInput = "Q" Or getoutofhere = True
                Console.WriteLine("Select One." & vbNewLine _
                         & "1. Add" & vbNewLine _
                         & "2. Subtract" & vbNewLine _
                         & "3. Multiply" & vbNewLine _
                         & "4. Divide")
                userInput = Console.ReadLine
                If userInput = "1" Then
                    getoutofhere = True
                    Console.WriteLine($"{fNumber} + {sNumber} = {fNumber + sNumber}")
                ElseIf userInput = "2" Then
                    getoutofhere = True
                    Console.WriteLine($"{fNumber} - {sNumber} = {fNumber - sNumber}")
                ElseIf userInput = "3" Then
                    getoutofhere = True
                    Console.WriteLine($"{fNumber} * {sNumber} = {fNumber * sNumber}")
                ElseIf userInput = "4" Then
                    getoutofhere = True
                    Console.WriteLine($"{fNumber} / {sNumber} = {fNumber / sNumber}")
                Else
                    Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                End If
            Loop
            getoutofhere = False


        Loop Until userInput = "Q"
            Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")

    End Sub

End Module

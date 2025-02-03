Module evilcalculator

    Sub Main()

        Dim userInput As String
        Dim getoutofhere As Boolean = False
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        Do
            Do
                Console.WriteLine("Please enter two numbers.")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine
                Console.WriteLine($"You entered {userInput}")

                Try
                    firstNumber = CInt(userInput)
                    getoutofhere = True

                Catch ex As Exception

                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not a whole number.")
                    Else
                        getoutofhere = True

                    End If
                End Try
            Loop Until getoutofhere = True OrElse userInput <> "Q"

            getoutofhere = False
            Do While userInput <> "Q" And getoutofhere = False
                Console.WriteLine("Enter a second number")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine
                Console.WriteLine($"You entered {userInput}")

                Try
                    secondNumber = CInt(userInput)
                    getoutofhere = True

                Catch ex As Exception

                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not a whole number.")
                    Else
                        getoutofhere = True

                    End If
                End Try
            Loop

            Console.WriteLine("Select One." & vbNewLine _
                         & "1. Add" & vbNewLine _
                         & "2. Subtract" & vbNewLine _
                         & "3. Multiply" & vbNewLine _
                         & "4. Divide")
            userInput = Console.ReadLine
            If userInput = "1" Then
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
            ElseIf userInput = "2" Then
                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
            ElseIf userInput = "3" Then
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
            ElseIf userInput = "4" Then
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
            Else
                Console.WriteLine($"You entered {userInput}, please enter a whole number.")
            End If


        Loop While userInput <> "Q"
        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")

    End Sub

End Module

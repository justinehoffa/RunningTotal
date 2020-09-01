Option Strict On
Option Explicit On
Option Compare Text

'Justine Hoffa
'RCET0265
'Fall 2020
'Running Total
'https://github.com/justinehoffa/RunningTotal

Module RunningTotal

    Sub Main()
        Dim userInput As String = ""
        Dim runningTotal As Decimal
        Const TAXRATE As Decimal = 0.06D
        Dim taxAmount As Decimal
        Dim badData As Boolean = True

        While userInput <> "q"

            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item")
            Console.WriteLine("2. Calculate Tax")

            'User Choice
            userInput = Console.ReadLine()


            If userInput = "1" Then
                Do
                    Console.WriteLine("Enter the item cost.")
                    userInput = Console.ReadLine()

                    Try
                        'runningTotal = runningTotal + CDec(userInput)
                        runningTotal += CDec(userInput)
                        badData = False
                    Catch ex As Exception
                        'promit user to give good data
                        Console.WriteLine("Item cost must be a number.")
                        badData = True
                    End Try
                Loop While badData

                Console.WriteLine("Total: " & runningTotal.ToString("C"))

            ElseIf userInput = "2" Then
                taxAmount = runningTotal * TAXRATE
                Console.WriteLine("Tax: " & taxAmount.ToString("C"))
            Else
                'catch all. bad choice
            End If

            Console.ReadLine()
        End While




    End Sub

End Module

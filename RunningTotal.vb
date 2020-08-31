Option Strict On
Option Explicit On

'Justine Hoffa
'RCET0265
'Fall 2020

Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Integer
        Const TAXRATE As Decimal = 0.06D

        While userInput <> "q"

            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item")
            Console.WriteLine("2. Calculate Tax")

            'User Choice???
            userInput = Console.ReadLine()


            If userInput = "1" Then
                Console.WriteLine("Enter the item cost.")
                userInput = Console.ReadLine()

                Try
                    'runningTotal = runningTotal + Cint(userInput)
                    runningTotal = CInt(userInput)
                Catch ex As Exception
                    'promit user to give good data
                End Try
                Console.WriteLine("Total: " & runningTotal)

            ElseIf userInput = "2" Then
                Console.WriteLine("Tax: " & runningTotal * TAXRATE)
            Else
                'prompt user for good data
            End If

            Console.ReadLine()
        End While




    End Sub

End Module

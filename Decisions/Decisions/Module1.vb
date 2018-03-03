Module Module1

    Sub Main()
        'Console.WriteLine("Please Type Something and Enter")
        'Dim uservalue As String
        'uservalue = Console.ReadLine()
        'Console.WriteLine("You Typed:" & uservalue)
        'Console.ReadLine()


        Console.WriteLine("Would you prefer what is behind door number 1,2 or 3?")
        Dim uservalue As String = Console.ReadLine()
        'If uservalue = "1" Then
        '    Console.WriteLine("You won a car")
        '    Console.ReadLine()
        'ElseIf uservalue = "2" Then
        '    Console.WriteLine("You won a boat")
        '    Console.ReadLine()
        'ElseIf uservalue = "3" Then
        '    Console.WriteLine()
        '    Console.ReadLine()
        'Else
        '    Console.WriteLine("Sorry,We did not understand your response..........")
        '    Console.ReadLine()


        'End If

        'can be coded using a string 

        Dim choices As String = "so much"
        Dim message As String = IIf(uservalue = "1", "pen", "Camel")
        Console.WriteLine("You have {2} and you  picked up :{1}...so you won a {0}", message, uservalue, choices)






        Console.ReadLine()




    End Sub

End Module

Imports System

Module Module1

    Sub Main()
        Dim order As String
        Do




            Console.WriteLine("                                             Welcome to Owais' Coffee Shop")
            Console.WriteLine("                                            Serving Fresh Coffee since 1972") 'this is the slogan of the coffee shop

            Dim address As String
            Dim numOrder As Integer
            Dim complain As String
            Dim newAmount As Single
            Dim goodService As Boolean
            Dim cost(0 To 4) As Single
            Dim age As Char
            Dim moneyPaid As Single
            Dim change As Single
            Dim maths As String
            Dim funFact As String
            Dim answer As String
            Const vat As Single = 1.2
            Dim ARNnumber As String
            Dim birthMonth As String
            Dim firstName As String
            Dim surname As String
            Dim dayOfBirth As String
            Dim upperFname As String
            Dim upperSname As String
            Dim password As String
            Dim customerTitle As String
            Dim counter As Integer
            Dim ans1, number As Integer
            Dim code(0 To 5) As String
            Dim counter1 As Integer
            Dim index As Integer
            Dim whippedCream As String
            Dim index1 As Integer
            Dim totalCost As Single
            Dim index2 As Integer
            Dim quant(0 To 4) As Integer
            Dim Numvat As Single
            Dim Newcost As Single

            index2 = -1
            index1 = -1
            index = -1
            Do
                counter = 0

                Console.WriteLine("What is your first name? ")
                firstName = Console.ReadLine()
            Loop Until firstName.Length > 0 And firstName.Length < 20 And firstName <> "" ' A length check so customer name can be nothing or more than 20 characters
            Do
                Console.WriteLine("What is your surname?")
                surname = Console.ReadLine
            Loop Until surname.Length > 0 And surname.Length < 20 And surname <> "" ' a presence check so users first name cant be blank
            Do
            
                Console.WriteLine("Please choose a title from : Mr, Mrs, Miss, Or Dr")
                customerTitle = UCase(Console.ReadLine()) ' makes the code more robust as its not going to do something different because of any upper/lower case letters as it changing it to upper which follows my code

' a lookup/list check which wont let the user out of the loop untill they pick one of the options from the list presented

Loop Until customerTitle = "MR" Or customerTitle = "MRS" Or customerTitle = "MISS" Or customerTitle = "DR"




            


            Console.WriteLine("Welcome to Owais' Coffee Shop, " & firstName & " " & surname)
            Do

Console.WriteLine("What is the Master Password")
                password = UCase(Console.Readline())
                If password <> "COMPUTING10" Then Console.WriteLine("Incorrect Password")

                If password <> "COMPUTING10" Then counter = counter + 1


            Loop Until password = "COMPUTING10"


            Console.WriteLine("Correct")
            Do
                Console.WriteLine("Please enter your home address for delivery")
                address = Console.ReadLine()
            
            Loop Until address.Length > 6
            
            Do
                Console.WriteLine("Please enter your birth month in number form e.g 09 for september")
                birthMonth = LCase(Console.ReadLine())


                Console.WriteLine("Please enter your day of birth e.g 01 for the 1st")
                dayOfBirth = LCase(Console.ReadLine())

                If birthMonth.Length <> 2 Or dayOfBirth.Length <> 2 Then Console.WriteLine("Please enter your day of birth and birth month correctly")

            Loop While birthMonth.Length <> 2 Or dayOfBirth.Length <> 2




            Console.WriteLine("Thank you, Now please press spacebar to order")
            Console.ReadKey()
            Console.WriteLine("") 'This leaves an empty line

            Console.WriteLine("                                          Owais' Menu")
            Console.WriteLine("")
            Console.WriteLine("      :       Coffee & Iced    :                                  :        Espresso        :") ' there are seperate sections as its visually better for the user to look at and dosent allow any confusion
            Console.WriteLine("    ")
            Console.WriteLine("         Regular Coffee  $1.40                                    Americano            $2.50")
            Console.WriteLine("         Black Coffee    $1.90                                    Latte                $3.50")
            Console.WriteLine("         Iced tea        $0.90                                    Mocha                $4.00")
            Console.WriteLine("         Iced Coffee     $1.40                                    Cappucciano          $3.50")

            Console.WriteLine("")
            Console.WriteLine("      :     Speciality Drinks   :                                :         Sandwiches      :")
            Console.WriteLine("")
            Console.WriteLine("         Tea              $0.90                                   Tuna Mayo            $2.40 ")
            Console.WriteLine("         Hot Chocolate    $1.20                                   Egg & Cheese         $1.90")
            Console.WriteLine("         Chai Latte       $1.20                                   Egg Salad            $1.20")
            Console.WriteLine("         Vanilla Smoothie $1.30                                   Chicken              $1.50")

            Console.WriteLine("*whipped cream is only offered on a single hot chocolate order and for FREE*")
            Console.WriteLine()

            Do
                Console.WriteLine("How many different items would you like to order, please choose a number between 1 and 5 ")
                numOrder = Console.ReadLine()
            Loop Until numOrder <= 5 And numOrder > 0



            For numOrder = 0 To numOrder

                index = index + 1
                index1 = index1 + 1
                index2 = index2 + 1
                Do
                    Console.WriteLine("What is the name of the item you want to order?")
                    code(index) = UCase(Console.ReadLine())
                    'assign a price to whatever item the user inputs
                    If code(index) = "REGULAR COFFEE" Then
                        cost(index1) = 1.4
                    ElseIf code(index) = "BLACK COFFEE" Then
                        cost(index1) = 1.9
                    ElseIf code(index) = "ICED TEA" Then
                        cost(index1) = 0.9
                    ElseIf code(index) = "ICED COFFEE" Then
                        cost(index1) = 1.4
                    ElseIf code(index) = "TUNA MAYO" Then
                        cost(index1) = 2.4
                    ElseIf code(index) = "EGG & CHEESE" Then
                        cost(index1) = 1.9
                    ElseIf code(index) = "EGG SALAD" Then
                        cost(index1) = 1.2
                    ElseIf code(index) = "CHICKEN" Then
                        cost(index1) = 1.5
                    ElseIf code(index) = "TEA" Then
                        cost(index1) = 0.9
                    ElseIf code(index) = "HOT CHOCOLATE" Then
                        cost(index1) = 1.2
                        Console.WriteLine("Do you also want whipped cream with that Yes or No?")
                        whippedCream = Console.ReadLine()
                    ElseIf code(index) = "CHAI LATTE" Then
                        cost(index1) = 1.2
                    ElseIf code(index) = "VANILLA SMOOTHIE" Then
                        cost(index1) = 1.3
                    ElseIf code(index) = "CAPPUCCIANO" Then
                        cost(index1) = 3.5
                    ElseIf code(index) = "MOCHA" Then
                        cost(index1) = 4
                    ElseIf code(index) = "AMERICANO" Then
                        cost(index1) = 2.5
                    ElseIf code(index) = "LATTE" Then
                        cost(index1) = 3.5

                    End If


                    If code(index) = "CHICKEN" Or code(index) = "REGULAR COFFEE" Or code(index) = "ICED TEA" Or code(index) = "ICED COFFEE" Or code(index) = "TUNA MAYO" Or code(index) = "EGG & CHEESE" Or code(index) = "EGG SALAD" Or code(index) = "CHICKEN" Or code(index) = "TEA" Or code(index) = "HOT CHOCOLATE" Or code(index) = "CHAI LATTE" Or code(index) = "VANILLA SMOOTHIE" Or code(index) = "AMERICANO" Or code(index) = "LATTE" Or code(index) = "MOCHA" Or code(index) = "CAPPUCCIANO" Then


                        Console.WriteLine("What is the quantity of the item you would Like To order")
                        quant(index2) = Console.ReadLine()
                        Do
                            If quant(index2) > 5 Then
                                Console.WriteLine("Please enter a number between 1 and 5")
                                quant(index2) = Console.ReadLine()
                            End If
                        Loop Until quant(index2) < 5
                    Else
                        Console.WriteLine("This is not an item from the menu")
                    End If

                Loop Until code(index) = "CHICKEN" Or code(index) = "REGULAR COFFEE" Or code(index) = "ICED TEA" Or code(index) = "ICED COFFEE" Or code(index) = "TUNA MAYO" Or code(index) = "EGG & CHEESE" Or code(index) = "EGG SALAD" Or code(index) = "CHICKEN" Or code(index) = "TEA" Or code(index) = "HOT CHOCOLATE" Or code(index) = "CHAI LATTE" Or code(index) = "VANILLA SMOOTHIE" Or code(index) = "AMERICANO" Or code(index) = "LATTE" Or code(index) = "MOCHA" Or code(index) = "CAPPUCCIANO"




            Next



            'calculates cost of the total order
            If numOrder = 1 Then
                totalCost = cost(0) * quant(0)
            ElseIf numOrder = 2 Then
                totalCost = cost(0) * quant(0) + cost(1) * quant(1)
            ElseIf numOrder = 3 Then
                totalCost = cost(0) * quant(0) + cost(1) * quant(1) + cost(2) * quant(2)
            ElseIf numOrder = 4 Then
                totalCost = cost(0) * quant(0) + cost(1) * quant(1) + cost(2) * quant(2) + cost(3) * quant(3)
            ElseIf numOrder = 5 Then
                totalCost = cost(0) * quant(0) + cost(1) * quant(1) + cost(2) * quant(2) + cost(3) * quant(3) + cost(4) * quant(4)
            End If




            Numvat = totalCost * 0.2 ' calculates the amount of vat they will have to pay
            Newcost = totalCost * vat 'calculates the total cost along with vat
            Console.WriteLine("How much money would you Like To pay, Please note you will be charged " & Format(Numvat, "currency") & " extra For VAT")
            moneyPaid = Console.ReadLine()
            
            
            Do 
            If moneyPaid < Newcost Then
                
  Console.WriteLine("You have Not paid enough money to cover the cost of your order. Please enter a New amount you would Like to pay")
                newAmount = Console.ReadLine()
                moneyPaid = newAmount
                End if
                
            Loop Until moneyPaid < Newcost

            

            change = moneyPaid - Newcost


            ARNnumber = LCase(Mid(firstName, 1, 1) & surname & dayOfBirth & birthMonth)
            upperFname = UCase(firstName)
            upperSname = UCase(surname)

            Console.WriteLine("              ") ' the reciept
            Console.WriteLine("                          Here Is your Reciept      ")
            Console.WriteLine("                                             ")
            Console.WriteLine("                           Owais'Coffee shop        ")
            Console.WriteLine("                    Serving fresh Coffee since 1972")
            Console.WriteLine("                       TELEPHONE - 07876491037    ")
            Console.WriteLine("                         www.owaiscoffee.com       ")
            Console.WriteLine()


            Console.WriteLine("                  Customer name                        " & upperFname & " " & upperSname)
            Console.WriteLine("                  Number of different items ordered    " & numOrder)
            Console.WriteLine("                  Cost of order                        " & Format(Newcost, "currency"))
            Console.WriteLine("                  Change                               " & Format(change, "currency")) ' this converts the change into currency to make it easier for the user to read their reciept
            For counter1 = 0 To numOrder - 1
                Console.WriteLine("                  Order name                           " & code(counter1) & " x " & quant(counter1))
            Next

            Console.WriteLine("                  Account reference number             " & ARNnumber)

            Console.WriteLine("")

            Console.WriteLine("'This website has good service True or False'")
            goodService = UCase(Console.ReadLine())

            If goodService = "TRUE" Then ' makes the code more robust as the case the user inputs in dosent matter
                goodService = True
                Console.WriteLine("Thank you we appreciate your feedback")
                Console.ReadLine()



            ElseIf goodService = "FALSE" Then
                goodService = False
                Console.WriteLine("I'm sorry you feel this way what complaints do you have about this website?")
                complain = Console.ReadLine()
                Console.WriteLine("Thank you for your feedback we will take this into consideration")
                Console.ReadLine()
            End If

            Console.WriteLine("Type a number between 1 to 3 to see a fun fact or anything else of not")
            funFact = Console.ReadLine()

            ' gives the user a funfact depending on the question they choose
            Select Case funFact
                Case 1
                    Console.WriteLine("The 20th of March is Snowman Burning Day")
                Case 2
                    Console.WriteLine("Bananas are curved because they grow towards the sun.")
                Case 3
                    Console.WriteLine("Tennis players are Not allowed To swear When they are playing In Wimbledon")
                Case < 1
                    Console.WriteLine("no facts available for this number")
                Case > 3
                    Console.WriteLine("no facts available for this number")


            End Select
            Console.WriteLine("type 1 if you want a quick maths question or anything else if not")
            maths = Console.ReadLine()
            Select Case maths
                Case 1 'only if the user enters 1 will they be asked this maths question
                    Console.WriteLine("What is [10 x -1] - 1 ")
                    answer = Console.ReadLine()


                    If answer = (Not 10) Then
                        Console.WriteLine("Correct")
                        Console.ReadLine()
                    Else
                        Console.WriteLine("False, it is - 11, better luck next time")
                        Console.ReadLine()
                    End If
            End Select

            For counter1 = 0 To 2

                Console.WriteLine("Guess a number between 1 to 10 for a chance at 10% off your delivery, you have 3 tries")
                ans1 = Console.ReadLine()
                number = CInt((Rnd() * 10) + 1)

                If number = ans1 Then
                    Console.WriteLine("Congrats you have 10% off your delivery")
                Else
                    Console.WriteLine("Incorrect")
                End If
            Next


            Console.WriteLine("Thanks for shopping here have a good day")
            Console.ReadLine()
            Console.Clear() ' this clears the screan in prepartion for the next customer
            Console.WriteLine("Is there another customer order Yes or No?")
            order = UCase(Console.ReadLine)
            Console.Clear()


        Loop Until order <> "YES" ' this will repatedly loop the code until theres not another order

    End Sub

End Module

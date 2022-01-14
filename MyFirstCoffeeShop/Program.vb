Imports System

Module Module1


    Structure Coffee 'creates a record
        Dim orderName As String
        Dim orderQuantity As Integer
        Dim orderPrice As Single
    End Structure

    Sub Main()
        Dim order As String

        Do
            Console.WriteLine("                                             Welcome to Owais' Coffee Shop")
            Console.WriteLine("                                            Serving Fresh Coffee since 1972") 'this is the slogan of the coffee shop
            Dim orderLine(0 To 5) As Coffee 'creates an array of records
            Dim address As String
            Dim numOrder As Integer
            Dim complain As String
            Dim newAmount As Single
            Dim goodService As Boolean
            Dim cost As Single
            Dim age As Char
            Dim moneyPaid As Single
            Dim change As Single
            Dim maths As String
            Dim funfact As String
            Dim answer As String
            Const vat As Single = 1.2 'vat is 1.2 throughout the whole program
            Dim ARNnumber As String
            Dim birthMonth As String
            Dim firstName As String
            Dim surName As String
            Dim dayOfBirth As String
            Dim counter3 As Integer
            Dim upperFname As String
            Dim upperSname As String
            Dim password As String
            Dim customerTitle As String
            Dim counter As Integer
            Dim ans1, number As Integer
            Dim index As Integer
            Dim num As Integer
            Dim orderNumber As Integer
            Dim ind As Integer
            Dim index1 As Integer
            Dim newCost As Single
            Dim numVat As Single

            counter3 = 0
            ind = 0
            index = 0
            orderNumber = -1 'assigned as -1 so when it increments it is stored in element 0 in the array 

            Do
                counter = 0

                Console.WriteLine("What is your first name? ")
                firstName = Console.ReadLine()
            Loop Until firstName.Length > 0 And firstName.Length < 20 And firstName <> "" ' A length check so customer name can be nothing or more than 20 characters
            Do
                Console.WriteLine("What is your surname?")
                surName = Console.ReadLine
            Loop Until surName.Length > 0 And surName.Length < 20 And surName <> "" ' a presence check so users first name cant be blank
            Do
                Console.WriteLine("Please choose a title from : Mr, Mrs, Miss, Or Dr")
                customerTitle = UCase(Console.ReadLine()) ' makes the code more robust as its not going to do something different because of any upper/lower case letters as it changing it to upper which follows my code

                If customerTitle <> "MR" And age <> "MRS" And age <> "MISS" And age <> "DR" Then ' a lookup/list check which wont let the user out of the loop untill they pick one of the options from the list presented

                End If


            Loop Until customerTitle = "MR" Or customerTitle = "MRS" Or customerTitle = "MISS" Or customerTitle = "DR"


            Console.WriteLine("Welcome to Owais' Coffee Shop, " & firstName & " " & surName)
            Do

                Console.WriteLine("Please enter the Master Password to continue to the main menu")
                password = UCase(Console.ReadLine())
                If password <> "COMPUTING10" Then Console.WriteLine("Incorrect Password")

                If password <> "COMPUTING10" Then counter = counter + 1
                If counter = 10 Then ' at 10 incorrect attempts the code will end
                    End
                End If

            Loop Until password = "COMPUTING10"


            Console.WriteLine("Correct")
            Do
                Console.WriteLine("Please enter your home address for delivery")
                address = Console.ReadLine()
            Loop Until address.Length > 6 'does not allow an address less than 7 characters long
            Do
                Console.WriteLine("For legal purposes, If you are 18 or above please type 'Y' if not please type 'N' ")
                age = UCase(Console.ReadLine())

                If age <> "N" And age <> "Y" Then
                    Console.WriteLine("Please enter Y or N")

                End If



            Loop Until age = "Y" Or age = "N"
            Do
                Console.WriteLine("Please enter your birth month in number form e.g 09 for september")
                birthMonth = LCase(Console.ReadLine())


                Console.WriteLine("Please enter your day of birth e.g 01 for the 1st")
                dayOfBirth = LCase(Console.ReadLine()) 'converts the day of birth to lowercase

                If birthMonth.Length <> 2 Or dayOfBirth.Length <> 2 Then Console.WriteLine("Please enter your day of birth and birth month correctly")

            Loop While birthMonth.Length <> 2 Or dayOfBirth.Length <> 2




            Console.WriteLine("Thank you, Now please press spacebar to order")
            Console.ReadKey()
            Console.WriteLine("") 'This leaves an empty line
            'displays menu to user
            Console.WriteLine("                                          Owais' Menu")
            Console.WriteLine("")
            Console.WriteLine("      :      Coffee & Iced    :                                  :        Espresso        :") ' there are seperate sections as its visually better for the user to look at and dosent allow any confusion
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
                Console.WriteLine("How many items would you like to order, please note you cannot order more then 5 unique items")
                numOrder = Console.ReadLine()
            Loop Until numOrder <= 5 And numOrder > 0 'user must order betwen 1 and 5 items

            For num = 0 To numOrder - 1

                Do ' this loop is put after the for loop so if a user enters an incorrect name it will not use up a spot on the for loop so it will only loop when a item from the menu has been input
                    If counter3 = 1 Then
                        Console.WriteLine("Thank you, Enter the name of another item you would like from the menu:")

                    Else
                        Console.WriteLine("Enter the name of one of the items you would like from the menu:")
                    End If
                    orderLine(num).orderName = UCase(Console.ReadLine())
                        counter3 = 1
                        'assigns a price to each item from the menu the users inputs
                        If orderLine(num).orderName = "ICED TEA" Then
                        orderLine(num).orderPrice = 0.9
                    ElseIf orderLine(num).orderName = "REGULAR COFFEE" Then
                        orderLine(num).orderPrice = 1.4
                    ElseIf orderLine(num).orderName = "BLACK COFFEE" Then
                        orderLine(num).orderPrice = 1.9
                    ElseIf orderLine(num).orderName = "ICED COFFEE" Then
                        orderLine(num).orderPrice = 1.4
                    ElseIf orderLine(num).orderName = "TUNA MAYO" Then
                        orderLine(num).orderPrice = 2.4
                    ElseIf orderLine(num).orderName = "EGG & CHEESE" Then
                        orderLine(num).orderPrice = 1.9
                    ElseIf orderLine(num).orderName = "EGG SALAD" Then
                        orderLine(num).orderPrice = 1.2
                    ElseIf orderLine(num).orderName = "CHICKEN" Then
                        orderLine(num).orderPrice = 1.5
                    ElseIf orderLine(num).orderName = "TEA" Then
                        orderLine(num).orderPrice = 0.9
                    ElseIf orderLine(num).orderName = "HOT CHOCOLATE" Then
                        orderLine(num).orderPrice = 1.2
                    ElseIf orderLine(num).orderName = "CHAI LATTE" Then
                        orderLine(num).orderPrice = 1.2
                    ElseIf orderLine(num).orderName = "VANILLA SMOOTHIE" Then
                        orderLine(num).orderPrice = 1.3
                    ElseIf orderLine(num).orderName = "AMERICANO" Then
                        orderLine(num).orderPrice = 2.5
                    ElseIf orderLine(num).orderName = "LATTE" Then
                        orderLine(num).orderPrice = 3.5
                    ElseIf orderLine(num).orderName = "MOCHA" Then
                        orderLine(num).orderPrice = 4
                    ElseIf orderLine(num).orderName = "Cappucciano" Then
                        orderLine(num).orderPrice = 3.5

                    End If
                    If orderLine(num).orderName = "Cappucciano" Or orderLine(num).orderName = "TEA" Or orderLine(num).orderName = "MOCHA" Or orderLine(num).orderName = "LATTE" Or orderLine(num).orderName = "AMERICANO" Or orderLine(num).orderName = "HOT CHOCOLATE" Or orderLine(num).orderName = "CHAI LATTE" Or orderLine(num).orderName = "VANILLA SMOOTHIE" Or orderLine(num).orderName = "REGULAR COFFEE" Or orderLine(num).orderName = "BLACK COFFEE" Or orderLine(num).orderName = "ICED TEA" Or orderLine(num).orderName = "ICED COFFEE" Or orderLine(num).orderName = "TUNA MAYO" Or orderLine(num).orderName = "EGG & CHEESE" Or orderLine(num).orderName = "EGG SALAD" Or orderLine(num).orderName = "CHICKEN" Then
                        Console.WriteLine("What is the quantity of the item you want to order?")
                        orderLine(num).orderQuantity = Console.ReadLine()
                        Do
                            If orderLine(num).orderQuantity > 5 Then
                                Console.WriteLine("Please enter a number between 1 and 5")
                                orderLine(num).orderQuantity = Console.ReadLine()
                            End If
                        Loop Until orderLine(num).orderQuantity <= 5
                    Else
                        Console.WriteLine("This is not an item from the menu")
                    End If
                Loop Until orderLine(num).orderName = "Cappucciano" Or orderLine(num).orderName = "TEA" Or orderLine(num).orderName = "MOCHA" Or orderLine(num).orderName = "LATTE" Or orderLine(num).orderName = "AMERICANO" Or orderLine(num).orderName = "HOT CHOCOLATE" Or orderLine(num).orderName = "CHAI LATTE" Or orderLine(num).orderName = "VANILLA SMOOTHIE" Or orderLine(num).orderName = "REGULAR COFFEE" Or orderLine(num).orderName = "BLACK COFFEE" Or orderLine(num).orderName = "ICED TEA" Or orderLine(num).orderName = "ICED COFFEE" Or orderLine(num).orderName = "TUNA MAYO" Or orderLine(num).orderName = "EGG & CHEESE" Or orderLine(num).orderName = "EGG SALAD" Or orderLine(num).orderName = "CHICKEN"

            Next
            ' calculates cost of order
            If numOrder = 1 Then
                cost = orderLine(0).orderPrice * orderLine(0).orderQuantity
            ElseIf numOrder = 2 Then
                cost = orderLine(0).orderPrice * orderLine(0).orderQuantity + orderLine(1).orderPrice * orderLine(1).orderQuantity
            ElseIf numOrder = 3 Then
                cost = orderLine(0).orderPrice * orderLine(0).orderQuantity + orderLine(1).orderPrice * orderLine(1).orderQuantity + orderLine(2).orderPrice * orderLine(2).orderQuantity
            ElseIf numOrder = 4 Then
                cost = orderLine(0).orderPrice * orderLine(0).orderQuantity + orderLine(1).orderPrice * orderLine(1).orderQuantity + orderLine(2).orderPrice * orderLine(2).orderQuantity + orderLine(3).orderPrice * orderLine(3).orderQuantity
            ElseIf numOrder = 5 Then
                cost = orderLine(0).orderPrice * orderLine(0).orderQuantity + orderLine(1).orderPrice * orderLine(1).orderQuantity + orderLine(2).orderPrice * orderLine(2).orderQuantity + orderLine(3).orderPrice * orderLine(3).orderQuantity + orderLine(4).orderPrice * orderLine(4).orderQuantity

            End If

            numVat = cost * 0.2
            newCost = cost * vat
            Console.WriteLine("How much money would you Like To pay, Please note you will be charged " & Format(numVat, "currency") & " extra For VAT")
            moneyPaid = Console.ReadLine()
            Do While moneyPaid < newCost 'if not enough money has been paid to cover the cost they wont be able to pass through the code until they input a valid amount of money
                Console.WriteLine("You have Not paid enough money to cover the cost of your order. Please enter a New amount you would Like to pay")
                newAmount = Console.ReadLine()
                moneyPaid = newAmount
            Loop

            change = moneyPaid - newCost


            ARNnumber = LCase(Mid(firstName, 1, 1) & surName & dayOfBirth & birthMonth)
            upperFname = UCase(firstName)
            upperSname = UCase(surName)

            Console.WriteLine("              ") ' displays the reciept
            Console.WriteLine("                             Here Is your Reciept      ")
            Console.WriteLine("                                             ")
            Console.WriteLine("                              Owais'Coffee shop        ")
            Console.WriteLine("                       Serving fresh Coffee since 1972")
            Console.WriteLine("                          TELEPHONE - 07876491037    ")
            Console.WriteLine("                            www.owaiscoffee.com       ")
            Console.WriteLine()


            Console.WriteLine("                     Customer name             " & upperFname & " " & upperSname)
            Console.WriteLine("                     Number of items ordered   " & numOrder)
            'loops each order line on a seperate line
            For ind = 0 To numOrder - 1
                Console.WriteLine("                     Order Name                " & orderLine(ind).orderName & " x " & orderLine(ind).orderQuantity)
            Next




            Console.WriteLine("                     Cost of order             " & Format(newCost, "currency"))
            Console.WriteLine("                     Change                    " & Format(change, "currency")) ' this converts the change into currency to make it easier for the user to read their reciept
            Console.WriteLine("                     Account reference number  " & ARNnumber)


            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("'This website has good service True or False'")
            goodService = UCase(Console.ReadLine())

            If goodService = "TRUE" Then ' makes the code more robust as the case the user inputs in dosent matter
                goodService = True
                Console.WriteLine("Thank you we appreciate your feedback")




            ElseIf goodService = "FALSE" Then
                goodService = False
                Console.WriteLine("I'm sorry you feel this way what complaints do you have about this website?")
                complain = Console.ReadLine()
                Console.WriteLine("Thank you for your feedback we will take this into consideration")
                Console.ReadLine()
            End If

            Console.WriteLine("Type a number between 1 to 3 to see a fun fact or anything else of not")
            funfact = Console.ReadLine()

            ' gives the user a funfact depending on the question they choose
            Select Case funfact
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

                    Else
                        Console.WriteLine("False, it is - 11, better luck next time")

                    End If
            End Select



            Console.WriteLine("Thanks for shopping here have a good day")
            Console.ReadLine()
            Console.Clear() ' this clears the screan in prepartion for the next customer
            Console.WriteLine("Is there another customer order Yes or No?")
            order = UCase(Console.ReadLine)
            Console.Clear()


        Loop Until order <> "YES" ' this will repatedly loop the code until theres not another order and if yes is not input the code will end

    End Sub

End Module
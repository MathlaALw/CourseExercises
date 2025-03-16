using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpExercisesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------- Exercise 1 ( Part 1) -------------------------------------
            ////1. Even or Odd

            int num;
            Console.WriteLine("Enter number : ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even number");

            }
            else
            {
                Console.WriteLine(num + " is Odd number");
            }

            Console.WriteLine(" -------------------------------------------------------");
            ////---------------------------------------------------------------------------

            ////2. Largest of Three Numbers

            int num1, num2, num3, larg;
            Console.WriteLine("Enter number 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3 : ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                larg = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                larg = num2;
            }
            else
            {
                larg = num3;
            }
            Console.WriteLine("The Largest number is " + larg);

            Console.WriteLine(" -------------------------------------------------------");

            ////---------------------------------------------------------------------------


            ////3. Temperature Converter
            double temp, fahrenheit;
            Console.WriteLine("Enter temperature : ");
            temp = double.Parse(Console.ReadLine());

            fahrenheit = (temp * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit is : " + fahrenheit);

            Console.WriteLine(" -------------------------------------------------------");
            ////---------------------------------------------------------------------------

            ////4. Simple Discount Calculator

            double price, discount, finalPrice;
            Console.WriteLine("Enter price : ");
            price = double.Parse(Console.ReadLine());

            if (price > 100)
            {
                discount = (price * 10) / 100;
                finalPrice = price - discount;
                Console.WriteLine("The final price is  " + finalPrice);
            }
            else
            {

                finalPrice = price;
                Console.WriteLine(" No Discount Your final price is  " + finalPrice);
            }

            Console.WriteLine(" -------------------------------------------------------");
            ////---------------------------------------------------------------------------

            ////5. Grading System


            int marks;
            Console.WriteLine("Enter a student score : ");
            marks = int.Parse(Console.ReadLine());
            char grade;

            if (marks >= 90)
            {
                grade = 'A';
            }
            else if (marks >= 80)
            {
                grade = 'B';
            }
            else if (marks >= 70)
            {
                grade = 'C';
            }
            else if (marks >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine(" Your grade is  " + grade);
            Console.WriteLine(" -------------------------------------------------------");

            ////---------------------------------------------------------------------------

            //6. Swap Two Numbers

            int number1, number2;
            Console.WriteLine("Enter number 1 : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping : Number 1= " + number1 + " Number 2 = " + number2);
            //Swapping
            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            Console.WriteLine("After Swapping : Number 1 " + number1 + " Number 2 = " + number2);
            Console.WriteLine(" -------------------------------------------------------");

            ////---------------------------------------------------------------------------

            //7.Days to Weeks and Days Converter

            int days, weeks, remainingDays;
            Console.WriteLine("Enter number of days : ");
            days = int.Parse(Console.ReadLine());
            weeks = days / 7;
            remainingDays = days % 7;
            Console.WriteLine("The number of days is " + days + "\nThe number of Week is : " + weeks + "\nThe Remainning Days is :" + remainingDays);
            Console.WriteLine(" -------------------------------------------------------");

            ////---------------------------------------------------------------------------

            //8. Electricity Bill Calculator

            float unitNumber, bill;
            Console.WriteLine("Enter number of units : ");
            unitNumber = float.Parse(Console.ReadLine());
            if (unitNumber <= 100)
            {
                bill = unitNumber * 0.5f;
                Console.WriteLine("The bill is : " + bill);
            }
            else if (unitNumber > 100 && unitNumber <= 300)
            {
                bill = unitNumber * 0.75f;
                Console.WriteLine("The bill is : " + bill);
            }
            else
            {
                bill = unitNumber * 1.0f;
                Console.WriteLine("The bill is : " + bill);
            }
            Console.WriteLine(" -------------------------------------------------------");
            ////---------------------------------------------------------------------------

            //9. Simple Calculator

            int numb1, numb2, result;
            char Operator;
            Console.WriteLine("Enter number 1 : ");
            numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator  (+, -, *, /) : ");
            Operator = char.Parse(Console.ReadLine());


            if (Operator == '+')
            {
                result = numb1 + numb2;
                Console.WriteLine("The result of addition is : " + result);
            }
            else if (Operator == '-')
            {
                result = numb1 - numb2;
                Console.WriteLine("The result subtraction is : " + result);
            }
            else if (Operator == '*')
            {
                result = numb1 * numb2;
                Console.WriteLine("The result multiplication is : " + result);
            }
            else if (Operator == '/')
            {
                if (numb2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                else
                {
                    result = numb1 / numb2;
                    Console.WriteLine("The result division is : " + result);
                }

            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            //------------------------------------- Exercise 1 ( Part 2) -------------------------------------

            //1.Simple Calculator(Switch - Case)

            int num_1, num_2, result1;
            char Operator1;
            Console.WriteLine("Enter number 1 : ");
            num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            num_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator  (+, -, *, /) : ");
            Operator1 = char.Parse(Console.ReadLine());


            switch (Operator1)
            {
                case '+':
                    result1 = num_1 + num_2;
                    Console.WriteLine("The result of addition is : " + result1);
                    break;
                case '-':
                    result1 = num_1 - num_2;
                    Console.WriteLine("The result subtraction is : " + result1);
                    break;
                case '*':
                    result1 = num_1 * num_2;
                    Console.WriteLine("The result multiplication is : " + result1);
                    break;
                case '/':
                    if (num_2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return;
                    }
                    else
                    {
                        result1 = num_1 / num_2;
                        Console.WriteLine("The result division is : " + result1);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            Console.WriteLine(" -------------------------------------------------------");
            //---------------------------------------------------------------------------


            //2.Basic ATM System

            double balance = 1000;
            char choice;
            double withdraw, deposit;
            Console.WriteLine("Chose what process you want withdraw , deposit or chechBalance ( w or d or c)");
            choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case 'w':
                    if (balance == 0)
                    {
                        Console.WriteLine("\nYour balance is : " + balance + " You cant withdraw");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nEnter amount to withdraw : \n");
                        withdraw = double.Parse(Console.ReadLine());
                        if (withdraw > balance)
                        {
                            Console.WriteLine("This amount is not avilable Your balance is " + balance);
                            return;
                        }
                        else
                        {
                            balance = balance - withdraw;
                            Console.WriteLine("\nYour balance is : " + balance);
                            break;
                        }
                    }
                case 'd':
                    Console.WriteLine("\nEnter amount to deposit : ");
                    deposit = double.Parse(Console.ReadLine());
                    balance = balance + deposit;
                    Console.WriteLine("\nYour balance is : " + balance);
                    break;
                case 'c':
                    Console.WriteLine("\nYour balance is : " + balance);
                    break;
                default:
                    Console.WriteLine("\nInvalid choice");
                    break;
            }


            Console.WriteLine(" -------------------------------------------------------");


            //---------------------------------------------------------------------------


            //3. Geometry Calculator
            string choiceshape;
            double area = 0;
            double pi = 3.14159;
            Console.WriteLine("Choose a shape: Circle , Square or Triangle ( c , s or t )");
            choiceshape = Console.ReadLine();
            switch (choiceshape)
            {
                case "c":
                    double radius, circumference;
                    Console.WriteLine("Enter the radius of the circle: ");
                    radius = double.Parse(Console.ReadLine());
                    area = pi * radius * radius;
                    Console.WriteLine("The area of the circle is: " + area);
                    circumference = 2 * pi * radius;
                    Console.WriteLine("The circumference of the circle is: " + circumference);
                    break;
                case "s":
                    double side, perimeter;
                    Console.WriteLine("Enter the length of the side of the square: ");
                    side = double.Parse(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("The area of the square is: " + area);
                    perimeter = 4 * side;
                    Console.WriteLine("The perimeter of the square is: " + perimeter);

                    break;
                case "t":
                    double basetriangle;
                    double heighttriangle;
                    Console.WriteLine("Enter the base of the triangle: ");
                    basetriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle: ");
                    heighttriangle = double.Parse(Console.ReadLine());
                    area = (basetriangle * heighttriangle) / 2;
                    Console.WriteLine("The area of the triangle is: " + area);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine(" -------------------------------------------------------");

            //---------------------------------------------------------------------------

            //4.Factorial of a Number

            int factorialnumber;
            Console.WriteLine("Enter a number to find the factorial : ");
            factorialnumber = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= factorialnumber; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("The factorial of " + factorialnumber + " is : " + fact);


            Console.WriteLine(" -------------------------------------------------------");

            //---------------------------------------------------------------------------



            //5. Sum of Even and Odd Numbers 

            int sumeven = 0;
            int sumodd = 0;
            int userNumber;
            Console.WriteLine("Enter a number : ");
            userNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 2 == 0)
                {
                    sumeven = sumeven + i;
                }
                else
                {
                    sumodd = sumodd + i;
                }
            }
            Console.WriteLine("Sum of Even Numbers : " + sumeven);
            Console.WriteLine("Sum of Odd Numbers : " + sumodd);

            Console.WriteLine(" -------------------------------------------------------");

            //---------------------------------------------------------------------------



            //6. Scientific Calculator (Switch-Case & Math Functions)


            char userChoice;
            Console.WriteLine("Choose a function : sin , cos , tan , sqrt , log , pow ( s , c , t , q , l , p )");
            userChoice = Console.ReadKey().KeyChar;
            switch (userChoice)
            {
                case 's':
                    double sinValue;
                    Console.WriteLine("\nEnter a number to find the sin value : ");
                    sinValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The sin value of " + sinValue + " is : " + Math.Sin(sinValue));
                    break;
                case 'c':
                    double cosValue;
                    Console.WriteLine("\nEnter a number to find the cos value : ");
                    cosValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The cos value of " + cosValue + " is : " + Math.Cos(cosValue));
                    break;
                case 't':
                    double tanValue;
                    Console.WriteLine("\nEnter a number to find the tan value : ");
                    tanValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The tan value of " + tanValue + " is : " + Math.Tan(tanValue));
                    break;
                case 'q':
                    double sqrtValue;
                    Console.WriteLine("\nEnter a number to find the tan value : ");
                    sqrtValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The tan value of " + sqrtValue + " is : " + Math.Sqrt(sqrtValue));
                    break;
                case 'l':
                    double logValue;
                    Console.WriteLine("\nEnter a number to find the log value : ");
                    logValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The log value of " + logValue + " is : " + Math.Log(logValue));
                    break;
                case 'p':
                    double powValue;
                    Console.WriteLine("\nEnter a number to find the power value : ");
                    powValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("The power value of " + powValue + " is : " + Math.Pow(powValue, 2));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }


            Console.WriteLine(" -------------------------------------------------------");

            //---------------------------------------------------------------------------

            //8. Print a Pyramid Pattern (For Loop)

            int n1;
            Console.WriteLine("Enter a number : ");
            n1 = int.Parse(Console.ReadLine());

            for (int index = 1; index <= n1; index++)
            {
                for (int space = 1; space <= n1 - index; space++)
                {
                    Console.Write(" ");
                }
                for (int starnum = 1; starnum <= 2 * index - 1; starnum++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}

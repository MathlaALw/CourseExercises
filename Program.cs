﻿using System;

namespace CsharpExercisesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            Console.WriteLine(" Your grade is  " +grade);
            Console.WriteLine(" -------------------------------------------------------");

            ////---------------------------------------------------------------------------

            ////6. Swap Two Numbers

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

            ////7.Days to Weeks and Days Converter

            int days, weeks, remainingDays;
            Console.WriteLine("Enter number of days : ");
            days = int.Parse(Console.ReadLine());
            weeks = days / 7;
            remainingDays = days % 7;
            Console.WriteLine("The number of days is " + days + "\nThe number of Week is : " + weeks + "\nThe Remainning Days is :" + remainingDays);
            Console.WriteLine(" -------------------------------------------------------");

            ////---------------------------------------------------------------------------

            ////8. Electricity Bill Calculator

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
                if (numb2 == 0) {
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

        }
    }
}

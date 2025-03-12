using System;

namespace CsharpExercisesPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////1. Even or Odd

            //int num;
            //Console.WriteLine("Enter number : ");
            //num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine(num + " is Even number");

            //}
            //else
            //{
            //    Console.WriteLine(num + " is Odd number");
            //}
            ////---------------------------------------------------------------------------

            ////2. Largest of Three Numbers

            //int num1, num2 ,num3,larg;
            //Console.WriteLine("Enter number 1 : ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2 : ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 3 : ");
            //num3 = int.Parse(Console.ReadLine());
            //if (num1 > num2 && num1 > num3)
            //{
            //    larg = num1;
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    larg = num2;
            //}
            //else
            //{
            //    larg = num3;
            //}
            //Console.WriteLine("The Largest number is " + larg);

            ////---------------------------------------------------------------------------


            ////3. Temperature Converter
            //float temp , Fahrenheit;
            //Console.WriteLine("Enter temperature : ");
            //temp = int.Parse(Console.ReadLine());

            //Fahrenheit = (temp*9/5)+32;

            //Console.WriteLine("Temperature in Fahrenheit is : " + Fahrenheit);


            ////---------------------------------------------------------------------------

            ////4. Simple Discount Calculator

            //float price, discount,finalPrice;
            //Console.WriteLine("Enter price : ");
            //price = float.Parse(Console.ReadLine());

            //if (price > 100)
            //{
            //    discount = price * 10 / 100;
            //    finalPrice = price - discount;
            //    Console.WriteLine("The final price is  " + finalPrice);
            //}
            //else
            //{

            //    finalPrice = price;
            //    Console.WriteLine(" No Discount Your final price is  " + finalPrice);
            //}


            ////---------------------------------------------------------------------------

            ////5. Grading System


            //int marks;
            //Console.WriteLine("Enter a student score : ");
            //marks = int.Parse(Console.ReadLine());


            //if (marks >= 90 && marks <= 100)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (marks >= 80 && marks <= 89)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (marks >= 70 && marks <= 79)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else if (marks >= 60 && marks <= 69)
            //{
            //    Console.WriteLine("Grade D");
            //}
            //else
            //{
            //    Console.WriteLine("Grade F");
            //}


            ////---------------------------------------------------------------------------

            ////6. Swap Two Numbers

            //int num1, num2;
            //Console.WriteLine("Enter number 1 : ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2 : ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Before Swapping : Number 1= " + num1 + " Number 2 = " + num2);
            ////Swapping
            //num1 = num1 * num2;
            //num2 = num1 / num2;
            //num1 = num1 / num2;
            //Console.WriteLine("After Swapping : Number 1 " + num1 + " Number 2 = " + num2);


            ////---------------------------------------------------------------------------

            ////7.Days to Weeks and Days Converter

            //int days, weeks, remainingDays;
            //Console.WriteLine("Enter number of days : ");
            //days = int.Parse(Console.ReadLine());
            //weeks = days / 7;
            //remainingDays = days % 7;
            //Console.WriteLine("The number of days is " + days + "\nThe number of Week is : " + weeks + "\nThe Remainning Days is :" + remainingDays);

            ////---------------------------------------------------------------------------

            ////8. Electricity Bill Calculator

            //float unitNumber, bill;
            //Console.WriteLine("Enter number of units : ");
            //unitNumber = float.Parse(Console.ReadLine());
            //if (unitNumber <= 100)
            //{
            //    bill = unitNumber * 0.5f;
            //    Console.WriteLine("The bill is : " + bill);
            //}
            //else if (unitNumber > 100 && unitNumber <= 300)
            //{
            //    bill = unitNumber * 0.75f;
            //    Console.WriteLine("The bill is : " + bill);
            //}
            //else 
            //{
            //    bill = unitNumber * 1.0f;
            //    Console.WriteLine("The bill is : " + bill);
            //}

            ////---------------------------------------------------------------------------

            //9. Simple Calculator

            int num1, num2, result;
            char Operator;
            Console.WriteLine("Enter number 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator  (+, -, *, /) : ");
            Operator = char.Parse(Console.ReadLine());


            if (Operator == '+')
            {
                result = num1 + num2;
                Console.WriteLine("The result of addition is : " + result);
            }
            else if (Operator == '-')
            {
                result = num1 - num2;
                Console.WriteLine("The result subtraction is : " + result);
            }
            else if (Operator == '*')
            {
                result = num1 * num2;
                Console.WriteLine("The result multiplication is : " + result);
            }
            else if (Operator == '/')
            {
                result = num1 / num2;
                Console.WriteLine("The result division is : " + result);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

        }
    }
}

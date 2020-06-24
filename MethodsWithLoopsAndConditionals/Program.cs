using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////  LUKE WARM ///////////////////////
            ////////////////    Numbers between 1000 and -1000 ///////////////////////
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
            ///////////////   Numbers 3 through 999 (counting by 3s) ///////////////////////////
            for (int k = 3; k < 1000; k += 3)
            {
                Console.WriteLine(k);
            }
            ///////////////   Are the intergers equal? ///////////////////////////

            Console.WriteLine("Write your first interger");
            var FirstInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Write your second interger");
            var SecondInt = int.Parse(Console.ReadLine());

            if (FirstInt == SecondInt)
            {
                Console.WriteLine($"These numbers are equal!");
            }

            else
            {
                Console.WriteLine($"These numbers are not equal.");
            }
            ///////////////   Is the number odd or even? ///////////////////////////

            Console.WriteLine("Write in any number to see if it is odd or even.");
            var OddOrEven = int.Parse(Console.ReadLine());

            if (OddOrEven % 2 == 0)
            {
                Console.WriteLine($"This is an EVEN number!");
            }

            else
            {
                Console.WriteLine($"This is an ODD number!");
            }
            /////////////////   Is the number positive or negative? ///////////////////////////
            Console.WriteLine("Write in any number to see if it is positive or negative.");
            var PositiveOrNegative = int.Parse(Console.ReadLine());

            if (PositiveOrNegative > -1)
            {
                Console.WriteLine($"This is a POSITIVE number!");
            }

            else
            {
                Console.WriteLine($"This is a NEGATIVE number!");
            }
            /////////////////   Are you old enough to vote? ///////////////////////////
            Console.WriteLine("Let's see if you are eligable to vote. How old are you?");
            var VotingAge = int.Parse(Console.ReadLine());

            if (VotingAge > 17)
            {
                Console.WriteLine($"You are old enough to vote! Remember vote early! Vote often!");
            }

            else
            {
                var AgeDifference = 18 - VotingAge;
                Console.WriteLine($"Hey you only have to wait {AgeDifference} more years until you are 18 to vote!");
            }




            //////////////////////////////  HEATIN UP ///////////////////////



            //////////////    Are you in range between 10 and -10? ///////////////////////

            Console.WriteLine("Type a number between -10 and 10 and let's see if it is in range.");
            var InRange = int.Parse(Console.ReadLine());

            if (InRange <= 10 && InRange >= -10)
            {
                Console.WriteLine($"You ARE in range.");
            }

            else
            {
                Console.WriteLine($"You are NOT in range.");
            }

            //////////////    Multiplicatin Tables ///////////////////////

            Console.WriteLine("Type in any number to see it multiplied 12 times.");
            var GivenNumber = int.Parse(Console.ReadLine());

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} x {GivenNumber} = {numbers[i] * GivenNumber}");
            }


            //////////////    Random Number Index ////////Didn't get the answer on my own///////////////

            {
                Console.WriteLine("Please write a number.");
                int InputNumber = int.Parse(Console.ReadLine());

                int[] array = ArrayCreator(InputNumber);
                foreach (int number in array)
                {
                    Console.WriteLine(number);
                }
            }


            int[] ArrayCreator(int UserNumber)
            {
                int[] CustomArray = new int[UserNumber];

                Random rng = new Random();

                for (int index = 0; index < CustomArray.Length; index++)
                {
                    CustomArray[index] = rng.Next(100);
                }
                return CustomArray;
            }


            //////////////    Sum of the elements in an array. ///////////////////////

            var Numbers = new List<int> { 8, 2, 6, 3, 12, 300 };
            int MySum = Numbers.Sum();
            Console.WriteLine(MySum);


            //////////////    Number to Cube ///////////////////////

            Console.WriteLine("Give to me any number and I will CUBE it!");
            var NumberToCube = int.Parse(Console.ReadLine());

            int Answer = NumberToCube * NumberToCube * NumberToCube;
            {
                Console.WriteLine($"The number {NumberToCube} cubed is {Answer}.");
            }


        }
    }
}


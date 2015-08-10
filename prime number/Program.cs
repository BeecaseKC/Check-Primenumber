using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    class Program
    {

        

        public static bool CheckPrime(int checkifPrime)
        {
            bool isPrime = true;
            for (int i = 2; i < checkifPrime - 1; i++)
            {

                if (checkifPrime % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }



        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the total number of prime numbers you want to print");
            int count = int.Parse(Console.ReadLine());

            int[] listOfPrimeNumber = new int[count];

            int arrayCount = 0;

            int number = 2;
            while (arrayCount < count)
            {
                var isNumberPrime = CheckPrime(number);

                if (isNumberPrime)
                {
                    listOfPrimeNumber[arrayCount] = number;
                    arrayCount += 1;
                }
                number += 1;                          
            }

            foreach (var primeNumber in listOfPrimeNumber)
            {
                Console.WriteLine(primeNumber);
            }

        }

    }

}



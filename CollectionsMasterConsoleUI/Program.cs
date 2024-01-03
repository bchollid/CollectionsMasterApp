using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var fiftyArray = new int[50];

            Populater(fiftyArray);


            Console.WriteLine("All Numbers Original");
            NumberPrinter(fiftyArray);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(fiftyArray);

            NumberPrinter(fiftyArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(fiftyArray);
            NumberPrinter(fiftyArray);

            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(fiftyArray);
            NumberPrinter(fiftyArray);

            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");
            Array.Sort(fiftyArray);
            NumberPrinter(fiftyArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            Console.WriteLine("************Start Lists**************");

            var myList = new List<int>();
            Console.WriteLine(myList.Capacity);
            Populater(myList);
            Console.WriteLine(myList.Capacity);

            Console.WriteLine("---------------------");

            Console.WriteLine("What number will you search for in the number list?");
            var userNumber = 0;
            if (Int32.TryParse(Console.ReadLine(), out userNumber))
            {
                NumberChecker(myList, userNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 0 and 50.");
            }
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(myList);
            Console.WriteLine("-------------------");

            
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            NumberPrinter(myList);

            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Evens!!");

            myList.Sort();
            NumberPrinter(myList);
           
            Console.WriteLine("------------------");

            var listIntoArray = myList.ToArray();
            myList.Clear();
            
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(var i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(var i = 0; i<numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            var notFound = 0;

            foreach (int num in numberList)
            {
                if (searchNumber == num)
                {
                    Console.WriteLine($"We have a match! {searchNumber} exists in the list.");
                }
                else
                {
                    notFound++;
                }
            }
            if(notFound == 50)
            {
                Console.WriteLine($"Sorry, {searchNumber} does not exist in this list.");
            }

               
           
        }

        private static void Populater(List<int> numberList)
        {
            for(int i = 0; i<50; i++)
            {
                Random rng = new Random();
                int randNum = rng.Next(0, 50);
                numberList.Add(randNum);
            }
        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                Random rng = new Random();
                int randNum = rng.Next(0, 50);
                numbers[i] = randNum;
            }
            Console.WriteLine($"First number in fifty number array: {numbers[0]}. Last number: {numbers[49]}");
        }

        private static void ReverseArray(int[] array)
        {
            for(int i = 0; i<array.Length/2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
        }

        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

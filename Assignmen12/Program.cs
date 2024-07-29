using Assignmen12.Collection_Functions;
using Assignmen12.ReverseArrayList;
using System.Collections;

namespace Assignmen12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Part 2
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original list:");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayListReverse.ReverseArrayList(list);

            //Console.WriteLine("Reversed list:");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 2 Part 2
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Original List:");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //List<int> evenNumbers = EvenFilter.GetEvenNumbers(numbers);

            //Console.WriteLine("Even Numbers List:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Question 3 part 2
            //FixedSizeList<int> fixedList = new FixedSizeList<int>(5);

            //fixedList.Add(1);
            //fixedList.Add(2);
            //fixedList.Add(3);
            //fixedList.Add(4);
            //fixedList.Add(5);

            //Console.WriteLine("List elements:");
            //for (int i = 0; i < fixedList.Count; i++)
            //{
            //    Console.WriteLine(fixedList.Get(i));
            //}

            //try
            //{
            //    fixedList.Add(6);
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            //try
            //{
            //    Console.WriteLine(fixedList.Get(10));
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //} 
            #endregion

            #region Question 4 part 2
            string testString = "aaaaaaaaaxa";
            Console.WriteLine($"Test String: {testString}");
            int index = CharacterHandler.NonRepeatingFirstCharIndex(testString);

            if (index != -1)
            {
                Console.WriteLine($"First non-repeated character is {testString[index]}");
                Console.WriteLine($"Index:{index}");
            }
            else
            {
                Console.WriteLine("No non-repeated character found.");
            }


            #endregion
        }
    }
}

using Assignmen12.ReverseArrayList;
using System.Collections;

namespace Assignmen12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Part 2
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original list:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ArrayListReverse.ReverseArrayList(list);

            Console.WriteLine("Reversed list:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); 
            #endregion



        }
    }
}

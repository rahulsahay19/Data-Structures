using System;

namespace DataStructures.Array
{
   public class ArrayNum
    {
        private int[] numbers = new [] {1, 2, 3, 4, 5};

        //Array scenarios:-
        //Search:- O(n)
        //Access:- O(1), as its index based
        //Insert:- O(n), as all other elements needs to be shifted
        //Delete:- O(n)
        public void AccessList()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

           // Console.ReadLine();
        }
    }
}

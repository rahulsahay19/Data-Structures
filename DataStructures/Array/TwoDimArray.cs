using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataStructures.Array
{
    public class TwoDimArray
    {
        private int[,] _data = new int[3, 3]
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        public void Access2DArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(_data[i,j] + "\t");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("Data length:- " + _data.Length);

            
        }
    }
}

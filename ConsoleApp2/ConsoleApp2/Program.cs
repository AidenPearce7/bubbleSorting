using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] tableToSort = new int[5];
            for (int i = 0; i <tableToSort.Length; i++)
            {
                tableToSort[i] = rand.Next(20);
                Console.Write(tableToSort[i]+" ");
            }
            Console.WriteLine();
            bool isSorted =false;
            while (!isSorted)
            {
                isSorted = true;
                Console.WriteLine();
                for (int i = 0; i < tableToSort.Length; i++)
                {
                    int k = i + 1;
                    if (k==tableToSort.Length)
                    {
                        Console.Write(tableToSort[i] + " ");
                        continue;
                    }
                    if (tableToSort[i] > tableToSort[k])
                    {
                        int temp = tableToSort[i];
                        tableToSort[i] = tableToSort[k];
                        tableToSort[k] = temp;
                        isSorted = false;
                    }
                    Console.Write(tableToSort[i]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}

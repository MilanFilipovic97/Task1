using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<int> ListOne = new List<int>() { 1, 3, 5, 7 };
            List<int> ListTwo = new List<int>() { 2, 4, 6, 8 };
            List<int> ListThree = new List<int>() { 0, 9, 10, 11 };

            List<int> newList = new List<int>();

            foreach (int i in ListOne)
            {
                newList.Add(i);             // adding elements in newList
            }
            foreach (int i in ListTwo)
            {
                newList.Add(i);             // adding elements in newList
            }
            foreach (int i in ListThree)
            {
                newList.Add(i);             // adding elements in newList
            }

            newList.Sort();                 //Sorting 
            Console.WriteLine("Sorted list... "); //Printing the result
            foreach (int i in newList)
            {
                Console.WriteLine(i + " "); //Printing the result
            }

        }

    }
   
}


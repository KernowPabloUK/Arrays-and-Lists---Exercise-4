using System;
using System.Collections.Generic;

namespace Arrays_and_Lists___Exercise_4
{
    internal class Program
    {
        // 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.


        //MY METHOD
        // read line, convert string input to int
        // WHILE a number is input, add to int LIST (dynamic)
        // FOREACH to compare current index with previous indexes for duplications
        //add unique values to a new list and then display on the console

        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enter a number, when you wish to end the program, please type \"Quit\"");
                string userEntry = Console.ReadLine();
                if (userEntry.ToUpper() == "QUIT") 
                {
                    break;
                }
                int numberEntry = Convert.ToInt32(userEntry);
                listOfNumbers.Add(numberEntry);
            }
            Console.Write("Unique numbers are ");
            foreach (int number in listOfNumbers)
            {
                if (listOfNumbers.IndexOf(number) == listOfNumbers.LastIndexOf(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}

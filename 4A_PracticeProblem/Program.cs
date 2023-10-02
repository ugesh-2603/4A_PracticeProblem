using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _4A_PracticeProblem.DictionaryOperator;

namespace _4A_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 4A PracticeProblems.");
            bool continueExecution = true;

            while (continueExecution)
            {
                Console.WriteLine("Please choose any one of the following program:");
                Console.WriteLine("1.Nlog Problem \n2.ArrayList \n3.DictionaryOperators");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enetr 1st number:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enetr 2nd number:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Addition addition = new Addition();
                        addition.Sum(x, y);
                        break;

                    case 2:

                        ArrayListOperations data = new ArrayListOperations();

                        data.AddFruit("Apple");
                        data.AddFruit("Banana");
                        data.AddFruit("Orange");

                        data.DisplayFruits();

                        data.UpdateFruit("Banana", "Mango");

                        data.DisplayFruits();

                        data.DeleteFruit("Apple");

                        data.DisplayFruits();
                        break;

                    case 3:

                        DictionaryOperations crudOperations = new DictionaryOperations();

                        crudOperations.Create(1, "Apple");
                        crudOperations.Create(2, "Banana");

                        Console.WriteLine("Reading fruits:");
                        Console.WriteLine($"Key 1: {crudOperations.Read(1)}");
                        Console.WriteLine($"Key 3: {crudOperations.Read(3)}");

                        crudOperations.Update(2, "Orange");
                        crudOperations.Update(3, "Grape");

                        Console.WriteLine("After update:");
                        Console.WriteLine($"Key 2: {crudOperations.Read(2)}");

                        crudOperations.Delete(1);
                        crudOperations.Delete(3);

                        Console.WriteLine("After delete:");
                        Console.WriteLine($"Key 1: {crudOperations.Read(1)}");

                        break;

                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
                Console.WriteLine("Do you want to continue (yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();
        }
    }
}


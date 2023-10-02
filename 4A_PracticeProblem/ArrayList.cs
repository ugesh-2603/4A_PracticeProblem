using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A_PracticeProblem
{
    internal class ArrayListOperations
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        private ArrayList fruits = new ArrayList();

        // Create operation
        public void AddFruit(string fruit)
        {

            fruits.Add(fruit);
        }

        // Read operation
        public void DisplayFruits()
        {
            log.Error("Ugesh");
            Console.WriteLine("Fruits in the collection:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        // Update operation
        public void UpdateFruit(string oldFruit, string newFruit)
        {
            int index = fruits.IndexOf(oldFruit);
            if (index != -1)
            {
                fruits[index] = newFruit;
                Console.WriteLine("Fruit updated successfully.");
            }
            else
            {
                Console.WriteLine("Fruit not found in the collection.");
            }
        }

        // Delete operation
        public void DeleteFruit(string fruit)
        {
            if (fruits.Contains(fruit))
            {
                fruits.Remove(fruit);
                Console.WriteLine("Fruit deleted successfully.");
            }
            else
            {
                Console.WriteLine("Fruit not found in the collection.");
            }
        }
    }
}
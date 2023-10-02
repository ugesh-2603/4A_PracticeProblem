using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A_PracticeProblem
{
    internal class DictionaryOperator
    {
        internal class DictionaryOperations
        {

            private Dictionary<int, string> fruits = new Dictionary<int, string>();

            public void Create(int key, string value)
            {
                if (!fruits.ContainsKey(key))
                {
                    fruits[key] = value;
                    Console.WriteLine($"Fruit with key {key} created.");
                }
                else
                {
                    Console.WriteLine($"Fruit with key {key} already exists. Use Update to modify.");
                }
            }

            public string Read(int key)
            {
                if (fruits.ContainsKey(key))
                {
                    return fruits[key];
                }
                else
                {
                    Console.WriteLine($"Fruit with key {key} not found.");
                    return null;
                }
            }

            public void Update(int key, string newValue)
            {
                if (fruits.ContainsKey(key))
                {
                    fruits[key] = newValue;
                    Console.WriteLine($"Fruit with key {key} updated.");
                }
                else
                {
                    Console.WriteLine($"Fruit with key {key} not found. Use Create to add new fruit.");
                }
            }

            public void Delete(int key)
            {
                if (fruits.ContainsKey(key))
                {
                    fruits.Remove(key);
                    Console.WriteLine($"Fruit with key {key} deleted.");
                }
                else
                {
                    Console.WriteLine($"Fruit with key {key} not found.");
                }
            }
        }
    }
}

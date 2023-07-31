using System;
using DataStructure;

namespace DataStructure
{
    internal class UnorderedlistOperation
    {
        public void ReadFileAndPerformOperation(string filepath)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            string[] words =  File.ReadAllText(filepath).Split(" ");
            foreach (var data in words)
            {
                linkedList.Add(data);
            }
            linkedList.Display();
            Console.WriteLine("\nEnter a input :");
            string input = Console.ReadLine();
            linkedList.Operation(input);
            linkedList.Display();
        }
    }
}

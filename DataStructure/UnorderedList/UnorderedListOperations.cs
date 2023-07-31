using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.UnorderedList
{
    public class UnorderedListOperations
    {
        public void ReadFileAndPerformOperation(string filePath)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                linkedList.Add(data);
            }
            linkedList.Display();
            linkedList.UnorderedOperation("a");
            linkedList.Display();
        }

    }
}

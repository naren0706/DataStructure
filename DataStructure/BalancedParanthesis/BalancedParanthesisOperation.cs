using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BalancedParanthesis
{
    public class BalancedParanthesisOperation
    {
        public void ReadAndPerformOperation(string filePath)
        {
            LinkedListStack<string> stack = new LinkedListStack<string>();
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                    stack.Push(data);
                if (data.Equals(")"))
                    stack.Pop();

            }
            if (stack.IsEmpty())
                Console.WriteLine("Balanced Parantheses");
            else
                Console.WriteLine("Unbalanced paranthesis");
        }
    }
}

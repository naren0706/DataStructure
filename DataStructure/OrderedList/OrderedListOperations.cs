using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class OrderedListOperations
    {
        public void ReadAndPerformOperation(string filePath)
        {
            LinkedList<int> intlist = new LinkedList<int>();
            string readAllText = File.ReadAllText(filePath);
            string[] numberString = readAllText.Split(",");
            int[] numbers = new int[numberString.Length];
            for (int i = 0; i < numberString.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberString[i]);
            }
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                intlist.Add(number);
            }
            intlist.Display();

            Console.WriteLine("Enter number to add");
            int num = Convert.ToInt32(Console.ReadLine());
            int position = intlist.Search(num);
            if (position == -1)
            {
                intlist.Add(num);
            }
            else
            {
                intlist.DeleteNodeAtParticularPosition(position);
            }
            intlist.Display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    internal class HashingOperation
    {
        static int size = 11;
        LinkedList<int>[] array = new LinkedList<int>[size];
        public HashingOperation()
        {
            for(int i = 0; i < size; i++)
            {
                array[i]=new LinkedList<int> ();
            }
        }
        public void ReadFile(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(",");
            foreach(var data  in words)
            {
                int num = Convert.ToInt32(data);
                int position = num % size;
                array[position].Add(num);
            }
        }
        public void Display()
        {
            int i = 0;
            foreach (var item in array)
            {
                Console.WriteLine("["+(i++)+"]");
                item.Display();
            }
        }
    }
}

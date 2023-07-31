
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList<T>
    {
        internal Node<T> head;
        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal int Search(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
        }

        public void UnorderedOperation(T word)
        {
            int position = Search(word);
            if (position == -1)
            {
                Add(word);
            }
            else
            {
                DeleteNodeAtParticularPosition(position);
            }
        }
    }
}

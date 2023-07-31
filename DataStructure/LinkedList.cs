using DataStructure;
using System;

namespace DataStructure
{
    internal class LinkedList<T>
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
            Console.WriteLine("{0} inserted to the linked list", node.data);
        }
        internal void AddInReverseOrder(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("The data has been added in the reverse");
        }
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("no data to display");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " | ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal Node<T> InsertAtParticularPosition(int position, T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                return newNode;
            }
            if (position == 0)
            {
                newNode.next = this.head;
                this.head = newNode;
                return this.head;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            Console.WriteLine("data has been inserted at the particular position");
            return this.head;
        }
        internal Node<T> RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("nothing to remove");
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("First nodehas been removed");
            return this.head;
        }
        internal Node<T> RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<T> NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            Console.WriteLine("Last node has been removed");
            return head;
        }
        internal int Search(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            bool flag = false;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    flag = true;
                    break;
                }
                node = node.next;
                count++;
            }
            if (!flag)
            {
                Console.WriteLine("value not found");
                return 0;
            }
            else
            {
                Console.WriteLine("the value is found in the index {0}", count);
                return count;
            }

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
            Console.WriteLine("the data has been deleted at the postion " + position);
            Size();
        }
        internal void Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("no data to display");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " | ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length: " + count);
        }
        public void Operation(T word)
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

        internal void SortAdd(T v)
        {
            Node<T> newNode = new Node<T> (v);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                while(head.next != null)
                {
                    if(head.data>v)


                }
            }
        }
    }
}

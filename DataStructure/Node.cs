using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }
    }
}

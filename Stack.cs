using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStruct
{
    public class StackNode
    {
        public int data;
        public StackNode nextNode { get; set; }

        public StackNode(int data)
        {
            this.data = data;
        }
    }

    public class Stack
    {
        private StackNode topNode;
        public bool IsEmpty { get { return (topNode == null); } }
        int length;
        public void Push(int data)
        {
            if (topNode == null)
            {
                topNode = new StackNode(data);
                length++;
                return;
            }
            StackNode currNode = new StackNode(data);
            currNode.nextNode = topNode;
            topNode = currNode;
            length++;
        }

        public int Pop()
        {
            int data;
            if (IsEmpty)
            {
                throw new Exception("Empty");
            }
            else
            {
                data = topNode.data;
                topNode = topNode.nextNode;
                length--;
                return data;
            }
        }

        public int Peek()
        {
            return topNode.data;
        }

        public int Capacity()
        {
            return length;
        }
    }
}
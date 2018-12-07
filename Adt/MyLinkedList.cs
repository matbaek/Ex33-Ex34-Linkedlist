using System;
using System.Collections.Generic;
using System.Text;

namespace Adt
{
    public class MyLinkedList
    {
        private Node head;
        private int count;

        private Node Head
        {
            get { return this.head; }
            set { this.head = value; }
        }
        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        //Metoder
        public void Insert(object data)
        {
            Node toAdd = new Node(data);
            toAdd.Next = head;
            head = toAdd;
            Count++;
        }

        public void Insert(object data, int index)
        {

            if (index <= 0)
            {
                Insert(data);
            }
            else
            {
                Node currentNode = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                Node nextNode = currentNode.Next;
                currentNode.Next = new Node(data);
                currentNode.Next.Next = nextNode;
                Count++;
            }
            
        }

        public void Delete()
        {
            Node currentNode = this.head;
            this.head = currentNode.Next;
            Count--;
        }

        public void Delete(int index)
        {
            Node currentNode = this.head;
            if(index == 0)
            {
                this.head = currentNode.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = currentNode.Next.Next;
                Count--;
            }
        }

        public object ItemAt(int index)
        {
            Node currentNode = this.head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Data;
        }

        public override string ToString()
        {
            Node currentNode = this.head;
            string result = currentNode.Data.ToString() + "\n";
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                result += currentNode.Data.ToString() + "\n";
            }
            return result;
        }
    }

    public class Node
    {
        private Node next;
        private object data;

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node(object data)
        {
            this.Data = data;
        }
    }
}

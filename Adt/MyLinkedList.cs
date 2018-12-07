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
            if(this.head == null)
            {
                this.head = toAdd;
            }
            else
            {
                Node lastNode = this.head;
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = toAdd;
                toAdd.Prev = lastNode;
            }
            Count++;
        }

        public void Insert(object data, int index)
        {

            if (index == 0)
            {
                Node toAdd = new Node(data);
                toAdd.Next = head;
                head = toAdd;
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
            }
            Count++;
            
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

        public void Reverse()
        {
            Node startNode = this.head;
            Node tempNode = null;

            while (startNode != null)
            {
                tempNode = startNode.Next;
                startNode.Next = startNode.Prev;
                startNode.Prev = tempNode;

                if (startNode.Prev == null)
                {
                    this.head = startNode;
                }

                startNode = startNode.Prev;
            }
        }

        public void Swap(int index)
        {
            Node currentNode = this.head;
            Node tempNode = new Node(null);
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            if (currentNode.Next != null) { 
                Node nodeAfterCurrentNode = currentNode.Next;
                tempNode.Data = currentNode.Data;
                currentNode.Data = nodeAfterCurrentNode.Data;
                nodeAfterCurrentNode.Data = tempNode.Data;
            }
        }

        public string FremTilbage()
        {
            string result = ToString();
            Reverse();
            Delete();
            result += ToString();

            return result;
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
        private Node prev;
        private object data;

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
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

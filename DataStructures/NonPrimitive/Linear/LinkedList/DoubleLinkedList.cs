using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.NonPrimitive.Linear.LinkedList
{
    class DoubleLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;

            public Node(int _data)
            {
                data = _data;
                next = null;
                prev = null;
            }
        }

        public void Prepend(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            newNode.prev = null;
            head.prev = newNode;
            head = newNode;
        }

        public void Append(int data)
        {
            Node newNode = new Node(data);

            newNode.next = null;

            if(head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }

            Node currentNode = head;

            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newNode;
            currentNode.next.prev = currentNode;
        }

        public void Delete(int data)
        {
            if(head == null)
            {
                return;
            }

            if(head.data == data)
            {
                head.next.prev = null;
                head = head.next;
                return;
            }

            Node currentNode = head;

            while(currentNode != null)
            {
                if(currentNode.data == data)
                {
                    if(currentNode.next != null)   // if node is not the last node
                    {
                        currentNode.prev.next = currentNode.next;
                        currentNode.next.prev = currentNode.prev;
                    }
                    else
                    {
                        currentNode.prev.next = null; // if node is last node
                    }
                    return;
                }
                currentNode = currentNode.next;
            }
        }

        public void Print(Node node)
        {
            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.data + " ");
                last = last.prev;
            }
        }

        public DoubleLinkedList()
        {
            Prepend(10);
            Prepend(95);
            Append(15);
            Append(25);
            Append(45);
            Append(55);
            Print(head);
            Delete(25);
            Console.WriteLine("\n\nAfter deleting 25 from list\n");
            Print(head);
        }
    }
}

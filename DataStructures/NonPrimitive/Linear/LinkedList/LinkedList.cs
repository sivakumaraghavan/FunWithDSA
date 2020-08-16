﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.NonPrimitive.Linear.LinkedList
{
    public class LinkedList
    {
        Node head;

        public LinkedList()
        {
            Console.WriteLine("\n*****Linked List*****");

            Append(10);
            Append(25);
            Prepend(5);
            Delete(25);
            Print();
        }

        public class Node
        {
            public int data;
            public Node next;
            public Node(int _data)
            {
                data = _data;
                next = null;
            }
        }

        public void Append(int data)
        {
            Node newNode = new Node(data);
            
            if(head == null)
            {
                head = newNode;
                return;
            }

            Node currentNode = head;
            
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newNode;
        }

        public void Prepend(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void Delete(int data)
        {
            if (head == null) return;

            if(head.data == data)
            {
                head = head.next;
            }

            Node currentNode = head;
            while(currentNode.next != null)
            {
                if (currentNode.next.data == data)
                {
                    currentNode.next = currentNode.next.next;
                    return;
                }
                currentNode = currentNode.next;
            }
        }

        public void Print()
        {
            Node currentNode = head;
            while(currentNode != null)
            {
                Console.Write(currentNode.data + "-->");
                currentNode = currentNode.next;
            }
        }
    }
}

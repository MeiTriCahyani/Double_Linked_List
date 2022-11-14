﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*node class represents the noe of doubly linked list.
        it consists of the information part and links to 
        its succeeding and precceding
        in terms of next and previous */

        public int noMhs;
        public string name;

        //point to teh succeding note
        public Node next;

        //point to the precceding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;

        //constructor

        public DoubleLinkedList()
        {
            START = null;

        }

        public void addNode()
        {
            int nim;
            string nm;
            Console.Write(" \n Enter the roll nu mber of student:");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the name of student:");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm; 

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\n Duplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
            //if the node  is to be inserted at between two node
            Node previous, current;
            for (current = previous = START; 
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return ;
                }
            }
            /*on the execution of the above for loop, prev and
            current will point to those nodes 
            between wich  the new node is to be insarted*/

            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be insarted at the end of the list   
            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return ;
            }
            current.prev = newNode;
            previous.next = newNode;
        }
        public bool search(int rollNo, ref Node previous,ref Node current)
        {
            for (previous = current = START; current != null &&
                rollNo != current.noMhs; previous = current,
                current = current.next) { }
            return (current != null);
        }
        public bool delNode(int rollNo)
        {
            Node previous,current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;

            //the begining of data
            if (current.next == null)
            {
                previous.next = null;
                return true; 
            }

            //node between two nodes in the list
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true ;
            }
            //if the to be deleted is the between the list then the  following line of is executed
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecord in the ascending order of" + "roll number are:\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.WriteLine(currentNode.noMhs + "" + currentNode.name + "\n");
            }
        }

        public void descending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\nRecord in the descending order of" + "roll number are\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                {}
                while(currentNode != null)
                {
                    Console.WriteLine(currentNode.noMhs + "" + currentNode.name + "\n");
                     currentNode = currentNode.prev;
                }
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList obj  = new DoubleLinkedList(); 
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all records in the ascending order of roll numbers");
                    Console.WriteLine("4. View all records in the descending order of roll numbers");
                    Console.WriteLine("5. Search for a record in the list");
                    Console.WriteLine("6. Exit\n");
                    Console.WriteLine("Enter your choice (1-6):");
                    char ch = Convert.ToChar(Console.ReadLine());
                }
            }
        }
    }
}

using System;
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

        }
    }

        static void Main(string[] args)
        {
        }
    
}

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

            
        }
    }

    static void Main(string[] args)
        {
        }
    
}

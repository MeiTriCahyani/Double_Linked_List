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

    

        static void Main(string[] args)
        {
        }
    
}

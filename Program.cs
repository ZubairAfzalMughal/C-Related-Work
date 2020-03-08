using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_in_Csharp
{
    class Node
    {
        public int data;
        public Node next;

        //Creating a Node 

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class LinkList
    {
        public Node head;
        public LinkList()
        {
            head = null;
        }
        public void InsertAtHead(int val)
        {
            // Creatin a temp Node 
            Node temp = new Node(val);
            if (head == null)
            {
                head = temp;
            }
            else
            {
                //Inserting at head
                temp.next = head;
                head = temp;

            }

        }

        public void InsertAtTail(int val)
        {
            Node temp = new Node(val);

            if (head==null)
            {
                head = temp;
            }
            else
            {
                Node mynode = head;
                while (mynode.next!=null)
                {
                    mynode = mynode.next;
                }
                mynode.next = temp;
            }

            
        }

        public void Print()
        {
            Node temp = head;
            while(temp!=null)
            {
                Console.Write(temp.data+ "  ");
                temp = temp.next;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            LinkList link = new LinkList();
            /*link.InsertAtHead(10);
            link.InsertAtHead(20);
            link.InsertAtHead(30);
            link.InsertAtHead(40);
            link.InsertAtHead(50);
            link.Print();*/
            Console.WriteLine("Insert at Tail");
            link.InsertAtTail(10);
            link.InsertAtTail(20);
            link.InsertAtTail(30);
            link.InsertAtTail(40);
            link.InsertAtTail(50);
            link.Print();
            Console.Read();
        }
    }
}

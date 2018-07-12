using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractice
{
    internal class SingleLinkedListExample
    {
        public static void CallMain()
        {
            SimpleNode node = SingleLinkedListOption2.InsertElementAtEnd();
            SingleLinkedListOption2.InsertElementBeforeValue(node);
            //SingleLinkedListOption2.InsertElementAfterValue(node);
            //SingleLinkedListOption2.InsertElementAtPosition(node);
            //SingleLinkedListOption2.InsertElementAtFront(node);

            //SinglyLinkedList obj = new SinglyLinkedList();
            //obj.Add("test1");
            //obj.Add("test 2");
            //obj.Add("test 3");
            //obj.Add(3, "test 4");
            //obj.Add("test 5");
            //obj.Add(2, "test 6");
            //obj.Display();
        }
    }

    public class SimpleNode
    {
        public int data;

        public SimpleNode Link;

        public SimpleNode(int value)
        {
            data = value;
            Link = null;
        }
    }

    public class Node
    {
        public Object data;

        public Node next;

        public Node(object value, Node head)
        {
            data = value;
            next = head;
        }
    }

    public class SinglyLinkedList
    {
        public Node head;

        public int size;

        public SinglyLinkedList()
        {
            head = null;
            size = 0;
        }

        public bool Empty
        {
            get
            {
                return size == 0;
            }
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public object Add(int index, object o)
        {
            Node current = this.head;
            if (current == null)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;

                current.next = new Node(o, current.next);
            }
            this.size++;

            return o;
        }

        public object Add(object o)
        {
            return this.Add(size, o);
        }

        public void Display()
        {
            Console.WriteLine("size {0},", this.size);

            Node nodes = this.head;
            while (nodes != null)
            {
                Console.WriteLine("{0},", nodes.data);
                nodes = nodes.next;
            }
        }
    }

    public class SingleLinkedListOption2
    {
        public static SimpleNode InsertElementAtEnd()
        {
            SimpleNode node = null;
            char flag = 'N';

            do
            {
                Console.WriteLine("Insert Numeric Element");
                var value = Convert.ToInt32(Console.ReadLine());
                if (node == null)
                {
                    var element = new SimpleNode(value);
                    node = element;
                }
                else
                {
                    SimpleNode p = node;
                    while (p.Link != null)
                    {
                        p = p.Link;
                    }

                    var element = new SimpleNode(value);
                    p.Link = element;
                }

                Console.WriteLine("Do You Insert More Numeric Element (Y/N)");
                flag = Convert.ToChar(Console.ReadLine()?.ToUpper());
            }
            while (flag == 'Y');

            DisplayElement(node);

            return node;
        }

        public static void InsertElementAtPosition(SimpleNode node)
        {
            if (node != null)
            {
                Console.WriteLine("Insert Numeric Element");
                var value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert element index");
                var index = Convert.ToInt32(Console.ReadLine());

                SimpleNode p = node;
                for (int i = 0; i < index - 2; i++)
                {
                    p = p.Link;
                }

                var element = new SimpleNode(value);
                element.Link = p.Link;
                p.Link = element;
            }
            else
            {
                Console.WriteLine("list empty");
            }

            DisplayElement(node);
        }

        public static void InsertElementAfterValue(SimpleNode node)
        {
            if (node != null)
            {
                Console.WriteLine("Insert Numeric Element");
                var value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert after element");
                var afterValue = Convert.ToInt32(Console.ReadLine());

                SimpleNode p = node;
                while (p.Link != null)
                {
                    if (p.data == afterValue)
                    {
                        break;
                    }
                    p = p.Link;
                }

                var element = new SimpleNode(value);
                element.Link = p.Link;
                p.Link = element;
            }
            else
            {
                Console.WriteLine("list empty");
            }

            DisplayElement(node);
        }

        public static void InsertElementBeforeValue(SimpleNode node)
        {
            if (node != null)
            {
                Console.WriteLine("Insert Numeric Element");
                var value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert before element");
                var afterValue = Convert.ToInt32(Console.ReadLine());

                SimpleNode p = node;
                while (p.Link != null)
                {
                    if (p.Link.data == afterValue)
                    {
                        break;
                    }
                    p = p.Link;
                }

                var element = new SimpleNode(value);
                element.Link = p.Link;
                p.Link = element;
            }
            else
            {
                Console.WriteLine("list empty");
            }

            DisplayElement(node);
        }

        public static void InsertElementAtFront(SimpleNode node)
        {
            SimpleNode elementNode = null;
            if (node != null)
            {
                Console.WriteLine("\n inserting element in front");
                Console.WriteLine("Insert Numeric Element");
                var value = Convert.ToInt32(Console.ReadLine());

                elementNode = new SimpleNode(value);
                elementNode.Link = node;
            }
            else
            {
                Console.WriteLine("list empty");
            }

            DisplayElement(elementNode);
        }

        public static void DisplayElement(SimpleNode node)
        {
            while (node != null)
            {
                Console.Write("{0},", node.data);
                node = node.Link;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SingleLinkedListExample.CallMain();

            //xyz obj = new xyz();
            //xyz obj2 = new xyz();

            //obj.MyProperty = 2;
            //Console.WriteLine(obj.MyProperty);
            //Console.WriteLine(obj2.MyProperty);
            //obj2 = obj;
            //obj.MyProperty = 3;
            //Console.WriteLine(obj.MyProperty);
            //Console.WriteLine(obj2.MyProperty);

            Console.ReadLine();
        }

        public class xyz
        {
            public int MyProperty { get; set; }
        }

        public class asd
        {
            public int MyProperty2 { get; set; }
        }
    }
}
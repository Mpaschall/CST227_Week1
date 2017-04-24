using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_9
{
    class Program
    {
        private String first;
        private char initial;
        private String last;
        public _6_9(String f, String l)
        {
            first = f;
            last = l;
        }
        public _6_9(String f, char i, String l) : this(f,l)
        {
            initial = i;
        }
        public override String ToString()
        {
            if (initial == '\u0000')
                return first + " " + last;
            else
            return first + " " + initial + " " + last;
        }
        
        static void Main(string[] args)
        {
            _6_9 name1 = new _6_9("Bill", 'A', "Hawking");
            _6_9 name2 = new _6_9("Bill", 'J', "Hawking");

            if (name1.last.CompareTo(name2.last) = 0)
            {
                if (name1.first.CompareTo(name2.first) = 0)
                {
                    name1.initial.CompareTo(name2.initial);
                }
            }
            else if (name1.last.CompareTo(name2.last) = -1)
            {
                Console.WriteLine("this returns -1");
            }
            else if (name1.last.CompareTo(name2.last) = 1)
            {
                Console.WriteLine("this returns 1");
            }




        }
    }
}

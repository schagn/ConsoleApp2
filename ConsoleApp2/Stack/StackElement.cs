using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class StackElement <T>
    {
        static void Main(string[] args)
        {
        }

        public T ValueOfStackElement { get; set; }
        public StackElement<T> Ancestor { get; set; }


    }
}

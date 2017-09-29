using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class Stack<T>
    {
        static void Main(string[] args)
        {
        }

        private StackElement<T> CurrentStackElement { get; set; }

        public void Push(T NewElement)
        {
            if (CurrentStackElement == null) // no Element stored in the Stack yet, Initialise new Element without Ancestor
            {
                CurrentStackElement = new StackElement<T>() { ValueOfStackElement = NewElement, Ancestor = null };
            }  // 0815 Scenario, new Element is created, Current Stack Element becomes his Ancestor 
                // and this new Element is set as the new Current Element

                StackElement<T> PushElement = new StackElement<T>() { ValueOfStackElement = NewElement, Ancestor = CurrentStackElement };

            CurrentStackElement = PushElement;
            
        }


        public T Pop()
        {
            if (CurrentStackElement == null) throw new NullReferenceException(); // no Elements stored in the Stack

            else if (CurrentStackElement != null) // stack Element is existing -> Current Element is stored temporarily, 
                // new Curent Element gets his Ancestor, the value of the removed Element should be given back 
            {
                StackElement<T> PopElement = CurrentStackElement;

                CurrentStackElement = PopElement.Ancestor;

                return PopElement.ValueOfStackElement;
            }
            else throw new NullReferenceException(); // if something different occures, an exception is thrown anyway 
            
            
        }

        public T Peek()
        {
            if(CurrentStackElement != null) // if not null, return the value of the current element
            {
                return CurrentStackElement.ValueOfStackElement;

            } else // else (CurrentStackElement not set) return default value for T 
            {
                return default(T);
            }
        }

    }
}

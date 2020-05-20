using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Zad3
{
    class CareTaker
    {
        public Memento PreviousState { get; set; }
        Stack<Memento> stack = new Stack<Memento>();

        public void PushStack(Memento memento)
        {
            stack.Push(memento);
        }
        public Memento PopStack()
        {
            return stack.Pop();
        }

    }
}

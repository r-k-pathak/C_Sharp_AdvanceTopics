using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_AdvanceTopics.Section2_Inheritance.Exercise
{
    class Stack
    {
        private List<object> _stack;
        public Stack()
        {
            _stack = new List<object>();
        }
        public void Push(object Itme)
        {
            if (Itme == null)
                throw new InvalidOperationException("Null is not allowed as valide value for stack.");
            _stack.Add(Itme);
            Console.WriteLine( "Item pushed.");
        }
        public Object  Pop()
        {
            int length = _stack.Count;
            if (length == 0)
                throw new InvalidOperationException("There is no element in Stack");
            var popedOutItem = _stack.ElementAtOrDefault(length - 1);
            _stack.RemoveAt(length-1);
           return popedOutItem;
        }
        public string Clear()
        {
            int lenght = _stack.Count;
            if(lenght==0)
                throw new InvalidOperationException("There is no element in Stack");
            _stack.RemoveRange(0,lenght-1);
           return "Stack is cleared.";
        }
    }
}

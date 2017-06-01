using System.Collections.Generic;

namespace stack
{
    public class Stack
    {
        private List<object> StackList { get; set; }
        
        public Stack()
        {
            StackList = new List<object>();
        }

        public void Push(object obj)
        {
            StackList.Add(obj);
            System.Console.WriteLine("Object added successfuly");
        }

        public object Pop()
        {
            if (StackList.Count > 0)
            {
                var popedObj = StackList[StackList.Count - 1];
                StackList.RemoveAt(StackList.Count - 1);
                return popedObj;
            }
            else
            {
                System.Console.WriteLine("no items left to pop");
                return -1;
            }
        }

        public void Clear()
        {
            StackList.Clear();
        }
    }
}
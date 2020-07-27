using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        try
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Stack is empty");
        }  
        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            string temp = null;
            while (temp != search)
            {
                temp = aStack.Pop();
            }
        }
        else 
        {
            Console.WriteLine("Stack contains \"{0}\": False", search);
        }
        aStack.Push(newItem);
        return aStack;
    }
}

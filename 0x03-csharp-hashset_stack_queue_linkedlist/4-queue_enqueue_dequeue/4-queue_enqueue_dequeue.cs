using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        try
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Queue is empty");
        }
        aQueue.Enqueue(newItem); 
        if (aQueue.Contains(search))
        {
            Console.WriteLine("Queue contains \"{0}\": True", search);
            string temp = null;
            while (temp != search)
            {
                temp = aQueue.Dequeue();
            }
        }
        else 
        {
            Console.WriteLine("Queue contains \"{0}\": False", search);
        }
        return aQueue;
    }
}

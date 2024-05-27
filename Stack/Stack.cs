using System;
using System.Collections.Generic;
public class Stack
{
    public object obj { get; set; }
    public readonly List<object> Objects;

    public Stack()
    {
        Objects = new List<object>();
    }


    public void Push(object obj)
    {
        if (obj != null)
        {
            Objects.Add(obj);
        }
        else
        {
            Console.WriteLine("Null cannot be added into the stack");
        }
    }

    public object Pop()
    {
        try
        {
            if (Objects.Count == 0)
            {
                throw new ArgumentOutOfRangeException("thisParameter");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Pop() cannot be called on an empty stack");            
        }

        var popped = Objects[Objects.Count - 1];
        Objects.RemoveAt(Objects.Count - 1);
        return popped;
    }

    public void Clear()
    {
        Objects.Clear();
    }
}

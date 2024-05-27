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
            throw new InvalidOperationException();
        }
    }

    public object Pop()
    {
        if (Objects.Count == 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        var index = Objects.Count - 1;
        var popped = Objects[index];
        Objects.RemoveAt(index);
        return popped;
    }

    public void Clear()
    {
        Objects.Clear();
    }
}

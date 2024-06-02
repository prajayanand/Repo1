using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private readonly Stack<T> _stack = new Stack<T>();

    public int Count()
    {
        return _stack.Count;
    }

    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _stack.Pop();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }
}



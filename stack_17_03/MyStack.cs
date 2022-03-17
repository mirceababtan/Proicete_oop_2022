﻿
using System.Diagnostics;

public class MyStack
{

    private int[] _data;
    private int _capacity = 16;
    private int _count = 0;

    public MyStack()
    {
        _data = new int[_capacity];

    }

    public void Push(int value)
    {
        Debug.WriteLine($"Incerc sa adaug valoarea {value} in stiva");
        
        if(Count == Capacity)
        {
            _capacity *= 2;
            int[] vs = new int[_capacity];
            for (int i = 0; i < Count; i++)
            {
                vs[i] = _data[i];
            }
            _data = vs;
            Debug.WriteLine("Se dubleaza capacitatea stivei");
        }

        _data[Count] = value;
        _count++;
    }


    public int Capacity
    {
        get
        {
            return _capacity;
        }
    }

    public int Count
    {
        get
        {
            return _count; 
        }
    }

    public int Pop()
    {
        if(Count > 0)
        {
            _count--;
            Debug.WriteLine($"Se elimina din stiva elementul {_data[_count]}");
            return _data[_count];
        }
        else
        {
            throw new StackEmptyException("Am incercat sa elimin un element din stiva goala.s");
        }
    }

    public int Peek()
    {
        if (Count > 0)
        {
            return _data[Count-1];
        }
        else
        {
            throw new StackEmptyException("Am incercat sa examinez vf unei stive goale");
        }
    }
}
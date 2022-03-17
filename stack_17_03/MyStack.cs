
internal class MyStack
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
        Console.WriteLine($"Incerc sa adaug valoarea {value} in stiva");
        
        if(Count < Capacity)
        {
            _data[Count] = value;
            _count++;
        }

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
}
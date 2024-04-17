using System.Collections;

namespace IntArrayList;
class Program
{
    static void Main(string[] args)
    {
        IntArrayList ls = new IntArrayList();
        ls.Add(1);
        ls.Add(4);
        ls.Add(7);
        ls.Add(10);
        ls.Add(13);
        ls.Add(16);
        ls.Add(19);
        ls.Add(22);
        ls.GetElements();
        Console.WriteLine(ls);
        ls.ToString();
    }
}
class IntArrayList
{
    int[] _arr;

    public int Capacity { get; set; } = 5;
    public int Count { get; set; } = 0;
    public IntArrayList()
    {
        _arr = new int[Capacity];
    }
    public IntArrayList(int capacity)
    {
        Capacity = capacity;
        _arr = new int[Capacity];
    }
    public void Add(int value)
    {
        if (_arr.Length==Count)
        {
            Array.Resize(ref _arr, Count + Capacity);
        }
        _arr[Count] = value;
        Count++;
    }
    public void GetElements()
    {
        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine(_arr[i]);
        }
    }

    public void ToString()
    {
        string result = string.Join(", ", _arr.ToArray());  //Muellim bunu kecmemishik arashdirib bunu tapdim.
        Console.WriteLine(result);
    }
    //public void RemoveItem(int _arr, object item)
    //{
    //    for (int i = 0; i < _arr.Count; i++)
    //    {
    //        if (_arr[i] == item)
    //        {
    //            list.RemoveAt(i);
    //        }
    //    }
    //}
}

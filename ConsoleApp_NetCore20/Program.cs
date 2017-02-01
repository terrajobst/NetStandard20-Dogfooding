using System;

class Program
{
    static void Main(string[] args)
    {
        var items = ClassLibrary1.Class1.CreateData();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
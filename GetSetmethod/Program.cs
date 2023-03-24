using System;



namespace GetSetmethod
{
    class Person
    {
       public string Name
        { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ob = new Person();
            ob.Name="samia";
            Console.WriteLine(ob.Name);
        }
    }
}

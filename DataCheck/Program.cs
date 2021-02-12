using System;

namespace DataCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 class1 = new Class1();
            Class2 class2 = new Class2(class1);
            Class3 class3 = new Class3(class1);
            class2.addMyName();
            class2.addMyName();
            class3.addMySurName();
            class2.addMyName();
            class3.addMySurName();
            class3.addMySurName();
        }
    }
}

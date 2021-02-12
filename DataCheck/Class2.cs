using System;
namespace DataCheck
{
    public class Class2
    {
        Class1 class1;
        public Class2(Class1 class1)
        {
            this.class1 = class1;
        }

        public void addMyName()
        {
            class1.Names.Add("Sanchit");
            foreach(string name in class1.Names)
            {
                Console.Write(name + '\t');
            }
            Console.WriteLine("\n");
        }
    }
}

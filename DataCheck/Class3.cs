using System;
namespace DataCheck
{
    public class Class3
    {
        Class1 class1;
        public Class3(Class1 class1)
        {
            this.class1 = class1;
        }

        public void addMySurName()
        {
            class1.Names.Add("Rastogi");
            foreach (string name in class1.Names)
            {
                Console.Write(name + '\t');
            }
            Console.WriteLine("\n");
        }
    }
}

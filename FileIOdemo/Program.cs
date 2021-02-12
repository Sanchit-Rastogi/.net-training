using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo currDer = new DirectoryInfo(".");
            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
            Console.WriteLine("This is the directory name -> " + directoryInfo.FullName);
            //Console.WriteLine("This is the folder name -> " + directoryInfo.Name);
            //Console.WriteLine("This is the parent name -> " + directoryInfo.Parent);
            //Console.WriteLine("This is the attribute name -> " + directoryInfo.Attributes);
            //Console.WriteLine("This is the creation time -> " + directoryInfo.CreationTime);

            //string[] names =
            //{
            //    "Elon Musk",
            //    "Jeff Bezos",
            //    "Bill Gates"
            //};

            string textFilePath = $"{Environment.CurrentDirectory}/names.txt";

            FileStream fs = File.Open(textFilePath, FileMode.Create);

            string randomText = "This is random text string to hold some text";

            byte[] rtByteString = Encoding.Default.GetBytes(randomText);

            fs.Write(rtByteString, 0, rtByteString.Length);

            fs.Position = 0;

            byte[] fileByteArray = new byte[rtByteString.Length];

            for (int i = 0; i < rtByteString.Length; i++) {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();

            //File.WriteAllLines(textFilePath, names);



            Console.ReadLine();
        }
    }
}

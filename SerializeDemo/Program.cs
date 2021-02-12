using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser", 45, 35);

            Stream stream = File.Open("AnimalData.dat", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, bowser);

            stream.Close();

            bowser = null;

            stream = File.Open("AnimalData.dat", FileMode.Open);

            bf = new BinaryFormatter();

            bowser = (Animal)bf.Deserialize(stream);

            stream.Close();

            Console.WriteLine(bowser.ToString());

            bowser.Weight = 50;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Animal));

            using (TextWriter tw = new StreamWriter($"{Environment.CurrentDirectory}/bowser.xml")) {
                xmlSerializer.Serialize(tw, bowser);
            }

            bowser = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));

            TextReader reader = new StreamReader($"{Environment.CurrentDirectory}/bowser.xml");

            object obj = deserializer.Deserialize(reader);

            bowser = (Animal)obj;

            reader.Close();

            Console.WriteLine(bowser.ToString());

            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60, 30),
                new Animal("Luigi", 50, 20),
                new Animal("Peach", 70, 40),
            };

            using (Stream fs = new FileStream($"{Environment.CurrentDirectory}/animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));
                serializer.Serialize(fs, theAnimals);
            }

            theAnimals = null;

            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fileStream = File.OpenRead($"{Environment.CurrentDirectory}/bowser.xml")) {
                theAnimals = (List<Animal>)xmlSerializer1.Deserialize(fileStream);
            }

            foreach (Animal a in theAnimals) {
                Console.Write(a.ToString());
            }

            Console.ReadLine();
        }
    }
}

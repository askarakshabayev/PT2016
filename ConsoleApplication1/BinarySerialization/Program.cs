using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    namespace Serialization
    {
        [Serializable]
        class Person
        {
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        class Program
        {
            public static void Main(String[] args)
            {
                Person person = new Person("Askar", 29);
                Console.WriteLine("Объект создан");
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream("people.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                formatter.Serialize(fs, person);
                Console.WriteLine("Объект сериализован");
                fs.Close();

                FileStream f = new FileStream("people.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Person p = (Person)formatter.Deserialize(f);
                Console.WriteLine(p.name + " " + p.age);
                f.Close();
                Console.ReadLine();
            }
        }
    }
}

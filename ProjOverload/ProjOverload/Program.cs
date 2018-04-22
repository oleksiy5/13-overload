using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tomek = new Person();
            Person ala = new Person("Ala");

            string result = $"{ala.GetName()} nie ma kota." +
                $" Kota ma {tomek.GetName()}.";

            Console.WriteLine(result);
            Console.ReadKey();
        }        
    }

    class Person
    {
        string _name;

        public Person()
        {
            _name = "Tomek";
        }

        public Person(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }


}

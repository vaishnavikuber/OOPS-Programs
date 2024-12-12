using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Programs
{
    internal class InheritanceExample
    {

        public string Name = "Vaishnavi";

        public void Display()
        {
            Console.WriteLine("Here is the inheritance example");
        }

    }

    class Derived:InheritanceExample
    {
        //static void Main(string[] args)
        //{
        //    Derived derived = new Derived();
        //    derived.Display();
        //    Console.WriteLine(derived.Name);
        //}
    }
}

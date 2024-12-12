using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Programs
{
    internal class CompileTimePolymorphism
    {

        void Display(string FName,string LName)
        {
            Console.WriteLine($"Hii {FName} {LName}");
        }

        void Display(string FName, string MName, string LName)
        {
            Console.WriteLine($"Hii {FName} {MName} {LName}");
        }

        void Display(string FName)
        {
            Console.WriteLine($"Hii {FName}");
        }
        static void Main(string[] args)
        {
            CompileTimePolymorphism com = new CompileTimePolymorphism();
            com.Display("Vaishnavi");
            com.Display("Vaishnavi", "Kuber");
            com.Display("Vaishnavi", "G", "Kuber");
        }

    }
}

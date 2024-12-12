using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Programs
{
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.SetName("ShriPrabha");
            emp1.SetAge(43);
            emp1.SetDesignation("CEO");

            Console.WriteLine( emp1.GetName() );
            Console.WriteLine(emp1.GetAge());
            Console.WriteLine(emp1.GetDesignation());
        }


    }

    public class Employee
    {
        private string Name;
        private int Age;
        private string Designation;

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetDesignation(string des)
        {
            Designation = des;
        }

        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetDesignation()
        {
            return Designation;
        }
    } 
}

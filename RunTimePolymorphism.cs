using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Programs
{
    internal class RunTimePolymorphism
    {

        public virtual void Animal()
        {
            Console.WriteLine("Animal");
        }


    }

    class Dog : RunTimePolymorphism
    {
        public override void Animal()
        {
            Console.WriteLine("I am a Dog , I bark!!!");
        }
    }

    class Cat : RunTimePolymorphism
    {

        public override void Animal()
        {
            Console.WriteLine("I am a Cat , I Meow!!!");
        }

    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    static void Select(RunTimePolymorphism animal)
        //    {
        //        animal.Animal();
        //    }

        //    Select(new Dog());
        //    Select(new Cat());
        //}
    }
}

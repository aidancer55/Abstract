using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Console.Write("{0} говорит ", cat.Name);
            cat.Say();
            Console.Write("{0} говорит ", dog.Name);
            dog.Say();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();
    }
    class Cat : Animal
    {
        string CatName = "Мурка";
        public override string Name
        {
            get
            {
                return CatName;
            }
            set
            {
                CatName = value;
            }

        }
        public override void Say()
        {
            Console.WriteLine("'Мяу'");
        }
    }
    class Dog : Animal
    {
        string DogName = "Шарик";
        public override string Name
        {
            get
            {
                return DogName;
            }
            set
            {
                DogName = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("'Гав'");
        }
    }

}

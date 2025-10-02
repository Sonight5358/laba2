using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class Program
    {
        public interface Pet
        {
            string GetName();
            void Noise();
        }

        public abstract class Animal : Pet
        {
            private string Name;

            public Animal(string Name)
            {
                this.Name = Name;
            }

            public abstract void Noise();

            public string GetName()
            {
                return this.Name;
            }
        }

        public class Turtle : Animal
        {
            public Turtle(string Name) : base(Name) { }
            public override void Noise()
            {
                Console.WriteLine("TurtleSound.mp3");
            }
        }

        public class Parrot : Animal
        {
            public Parrot(string Name) : base(Name) { }

            public override void Noise()
            {
                Console.WriteLine("ParrotSound.mp3");
            }
        }

        public class Person
        {
            private Pet pet;
            public string name;

            public Person(Pet pet, string name)
            {
                this.pet = pet;
                this.name = name;
            }

            public void GetPetInfo()
            {
                Console.WriteLine("Pet for {0} is named {1}", name, pet.GetName());
                Console.WriteLine("It sounds like:");
                pet.Noise();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Parrot parrot1 = new Parrot("Bashmak");
            Turtle turtle1 = new Turtle("Donatello");
            Person person1 = new Person(parrot1, "Serega");
            Person person2 = new Person(turtle1, "Kostyan");
            person1.GetPetInfo();
            person2.GetPetInfo();
        }
    }
}

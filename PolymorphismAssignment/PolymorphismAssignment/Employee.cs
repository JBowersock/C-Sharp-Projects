using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Step 2.
    public class Employee : IQuittable //Inhereting from interface 'IQuittable'.
    {
        public void Quit(string a) //Method. 
        {
            Console.Write("This is a sentence from Class Employee. " + a); //Prints string and result.
            //Result: The string prints, however the value 'a' changes to 'b' with polymorphism. 'b' is sent from Program.cs (Line 14), to IQuittable's Quit() method, then to here.
        }
    }
    
    //Step 3
    public class Animal //Base Class (Parent)
    {
        public void animalSize() //Method.
        {
            Console.WriteLine("Animals come in various sizes."); //Prints string.
        }
    }
    public class Bird : Animal //Derived Class (Child)
    {
        public void animalSize() //Method.
        {
            Console.WriteLine("Birds are small."); //Prints string.
        }
    }
    public class Bear : Animal //Derived Class (Child)
    {
        public void animalSize() //Method.
        {
            Console.WriteLine("Bears are large."); //Prints string.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Age;
            string Address;
            int Contact;

            Console.WriteLine("Enter the Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Address: ");
            Address = Console.ReadLine();

            Console.WriteLine("Enter the Contact: ");
            Contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Name:   " + Name);
            Console.WriteLine("Age:   " + Age);
            Console.WriteLine("Address:   " + Address);
            Console.WriteLine("Contact:   " + Contact);


            //Console.WriteLine("Name           Age      Address      Contact  ");
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine(Name + "       " + Age + "      " + Address + "     " + Contact);

         


            Console.ReadKey();


        }
    }
}

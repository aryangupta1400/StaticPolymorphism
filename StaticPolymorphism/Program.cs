
// 2) Print Firstname, Lastname, City, Mobile number, Email using Static polimorphism

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Aryan", "Gupta", "Surat, Gujarat", 1234567890, "aryan.gupta@oneadvanced.com");

            employee.display();
            Console.ReadKey();
        }
    }

    class Employee
    {
        string firstName, lastName, city, email;
        int mobileNumber;

        public Employee(string firstName, string lastName, string city, int mobileNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.mobileNumber = mobileNumber;
            this.email = email; 
        }

        public void display()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Home City: " + city);
            Console.WriteLine("Contact Number: " + mobileNumber);
            Console.WriteLine("Work Email: " + email);
        }

    }

}

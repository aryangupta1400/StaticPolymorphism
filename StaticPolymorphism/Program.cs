
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
            Employee employee = new Employee();
            employee.EmployeeDetails("Aryan", "Gupta", "aryan.gupta@oneadvanced.com");
            employee.EmployeeDetails("Aryan", "Gupta", "Surat, Gujarat", 1234567890, "aryan.gupta@oneadvanced.com");

            Console.ReadKey();
        }
    }

    class Employee
    {                       
        public void EmployeeDetails(string firstName, string lastName, string email)
        {
            Console.WriteLine("\nFull Name: " + firstName + " " + lastName);
            Console.WriteLine("Work Email: " + email);
        }

        public void EmployeeDetails(string firstName, string lastName, string city, int mobileNumber, string email)
        {
            Console.WriteLine("\n\nName: " + firstName + " " + lastName);
            Console.WriteLine("Home City: " + city);
            Console.WriteLine("Contact Number: " + mobileNumber);
            Console.WriteLine("Work Email: " + email);
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Person
    {
        public int Id { get; set; } // it get initialized so that it does not through null
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }=string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty; 
        public string PostalCode { get; set; }= string.Empty;
        public string Country { get; set; } = String.Empty;
        public string Phone { get; set; }=String.Empty;
        public override string ToString()
        {
            return $"ID:{this.Id},Name:{FirstName}{LastName},\n" +
                $"Adresss:{Address},city:{City},state:{Region},\n" +
                $" phone:{Phone},country:{Country},Zip:{PostalCode}";
        }
    }
    internal class Testperson
    {
        public static void Testone() 
        {
        Person firstperson = new Person();
        firstperson.Id = 1;
            firstperson.FirstName = "shri";
            firstperson.LastName = "J";
            firstperson.Address = "vadapalani";
            firstperson.City = "chennai";
            firstperson.Country = "India";
            firstperson.Phone = "1234567890";
            string value=firstperson.ToString();
            Console.WriteLine(value);
        }
    }
}

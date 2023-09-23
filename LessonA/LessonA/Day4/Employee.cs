using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day4
{
    public enum city { chennai,bangalore,hydrabad}
    public enum Designation { Manager, Admin ,Developer}
    internal class Employee
    {
        public readonly int EId;

        public string Ename;
        public city Ecity;
        public Designation jobtitle;
        public Employee(int v1) { EId= v1; }

        public override string ToString()
        {
            String output = string.Empty;
            output = $" Details of a employee are:{EId}{Ename}{jobtitle}";
            return output;
        }
    }
    class Testemployee
    {
        public static void Testone()
        { Employee e1 = new Employee(348);
            e1.Ename = "shri";
            e1. Ecity = city.chennai;
            e1.jobtitle=Designation.Manager;
            String output = e1.ToString();
            Console.WriteLine(output);

        }
    }

    
}

using LessonA.Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day6
{
        class EmpA
        {
            public int Eno = 0;
            private readonly Address address;
            public EmpA()
            {
                address=new Address(this);

            }
            public Address GetAddress()
            {
                return address;
            }
            //Inner class
            public class Address
            {
                public string Address1;
                public string Address2;
                private readonly EmpA e1;

                internal Address(EmpA outerEmpA)
                {
                    if (outerEmpA == null)
                        throw new NullReferenceException("outer EmpA is Null!!");
                    e1 = outerEmpA;

                }
                public override string ToString()
                {
                    return Address1 + "'" + Address2 + "of" + e1.Eno;
                }
                //end of Address
                //end of EmpA
            }
            
        }
        class TestEmp
        {
            public static void TestA()
            {
                try
                {
                    EmpA.Address address = new EmpA.Address(null);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                EmpA e1 = new EmpA();
                //Inner class object
                EmpA.Address add = e1.GetAddress();
                add.Address1 = "Ambattur";
                add.Address2 = "Chennai";
                Console.WriteLine($"Address1:{add.Address1}");
                Console.WriteLine($"Address2:{add.Address2}");
            }
        }
    
}

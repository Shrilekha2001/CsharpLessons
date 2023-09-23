using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal sealed class Invoice
    {
        public Invoice()
        {
            Console.WriteLine("Invoice Constructor...");
        }
    }
    internal class Bill
    {
        private Bill()
        {
            Console.WriteLine("Bill Constructor...");
        }
        public static Bill CreateBill()
        {
            return new Bill();
        }
    }
    public class BillTester
    {
        public static void TestOne()
        {
            //Bill bill = new Bill();
            Bill bill = Bill.CreateBill();
        }
    }


}

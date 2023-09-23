using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal interface MessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceivedMessage();
        void DeleteMessage();
    }
    public interface Payment
    {
        void MakePayment(float amount);
    }
    internal class Whatsapp : MessageService, Payment
    {
        public void MakePayment(float amount)
        {
            Console.WriteLine($"paid amount{amount}");
        }
        public void DeleteMessage()
        {
            Console.WriteLine("NotImplementedException();");
        }
        public void ReceivedMessage()
        {
            Console.WriteLine("NotImplementedException();");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("NotImplementedException();");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("NotImplementedException();");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("NotImplementedException();");
        }
    }
    public class MessageTester
    {
        public static void TestOne()
        {
            MessageService service = new Whatsapp();
            service.SendVideoMessage("hello");
            service.SendAudioMessage("hi");
            service.SendMessage("welcome");
            service.ReceivedMessage();
            service.DeleteMessage();




        }
        public static void TestTwo()
        {


        }
    }
}

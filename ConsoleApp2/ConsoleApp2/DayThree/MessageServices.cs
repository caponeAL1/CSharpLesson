using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayThree
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceivedMessage();
        void DeleteMessage();

    }
     public interface IPayments
    {
        void Makepayment(float amount);
    }
    internal class WhatsApp : IMessageService, IPayments
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Message Deleted");
        }
        public void Makepayment(float amount)
        {
            Console.WriteLine($"Paid Amount:{amount}");
        }
        public void ReceivedMessage()
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method Not IMplemented");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Methid Not Implemented");
        }
    }
    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new WhatsApp();
            messageService.SendMessage("hello");
            messageService.ReceivedMessage();

        }
    }
}

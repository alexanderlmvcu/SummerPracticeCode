using System;

namespace CallMeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phone number");
            var toNumber = new PhoneNumber($"+1{Console.ReadLine()}");
            Console.WriteLine("Enter a name:");




            InitTwilioClient();

            SendSms(toNumber, fromNumber, name);
        }
    }
}

using System;

namespace DelegatesBasic
{
    class Program
    {
        delegate void LogDel(string text, DateTime dateTime);
        static void Main(string[] args)
        {
            LogDel logdel = new LogDel(LogTextToScreen); //Pass tne name of the method (like: LogTextToScreen) that we want the logdel variable to reference into the logdel types constructor
            //logdel("Hi Jaanu!");   // or logdel.Invoke("Hi Jaanu!") - can also invoke delegates through the use of delegates types invoke method \
            Console.Write("Kindly Enter Your Name : ");
            var name = Console.ReadLine();
            logdel(name, DateTime.Now);
            Console.ReadKey();
        }
        static void LogTextToScreen(string text, DateTime dateTime){
            Console.WriteLine($"{dateTime} : Nice to see you {text}!");
        }
    }
}
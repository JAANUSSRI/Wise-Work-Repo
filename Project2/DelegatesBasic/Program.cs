using System;

namespace DelegatesBasic
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            LogDel logdel = new LogDel(LogTextToScreen); //Pass tne name of the method (like: LogTextToScreen) that we want the logdel variable to reference into the logdel types constructor
            logdel("Hi Jaanu!");   // or logdel.Invoke("Hi Jaanu!") - can also invoke delegates through the use of delegates types invoke method 
            Console.ReadKey();
        }
        static void LogTextToScreen(string text){
            Console.WriteLine($"{DateTime.Now} : {text}");
        }
    }
}
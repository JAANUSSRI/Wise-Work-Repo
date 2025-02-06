using System;

namespace DelegatesBasic
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            // LogDel logdel = new LogDel(LogTextToScreen); //Pass tne name of the method (like: LogTextToScreen) that we want the logdel variable to reference into the logdel types constructor
            // logdel("Hi Jaanu!");   // or logdel.Invoke("Hi Jaanu!") - can also invoke delegates through the use of delegates types invoke method \
            LogDel logdel = new LogDel(LogTextToFile); // now logdel variable referencing to file
                                                       // creates log.txt file in Project2\DelegatesBasic\bin\Debug\net9.0\Log.txt
            Console.Write("Kindly Enter Your Name : ");
            var name = Console.ReadLine();
            logdel(name);
            Console.ReadKey();
        }
        static void LogTextToScreen(string text){
            Console.WriteLine($"{DateTime.Now} : Nice to see you {text}!");
        }
        static void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now} : {text}");
            }
        }
    }
}
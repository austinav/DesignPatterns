using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Runtime;
using System.Text;

using ConsoleApp1.Patterns.Decorator;
using DesignPatterns;

namespace classes
{
    class Program
    {
        public static void Main()
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            List<Type> apps = thisAssembly.GetTypes()
                        .Where(t => t.BaseType == thisAssembly.GetType("DesignPatterns.App"))
                        .ToList();
            string appToRun = ChooseApp(apps);
            while (appToRun != "quit")
            {
                Console.Clear();
                Console.WriteLine("Program: " + appToRun);
                Console.WriteLine("__________________________________________________");
                Console.WriteLine();

                try
                {
                    Type appType = apps.Where(t => t.Name == $"{appToRun}App").FirstOrDefault();
                    App app = (App)Activator.CreateInstance(appType);

                    app.Run();
                }
                catch
                {
                    Console.WriteLine("Your selection is invalid");
                    Console.WriteLine();
                }

                appToRun = ChooseApp(apps);
            }

            Console.WriteLine();
            Console.WriteLine("Goodbye");
        }

        private static string ChooseApp(List<Type> apps)
        {
            Console.WriteLine("What program do you want to run?");
            Console.WriteLine();
            apps.OrderBy(t => t.Name).ToList().ForEach(a => Console.WriteLine(FormatAppName(a.Name)));
            Console.WriteLine();
            return Console.ReadLine();
        }

        private static string FormatAppName(string className) 
        {
            return className.Substring(0, className.Length-3);
        }
    }
}

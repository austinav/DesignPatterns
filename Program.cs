using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;

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
            string appToRun = ChooseApp(string.Join(", ", apps.Select(t => t.Name)));
            while (appToRun != "quit")
            {
                Console.Clear();
                Console.WriteLine("Program: " + appToRun);
                Console.WriteLine("__________________________________________________");
                Console.WriteLine();

                try
                {
                    Type appType = apps.Where(t => t.Name == appToRun).FirstOrDefault();
                    App app = (App)Activator.CreateInstance(appType);

                    app.Run();
                }
                catch
                {
                    Console.WriteLine("Your selection is invalid");
                    Console.WriteLine();
                }

                appToRun = ChooseApp(string.Join(", ", apps.Select(t => t.Name)));
            }

            Console.WriteLine();
            Console.WriteLine("Goodbye");
        }

        private static string ChooseApp(string selections)
        {
            Console.WriteLine("What program do you want to run?");
            Console.WriteLine(selections);
            Console.WriteLine();
            return Console.ReadLine();
        }
    }
}

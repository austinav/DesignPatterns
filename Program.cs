using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;

using ConsoleApp1.Patterns.Decorator;
using ConsoleApp1;

namespace classes
{
    class Program
    {
        public static void Main()
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            List<Type> apps = thisAssembly.GetTypes()
                        .Where(t => t.Name.EndsWith("App") && !t.IsAbstract)
                        .ToList();

            Console.WriteLine("What program do you want to run?");
            Console.WriteLine(string.Join(", ", apps.Select(t => t.Name)));
            Console.WriteLine();
            string appToRun = Console.ReadLine();

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
            }
        }
    }
}

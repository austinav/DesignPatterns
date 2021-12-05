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


            #region primeNumberStuff
            ////find all prime number to y
            //List<int> primeNumbers = new List<int>();
            //int countDivisors = 0;
            //for (int i = 1; i <= y; i++) 
            //{
            //    countDivisors = 0;

            //    for (int checkNumber = 2; checkNumber <= i / 2; checkNumber++)
            //    {
            //        if (i % checkNumber == 0)
            //        {
            //            countDivisors++;
            //            break; 
            //        }
            //    }

            //    if(countDivisors == 0 && i != 1)
            //    {
            //        primeNumbers.Add(i);
            //    }

            //}

            ////find prime number between x and y
            //List<int> primeNumbersBetween = primeNumbers.Where(pn => pn >= x && pn <= y).ToList();

            ////find prime numbers that are sum of 2 consecutive prime numbers + 1
            //int sum = 0;
            //int counter = 0;
            //for (int pnbIndex = 0; pnbIndex < primeNumbersBetween.Count(); pnbIndex++)
            //{
            //    List<int> primeNumbersBeforeHalf = primeNumbers.Where(pnbh => (double)pnbh <= (double)(primeNumbersBetween[pnbIndex] / 2)).ToList();
            //    List<int> primeNumbersAfterHalf = primeNumbers.Where(pnah => (double)pnah > (double)(primeNumbersBetween[pnbIndex] / 2)).ToList();

            //    if(primeNumbersBeforeHalf.Count > 0)
            //    { 
            //        sum = primeNumbersBeforeHalf.Last() + primeNumbersAfterHalf.First() + 1;
            //    }

            //    if (sum == primeNumbersBetween[pnbIndex]) {
            //        counter++;
            //    }

            //}

            //Console.WriteLine(counter);


            //find all prime number to y

            //  while (++linesRead < inputSize)
            //  {
            //      arrayValues.AddRange(new List<String>() { "value2", "value3"});
            //  }

            //arrayValues.Reverse(); // Reverse(arrayValues);

            //  Console.Write(string.Join(" ", arrayValues));


            //// START READ
            //List<String> stringLIst = new List<String>();
            //string currentLine;

            //currentLine = Console.ReadLine();
            //while (!(currentLine == null) && (i < 5))
            //{
            //    stringLIst.Add(currentLine);
            //    Console.WriteLine("current line: " + currentLine + " Length=" + currentLine.Length);
            //    Console.WriteLine(string.Join(", ", stringLIst));
            //    currentLine = Console.ReadLine();
            //    i++;
            //}
            //// END READ

            //add 2 integers
            //string currentLine;
            //int integer1 = 0, integer2 = 0, sum = 0;
            //int currentLineNumber = 1;

            //currentLine = Console.ReadLine();
            //while (!(currentLine == null))
            //{
            //    if (++currentLineNumber % 2 != 0)
            //    {
            //        int.TryParse(currentLine, out integer2);
            //        sum = integer1 + integer2;
            //        Console.WriteLine(sum);
            //    }
            //    else
            //        int.TryParse(currentLine, out integer1);

            //    currentLine = Console.ReadLine();

            //}



            //// Test if input arguments were supplied.
            //if (arguments.Length == 0)
            //{
            //    Console.WriteLine("Please enter a numeric argument.");
            //    Console.WriteLine("Usage: Factorial <num>");
            //}
            #endregion
        }
    }
}

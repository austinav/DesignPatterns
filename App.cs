using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class App
    {
        public abstract void MainProgram();
        public void Run()
        {
            string whatNext = string.Empty;
            while (whatNext != "quit")
            {
                this.MainProgram();

                Console.WriteLine("Run again or quit? (enter 'quit' to exit)");
                whatNext = Console.ReadLine();
                Console.WriteLine();
            }
        } 
    }
}

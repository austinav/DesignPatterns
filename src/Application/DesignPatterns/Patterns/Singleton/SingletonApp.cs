using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    class SingletonApp : App
    {
        public override void MainProgram()
        {
            Console.WriteLine(Singleton1.Instance == null);
            Console.WriteLine(Singleton2.Instance == null);
        }
    }
}

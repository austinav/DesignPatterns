using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton
{
    // all and more from this article https://csharpindepth.com/articles/singleton
    public sealed class Singleton1
    {
        private static readonly Lazy<Singleton1> lazy =
            new Lazy<Singleton1>(() => new Singleton1());

        public static Singleton1 Instance { get { return lazy.Value; } }

        private Singleton1()
        {
        }
    }

    public sealed class Singleton2
    {
        private Singleton2()
        {
        }

        public static Singleton2 Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton2 instance = new Singleton2();
        }
    }
    
    //not quite as lazy, but thread-safe without using locks
    public sealed class Singleton3
    {
        private static readonly Singleton3 instance = new Singleton3();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton3()
        {
        }

        private Singleton3()
        {
        }

        public static Singleton3 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

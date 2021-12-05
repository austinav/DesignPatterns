using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ConsoleApp1.Patterns.Decorator
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };

        public Size size { get; set; } = Size.TALL;

        public abstract string description { get; }
        public abstract decimal cost();
    }
}
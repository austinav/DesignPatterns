using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp1.Patterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        public override Size BeverageSize { get => beverage.BeverageSize; set => beverage.BeverageSize = value; }

        public override string description
        {
            get
            {
                if (this.beverage.GetType().BaseType == (typeof(Beverage)))
                {
                    return $"{this.beverage.description} with {this.GetType().Name}";
                }
                else
                {
                    return $"{this.beverage.description} and {this.GetType().Name}";                    
                }
            }
        }

 
    }
}